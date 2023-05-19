namespace Pizzazo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int osszeg = ((int)numericUpDown1.Value * 2000) + ((int)numericUpDown2.Value * 2000) + ((int)numericUpDown3.Value * 2000) + ((int)numericUpDown4.Value * 2000) + ((int)numericUpDown5.Value * 2000);

            if (checkBox1.Checked)
            {
                osszeg += 100;
            }
            if (checkBox2.Checked)
            {
                osszeg += 100;
            }
            if (checkBox3.Checked)
            {
                osszeg += 100;
            }
            label10.Text = osszeg.ToString();
        }
    }
}