using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class Bird : IAnimal
    {
        private string ac = "Птица";
        public string AnimalClass { get { return ac; } }

        public string AnimalSpecies { get; set; }

        public Bird(string species) 
        {
            AnimalSpecies = species;
        }

        public override string ToString()
        {
            return $"{AnimalClass}, {AnimalSpecies}";
        }
    }
}
