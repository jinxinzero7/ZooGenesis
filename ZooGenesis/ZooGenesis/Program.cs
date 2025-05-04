using ZooGenesis;

List<char> standardGenes = new List<char>();
standardGenes.Add('a');
standardGenes.Add('b');
standardGenes.Add('b');
standardGenes.Add('b');
standardGenes.Add('a');
standardGenes.Add('a');


Penguin penguin = new Penguin("Чел", 5, 100, PenguinSize.Малый, Gender.Мужской, standardGenes);
Console.WriteLine(penguin); // Вывод информации о пингвине
penguin.MakeSound();

Snake snake = new Snake("Шланг", 3, 100, BodyLength.Гигантская, Gender.Женский, standardGenes);
Console.WriteLine(snake);
snake.MakeSound();

Lion lion = new Lion("Грива", 10, 95, ManeLength.Большая, Gender.Мужской, standardGenes);
Console.WriteLine(lion);
lion.MakeSound();

Console.WriteLine("\n");
lion.Mutate(0.5);
Console.WriteLine(lion);
