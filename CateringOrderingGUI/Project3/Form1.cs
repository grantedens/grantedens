namespace Project3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            cmbSauces.Items.AddRange(sauces);
            cmbSides.Items.AddRange(sides);
            DateTime now = DateTime.Now;
            lblCurrentDate.Text = now.ToString("D");
        }

        const double STEAK = 30.95;
        const double CHICKEN = 19.95;
        const double PASTA = 14.95;
        const double DRAWNBUTTER = 1;
        const double AIOLI = 2.50;
        const double GARLICESAUCE = 1.5;
        const double HOLLANDAISE = 3;
        const double REMOULADE = 2.5;
        const double BRUSSELS = 3;
        const double BUTTERNUT = 4;
        const double MACSALAD = 2.5;
        const double BROCCOLI = 2.0;
        const double OPENBAR = 25;
        const double WINE = 8;
        double entreePrice;
        double totalCost;
        string status;
        int orderNumber = 1;
        double saucePrice;
        double sidePrice;
        string[] sauces = { "Drawn Butter", "Aioli", "Garlic Sauce", "Hollandaise", "Remoulade" };
        string[] sides = { "Brussels Sprouts", "Butternut Squash", "Macaroni Salad", "Roasted Broccoli" };
        List<double> allCost = new List<double>(); 


        public void calculateTotal(string check, int guestCount, int orderNumber)
        {
            if (check == "Calculate")
            {
                if (guestCount == 0)
                {
                    MessageBox.Show("INVALID GUEST COUNT");
                    return;
                }
                
                
                
                string selectedEntree;
                if (rdoSteak.Checked == true)
                {
                    entreePrice = STEAK;
                    selectedEntree = rdoSteak.Text;
                }
                else if (rdoChicken.Checked == true)
                {
                    entreePrice = CHICKEN;
                    selectedEntree = rdoChicken.Text;
                }
                else if (rdoPasta.Checked == true)
                {
                    entreePrice = PASTA;
                    selectedEntree = rdoPasta.Text;
                }
                else
                {
                    MessageBox.Show("PLEASE SELECT AN ENTREE");
                    selectedEntree = "NOTHING SELECTED";
                    return;
                }

                string selectedSauce = cmbSauces.Text;

                if(selectedSauce == sauces[0])
                {
                    saucePrice = DRAWNBUTTER;
                }
                else if (selectedSauce == sauces[1])
                {
                    saucePrice = AIOLI;
                }
                else if (selectedSauce == sauces[2])
                {
                    saucePrice = GARLICESAUCE;
                }
                else if (selectedSauce == sauces[3])
                {
                    saucePrice = HOLLANDAISE;
                }
                else if (selectedSauce == sauces[4])
                {
                    saucePrice = REMOULADE; //$"total number of events: {orderNumber}
                }
                else
                {
                    MessageBox.Show("PLEASE SELECT A SAUCE");
                    selectedSauce = "NOTHING SELECTED";
                    return;
                }
                string selectedSide = cmbSides.Text;

                if (selectedSide == sides[0])
                {
                    sidePrice = BRUSSELS;
                }
                else if (selectedSide == sides[1])
                {
                    sidePrice = BUTTERNUT;
                }
                else if (selectedSide == sides[2])
                {
                    sidePrice = MACSALAD;
                }
                else if (selectedSide == sides[3])
                {
                    sidePrice = BROCCOLI;
                }
                else
                {
                    MessageBox.Show("PLEASE SELECT A SIDE");
                    selectedSide = "NOTHING SELECTED";
                    return;
                }

                double barPrice = 0;
                double winePrice = 0;

                if (openBarCb.Checked == true)
                {
                    barPrice = OPENBAR;
                }
                if (wineCbx.Checked == true)
                {
                    winePrice = WINE;
                }

                double entreeCost = (guestCount * entreePrice);
                double sauceCost = (guestCount * saucePrice);
                double sideCost = (guestCount * sidePrice);
                double barCost = (barPrice * guestCount) + (winePrice * guestCount);
                //lblRec.Text += $"{selectedEntree} Cost: {entreeCost.ToString("C")}\n";
                double totalCost = sauceCost + entreeCost + sideCost + barCost;
                textBox1.Text = totalCost.ToString("C");
                allCost.Add(totalCost);
            }
            else if (check == "Summary")
            {
                // lblReciept.Text = check;
                double summaryCost;
                summaryCost = allCost.Sum();

                //if (MessageBox.Show($"Total cost of all orders: {summaryCost.ToString}")) ;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void msgBtn_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Total Events: " + orderNumber.ToString() + "\nTotal Guests: " + txtGuest.Text + "\nTotal Amount Due: " + textBox1.Text + "\n\n Would you like to clear the summary information?", "Edens Catering", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                txtGuest.Text = "";
                textBox1.Text = "";
                rdoChicken.Checked = false;
                rdoSteak.Checked = false;
                rdoPasta.Checked = false;
                cmbSauces.SelectedIndex = -1;
                cmbSides.SelectedIndex = -1;
                openBarCb.Checked = false;
                wineCbx.Checked = false;
            }
            
            //int guestCount = int.TryParse(txtGuest.Text);
           // status = "Summary";
           // calculateTotal(status, guestCount, orderNumber);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcBtn_Click_1(object sender, EventArgs e)
        {
            int guestCount;
            int.TryParse(txtGuest.Text, out guestCount);
            status = "Calculate";
            
            
            calculateTotal(status, guestCount, orderNumber);
            orderNumber++;

            msgBtn.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuest.Text = "";
            textBox1.Text = "";
            rdoChicken.Checked = false;
            rdoSteak.Checked = false;
            rdoPasta.Checked = false;
            cmbSauces.SelectedIndex = -1;
            cmbSides.SelectedIndex = -1;
            openBarCb.Checked = false;
            wineCbx.Checked = false;
            
        }
    }
}