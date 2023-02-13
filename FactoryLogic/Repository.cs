using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLogic
{
    public class Repository
    {
        public List<IAnimal> animals;

        public Repository() 
        {
            animals = new List<IAnimal>();
        }

        public void Add(IAnimal animal) { animals.Add(animal); }

        public void Remove(int index) { animals.Remove(animals[index]); }

        public void Change(int index, string change) { animals[index].AnimalSpecies= change; }

        public void Save()
        {
            StreamWriter stream = new StreamWriter(Path.GetFullPath(@"AnimalsSave.txt"));

            foreach(IAnimal animal in animals) { stream.WriteLine($"{animal.AnimalClass}/{animal.AnimalSpecies}/");}
            stream.Close();
        }

        public void Load() 
        {
            StreamReader stream = new StreamReader(Path.GetFullPath(@"AnimalsSave.txt"));

            string text = stream.ReadToEnd();
            string[] lines = text.Split('\n');

            
            foreach(string line in lines) 
            {
                try
                {

                    string[] subline = line.Split('/');
                    Add(Factory.NewAnimal(subline[0], subline[1]));
                }
                catch (IndexOutOfRangeException)
                {
                    
                }
            }
            stream.Close();
        }
    }
}
