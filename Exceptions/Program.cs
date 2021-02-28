using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();
            //ActionDemo();
            //RunMethod(() => { Topla2(3, 5); });


            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());

        }

        private static void RunMethod(Action action)
        {
            action.Invoke();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        static void Topla2(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        private static void ActionDemo()
        {
            // Methoda parametre olan void bir method veriliyor.
            HandleException(() => 
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Çağkan", "Selin", "Ece" };

            if (!students.Contains("Timuçin"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Çağkan", "Selin", "Ece" };
                students[3] = "Timuçin";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}