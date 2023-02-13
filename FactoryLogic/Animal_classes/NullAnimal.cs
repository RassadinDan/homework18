using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class NullAnimal : IAnimal
    {
        private string ac = "Животное";

        public string AnimalClass { get { return ac; } }

        public string AnimalSpecies { get; set; }
        public NullAnimal(string species) 
        {
            AnimalSpecies= species;
        }

        public override string ToString()
        {
            return $"{AnimalClass}, {AnimalSpecies}";
        }
    }
}
