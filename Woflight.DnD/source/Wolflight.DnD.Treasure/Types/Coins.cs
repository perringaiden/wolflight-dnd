namespace Wolflight.DnD.Treasure.Types
{
    public class Coins
    {
        /// <summary>
        /// The number of copper pieces.
        /// </summary>
        public int Copper { get; set; }

        /// <summary>
        /// The number of silver pieces.
        /// </summary>
        public int Silver { get; set; }

        /// <summary>
        /// The number of gold pieces.
        /// </summary>
        public int Gold { get; set; }

        /// <summary>
        /// The number of platinum pieces.
        /// </summary>
        public int Platinum { get; set; }

        /// <summary>
        /// Returns the total of the coins in copper pieces.
        /// </summary>
        /// <returns>The total copper value.</returns>
        public int Value()
        {
            return Copper + (Silver * 10) + (Gold * 100) + (Platinum * 1000);
        }
    }
}
