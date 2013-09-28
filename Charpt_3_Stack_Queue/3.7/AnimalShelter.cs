using System;
using System.Collections.Generic;
/*
 * An animal shelter holds only dogs and cats, and operates on the strictly "first in,
 * first out" basis. People must adopt either the "oldest" (based on arrival time) of 
 * all animals at the shelter, or they can select  whether they would perfer a dog or
 * a cat(and will receive the oldest animal of that type). they cannot select which
 * specific animal they would like. Create the data structures to maintain this system
 * and implement operations such as enqueue, dequeueAny, dequeueDog and dequeueCat.
 * you may use the build-in LinkedList data structure
 * 
 */ 
namespace AnimalShelter
{
    public class AnimalShelter
    {
        private LinkedList<object> animalQueue = new LinkedList<object>();

        public void enqueue(object o)
        {
            animalQueue.AddFirst(o);
        }

        public object dequeueAny()
        {
            object o = animalQueue.Last.Value;
            animalQueue.RemoveLast();
            return o;
        }

        public dog dequeueDog()
        {
            LinkedListNode<object> node=animalQueue.First;
            LinkedListNode<object> lastDog = null;
            while (node != null)
            {
                if (node.Value is dog)
                {
                    lastDog = node;
                }
                node = node.Next;
            }
            animalQueue.Remove(lastDog);
            return (dog)lastDog.Value;
                
        }

        public cat dequeueCat()
        {
            LinkedListNode<object> node = animalQueue.First;
            LinkedListNode<object> lastCat = null;
            while (node != null)
            {
                if (node.Value is cat)
                {
                    lastCat = node;
                }
                node = node.Next;
            }
            animalQueue.Remove(lastCat);
            return (cat)lastCat.Value;

        }
    }


    public class cat
    {
        public string name;
        public cat(string _name)
        {
            this.name = _name;
        }
    }

    public class dog
    {
        public string name;
        public dog(string _name)
        {
            this.name = _name;
        }
    }
}
