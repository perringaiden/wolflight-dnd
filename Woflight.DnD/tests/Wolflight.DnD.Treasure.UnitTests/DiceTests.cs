namespace Wolflight.DnD.Treasure
{
    public class DiceTests
    {
        public class RollMethod
        {
            [Fact]
            public void SingleDieWithinValues()
            {
                for (int i = 0; i < 100; i++)
                {
                    Assert.InRange(Dice.Roll(1, 6), 1, 6);
                }
            }

            [Fact]
            public void SingleDieWithBonusWithinValues()
            {
                for (int i = 0; i < 100; i++)
                {
                    Assert.InRange(Dice.Roll(1, 6, 2), 3, 8);
                }
            }

            [Fact]
            public void MultipleDiceWithinValues()
            {
                for (int i = 0; i < 100; i++)
                {
                    Assert.InRange(Dice.Roll(3, 6), 3, 18);
                }

            }
            [Fact]
            public void MultipleDiceWithBonusWithinValues()
            {
                for (int i = 0; i < 100; i++)
                {
                    Assert.InRange(Dice.Roll(3, 6, 7), 10, 25);
                }

            }
        }

    }
}
