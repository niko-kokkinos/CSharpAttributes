using System;

namespace AttributesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter achilles = new Fighter()
            {
                BeltColor = "Yellow",
                Name = "Achilles"
            };

            FighterWriter fighterWriter = new FighterWriter(achilles);
            fighterWriter.Write();

            Console.WriteLine("\n Demo ends. Good Bye :-) ");
        }
    }
}
