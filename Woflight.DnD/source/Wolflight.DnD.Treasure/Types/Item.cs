namespace Wolflight.DnD.Treasure.Types
{
    public class Item
    {
        public Item(
            long id,
            string name,
            Enums.ItemCategory category,
            Enums.Rarity rarity,
            (Enums.TreasureTheme Theme, int TableCount)[] themes,
            int value
        )
        {
            ID = id;
            Name = name;
            Category = category;
            Rarity = rarity;
            Themes = themes.ToDictionary(x => x.Theme, x => x.TableCount);
            Value = value;
        }

        public long ID { get; }

        public string Name { get; }

        public Enums.ItemCategory Category { get; }

        public Enums.Rarity Rarity { get; }

        public IReadOnlyDictionary<Enums.TreasureTheme, int> Themes { get; }

        public int Value { get; }

    }
}
