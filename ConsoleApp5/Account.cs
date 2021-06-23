using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Account
    {
        public Message Info;
        public Message Error;

        private string Name;
        private string LastName;

        public int Sum { get; set; } = 0;

        private bool bank_account = false;
        private double Bablo;

        public void Open(string Name, string LastName)
        {
            if (bank_account)
            {
                this.Name = Name;
                this.LastName = LastName;
                bank_account = true;
                Info?.Invoke("Счёт на имя: '" + Name + " " + LastName + "' Открыт");
            }
            else
            {
                Error?.Invoke("У вас уже есть открытый счёт");
            }
        }

        public void SetBablo()
        {
            if (bank_account == true)
            {
                Info?.Invoke("У вас на счету " + Sum + " денег");
                Info?.Invoke("Сколько желаете положить? ");
                int IncludedBablo = Convert.ToInt32(Console.ReadLine());
                if (IncludedBablo < 0)
                {
                    Error?.Invoke("Мы не можем положить на счёт отрицательное количество денег");
                }
                Info?.Invoke("Теперь у вас на счету" + (Sum + IncludedBablo) + "денег");
            }
            else
            {
                Error?.Invoke("У вас нет счёта, чтобы положить деньги");
            }
        }

        public void TakeBablo()
        {
            if (bank_account == true)
            {
                Info?.Invoke("У вас на счету " + Sum + " денег");
                Info?.Invoke("Сколько желаете снять?");
                int TakenBablo = Convert.ToInt32(Console.ReadLine());
                if (TakenBablo > Sum)
                {
                    Error?.Invoke("У вас нет достаточного количества денег на счету, чтобы выполнить данную операцию");
                }
                if (TakenBablo < 0)
                {
                    Error?.Invoke("Мы не можем снять с счёта отрицательно количество денег");
                }
                else
                {
                    Info?.Invoke("Теперь у вас на счету" + (Sum - TakenBablo) + "денег");
                }
            }
            else
            {
                Error?.Invoke("Вы не можете снять деньги поскольку у вас нет открытого счёта");
            }
        }

        public void Close()
        {
            if (bank_account == true)
            {
                bank_account = false;
                Info?.Invoke("Вы закрыли счёт");
            }
            else
            {
                Error?.Invoke("У вас нет открытого счёта");
            }
        }

    }
}
// ДОМАШКА
