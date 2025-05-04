using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGenesis
{
    public enum Gender
    {
        Мужской,
        Женский,
        Неизвестно
    }
    abstract public class Animal : IMutable
    {
        private string _name;
        private int _age;
        private double _health;
        private List<char> _genes;
        private bool _isAlive;
        private Gender _gender;

        private static readonly Dictionary<char, string> GeneSymbols = new Dictionary<char, string>()
        {
            {'a', "▲"},
            {'b', "■"},
        };

        public string Name
        {
            get { return _name; }
            set { _name = value ?? "Безымянный"; }
        }

        public int Age
        {
            get { return _age; }
            protected set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Возраст не может быть отрицательным. Возраст не изменен.");
                }
            }
        }

        public double Health
        {
            get { return _health; }
            protected set
            {
                _health = Math.Clamp(value, 0, 100);
                _isAlive = _health > 0;
            }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
        }

        public List<char> Genes
        {
            get { return _genes; }
        }
        public Gender Gender { get; set; }

        public Animal(string name, int age, double health, Gender gender, List<char> genes)
        {
            _name = name;
            Age = age;
            Health = health;
            _genes = genes; ;
            _isAlive = _health > 0;
            _gender = gender;
        }

        // метод для восполнения здоровья
        public void Eat()
        {
            if (IsAlive)
            {
                Health += 10;
                Console.WriteLine($"{Name} поело и его здоровье увеличилось.");
            }
            else
            {
                Console.WriteLine($"{Name} мёртв, кормить его бесполезно.");
            }

        }

        public virtual void MakeSound()
        {
            if (IsAlive)
            {
                Console.WriteLine("Sound");
            }
            else
            {
                Console.WriteLine($"{Name} мёртв, он не может издавать звуки");
            }

        }



        public void GetSick()
        {
            if (IsAlive)
            {
                // рандомное число для болезни
                Random rand = new Random();
                // рандомное число олицетворяет тяжесть болезни, домножение на 5 в связи с количеством хп
                Health -= rand.Next(10) * 5;
                Console.WriteLine($"{Name} заболело! Здоровье уменьшилось до {Health}");
            }
            else
            {
                Console.WriteLine($"{Name} мёртв, болеть ему уже нечем.");
            }
        }

        public void Mutate(double mutationRate) // mutationRate - вероятность мутации для каждого гена
        {
            if (IsAlive)
            {
                Random random = new Random();
                for (int i = 0; i < Genes.Count; i++)
                {
                    if (random.NextDouble() < mutationRate) // Случайное число от 0.0 до 1.0
                    {
                        // Мутируем ген
                        char newGene;
                        do
                        {
                            newGene = (char)('a' + random.Next(GeneSymbols.Count)); // Выбираем случайный символ от 'a' до 'a' + размер словаря
                        } while (newGene == Genes[i]); // Убеждаемся, что новый ген отличается от старого
                        Genes[i] = newGene;
                    }
                }
            }
            else
            {
                Console.WriteLine("Животное умерло и не может мутировать.");
            }

        }

        public string GetGenesAsSymbols()
        {
            return string.Join(" ", Genes.Select(gene => GeneSymbols.GetValueOrDefault(gene, "?")));
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Здоровье: {Health}%, Пол: {Gender}, Гены: {GetGenesAsSymbols()}";
        }

    }
}
