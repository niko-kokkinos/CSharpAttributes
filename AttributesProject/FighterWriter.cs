using System;
using System.Reflection;
using System.Text;
using static System.Console;


namespace AttributesProject
{
    public class FighterWriter
    {
        private readonly Fighter _fighter;
        private ConsoleColor _color; 

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
            //WriteLine(_fighter.BeltColor);
            PropertyInfo beltColorProperty = typeof(Fighter).GetProperty(nameof(Fighter.BeltColor));
            DisplayAttribute beltColorDisplayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(beltColorProperty, typeof(DisplayAttribute));

            PreserveForegroundColor();

            StringBuilder sb = new StringBuilder();
            
            if (beltColorDisplayAttribute != null)
            {
                ForegroundColor = beltColorDisplayAttribute.Color;
                sb.Append(beltColorDisplayAttribute.Label);
            }

            if (_fighter.BeltColor !=null)
            {
                sb.Append(_fighter.BeltColor);
            }

            WriteLine(sb);

            RestoreForegroundColor();
        }

        private void PreserveForegroundColor()
        {
            _color = ForegroundColor;
        }

        private void RestoreForegroundColor()
        {
            ForegroundColor = _color;
        }
    }
}
