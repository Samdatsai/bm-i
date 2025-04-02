namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToInt32(textBox1.Text);
            double weight = Convert.ToInt32(textBox2.Text);
            double BMI = weight / ((height / 100) * (height / 100));
            string s = Math.Round(BMI, 2).ToString();
            label11.Text = s.Substring(0, s.Length - 1);

        }
    }
}