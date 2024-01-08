using System;

namespace M3UF2
{
    class Ex2
    {
        public static void Main()
        {
            const string Choice = "1.Validar si un nombre és senar \n2.Calcular la potència d'un nombre \n3.Retornar un valor aleatori \n4.Comptar el nombre de vocals o consonants en un text " +
                "\n5.Sortir", Question = "Què vols fer?", NotValid = "Introdueix un nombre vàlid", Odd = "El nombre és senar", NotOdd = "El nombre no és senar", Goodbye = "Fins aviat";
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
            if (choice == 2)
            {
                Console.WriteLine(Power());
            }
            if (choice == 3)
            {
                Console.WriteLine(Random());
            }
            if (choice == 5)
            {
                Console.WriteLine(Goodbye);
            }
            else
            {
                Console.WriteLine("No ho he acabat");
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
        public static int Power()
        {
            const string Base = "Digues la base", Exp = "Digues l'exponent";
            int bas, exp = -1, result = 1;

            Console.WriteLine(Base);
            bas = Validate();
            while (exp < 0)
            {
                Console.WriteLine(Exp);
                exp = Validate();
            }
            if (exp == 0)
            {
                return 1;
            }
            for (int i = 0; i < exp; i++)
            {
                result *= bas;
            }
            return result;
        }
        public static int Random()
        {
            Random Rnd = new Random();
            return Rnd.Next();
        }
        
    }
}
