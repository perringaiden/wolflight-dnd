using Wolflight.DnD.Treasure.Enums;
using Wolflight.DnD.Treasure.Types;

namespace Wolflight.DnD.Treasure.Providers
{
    public class RandomMagicItemGenerator
    {
        public RandomMagicItemGenerator()
        {
            ItemMatrix = [];

            foreach (Rarity rarity in Enum.GetValues<Rarity>())
            {
                ItemMatrix.Add(
                    rarity,
                    new Dictionary<TreasureTheme, List<Item>>
                    {
                        {TreasureTheme.Any, new List<Item>()},
                        {TreasureTheme.Arcana, new List<Item>()},
                        {TreasureTheme.Armaments, new List<Item>()},
                        {TreasureTheme.Implements, new List<Item>()},
                        {TreasureTheme.Relics, new List<Item>()}
                    }
                );
            }

            foreach (Item item in TreasureItemLoader.ItemList())
            {
                foreach (KeyValuePair<TreasureTheme, int> tableRecord in item.Themes)
                {
                    List<Item> table = ItemMatrix[item.Rarity][tableRecord.Key];

                    for (int i = 0; i < tableRecord.Value; i++)
                    {
                        table.Add(item);
                    }
                }
            }
        }


        public Item SelectMagicItem(Rarity rarity, TreasureTheme theme)
        {
            List<Item> table;


            table = ItemMatrix[rarity][theme];

            // Select an entry based on a random role for all slots.
            return table[Dice.Roll(1, table.Count) - 1];

        }

        private Dictionary<Rarity, Dictionary<TreasureTheme, List<Item>>> ItemMatrix { get; }

    }
}
