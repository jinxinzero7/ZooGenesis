using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGenesis;

namespace ZooGenesis
{
    public enum PenguinSize
    {
        Малый,
        Средний,
        Большой,
        Императорский
    }
    public class Penguin : Animal
    {
        public PenguinSize Size { get; set; }
        public Penguin(string name, int age, double health, PenguinSize size, Gender gender, List<char> genes = null)
            : base(name, age, health, gender, genes)
        {
            Size = size;
        }

        public override void MakeSound()
        {
            Console.WriteLine("A-akh, akh, akh!");
        }

        public override string ToString()
        {
            return base.ToString() + $", Размер: {Size}";
        }
    }
}
