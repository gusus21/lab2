using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void FirstBlock()
        {
            Console.WriteLine("Введіть кількість чисел");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть послідовність");
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                if (elem > max)
                    max = elem;                
            }
            Console.WriteLine("Максимальне число = " + max);
        }
        static void SecondBlock()
        {
            Console.WriteLine("Введіть послідовність чисел");
            int firstNumber = int.Parse(Console.ReadLine());
            int elem = int.Parse(Console.ReadLine());
            uint count = 0;
            while (elem != 0 && firstNumber != 0)
            {
                if (elem % firstNumber == 0)
                    count++;
                elem = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Чисел кратних першому: " + count);

        }
        static void ThirdBlock()
        {
            bool prost = true;
            Console.WriteLine("Введіть число: ");
            int k = int.Parse(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(k); i++)
            {
                if (k % i == 0)
                {
                    prost = false;
                    break;
                }
            }
                if (prost)
                    Console.WriteLine("Число просте");
                else
                    Console.WriteLine("Число не просте");
            
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Для виконання блоку 1 (варіант 9) введіть 1");
                Console.WriteLine("Для виконання блоку 2 (варіант 32) введіть 2");
                Console.WriteLine("Для виконання блоку 3 (варіант 45) введіть 3");
                Console.WriteLine("Для виходу з програми введіть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую блок 1");
                        FirstBlock();
                        break;
                    case 2:
                        Console.WriteLine("Виконую блок 2");
                        SecondBlock();
                        break;
                    case 3:
                        Console.WriteLine("Виконую блок 3");
                        ThirdBlock();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);

        }
    }
}
