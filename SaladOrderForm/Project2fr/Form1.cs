namespace Project2fr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double fruitSaladPrice = 9.95;
        double pastaSaladPrice = 12;
        double smoothiePrice = 4.95;
        double fruitJuicePrice = 3.95;
        double cupcakePrice = 3;
        double shortcakePrice = 6;
        double saladPrice, drinkPrice, dessertPrice, totalCost;
        int fruitSaladQuantity, pastaSaladQuantity, smoothieQuantity, fruitJuiceQuantity, cupcakeQuantity, shortcakeQuantity, totalQuantity, drinkQuantity, dessertQuantity, saladQuantity;

        private void clearButt_Click_1(object sender, EventArgs e)
        {
            saladLbl.Text = "Salads Label";
            dessertLbl.Text = "Dessert Label";
            drinksLbl.Text = "Drinks Label";
            saladPriceTb.Text = "0";
            saladQuantityTb.Text = "0";
            dessertPriceTb.Text = "0";
            dessertQuantityTb.Text = "0";
            drinkPriceTb.Text = "0";
            drinkQuantityTb.Text = "0";
        }

        private void fruitJuiceRdo_CheckedChanged(object sender, EventArgs e)
        {
            drinkPrice = 3.95;
            drinkPriceTb.Text = "$3.95";
            drinksLbl.Text = "Drinks Selection: Fruit Juice";

        }
        private void cupcakeRdo_CheckedChanged(object sender, EventArgs e)
        {
            dessertPrice = 3;
            dessertPriceTb.Text = "$3.00";
            dessertLbl.Text = "Dessert Choice: Cupcake";
        }

        private void shortcakeRdo_CheckedChanged(object sender, EventArgs e)
        {
            dessertPrice = 6;
            dessertPriceTb.Text = "$6.00";
            dessertLbl.Text = "Dessert Choice: Shortcake";
        }

       

        private void smoothieRDB_CheckedChanged(object sender, EventArgs e)
        {
            drinkPrice = 4.95;
            drinkPriceTb.Text = "$4.95";
            drinksLbl.Text = "Drinks Selection: Smoothie";

        }

        private void pastaSaladRdo_CheckedChanged(object sender, EventArgs e)
        {
            saladPrice = 12;
            saladPriceTb.Text = "$12.00";
            saladLbl.Text = "Salads Selection: Pasta Salad";

        }

        private void fruitSaladRdo_CheckedChanged(object sender, EventArgs e)
        {
            saladPrice = 9.95;
            saladPriceTb.Text = "$9.95";
            saladLbl.Text = "Salads Selection: Fruit Salad";
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}