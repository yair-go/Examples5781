using System;
using System.Threading;

namespace Lesson6
{
    class Program
    {
        static private Random rand = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            Account myAccount = new Account(1000, 2);

            while (!myAccount.threadFinished(false))
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.KeyChar)
                {
                    case '1':
                        myAccount.Deposit(rand.Next(100));
                        break;
                    case '2':
                        myAccount.Withdraw(rand.Next(200));
                        break;
                    case '0':
                        myAccount.Close();
                        myAccount.threadFinished(true);
                        //Thread.Sleep(200);
                        break;
                }
            }

        }
    }
}
