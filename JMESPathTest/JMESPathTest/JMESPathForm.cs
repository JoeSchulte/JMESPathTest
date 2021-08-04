using DevLab.JmesPath;
using JMESPathTest.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMESPathTest
{
	public partial class JMESPathForm : Form
	{
		public JMESPathForm()
		{
			InitializeComponent();

			if (Settings.Default.RequiresUpdate)
			{
				Settings.Default.Upgrade();
				Settings.Default.RequiresUpdate = false;
			}
		}

		private void JMESPathForm_Load(object sender, EventArgs e)
		{
			textBoxSource.Text = Settings.Default.Source;
			textBoxExpresion.Text = Settings.Default.JMESPath;
		}

		private void JMESPathForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Source = textBoxSource.Text;
			Settings.Default.JMESPath = textBoxExpresion.Text;
			Settings.Default.Save();
		}

		private void buttonExecute_Click(object sender, EventArgs e)
		{
			try
			{
				var jmes = new JmesPath();
				var result = jmes.Transform(textBoxSource.Text, textBoxExpresion.Text);
				textBoxResult.Text = format_json(result);
			}
			catch (Exception ex)
			{
				textBoxResult.Text = ex.Message;
			}
		}

		public static string FormatJson(string json, string indent = "  ")
		{
			var indentation = 0;
			var quoteCount = 0;
			var escapeCount = 0;

			var result =
				from ch in json ?? string.Empty
				let escaped = (ch == '\\' ? escapeCount++ : escapeCount > 0 ? escapeCount-- : escapeCount) > 0
				let quotes = ch == '"' && !escaped ? quoteCount++ : quoteCount
				let unquoted = quotes % 2 == 0
				let colon = ch == ':' && unquoted ? ": " : null
				let nospace = char.IsWhiteSpace(ch) && unquoted ? string.Empty : null
				let lineBreak = ch == ',' && unquoted ? ch + Environment.NewLine + string.Concat(Enumerable.Repeat(indent, indentation)) : null
				let openChar = (ch == '{' || ch == '[') && unquoted ? ch + Environment.NewLine + string.Concat(Enumerable.Repeat(indent, ++indentation)) : ch.ToString()
				let closeChar = (ch == '}' || ch == ']') && unquoted ? Environment.NewLine + string.Concat(Enumerable.Repeat(indent, --indentation)) + ch : ch.ToString()
				select colon ?? nospace ?? lineBreak ?? (
					openChar.Length > 1 ? openChar : closeChar
				);

			return string.Concat(result);
		}

		private static string format_json(string json)
		{
			dynamic parsedJson = JsonConvert.DeserializeObject(json);
			return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
		}
	}
}
