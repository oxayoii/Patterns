using AbstractFactory.AF;
using AbstractFactory.Cars;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние:");
            int distance = int.Parse(Console.ReadLine());

            IAutoFactory factory;
            Console.WriteLine("Выберите тип автомобиля: 1 - джип, 2 - седан");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    factory = new JeepFactory();
                    break;
                case 2:
                    factory = new SedanFactory();
                    break;
                default:
                    throw new ArgumentException("Неверный выбор");
            }

            Car car = factory.createCar();
            int time = factory.calculateTime(distance);

            Console.WriteLine($"Автомобиль пройдет расстояние за {time} часов");
        }
    }
}
    

