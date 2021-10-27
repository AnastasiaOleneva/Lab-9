using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое целое число");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое второе число");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции :   \n 1-сложение \n 2- вычитание \n 3-произведение \n 4-частное");

                int action = Convert.ToInt32(Console.ReadLine());


                switch (action)
                {


                    case 1:

                        double sum = firstNumber + secondNumber;
                        Console.WriteLine(sum);

                        break;


                    case 2:

                        Console.WriteLine(firstNumber - secondNumber);
                        break;

                    case 3:

                        Console.WriteLine(firstNumber * secondNumber);
                        break;

                    case 4:

                        Console.WriteLine(firstNumber / secondNumber);

                        break;

                    default:
                        Console.WriteLine("Введен несуществующий код операции");
                        break;

                }
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {

                Console.WriteLine("Ошибка! Входная строка имеет неверный формат");
            }

            Console.ReadKey();
        }



    }
}










