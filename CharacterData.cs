namespace Characterstatgui
{
    // Holds all my character data passed between forms
    public class CharacterData
    {
        public string Name;
        public CharacterClass ClassInfo;

        public int Points;
        public int Strength;
        public int Dexterity;
        public int Intelligence;
        public int Vitality;
        public int Energy;

        public CharacterData(string name, CharacterClass chosenClass)
        {
            Name = name;
            ClassInfo = chosenClass;

            Points = chosenClass.StartingPoints;
            Strength = chosenClass.Strength;
            Dexterity = chosenClass.Dexterity;
            Intelligence = chosenClass.Intelligence;
            Vitality = chosenClass.Vitality;
            Energy = chosenClass.Energy;
        }
    }
}

