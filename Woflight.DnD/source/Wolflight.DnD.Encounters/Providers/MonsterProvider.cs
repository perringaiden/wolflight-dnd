namespace Wolflight.DnD.Encounters.Providers
{
    public class MonsterProvider
    {
        static MonsterProvider()
        {
            Monsters = PopulateMonsters();
        }

        private static readonly Dictionary<int, Types.Combatant> Monsters;

        private static Dictionary<int, Types.Combatant> PopulateMonsters()
        {
            return new Types.Combatant[] {
                new(5194864, Enums.ChallengeRating.Four, 1100, "Aarakocra Aeromancer"),
                new(5194865, Enums.ChallengeRating.Quarter, 50, "Aarakocra Skirmisher"),
                new(5194879, Enums.ChallengeRating.Two, 450, "Allosaurus"),
                new(5194893, Enums.ChallengeRating.One, 200, "Animated Armor"),
                new(4775801, Enums.ChallengeRating.Half, 100, "Ape"),
                new(5194905, Enums.ChallengeRating.Zero, 10, "Awakened Shrub"),
                new(5194915, Enums.ChallengeRating.Eighth, 25, "Bandit")
            }.ToDictionary(x => x.ID);
        }

        public static Types.Combatant GetMonsterByID(int monsterID)
        {
            if (Monsters.TryGetValue(monsterID, out Types.Combatant rc))
            {
                return rc;
            }
            else
            {
                return new Types.Combatant();
            }
        }

        public static IReadOnlyDictionary<int, string> GetMonsterNames()
        {
            return Monsters.ToDictionary(x => x.Key, x => x.Value.Name);
        }

    }
}

