using static System.Console;


namespace AttributesProject
{
    public class FighterWriter
    {
        private readonly Fighter _fighter;

        public FighterWriter(Fighter fighter)
        {
            _fighter = fighter;
        }

        public void Write()
        {
            WriteBeltColor();
            WriteName();
        }

        private void WriteName()
        {
            WriteLine(_fighter.Name);
        }

        private void WriteBeltColor()
        {
            WriteLine(_fighter.BeltColor);
        }
    }
}
