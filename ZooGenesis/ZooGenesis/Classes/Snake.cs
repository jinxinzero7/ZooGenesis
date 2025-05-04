using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGenesis
{
    public enum BodyLength
    {
        Короткая,
        Средняя,
        Длинная,
        Гигантская
    }
    public class Snake : Animal
    {
        private BodyLength _bodyLength;
        public BodyLength BodyLength { get; set; }

        public Snake(string name, int age, double health, BodyLength bodyLength, Gender gender, List<char> genes = null)
            : base(name, age, health, gender, genes)
        {
            BodyLength = bodyLength;
            Console.WriteLine($"Создана змея: {name}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ssss...");
        }

        public override string ToString()
        {
            return base.ToString() + $", Длина тела: {BodyLength}";
        }

    }
}
