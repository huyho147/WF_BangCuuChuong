namespace WF_BangCuuChuong
{
    partial class Form1
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            SoTxt = new TextBox();
            label2 = new Label();
            KetQuaLbl = new Label();
            TinhBtn1 = new Button();
            trackBar1 = new TrackBar();
            Tinh2Btn = new Button();
            TinhBtn3 = new Button();
            SoLbl1 = new Label();
            groupBox1 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listBox = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(290, 30);
            label1.TabIndex = 0;
            label1.Text = "Chọn bảng cửu chương: ";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(489, 32);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(134, 38);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // SoTxt
            // 
            SoTxt.Location = new Point(348, 32);
            SoTxt.Name = "SoTxt";
            SoTxt.Size = new Size(121, 38);
            SoTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 289);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 3;
            label2.Text = "Kết quả:";
            label2.Click += label2_Click;
            // 
            // KetQuaLbl
            // 
            KetQuaLbl.AutoSize = true;
            KetQuaLbl.Location = new Point(190, 289);
            KetQuaLbl.Name = "KetQuaLbl";
            KetQuaLbl.Size = new Size(0, 30);
            KetQuaLbl.TabIndex = 4;
            // 
            // TinhBtn1
            // 
            TinhBtn1.Location = new Point(709, 30);
            TinhBtn1.Name = "TinhBtn1";
            TinhBtn1.Size = new Size(133, 42);
            TinhBtn1.TabIndex = 5;
            TinhBtn1.Text = "Tính";
            TinhBtn1.UseVisualStyleBackColor = true;
            TinhBtn1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.AllowDrop = true;
            trackBar1.LargeChange = 2;
            trackBar1.Location = new Point(286, 110);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(309, 56);
            trackBar1.TabIndex = 6;
            trackBar1.UseWaitCursor = true;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Tinh2Btn
            // 
            Tinh2Btn.Location = new Point(709, 106);
            Tinh2Btn.Name = "Tinh2Btn";
            Tinh2Btn.Size = new Size(133, 42);
            Tinh2Btn.TabIndex = 5;
            Tinh2Btn.Text = "Tính";
            Tinh2Btn.UseVisualStyleBackColor = true;
            Tinh2Btn.Click += Tinh2Btn_Click;
            // 
            // TinhBtn3
            // 
            TinhBtn3.Location = new Point(709, 195);
            TinhBtn3.Name = "TinhBtn3";
            TinhBtn3.Size = new Size(133, 42);
            TinhBtn3.TabIndex = 5;
            TinhBtn3.Text = "Tính";
            TinhBtn3.UseVisualStyleBackColor = true;
            TinhBtn3.Click += TinhBtn3_Click;
            // 
            // SoLbl1
            // 
            SoLbl1.AutoSize = true;
            SoLbl1.Location = new Point(612, 118);
            SoLbl1.Name = "SoLbl1";
            SoLbl1.Size = new Size(0, 30);
            SoLbl1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton10);
            groupBox1.Controls.Add(radioButton9);
            groupBox1.Controls.Add(radioButton8);
            groupBox1.Controls.Add(radioButton7);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(52, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 99);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn bảng cửu chương:";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(491, 42);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(62, 34);
            radioButton10.TabIndex = 0;
            radioButton10.TabStop = true;
            radioButton10.Text = "10";
            radioButton10.UseVisualStyleBackColor = true;
            radioButton10.CheckedChanged += KtraDro;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(437, 42);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(48, 34);
            radioButton9.TabIndex = 0;
            radioButton9.TabStop = true;
            radioButton9.Text = "9";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += KtraDro;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(383, 42);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(48, 34);
            radioButton8.TabIndex = 0;
            radioButton8.TabStop = true;
            radioButton8.Text = "8";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += KtraDro;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(335, 42);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(48, 34);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "7";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += KtraDro;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(281, 42);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(48, 34);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "6";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += KtraDro;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(227, 42);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(48, 34);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += KtraDro;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(173, 42);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(48, 34);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += KtraDro;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(119, 42);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 34);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += KtraDro;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(65, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 34);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += KtraDro;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 42);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += KtraDro;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 30;
            listBox.Location = new Point(511, 305);
            listBox.Name = "listBox";
            listBox.Size = new Size(310, 334);
            listBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(890, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 11;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 675);
            Controls.Add(button1);
            Controls.Add(listBox);
            Controls.Add(groupBox1);
            Controls.Add(SoLbl1);
            Controls.Add(trackBar1);
            Controls.Add(TinhBtn3);
            Controls.Add(Tinh2Btn);
            Controls.Add(TinhBtn1);
            Controls.Add(KetQuaLbl);
            Controls.Add(label2);
            Controls.Add(SoTxt);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private TextBox SoTxt;
        private Label label2;
        private Label KetQuaLbl;
        private Button TinhBtn1;
        private Button Tinh2Btn;
        private Button TinhBtn3;
        public TrackBar trackBar1;
        private Label SoLbl1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private ListBox listBox;
        private Button button1;
    }
}
