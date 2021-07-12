
namespace TrungTamTinHoc.UI
{
	partial class ForGetPass
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_laylaimk = new System.Windows.Forms.Button();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_laylaimk
			// 
			this.btn_laylaimk.Location = new System.Drawing.Point(260, 132);
			this.btn_laylaimk.Name = "btn_laylaimk";
			this.btn_laylaimk.Size = new System.Drawing.Size(138, 23);
			this.btn_laylaimk.TabIndex = 0;
			this.btn_laylaimk.Text = "Lấy lại mật khẩu";
			this.btn_laylaimk.UseVisualStyleBackColor = true;
			this.btn_laylaimk.Click += new System.EventHandler(this.btn_laylaimk_Click);
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(145, 79);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(404, 20);
			this.txt_email.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(79, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "email:";
			// 
			// ForGetPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 215);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.btn_laylaimk);
			this.Name = "ForGetPass";
			this.Text = "Quên mật khẩu";
			this.Load += new System.EventHandler(this.ForGetPass_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_laylaimk;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label1;
	}
}