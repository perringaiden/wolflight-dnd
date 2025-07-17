using Wolflight.DnD.Encounters.Enums;

namespace Wolflight.DnD.Encounters.Types
{
    public class Encounter
    {
        public IList<int> Levels { get; } = [];

        public int LowDifficultyXP { get; private set; } = 0;
        public int ModerateDifficultyXP { get; private set; } = 0;
        public int HighDifficultyXP { get; private set; } = 0;

        public Difficulty CurrentDifficulty { get; private set; } = Difficulty.Low;

        public IList<Combatant> Enemies { get; } = [];


        public void AddLevel(int level)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(level, 1);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(level, 20);

            Levels.Add(level);

            RecalculateLevels();
            RecalculateDifficulty();
        }

        public bool RemoveLevel(int level)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(level, 1);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(level, 20);

            if (Levels.Remove(level))
            {
                RecalculateLevels();
                RecalculateDifficulty();
                return true;
            }
            else
            {
                return false;
            }
        }


        private void RecalculateLevels()
        {
            LowDifficultyXP = GetDifficultyXP(Difficulty.Low);
            ModerateDifficultyXP = GetDifficultyXP(Difficulty.Moderate);
            HighDifficultyXP = GetDifficultyXP(Difficulty.High);
        }


        private int GetDifficultyXP(Difficulty difficulty)
        {
            return Levels.Select(
                x =>
                {
                    return difficulty switch
                    {
                        Difficulty.Low => XPTables.LowXPBudget[x],
                        Difficulty.Moderate => XPTables.ModerateXPBudget[x],
                        Difficulty.High => XPTables.HighXPBudget[x],
                        _ => 0,
                    };
                    ;
                }
            ).Sum();
        }

        public int CurrentXP { get; private set; } = 0;

        public void AddEnemy(Combatant combatant)
        {
            if (!combatant.IsEmpty())
            {
                Enemies.Add(combatant);

                CurrentXP += combatant.XP;

                RecalculateDifficulty();
            }
        }

        public void RemoveEnemy(int ID)
        {
            Combatant toRemove = Enemies.FirstOrDefault(x => ID == x.ID);

            if (!toRemove.IsEmpty())
            {
                Enemies.Remove(toRemove);

                CurrentXP -= toRemove.XP;

                RecalculateDifficulty();
            }


        }



        private void RecalculateDifficulty()
        {
            if (CurrentXP <= LowDifficultyXP)
            {
                CurrentDifficulty = Difficulty.Low;
            }
            else if (CurrentXP <= ModerateDifficultyXP)
            {
                CurrentDifficulty = Difficulty.Moderate;
            }
            else if (CurrentXP <= HighDifficultyXP)
            {
                CurrentDifficulty = Difficulty.High;
            }
            else
            {
                CurrentDifficulty = Difficulty.Deadly;
            }
        }
    }
}
