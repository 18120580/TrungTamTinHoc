
namespace TrungTamTinHoc.UI
{
	partial class BeginForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_chuacomk = new System.Windows.Forms.Button();
			this.btn_quenmk = new System.Windows.Forms.Button();
			this.btn_dangnhap = new System.Windows.Forms.Button();
			this.txt_tendangnhap = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_mk = new System.Windows.Forms.TextBox();
			this.dtgthongtinlop = new System.Windows.Forms.DataGridView();
			this.dtg_chuongtrinhdaotao = new System.Windows.Forms.DataGridView();
			this.btn_xemlop = new System.Windows.Forms.Button();
			this.btn_xemctdt = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgthongtinlop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtg_chuongtrinhdaotao)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.OrangeRed;
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.splitContainer1.Panel2.Controls.Add(this.dtgthongtinlop);
			this.splitContainer1.Panel2.Controls.Add(this.dtg_chuongtrinhdaotao);
			this.splitContainer1.Panel2.Controls.Add(this.btn_xemlop);
			this.splitContainer1.Panel2.Controls.Add(this.btn_xemctdt);
			this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer1.Size = new System.Drawing.Size(837, 584);
			this.splitContainer1.SplitterDistance = 419;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Snow;
			this.groupBox1.Controls.Add(this.btn_chuacomk);
			this.groupBox1.Controls.Add(this.btn_quenmk);
			this.groupBox1.Controls.Add(this.btn_dangnhap);
			this.groupBox1.Controls.Add(this.txt_tendangnhap);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_mk);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(413, 578);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FORM ĐĂNG NHẬP";
			// 
			// btn_chuacomk
			// 
			this.btn_chuacomk.BackColor = System.Drawing.Color.White;
			this.btn_chuacomk.ForeColor = System.Drawing.Color.Blue;
			this.btn_chuacomk.Location = new System.Drawing.Point(239, 465);
			this.btn_chuacomk.Name = "btn_chuacomk";
			this.btn_chuacomk.Size = new System.Drawing.Size(153, 23);
			this.btn_chuacomk.TabIndex = 7;
			this.btn_chuacomk.Text = "bạn chưa có tài khoản?";
			this.btn_chuacomk.UseVisualStyleBackColor = false;
			this.btn_chuacomk.Click += new System.EventHandler(this.btn_chuacomk_Click);
			// 
			// btn_quenmk
			// 
			this.btn_quenmk.BackColor = System.Drawing.Color.White;
			this.btn_quenmk.ForeColor = System.Drawing.Color.Blue;
			this.btn_quenmk.Location = new System.Drawing.Point(9, 463);
			this.btn_quenmk.Name = "btn_quenmk";
			this.btn_quenmk.Size = new System.Drawing.Size(155, 25);
			this.btn_quenmk.TabIndex = 6;
			this.btn_quenmk.Text = "bạn quên mật khẩu?";
			this.btn_quenmk.UseVisualStyleBackColor = false;
			this.btn_quenmk.Click += new System.EventHandler(this.btn_quenmk_Click);
			// 
			// btn_dangnhap
			// 
			this.btn_dangnhap.Location = new System.Drawing.Point(137, 350);
			this.btn_dangnhap.Name = "btn_dangnhap";
			this.btn_dangnhap.Size = new System.Drawing.Size(131, 23);
			this.btn_dangnhap.TabIndex = 4;
			this.btn_dangnhap.Text = "Đăng nhập";
			this.btn_dangnhap.UseVisualStyleBackColor = true;
			this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
			// 
			// txt_tendangnhap
			// 
			this.txt_tendangnhap.Location = new System.Drawing.Point(111, 129);
			this.txt_tendangnhap.Name = "txt_tendangnhap";
			this.txt_tendangnhap.Size = new System.Drawing.Size(199, 20);
			this.txt_tendangnhap.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Snow;
			this.label2.Location = new System.Drawing.Point(6, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật khẩu:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(6, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tên Đăng nhập:";
			// 
			// txt_mk
			// 
			this.txt_mk.Location = new System.Drawing.Point(111, 242);
			this.txt_mk.Name = "txt_mk";
			this.txt_mk.PasswordChar = '*';
			this.txt_mk.Size = new System.Drawing.Size(199, 20);
			this.txt_mk.TabIndex = 1;
			// 
			// dtgthongtinlop
			// 
			this.dtgthongtinlop.BackgroundColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgthongtinlop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgthongtinlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgthongtinlop.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtgthongtinlop.Location = new System.Drawing.Point(4, 311);
			this.dtgthongtinlop.Name = "dtgthongtinlop";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgthongtinlop.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtgthongtinlop.Size = new System.Drawing.Size(383, 270);
			this.dtgthongtinlop.TabIndex = 3;
			// 
			// dtg_chuongtrinhdaotao
			// 
			this.dtg_chuongtrinhdaotao.BackgroundColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_chuongtrinhdaotao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dtg_chuongtrinhdaotao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtg_chuongtrinhdaotao.DefaultCellStyle = dataGridViewCellStyle5;
			this.dtg_chuongtrinhdaotao.Location = new System.Drawing.Point(4, 33);
			this.dtg_chuongtrinhdaotao.Name = "dtg_chuongtrinhdaotao";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_chuongtrinhdaotao.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dtg_chuongtrinhdaotao.Size = new System.Drawing.Size(383, 232);
			this.dtg_chuongtrinhdaotao.TabIndex = 2;
			// 
			// btn_xemlop
			// 
			this.btn_xemlop.Location = new System.Drawing.Point(3, 281);
			this.btn_xemlop.Name = "btn_xemlop";
			this.btn_xemlop.Size = new System.Drawing.Size(221, 23);
			this.btn_xemlop.TabIndex = 1;
			this.btn_xemlop.Text = "xem thông tin các lớp";
			this.btn_xemlop.UseVisualStyleBackColor = true;
			this.btn_xemlop.Click += new System.EventHandler(this.btn_xemlop_Click);
			// 
			// btn_xemctdt
			// 
			this.btn_xemctdt.Location = new System.Drawing.Point(3, 3);
			this.btn_xemctdt.Name = "btn_xemctdt";
			this.btn_xemctdt.Size = new System.Drawing.Size(221, 23);
			this.btn_xemctdt.TabIndex = 0;
			this.btn_xemctdt.Text = "Xem thông tin các chương trình đầo tạo";
			this.btn_xemctdt.UseVisualStyleBackColor = true;
			this.btn_xemctdt.Click += new System.EventHandler(this.btn_xemctdt_Click);
			// 
			// BeginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 584);
			this.Controls.Add(this.splitContainer1);
			this.MaximizeBox = false;
			this.Name = "BeginForm";
			this.Text = "Đăng nhập hệ thống";
			this.Load += new System.EventHandler(this.BeginForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgthongtinlop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtg_chuongtrinhdaotao)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_mk;
		private System.Windows.Forms.TextBox txt_tendangnhap;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_dangnhap;
		private System.Windows.Forms.Button btn_chuacomk;
		private System.Windows.Forms.Button btn_quenmk;
		private System.Windows.Forms.DataGridView dtgthongtinlop;
		private System.Windows.Forms.DataGridView dtg_chuongtrinhdaotao;
		private System.Windows.Forms.Button btn_xemlop;
		private System.Windows.Forms.Button btn_xemctdt;
	}
}