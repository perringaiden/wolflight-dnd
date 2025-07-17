using Wolflight.DnD.Treasure.Enums;
using Wolflight.DnD.Treasure.Types;

namespace Wolflight.DnD.Treasure.Providers
{
    internal static class TreasureItemLoader
    {
        public static List<Item> ItemList()
        {
            return [
                new(
                    5370,
                    "Adamantine Armor",
                    ItemCategory.Armor,
                    Rarity.Uncommon,
                    [(TreasureTheme.Armaments, 4)],
                    0
                ),
                new(
                    9228431,
                    "Adamantine Weapon",
                    ItemCategory.Armor,
                    Rarity.Uncommon,
                    [(TreasureTheme.Armaments, 4)],
                    0
                ),
                new(
                    9228343,
                    "Alchemy Jug",
                    ItemCategory.WonderousItem,
                    Rarity.Uncommon,
                    [(TreasureTheme.Implements, 2)],
                    0
                ),
                new(
                    5407,
                    "Ammunition +1",
                    ItemCategory.Weapon,
                    Rarity.Uncommon,
                    [(TreasureTheme.Armaments, 5)],
                    0
                ),
                new(
                    5410,
                    "Ammunition +2",
                    ItemCategory.Weapon,
                    Rarity.Rare,
                    [(TreasureTheme.Armaments, 3)],
                    0
                ),
                new(
                    5411,
                    "Ammunition +3",
                    ItemCategory.Weapon,
                    Rarity.VeryRare,
                    [(TreasureTheme.Armaments, 3)],
                    0
                ),
                new(
                    9228344,
                    "Ammunition of Slaying",
                    ItemCategory.Weapon,
                    Rarity.VeryRare,
                    [(TreasureTheme.Armaments, 3)],
                    0
                ),
                new(
                    4568,
                    "Amulet of Health",
                    ItemCategory.WonderousItem,
                    Rarity.Rare,
                    [(TreasureTheme.Relics, 3)],
                    0
                ),
                new(
                    4569,
                    "Amulet of Proof against Detection and Location",
                    ItemCategory.WonderousItem,
                    Rarity.Uncommon,
                    [(TreasureTheme.Arcana, 1)],
                    0
                ),
                new(
                    9228345,
                    "Amulet of the Planes",
                    ItemCategory.WonderousItem,
                    Rarity.VeryRare,
                    [(TreasureTheme.Arcana, 2)],
                    0
                ),
                new(
                    4571,
                    "Animated Shield",
                    ItemCategory.Armor,
                    Rarity.VeryRare,
                    [(TreasureTheme.Armaments, 3)],
                    0
                ),
                new(
                    928348,
                    "Apparatus of Kwalish",
                    ItemCategory.WonderousItem,
                    Rarity.Legendary,
                    [(TreasureTheme.Arcana, 4)],
                    0
                )
            ];

        }

    }
}


//,
//                new(
//                    ,
//                    "",
//                    ItemCategory.,
//                    Rarity.,
//                    [],
//                    0
//                )