// See https://aka.ms/new-console-template for more information
// version 1.0.0
// this is for commit and push branch (updated nasdaq calculation)
// this for pull branch (added a new pair for forex)

while (true)
{
    Console.WriteLine("List of pairs:");
    Console.WriteLine("NASDAQ (indices)\n");
    Console.WriteLine("AUDCAD (forex)\n");
    Console.WriteLine("Please select what pair to trade:");
    string pair = Console.ReadLine();
    Console.WriteLine();

    if (pair == "")
    {
        break;
    }

    Console.WriteLine("Risk amount $: ");
    double risk_amount = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Pips: ");
    double pips = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    double position = 0;
    bool validpair = true;

    switch (pair.ToUpper())
    {
        case "NASDAQ":
            position = nasdaq(risk_amount, pips);
            break;
        case "AUDCAD":
            position = audcad(risk_amount, pips);
            break;
        default:
            Console.WriteLine("Invalid pair selection. Please choose from the options");
            validpair = false;
            break;
    }
    if (validpair)
    {
        Console.WriteLine($"POSITION: {position}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    Console.WriteLine();
}
static double nasdaq(double risk_amount, double pips)
{
    double contract_size = 10; // Standard lot size for indices
    double new_pips = pips * 100;
    double position = risk_amount / new_pips * contract_size;
    double lot_size = Math.Round(position, 2);
    return lot_size;
}

static double audcad(double risk_amount, double pips)
{
    double contract_size = 7.25; // Standard lot size for indices
    double new_pips = pips;
    double position = risk_amount / new_pips * contract_size;
    double lot_size = Math.Round(position, 2);
    return lot_size;
}




