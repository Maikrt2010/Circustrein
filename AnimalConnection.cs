using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public interface IAnimalConnection
    {
        void Makecarnivore(int size);
        void Makeherbivore(int size);
        Animal Animaltoload(int size);
        int Loadammount();
        List<Animal> Animalstoshow();
        void AnimalLoaded(Animal Loaded);
    }

    public class AnimalConnection : IAnimalConnection
    {
        private List<Animal> _animals = new List<Animal>();

        public int Loadammount()
        {
            return _animals.Count;
        }

        public void Makecarnivore(int size)
        {
            int animalid = _animals.Count + 1;
            _animals.Add(new Carnivore(animalid, size, Animaltype.carnivore));
        }


        public void Makeherbivore(int size)
        {
            int animalid = _animals.Count + 1;
            _animals.Add(new Herbivore(animalid, size, Animaltype.herbivore));

        }

        public Animal Animaltoload(int size)
        {
            Animal animaltoload = _animals.Find(animal => animal.Size <= size);
            return animaltoload ;
        }

        public void AnimalLoaded(Animal Loaded)
        {
            _animals.Remove(Loaded);
        }

        public List<Animal> Animalstoshow()
        {
            return _animals;
        }

    }
}
