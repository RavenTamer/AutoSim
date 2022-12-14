namespace AutoSim
{
    public partial class Form1 : Form
    {
        private Auto auto;

        public Form1()
        {
            InitializeComponent();

            choicebox.Items.Add(new Auto("Porsche", 250));
            choicebox.Items.Add(new Auto("Opel", 90));
            choicebox.Items.Add(new Auto("Ferrari", 370));

           

        }

        private void key_Click(object sender, EventArgs e)
        {
            if (auto is null)
            {
                return;
            }
            else if (auto.IsEngineOn)
            {
                auto.TurnOffEngine();
            }
            else
            {
                auto.StartEngine();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Admin\OneDrive - sluz\BLJ\OOP_C#\AutoSim\car-ignition.wav");
                player.Play();
            }
            EngineCheck.Checked = auto.IsEngineOn;

        }

        public void choicebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            auto = (Auto)choicebox.SelectedItem;

            if (choicebox.SelectedItem != null)
            {
                hplabel.Text = auto.GetHorsepower();
            }
            else
            {
                hplabel.Text = "0 PS";
            }
            if (auto.IsEngineOn)
            {
                auto.TurnOffEngine();
            }
        }
        
        private void acceleratorbutton_MouseHover(object sender, EventArgs e)
        {
            if (auto != null && auto.IsEngineOn)
            {
                while (MouseIsOverControl(acceleratorbutton))
                {
                    auto.Accelerate();
                    auto.CalculateCurrentGear();
                    SpeedLabel.Text = Convert.ToString(auto.CurrentSpeed);
                    GearLabel.Text = Convert.ToString(auto.CurrentGear);

                    Thread.Sleep(300);
                    Application.DoEvents();
                }
            }
        }

        private void breakbutton_MouseHover(object sender, EventArgs e)
        {
            if (auto != null )
            {
                while (MouseIsOverControl(breakbutton) && auto.CurrentSpeed >= 0)
                {
                    auto.Break();
                    auto.CalculateCurrentGear();
                    SpeedLabel.Text = Convert.ToString(auto.CurrentSpeed);
                    GearLabel.Text = Convert.ToString(auto.CurrentGear);
                    Thread.Sleep(300);
                    Application.DoEvents();
                }
            }
            if (auto != null && auto.CurrentSpeed < 0)
            {
                auto.CurrentSpeed = 0;
                SpeedLabel.Text = Convert.ToString(auto.CurrentSpeed);
            }

        } 

        private bool MouseIsOverControl(Button btn) =>
            btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position));

        private void horn_Click(object sender, EventArgs e)
        {
            if (auto.IsEngineOn)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Admin\OneDrive - sluz\BLJ\OOP_C#\AutoSim\doomfist_and_they_say.wav");
                player.Play();
            }
        }
    }
}