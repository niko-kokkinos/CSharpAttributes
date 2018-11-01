using System;

namespace AttributesProject
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayAttribute : Attribute
    {
        
        public DisplayAttribute(string label, ConsoleColor color = ConsoleColor.White)
        {
            Color = color;
            Label = label ?? throw new ArgumentNullException(nameof(label));
        }

        public string  Label { get; private set; }

        public ConsoleColor Color { get; private set; }
    }
}
