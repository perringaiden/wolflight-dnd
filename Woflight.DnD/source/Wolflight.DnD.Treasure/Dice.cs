namespace Wolflight.DnD.Treasure
{
    internal class Dice
    {
        private readonly static Random Random;

        static Dice()
        {
            Random = new Random();
        }

        public static int Roll(int count, int die)
        {
            return Roll(count, die, 0);
        }
        public static int Roll(int count, int die, int bonus)
        {
            int rc = 0;

            for (int i = 0; i < count; i++)
            {
                // The upper value is exclusive, so we need to add 1.
                rc += Random.Next(1, die + 1);
            }

            rc += bonus;

            return rc;
        }

        public static int RollBetween(int min, int max)
        {
            // The upper value is exclusive, so we need to add 1.
            return Random.Next(min, max + 1);
        }
    }
}

