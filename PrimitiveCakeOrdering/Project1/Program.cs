//Naming my variables

const double TAX_RATE = .095;


static void PrintMenu()
{
    string fruitSaladName = "Fruit Salad ";
    string pastaSaladName = "Pasta Salad ";
    string smoothieName = "Smoothie ";
    string fruitJuiceName = "Fruit Juice ";
    string cupcakeName = "Cupcake ";
    string shortcakeName = "Shortcake ";


    double fruitSaladPrice = 9.95;
    double pastaSaladPrice = 12;
    double smoothiePrice = 4.95;
    double fruitJuicePrice = 3.95;
    double cupcakePrice = 3.00;
    double shortcakePrice = 6.00;

    Console.WriteLine("*******************MENU*******************");

    Console.WriteLine(fruitSaladName + fruitSaladPrice.ToString("C"));
    Console.WriteLine(pastaSaladName + pastaSaladPrice.ToString("C"));
    Console.WriteLine(smoothieName + "   " + smoothiePrice.ToString("C"));
    Console.WriteLine(fruitJuiceName +  fruitJuicePrice.ToString("C"));
    Console.WriteLine(cupcakeName + "    " + cupcakePrice.ToString("C"));
    Console.WriteLine(shortcakeName + "  " +shortcakePrice.ToString("C"));
}

static void Order()
{
    double fruitSaladPrice = 9.95;
    double pastaSaladPrice = 12;
    double smoothiePrice = 4.95;
    double fruitJuicePrice = 3.95;
    double cupcakePrice = 3.00;
    double shortcakePrice = 6.00;
    Console.WriteLine("*******************ENTER YOUR ORDER*******************");

    Console.WriteLine($"How many fruit salad --- $9.95?");
    int fruitSaladOrder = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"How many pasta salad --- $12.00?");
    int pastaSaladOrder = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"How many smoothies --- $4.95?");
    int smoothieOrder = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"How many fruit juice --- $3.95?");
    int fruitJuiceOrder = Convert.ToInt32(Console.ReadLine());

    

    Console.WriteLine($"How many cupcakes --- $3.00?");
    int cupcakeOrder = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"How many shortcake --- $6.00?");
    int shortcakeOrder = Convert.ToInt32(Console.ReadLine());

    double subTotal = (fruitSaladOrder * fruitSaladPrice) + (pastaSaladOrder * pastaSaladPrice) + (smoothieOrder * smoothiePrice) + (fruitJuiceOrder * fruitJuicePrice) + (cupcakeOrder * cupcakePrice) + (shortcakeOrder * shortcakePrice);
    double tax = (subTotal * TAX_RATE);
    double total = (subTotal + tax);

    Console.WriteLine("*************************************");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("SubTotal Costs $" + Math.Round(subTotal,2));
    Console.WriteLine("Tax $" + Math.Round(tax,2));
    Console.WriteLine("Total Costs $" + Math.Round(total,2));


}
PrintMenu();
Order();





//Writing to console 
//Console.WriteLine(fruitSaladName + fruitSaladPrice.ToString("C"));
//Console.WriteLine(pastaSaladName + pastaSaladPrice.ToString("C"));
//Console.WriteLine((pastaSaladPrice + fruitSaladPrice) * 2);

//Console.WriteLine(shakeName + shakePrice.ToString("C"));
//Console.WriteLine(pastaSaladName + pastaSaladPrice.ToString("C"));
//Console.WriteLine("The cost of a shake is - {0}", shakePrice);

//Console.WriteLine("How many shakes do you want?");
//int shakesOrder = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("How many Fruit Salads do you want?");
//int fruitSaladOrder = Convert.ToInt32(Console.ReadLine());


//double subTotalPrice = ((shakesOrder * shakePrice) + (fruitSaladOrder * fruitSaladPrice));
//double taxAmount = subTotalPrice * TAX_RATE;
//double totalPrice = (taxAmount + subTotalPrice);

//Console.WriteLine(totalPrice.ToString("C"));