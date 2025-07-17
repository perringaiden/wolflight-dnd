namespace Wolflight.DnD.Treasure
{

    public class Program
    {
        static void Main()
        {
            Console.WriteLine("CR 1");
            Console.WriteLine(PrintIndividualTreasure(1, 10));

            Console.WriteLine("CR 5");
            Console.WriteLine(PrintIndividualTreasure(5, 10));

            Console.WriteLine("CR 11");
            Console.WriteLine(PrintIndividualTreasure(11, 10));

            Console.WriteLine("CR 17");
            Console.WriteLine(PrintIndividualTreasure(17, 10));

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(PrintRandomMagicGenerator());
            }

        }

        internal static string PrintIndividualTreasure(int level, int iterations)
        {
            System.Text.StringBuilder sb;


            sb = new System.Text.StringBuilder();

            sb.AppendLine($"/-----|-----|-----|-----|-----|-----\\");
            sb.AppendLine($"|Count|PP   |GP   |SP   |CP   |Value|");
            sb.AppendLine($"|-----|-----|-----|-----|-----|-----|");

            for (int i = 0; i < iterations; i++)
            {
                Types.Coins coins;

                coins = Providers.TreasureGenerator.IndividualTreasure(level);


                sb.AppendLine($"|{i + 1,5}|{coins.Platinum,5}|{coins.Gold,5}|{coins.Silver,5}|{coins.Copper,5}|{coins.Value() / 100,5}|");

            }

            sb.AppendLine($"\\-----|-----|-----|-----|-----|-----/");

            return sb.ToString();
        }

        internal static string PrintRandomMagicGenerator()
        {
            System.Text.StringBuilder sb;
            Types.Item item;
            Providers.RandomMagicItemGenerator generator = new();

            sb = new System.Text.StringBuilder();

            item = generator.SelectMagicItem(Enums.Rarity.Uncommon, Enums.TreasureTheme.Armaments);

            sb.AppendLine($"----------------------------");
            sb.AppendLine($"ID: {item.ID}");
            sb.AppendLine($"Name: {item.Name}");
            sb.AppendLine($"Rarity: {item.Rarity}");
            sb.AppendLine($"Category: {item.Category}");
            sb.AppendLine($"Value: {item.Value}");
            sb.AppendLine($"----------------------------");

            return sb.ToString();

        }
    }
}

