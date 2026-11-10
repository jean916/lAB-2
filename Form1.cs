
using System;
using System.Windows.Forms;

namespace mushrooms
{
    public partial class Form1 : Form
    {
        // Mushroom Finder variables
        private int stage = 0;
        private bool growsInForest = false;

        public Form1()
        {
            InitializeComponent();

            // Set the starting screen
            ShowPanel(panelLogin);

            // Bicycle hour settings
            nudStart.Minimum = 0;
            nudStart.Maximum = 23;
            nudStart.Value = 7;

            nudEnd.Minimum = 1;
            nudEnd.Maximum = 24;
            nudEnd.Value = 8;

            // Prepare the Mushroom screen
            StartMushroom();
        }

        // Show only one panel at a time
        private void ShowPanel(Panel selectedPanel)
        {
            panelLogin.Visible = false;
            panelChoose.Visible = false;
            panelMushroom.Visible = false;
            panelBicycle.Visible = false;

            selectedPanel.Visible = true;
            selectedPanel.BringToFront();
        }

        // LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "1234")
            {
                txtPassword.Clear();
                ShowPanel(panelChoose);
            }
            else
            {
                MessageBox.Show(
                    "Incorrect username or password.",
                    "Login Failed"
                );
            }
        }

        // CHOOSE MUSHROOM
        private void btnMushroom_Click(object sender, EventArgs e)
        {
            StartMushroom();
            ShowPanel(panelMushroom);
        }

        // CHOOSE BICYCLE
        private void btnBicycle_Click(object sender, EventArgs e)
        {
            ShowPanel(panelBicycle);
        }

        // LOGOUT FROM CHOOSE SCREEN
        private void btnChooseLogout_Click(object sender, EventArgs e)
        {
            ShowPanel(panelLogin);
        }

        // START OR RESTART MUSHROOM FINDER
        private void StartMushroom()
        {
            stage = 0;
            growsInForest = false;

            lblTitle.Text = "MUSHROOM FINDER";

            lblResult.Text = "";
            lblResult.Visible = true;

            btnYes.Visible = true;
            btnNo.Visible = true;
            btnRestart.Visible = false;

            lblQuestion.Text =
                "Does your mushroom grow in a forest?";
        }

        // YES BUTTON
        private void btnYes_Click(object sender, EventArgs e)
        {
            ProcessMushroomAnswer(true);
        }

        // NO BUTTON
        private void btnNo_Click(object sender, EventArgs e)
        {
            ProcessMushroomAnswer(false);
        }

        // PROCESS MUSHROOM ANSWERS
        private void ProcessMushroomAnswer(bool answer)
        {
            if (stage == 0)
            {
                growsInForest = answer;
                stage = 1;

                lblQuestion.Text =
                    "Does your mushroom have a convex cup?";
            }
            else if (stage == 1)
            {
                if (!growsInForest)
                {
                    if (answer)
                        ShowMushroomResult("Agaric Jaunissant");
                    else
                        ShowMushroomResult("Coprin chevelu");
                }
                else
                {
                    if (answer)
                    {
                        stage = 2;
                        lblQuestion.Text =
                            "Does your mushroom have a ring?";
                    }
                    else
                    {
                        stage = 3;
                        lblQuestion.Text =
                            "Does your mushroom have gills?";
                    }
                }
            }
            else if (stage == 2)
            {
                if (answer)
                    ShowMushroomResult("Amanite tue-mouche");
                else
                    ShowMushroomResult("Pied bleu");
            }
            else if (stage == 3)
            {
                if (answer)
                    ShowMushroomResult("Girolle");
                else
                    ShowMushroomResult("Cepe de Bordeaux");
            }
        }

        // DISPLAY MUSHROOM RESULT
        private void ShowMushroomResult(string result)
        {
            lblQuestion.Text = "Your mushroom has been identified!";

            lblResult.Text = "Your mushroom is: " + result;

            btnYes.Visible = false;
            btnNo.Visible = false;
            btnRestart.Visible = true;
        }

        // RESTART MUSHROOM FINDER
        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartMushroom();
        }

        // LOGOUT FROM MUSHROOM
        private void btnMushroomLogout_Click(object sender, EventArgs e)
        {
            ShowPanel(panelLogin);
        }

        // BICYCLE RENTAL HOURLY RATE
        private int RateForHour(int hour)
        {
            if (hour >= 14 && hour < 19)
                return 1500;

            else if ((hour >= 7 && hour < 14) ||
                     (hour >= 19 && hour < 21))
                return 1000;

            else
                return 500;
        }

        // CALCULATE BICYCLE RENTAL
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start = (int)nudStart.Value;
            int end = (int)nudEnd.Value;

            if (start >= end)
            {
                MessageBox.Show(
                    "Starting hour must be less than ending hour.",
                    "Invalid Time"
                );

                return;
            }

            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                total += RateForHour(hour);
            }

            int duration = end - start;

            lblDuration.Text =
                "Rental duration: " + duration + " hour(s)";

            lblTotal.Text =
                "Total to pay: " + total.ToString("N0") + " RWF";
        }

        // LOGOUT FROM BICYCLE
        private void btnBicycleLogout_Click(object sender, EventArgs e)
        {
            ShowPanel(panelLogin);
        }
    }
}
