namespace basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemplu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            MessageBox.Show("Introduceti mesajul in caseta albastra");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtExemplu.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}