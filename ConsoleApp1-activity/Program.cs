// See https://aka.ms/new-console-template for more information
// version 1.0.0
// this is for commit and push branch (updated nasdaq calculation)

while (true)
{
    Console.WriteLine("List of pairs:");
    Console.WriteLine("NASDAQ - Indices\n");
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

    switch (pair)
    {
        case "NASDAQ" or "nasdaq":
            double position = nasdaq(risk_amount, pips);
            Console.Write($"POSITION: {position}");
            Console.ReadKey();
            break;
    }
    Console.WriteLine();
}
Console.ReadKey();

static double nasdaq(double risk_amount, double pips)
{
    double contract_size = 10;
    double new_pips = pips * 100;
    double position = (risk_amount / new_pips) * contract_size;
    double lot_size = Math.Round(position, 2);
    return lot_size;
}
