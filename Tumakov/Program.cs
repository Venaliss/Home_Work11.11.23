using System;

namespace Tumakov
{
    public enum Account_Types
    {
        safe,
        actual,
    }
    class Bank
    {
        /*Тумаков 9.1 Упражнение - добавить в класс банк конструкторы баланса, типа счета и баланса и счета одновременно*/
        public Bank(double balance)
        {
            Console.WriteLine("Создаем ячейку баланса...");
            Random rnd = new Random();
            Number_Acc = rnd.Next(1000000000, int.MaxValue);/*конструктор баланса*/
            Balance = balance;
            Console.WriteLine($"Номер лицевого счета - {Number_Acc}. Ваш баланс равен {Balance}");
        }
        public Bank(Account_Types type)
        {
            Console.WriteLine("Создаем ячейку типа...");
            Random rnd = new Random();
            Number_Acc = rnd.Next(1000000000, int.MaxValue);/*конструктор типа*/
            Type = type;
            Console.WriteLine($"Номер лицевого счета - {Number_Acc}. Тип банковского счета - {Type}");
        }
        public Bank(double balance, Account_Types type)
        {
            Console.WriteLine("Создаем ячейку под баланс и тип банковского счета...");
            Random rnd = new Random();
            Number_Acc = rnd.Next(1000000000, int.MaxValue);/*конструктор типа и баланса*/
            Type = type;
            Balance = balance;
            Console.WriteLine($"Номер лицевого счета - {Number_Acc}. На {Type} счете, баланс равен - {Balance}");
        }
        public int Number_Acc;
        public double Balance;
        public Account_Types Type;
        public void Stringer()
        {
            Console.WriteLine($"AccountNumber - {Number_Acc}, Balance - {Balance}, Type - {Type}");
        }
        public void AddMoney(double summ)
        {
            if (summ>0)
            {
                Balance += summ;
            }
            else
            {
                Console.WriteLine("Произошла ошибка при пополнении баланса. Неверно введено число.");
            }
        }
        public void TakeOffMoney(double summ)
        {
            if (Balance >= summ)
            {
                Balance -= summ;
            }
            else if(Balance <= summ)
            {
                Console.WriteLine("Произошла ошибка при снятии. Превышена сумма для снятия с баланса.");
            }
            else
            {
                Console.WriteLine("Произошла ошибка при снятии. Неверно введено число.");
            }
        }
        public void SwitchAccount(Account_Types type, double summ)
        {
            Bank safe = new Bank(4564546, Account_Types.safe);
            Bank actual = new Bank(86468846, Account_Types.actual);
            Console.WriteLine("С какого счета нужно перевести деньги на другой?(0 - Сберегательный ! 1 - Действительный");
            if (Console.ReadLine() == Convert.ToString('0'))
            {
                safe.Stringer();
                actual.Stringer();
                safe.TakeOffMoney(summ);
                actual.AddMoney(summ);
                Console.WriteLine("Перевод успешно завершен");
                actual.Stringer();
            }
            else if (Console.ReadLine() == Convert.ToString('1'))
            {
                safe.Stringer();
                actual.Stringer();
                actual.TakeOffMoney(summ);
                safe.AddMoney(summ);
                Console.WriteLine("Перевод успешно завершен");
                safe.Stringer();
            }
            else
            {
                Console.WriteLine("произошла неизвестная ошибка");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank balance = new Bank(10000);
            Bank type = new Bank(Account_Types.actual);
            Bank all = new Bank(1000, Account_Types.actual);
            Console.ReadKey();
        }
    }
}
