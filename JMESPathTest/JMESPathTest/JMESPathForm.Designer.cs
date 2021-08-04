
namespace JMESPathTest
{
	partial class JMESPathForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxSource = new System.Windows.Forms.TextBox();
			this.textBoxExpresion = new System.Windows.Forms.TextBox();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxSource
			// 
			this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSource.Location = new System.Drawing.Point(12, 12);
			this.textBoxSource.MaxLength = 1000000;
			this.textBoxSource.Multiline = true;
			this.textBoxSource.Name = "textBoxSource";
			this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxSource.Size = new System.Drawing.Size(776, 175);
			this.textBoxSource.TabIndex = 0;
			// 
			// textBoxExpresion
			// 
			this.textBoxExpresion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxExpresion.Location = new System.Drawing.Point(12, 193);
			this.textBoxExpresion.Name = "textBoxExpresion";
			this.textBoxExpresion.Size = new System.Drawing.Size(695, 23);
			this.textBoxExpresion.TabIndex = 1;
			// 
			// textBoxResult
			// 
			this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxResult.Location = new System.Drawing.Point(12, 222);
			this.textBoxResult.MaxLength = 1000000;
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxResult.Size = new System.Drawing.Size(776, 153);
			this.textBoxResult.TabIndex = 2;
			// 
			// buttonExecute
			// 
			this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExecute.Location = new System.Drawing.Point(713, 192);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(75, 23);
			this.buttonExecute.TabIndex = 3;
			this.buttonExecute.Text = "Execute";
			this.buttonExecute.UseVisualStyleBackColor = true;
			this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
			// 
			// JMESPathForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 387);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.textBoxExpresion);
			this.Controls.Add(this.textBoxSource);
			this.Name = "JMESPathForm";
			this.Text = "JMESPath Tester";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JMESPathForm_FormClosing);
			this.Load += new System.EventHandler(this.JMESPathForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSource;
		private System.Windows.Forms.TextBox textBoxExpresion;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Button buttonExecute;
	}
}

