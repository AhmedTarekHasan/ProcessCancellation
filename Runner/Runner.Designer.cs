
namespace Runner
{
	partial class Runner
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
			this.LstLogs1 = new System.Windows.Forms.ListBox();
			this.BtnStart1 = new System.Windows.Forms.Button();
			this.BtnStop1 = new System.Windows.Forms.Button();
			this.BtnStop2 = new System.Windows.Forms.Button();
			this.BtnStart2 = new System.Windows.Forms.Button();
			this.LstLogs2 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// LstLogs1
			// 
			this.LstLogs1.FormattingEnabled = true;
			this.LstLogs1.ItemHeight = 20;
			this.LstLogs1.Location = new System.Drawing.Point(12, 12);
			this.LstLogs1.Name = "LstLogs1";
			this.LstLogs1.Size = new System.Drawing.Size(325, 264);
			this.LstLogs1.TabIndex = 0;
			// 
			// BtnStart1
			// 
			this.BtnStart1.Location = new System.Drawing.Point(12, 300);
			this.BtnStart1.Name = "BtnStart1";
			this.BtnStart1.Size = new System.Drawing.Size(152, 29);
			this.BtnStart1.TabIndex = 1;
			this.BtnStart1.Text = "Start 1";
			this.BtnStart1.UseVisualStyleBackColor = true;
			this.BtnStart1.Click += new System.EventHandler(this.BtnStart1_Click);
			// 
			// BtnStop1
			// 
			this.BtnStop1.Location = new System.Drawing.Point(183, 300);
			this.BtnStop1.Name = "BtnStop1";
			this.BtnStop1.Size = new System.Drawing.Size(153, 29);
			this.BtnStop1.TabIndex = 2;
			this.BtnStop1.Text = "Stop 1";
			this.BtnStop1.UseVisualStyleBackColor = true;
			this.BtnStop1.Click += new System.EventHandler(this.BtnStop1_Click);
			// 
			// BtnStop2
			// 
			this.BtnStop2.Location = new System.Drawing.Point(514, 300);
			this.BtnStop2.Name = "BtnStop2";
			this.BtnStop2.Size = new System.Drawing.Size(153, 29);
			this.BtnStop2.TabIndex = 4;
			this.BtnStop2.Text = "Stop 2";
			this.BtnStop2.UseVisualStyleBackColor = true;
			this.BtnStop2.Click += new System.EventHandler(this.BtnStop2_Click);
			// 
			// BtnStart2
			// 
			this.BtnStart2.Location = new System.Drawing.Point(342, 300);
			this.BtnStart2.Name = "BtnStart2";
			this.BtnStart2.Size = new System.Drawing.Size(152, 29);
			this.BtnStart2.TabIndex = 3;
			this.BtnStart2.Text = "Start 2";
			this.BtnStart2.UseVisualStyleBackColor = true;
			this.BtnStart2.Click += new System.EventHandler(this.BtnStart2_Click);
			// 
			// LstLogs2
			// 
			this.LstLogs2.FormattingEnabled = true;
			this.LstLogs2.ItemHeight = 20;
			this.LstLogs2.Location = new System.Drawing.Point(343, 12);
			this.LstLogs2.Name = "LstLogs2";
			this.LstLogs2.Size = new System.Drawing.Size(325, 264);
			this.LstLogs2.TabIndex = 5;
			// 
			// Runner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 340);
			this.Controls.Add(this.LstLogs2);
			this.Controls.Add(this.BtnStop2);
			this.Controls.Add(this.BtnStart2);
			this.Controls.Add(this.BtnStop1);
			this.Controls.Add(this.BtnStart1);
			this.Controls.Add(this.LstLogs1);
			this.Name = "Runner";
			this.Text = "Runner";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox LstLogs1;
		private System.Windows.Forms.Button BtnStart1;
		private System.Windows.Forms.Button BtnStop1;
		private System.Windows.Forms.Button BtnStop2;
		private System.Windows.Forms.Button BtnStart2;
		private System.Windows.Forms.ListBox LstLogs2;
	}
}

