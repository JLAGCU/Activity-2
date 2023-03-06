//JARED ABRAMS//CST-150//05MARCH2023//THIS IS MY OWN WORK

namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            double earthWeight = 0;
            double marsWeight = 0;
            double.TryParse(textBox_EarthWeight.Text, out earthWeight);
            marsWeight = Math.Round((earthWeight / 9.81) * 3.711, 3);
            textBox_MarsWeight.Text = marsWeight.ToString();
        }
    }
}