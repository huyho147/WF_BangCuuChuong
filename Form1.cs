using System.Data;

namespace WF_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int so;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SoTxt.Text = numericUpDown1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoLbl1.Text = trackBar1.Value.ToString();
            SoTxt.Text = numericUpDown1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            so = Convert.ToInt32(SoTxt.Text);
            BangCuuChuong();
        }

        private void BangCuuChuong()
        {

            KetQuaLbl.Text = "";
            listBox.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                KetQuaLbl.Text += Environment.NewLine + so + " x " + i + " = " + (so * i).ToString();
                listBox.Items.Add((so + " x " + i + " = " + (so * i)).ToString());
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SoLbl1.Text = trackBar1.Value.ToString();
        }

        private void Tinh2Btn_Click(object sender, EventArgs e)
        {
            so = Convert.ToInt32(SoLbl1.Text);
            BangCuuChuong();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TinhBtn3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                so = 1;
            if (radioButton2.Checked)
                so = 2;
            if (radioButton3.Checked)
                so = 3;
            if (radioButton4.Checked)
                so = 4;
            if (radioButton5.Checked)
                so = 5;
            if (radioButton6.Checked)
                so = 6;
            if (radioButton7.Checked)
                so = 7;
            if (radioButton8.Checked)
                so = 8;
            if (radioButton9.Checked)
                so = 9;
            if (radioButton10.Checked)
                so = 10;
            BangCuuChuong();
        }

        private void KtraDro(object sender, EventArgs e)
        {
            KetQuaLbl.Text = "";
            listBox.Items.Clear();
            RadioButton r = (RadioButton)sender;
            so = Convert.ToInt32(r.Text);
            BangCuuChuong();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
