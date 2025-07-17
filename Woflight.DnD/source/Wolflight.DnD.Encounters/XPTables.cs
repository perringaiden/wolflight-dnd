namespace Wolflight.DnD.Encounters
{
    public static class XPTables
    {
        public static IReadOnlyDictionary<int, int> LowXPBudget { get; } = new Dictionary<int, int>
        {
            {1, 50},
            {2, 100 },
            {3, 150 },
            {4, 250 },
            {5, 500 },
            {6, 600 },
            {7, 750 },
            {8, 1000 },
            {9, 1300 },
            {10, 1600 },
            {11, 1900 },
            {12, 2200 },
            {13, 2600 },
            {14, 2900 },
            {15, 3300 },
            {16, 3800 },
            {17, 4500 },
            {18, 5000 },
            {19, 5500 },
            {20, 6400 }
        };

        public static IReadOnlyDictionary<int, int> ModerateXPBudget { get; } = new Dictionary<int, int>
        {
            {1, 75},
            {2, 150 },
            {3, 225 },
            {4, 375 },
            {5, 750 },
            {6, 1000 },
            {7, 1300 },
            {8, 1700 },
            {9, 2000 },
            {10, 2300 },
            {11, 2900 },
            {12, 3700 },
            {13, 4200 },
            {14, 4900 },
            {15, 5400 },
            {16, 6100 },
            {17, 7200 },
            {18, 8700 },
            {19, 10700 },
            {20, 13200 }
        };
        public static IReadOnlyDictionary<int, int> HighXPBudget { get; } = new Dictionary<int, int>
        {
            {1, 100},
            {2, 200 },
            {3, 400 },
            {4, 500 },
            {5, 1100 },
            {6, 1400 },
            {7, 1700 },
            {8, 2100 },
            {9, 2600 },
            {10, 3100 },
            {11, 4100 },
            {12, 4700 },
            {13, 5400 },
            {14, 6200 },
            {15, 7800 },
            {16, 9800 },
            {17, 11700 },
            {18, 14200 },
            {19, 17200 },
            {20, 22000 }
        };

    }
}
