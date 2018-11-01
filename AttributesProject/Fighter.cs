using System;
using System.Collections.Generic;
using System.Text;

namespace AttributesProject
{
    public class Fighter
    {
        public string Name { get; set; }

        [Display("Belt: ", ConsoleColor.DarkRed)]
        public string BeltColor { get; set; }
    }
}
