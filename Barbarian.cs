namespace Characterstatgui
{
    // Barbarian class inherits from CharacterClass
    public class Barbarian : CharacterClass
    {
        public Barbarian()
        {
            ClassName = "Barbarian";

            StartingPoints = 7;
            Strength = 3;
            Dexterity = 1;
            Intelligence = 0;
            Vitality = 3;
            Energy = 0;
        }
    }
}

