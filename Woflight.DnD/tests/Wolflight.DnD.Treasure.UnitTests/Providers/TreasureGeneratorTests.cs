using Wolflight.DnD.Encounters.Enums;
using Wolflight.Utilities.Testing;

namespace Wolflight.DnD.Treasure.Providers
{
    public class TreasureGeneratorTests
    {

        public class IndividualTreasureMethod
        {
            [Fact]
            public void GetsSimpleTreasure()
            {
                foreach (
                    ChallengeRating challengeRating in new[] {
                        ChallengeRating.Eighth,
                        ChallengeRating.Quarter,
                        ChallengeRating.Half,
                        ChallengeRating.One,
                        ChallengeRating.Two,
                        ChallengeRating.Three,
                        ChallengeRating.Four
                    }
                )
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Types.Coins result = TreasureGenerator.IndividualTreasure(challengeRating);

                        Assert.InRange(result.Gold, 3, 18);
                        result.Platinum.AssertZero();
                        result.Copper.AssertZero();
                        result.Silver.AssertZero();
                        Assert.InRange(result.Value(), 300, 1800);

                    }
                }

                foreach (
                    ChallengeRating challengeRating in new[] {
                        ChallengeRating.Five,
                        ChallengeRating.Six,
                        ChallengeRating.Seven,
                        ChallengeRating.Eight,
                        ChallengeRating.Nine,
                        ChallengeRating.Ten
                    }
                )
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Types.Coins result = TreasureGenerator.IndividualTreasure(challengeRating);

                        Assert.InRange(result.Gold, 20, 160);
                        result.Platinum.AssertZero();
                        result.Copper.AssertZero();
                        result.Silver.AssertZero();
                        Assert.InRange(result.Value(), 2000, 16000);

                    }
                }

                foreach (
                    ChallengeRating challengeRating in new[] {
                        ChallengeRating.Eleven,
                        ChallengeRating.Twelve,
                        ChallengeRating.Thirteen,
                        ChallengeRating.Fourteen,
                        ChallengeRating.Fifteen,
                        ChallengeRating.Sixteen
                    }
                )
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Types.Coins result = TreasureGenerator.IndividualTreasure(challengeRating);

                        Assert.InRange(result.Platinum, 20, 200);
                        result.Gold.AssertZero();
                        result.Copper.AssertZero();
                        result.Silver.AssertZero();
                        Assert.InRange(result.Value(), 20000, 200000);

                    }
                }

                foreach (
                    ChallengeRating challengeRating in new[] {
                        ChallengeRating.Seventeen,
                        ChallengeRating.Eighteen,
                        ChallengeRating.Nineteen,
                        ChallengeRating.Twenty
                    }
                )
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Types.Coins result = TreasureGenerator.IndividualTreasure(challengeRating);

                        Assert.InRange(result.Platinum, 200, 1600);
                        result.Gold.AssertZero();
                        result.Copper.AssertZero();
                        result.Silver.AssertZero();
                        Assert.InRange(result.Value(), 200000, 1600000);

                    }
                }
            }
        }

    }
}
