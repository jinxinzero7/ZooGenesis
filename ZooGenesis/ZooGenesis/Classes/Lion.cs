using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGenesis
{
    public enum ManeLength
    {
        Маленькая,
        Средняя,
        Большая,
        Великолепная
    }
    public class Lion : Animal
    {
        // длина гривы
        private ManeLength _maneSize;
        public ManeLength ManeSize
        {
            get { return _maneSize; }
            set { _maneSize = value; }
        }
        public Lion(string name, int age, double health,ManeLength maneSize, Gender gender, List<char> genes = null)
            : base(name, age, health, gender, genes)
        {
            ManeSize = maneSize;
            Console.WriteLine($"Создан лев: {name}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Grrr-roar!...");
        }

        public override string ToString()
        {
            return base.ToString() + $", Размер гривы: {ManeSize}";
        }
    }
}
