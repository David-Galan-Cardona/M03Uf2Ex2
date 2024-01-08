using System;
namespace M3UF2
{
    class Ex2
    {
        public static void Main()
        {
            const string Choice = "1.Validar si un nombre és senar \n2.Calcular la potència d'un nombre \n3.Retornar un valor aleatori \n4.Comptar el nombre de vocals o consonants en un text " +
                "\n5.Sortir", Question = "Què vols fer?", NotValid = "Introdueix un nombre vàlid", Odd = "El nombre és senar", NotOdd = "El nombre no és senar";
            int choice;

            Console.WriteLine(Question);
            Console.WriteLine(Choice);
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice < 1 || choice > 5)
            {
                Console.WriteLine(NotValid);
                choice = Convert.ToInt32(Console.ReadLine());
            }
            if (choice == 1)
            {
                if (Senar())
                {
                    Console.WriteLine(Odd);
                }
                else
                {
                    Console.WriteLine(NotOdd);
                }
            }

        }
        public static int Validate()
        {
            const string NotValid = "Introdueix un nombre vàlid";
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine(NotValid);
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        public static bool Senar()
        {
            const string InputNum = "Introdueix un nombre";
            Console.WriteLine(InputNum);
            int num = Validate();
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}