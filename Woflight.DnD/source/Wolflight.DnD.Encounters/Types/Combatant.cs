using System.Diagnostics.CodeAnalysis;

namespace Wolflight.DnD.Encounters.Types
{
    public struct Combatant : IEquatable<Combatant>
    {
        public Combatant(int id, Enums.ChallengeRating challengeRating, int xp, string name)
        {
            ID = id;
            ChallengeRating = challengeRating;
            XP = xp;
            Name = name;
        }

        public int ID { get; }
        public Enums.ChallengeRating ChallengeRating { get; }

        public int XP { get; }

        public string Name;

        public bool IsEmpty()
        {
            return (ID == 0);
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj != null)
            {
                return obj is Combatant ? Equals((Combatant)obj) : false;
            }
            else
            {
                return false;
            }
        }

        public bool Equals([NotNullWhen(true)] Combatant other)
        {
            return (ID == other.ID);
        }
    }
}
