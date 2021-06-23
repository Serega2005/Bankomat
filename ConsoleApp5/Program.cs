using System;

namespace Bank
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Мы приветствуем вас в Сбербанке, какую операцию с вашим счётом вы хотите сделать?");

            Account account = new Account();
            account.Info = ShowInfo;
            account.Error = ShowError;

            string Name = "";
            string LastName = "";

            for (; ; )
            {
                int cislo = 0;

                Console.WriteLine("1. Открыть счёт", cislo);
                Console.WriteLine("2. Внести деньги", cislo);
                Console.WriteLine("3. Снять деньги", cislo);
                Console.WriteLine("4. Закрыть счёт", cislo);
                Console.WriteLine("Введите имя - ", Name);
                Console.WriteLine("Введите фамилию - ", LastName);
                if (cislo == 1)account.Open(Name, LastName);
                if (cislo == 2)account.SetBablo();
                if (cislo == 3)account.TakeBablo();
                if (cislo == 4)account.Close();
            }

            static void ShowInfo(string message)
            {
                Console.WriteLine(message);
            }
            static void ShowError(string message)
            {
                Console.WriteLine(message);
            }

        }
    }
}
