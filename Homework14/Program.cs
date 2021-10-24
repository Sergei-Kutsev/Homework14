using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Кот.";
            cat.Say();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.Name = "Собака.";
            dog.Say();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { set; get; }
        public Animal()
        {
            Name = "Животное";
        }

        abstract public string Say();
        public virtual void ShowInfo()
        {
            Console.WriteLine("{0} {1}", Name, Say());
            
        }
        
    }
    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return "Мяу.";
        }
    }
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return "Гав.";
        }
    }
}