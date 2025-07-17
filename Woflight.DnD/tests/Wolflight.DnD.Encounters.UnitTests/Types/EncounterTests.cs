namespace Wolflight.DnD.Encounters.Types
{
    public class EncounterTests
    {
        public class CurrentDifficultyMethod
        {
            [Fact]
            public void ReturnsCorrectDifficultyForSinglePlayer()
            {
                Encounter target = new();

                target.AddLevel(5);

                target.AddEnemy(new Combatant(1, Enums.ChallengeRating.One, 200, "Animated Armor"));
                target.AddEnemy(new Combatant(1, Enums.ChallengeRating.One, 200, "Animated Armor"));

                Assert.Equal(Enums.Difficulty.Low, target.CurrentDifficulty);

                target.AddEnemy(new Combatant(1, Enums.ChallengeRating.One, 200, "Animated Armor"));

                Assert.Equal(Enums.Difficulty.Moderate, target.CurrentDifficulty);

                target.AddEnemy(new Combatant(1, Enums.ChallengeRating.One, 200, "Animated Armor"));


            }

            [Fact]
            public void ReturnsCorrectDifficultyForMultiple()
            {
                Encounter target = new();

                target.AddLevel(5);
                target.AddLevel(5);
                target.AddLevel(5);
                target.AddLevel(5);

                for (int i = 0; i < 199; i++)
                {
                    target.AddEnemy(Providers.MonsterProvider.GetMonsterByID(5194905));
                }

                Assert.Equal(Enums.Difficulty.Low, target.CurrentDifficulty);

                for (int i = 0; i < 2; i++)
                {
                    target.AddEnemy(Providers.MonsterProvider.GetMonsterByID(5194905));
                }

                Assert.Equal(Enums.Difficulty.Moderate, target.CurrentDifficulty);

                for (int i = 0; i < 98; i++)
                {
                    target.AddEnemy(Providers.MonsterProvider.GetMonsterByID(5194905));
                }

                Assert.Equal(Enums.Difficulty.Moderate, target.CurrentDifficulty);


                for (int i = 0; i < 2; i++)
                {
                    target.AddEnemy(Providers.MonsterProvider.GetMonsterByID(5194905));
                }

                Assert.Equal(Enums.Difficulty.High, target.CurrentDifficulty);

                for (int i = 0; i < 138; i++)
                {
                    target.AddEnemy(Providers.MonsterProvider.GetMonsterByID(5194905));
                }

                Assert.Equal(Enums.Difficulty.High, target.CurrentDifficulty);

                for (int i = 0; i < 2; i++)
                {
                    target.AddEnemy(Providers.MonsterProvider.GetMonsterByID(5194905));
                }

                Assert.Equal(Enums.Difficulty.Deadly, target.CurrentDifficulty);
            }
        }

    }
}
