
namespace Wolflight.DnD.Treasure.Providers
{
    public class TreasureGenerator
    {

        #region Individual Treasure (Gold)

        /// <summary>
        /// The individual treasure for a creature, as Gold/Platinum.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>A <see cref="Types.Coins"/> with the treasure.</returns>
        public static Types.Coins IndividualTreasure(Encounters.Enums.ChallengeRating challengeRating)
        {
            return new Types.Coins()
            {
                Gold = IndividualGold(challengeRating),
                Platinum = IndividualPlatinum(challengeRating)
            };
        }


        /// <summary>
        /// The individual number of Gold pieces for a creature.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>A number of Gold pieces.</returns>
        private static int IndividualGold(Encounters.Enums.ChallengeRating challengeRating)
        {
            switch (challengeRating)
            {
                case <= Encounters.Enums.ChallengeRating.Four:
                    return Dice.Roll(3, 6);
                case > Encounters.Enums.ChallengeRating.Four and <= Encounters.Enums.ChallengeRating.Ten:
                    return Dice.Roll(2, 8) * 10;
                case > Encounters.Enums.ChallengeRating.Ten and <= Encounters.Enums.ChallengeRating.Sixteen:
                    return 0;
                case > Encounters.Enums.ChallengeRating.Sixteen:
                    return 0;
            };
        }


        /// <summary>
        /// The individual number of Platinum pieces for a creature.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>A number of Platinum pieces.</returns>
        private static int IndividualPlatinum(Encounters.Enums.ChallengeRating challengeRating)
        {
            switch (challengeRating)
            {
                case <= Encounters.Enums.ChallengeRating.Four:
                    return 0;
                case > Encounters.Enums.ChallengeRating.Four and <= Encounters.Enums.ChallengeRating.Ten:
                    return 0;
                case > Encounters.Enums.ChallengeRating.Ten and <= Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(2, 10) * 10;
                case > Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(2, 8) * 100;
            };

        }

        /// <summary>
        /// The individual treasure for a creature, expressed in copper pieces.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>The total number of copper pieces.</returns>
        public static int IndividualTreasureCopper(Encounters.Enums.ChallengeRating challengeRating)
        {
            return (IndividualGold(challengeRating) * 100) +
                (IndividualPlatinum(challengeRating) * 1000);
        }

        #endregion

        #region 

        /// <summary>
        /// The hoard treasure for a creature, as Gold/Platinum.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>A <see cref="Types.Coins"/> with the treasure.</returns>
        public static Types.Coins HoardTreasureCoins(Encounters.Enums.ChallengeRating challengeRating)
        {
            return new Types.Coins()
            {
                Gold = HoardGold(challengeRating),
                Platinum = HoardPlatinum(challengeRating)
            };

        }


        /// <summary>
        /// The hoard treasure number of Gold pieces for a creature.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>A number of Gold pieces.</returns>
        private static int HoardGold(Encounters.Enums.ChallengeRating challengeRating)
        {
            switch (challengeRating)
            {
                case <= Encounters.Enums.ChallengeRating.Four:
                    return Dice.Roll(2, 4) * 100;
                case > Encounters.Enums.ChallengeRating.Four and <= Encounters.Enums.ChallengeRating.Ten:
                    return Dice.Roll(8, 10) * 100;
                case > Encounters.Enums.ChallengeRating.Ten and <= Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(6, 8) * 1000;
                case > Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(4, 10) * 10000;
            };
        }

        /// <summary>
        /// The hoard treasure number of Platinum pieces for a creature.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns>A number of Platinum pieces.</returns>
        private static int HoardPlatinum(Encounters.Enums.ChallengeRating challengeRating)
        {
            switch (challengeRating)
            {
                case <= Encounters.Enums.ChallengeRating.Four:
                    return 0;
                case > Encounters.Enums.ChallengeRating.Four and <= Encounters.Enums.ChallengeRating.Ten:
                    return 0;
                case > Encounters.Enums.ChallengeRating.Ten and <= Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(2, 8) * 100;
                case > Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(2, 10) * 1000;
            };
        }

        /// <summary>
        /// The number of magical items to include in the hoard.
        /// </summary>
        /// <param name="challengeRating">The CR of the creature.</param>
        /// <returns></returns>
        public static int HoardMagicItems(Encounters.Enums.ChallengeRating challengeRating)
        {
            switch (challengeRating)
            {
                case <= Encounters.Enums.ChallengeRating.Four:
                    return Dice.Roll(1, 4, -1);
                case > Encounters.Enums.ChallengeRating.Four and <= Encounters.Enums.ChallengeRating.Ten:
                    return Dice.Roll(1, 3);
                case > Encounters.Enums.ChallengeRating.Ten and <= Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(1, 4);
                case > Encounters.Enums.ChallengeRating.Sixteen:
                    return Dice.Roll(1, 6);
            };
        }


        #endregion

        #region "Magic Items"



        #endregion

    }
}
