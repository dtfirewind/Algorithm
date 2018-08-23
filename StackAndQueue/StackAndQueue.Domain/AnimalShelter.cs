using System;

namespace StackAndQueue.Domain
{
    public enum PetType
    {
        dog = 1,
        cat = 2
    }

    public class Animal
    {
        public string name;
        public int order;

        public bool IsOlderThan(Animal animal)
        {
            return this.order < animal.order;
        }
    }

    public class AnimalShelter
    {
        MyQueue<Animal> dogs;
        MyQueue<Animal> cats;

        int order;

        public AnimalShelter()
        {
            dogs = new MyQueue<Animal>();
            cats = new MyQueue<Animal>();
        }

        public void Enqueue(Animal animal, PetType type)
        {
            animal.order = order;
            if(type == PetType.dog)
            {
                dogs.Add(animal);
            }else{
                cats.Add(animal);
            }
            order++;
        }

        public Animal DequeueAny()
        {
            if(dogs.IsEmpty()){
                return cats.Remove();
            }
            else if(cats.IsEmpty()){
                return dogs.Remove();
            }

            Animal dog = dogs.Peek();
            Animal cat = cats.Peek();

            return dog.IsOlderThan(cat) ? dog : cat;
        }

        public Animal DequeueDog()
        {
            return dogs.Remove();
        }

        public Animal DequeueCat()
        {
            return cats.Remove();
        }
    }
}