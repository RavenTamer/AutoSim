namespace AutoSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            choicebox.Items.Add(new Auto("Porsche", 250).ToString());
            choicebox.Items.Add(new Auto("Opel", 90).ToString());
            choicebox.Items.Add(new Auto("Ferrari", 370).ToString());
        }

        private void key_Click(object sender, EventArgs e)
        {

        }
    }
}