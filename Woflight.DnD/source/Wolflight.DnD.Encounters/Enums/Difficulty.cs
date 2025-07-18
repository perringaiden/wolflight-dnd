﻿namespace Wolflight.DnD.Encounters.Enums
{
    public enum Difficulty
    {
        /// <summary>
        /// An encounter of low difficulty is likely to have one or two scary moments for the players,
        /// but their characters should emerge victorious with no casualties. One or more of them might
        /// need to use healing resources, however. As a rough guideline, a single monster generally presents
        /// a low-difficulty challenge for a party of four characters whose level equals the monster’s CR.
        /// </summary>
        Low,

        /// <summary>
        /// Absent healing and other resources, an encounter of moderate difficulty could go 
        /// badly for the adventurers. Weaker characters might get taken out of the fight, and
        /// there’s a slim chance that one or more characters might die.
        /// </summary>
        Moderate,

        /// <summary>
        /// A high-difficulty encounter could be lethal for one or more characters. To survive it,
        /// the characters will need smart tactics, quick thinking, and maybe even a little luck.
        /// </summary>
        High,

        /// <summary>
        /// This encounter is most likely lethal for one or more characters, and possible an entire party.
        /// </summary>
        Deadly
    }
}
