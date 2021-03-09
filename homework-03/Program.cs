using System;

namespace homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("========please input money=======");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ($"===========Money - {money}=========");
            Calc(money);
        }

        static void Calc (int money)
        { 
            double moneyToTime = money / 1000;
            Console.WriteLine($"======you have {moneyToTime} min ==========");
            double minute = (moneyToTime % 60) * 60;
            double hours = (moneyToTime / 60) - (moneyToTime % 60);
            TimeSpan time = new TimeSpan(00, 01, 00);
            DateTime workTime = new DateTime();
            workTime = DateTime.Now;
            workTime.AddMinutes(minute);
            workTime.AddHours(hours);
            TimeSpan diff = workTime.Subtract(DateTime.Now);
            if (diff == time)
            {
                Console.WriteLine("=====one minute left======");
            }
            if (DateTime.Now == workTime)
            {
                Console.WriteLine("=======your time is end========");
            }
        }

    }
}
