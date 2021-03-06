﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lesson6
{
    class Account
    {
        private int balance;
        private readonly int interestRate; // integer % number
        private Thread myThread = null;
        private volatile bool _shouldStop;

        public Account(int initBalance, int interestRate)
        {
            this.balance = initBalance;
            this.interestRate = interestRate;
            //Thread th = new Thread(interestLoop);
            //th.Start();
            new Thread(() =>
            {
                myThread = Thread.CurrentThread;
                _shouldStop = false;
                while (!_shouldStop)
                {
                    applyInterest();
                    Thread.Sleep(3000); // 3 seconds
                }
                Thread.Sleep(5000);  // 5 seconds delay
            }).Start();

            //interestLoop();
        }

        internal bool threadFinished(bool sync)
        {
            timeOutput();
            if (myThread == null)
            {
                Console.WriteLine("threadFinished: no thread");
                return true;
            }
            if (sync)
            {
                Console.WriteLine("threadFinished: joining");
                myThread.Join();
                timeOutput();
                Console.WriteLine("threadFinished: true");
                return true;
            }
            bool t = !myThread.IsAlive;
            Console.WriteLine("threadFinished: {0}", t);
            return t;
        }

        internal void Close()
        {
            // NEVER ABORT A THREAD LIKE THIS: myThread.Abort(); // IT IS DANGEROUS
            timeOutput();
            Console.WriteLine("close: trying");
            _shouldStop = true;
        }

        public void Deposit(int amount)
        {
            timeOutput();
            out1("Deposit");
            balance += amount;
            out2();
        }

        public bool Withdraw(int amount)
        {
            timeOutput();
            if (amount > balance)
            {
                out1("No withdraw");
                out2();
                return false;
            }
            out1("Withdraw");
            balance -= amount;
            out2();
            return true;
        }

        private void applyInterest()
        {
            timeOutput();
            out1("applyInterest");
            balance = (balance * (100 + interestRate)) / 100;
            out2();
        }
        public void interestLoop()
        {
            while (true)
            {
                applyInterest();
                Thread.Sleep(3000); // 3000 milliseconds
            }
        }

        private void timeOutput()
        {
            Console.Write("{0}: ", DateTime.Now.ToString("HH:mm:ss"));
        }
        private void out1(string loc)
        {
            Console.Write("{0}: old balance = {1}, ", loc, balance);
        }
        private void out2()
        {
            Console.WriteLine("new balance = {0}, ", balance);
        }
    }
}
