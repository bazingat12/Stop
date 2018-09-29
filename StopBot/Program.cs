using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StopBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string Stop;
            Stop = Console.ReadLine();
            if (Stop == "Театральная площадь")
            {
                int dtHour, dtMinute;
                dtHour = DateTime.Now.Hour;
                dtMinute = DateTime.Now.Minute;
                TheatreSquare(dtHour, dtMinute);
            }     
            Console.Read();
        }

        //Метод Театральной площади: авт46,
        private static void TheatreSquare(int dtHour, int dtMinute)
        {
            string strdt;
            decimal Minute = 0.60M;
            decimal j = 0;
            if (dtMinute == 1 || dtMinute == 2|| dtMinute == 3 || dtMinute == 4 || dtMinute == 5 || dtMinute == 6 || dtMinute == 7 || dtMinute == 8 || dtMinute == 9)
            {
                strdt = Convert.ToString(dtHour) + ",0" + Convert.ToString(dtMinute);
            }
            else
                strdt = Convert.ToString(dtHour) + "," + Convert.ToString(dtMinute);
            decimal dt = Convert.ToDecimal(strdt);
            //Авт. 46
            decimal[] bus46 = new decimal[85] { 06.17M, 06.32M, 06.47M, 06.54M, 07.09M, 07.17M, 07.24M, 07.32M, 07.39M, 07.47M, 07.52M, 08.09M, 08.17M, 08.24M, 08.32M, 08.39M, 08.47M, 08.54M, 09.02M, 09.09M, 09.17M, 09.24M, 09.39M, 09.47M, 09.54M, 10.02M, 10.09M, 10.17M, 10.24M, 10.39M, 10.54M, 11.09M, 11.24M, 11.39M, 11.54M, 12.09M, 12.24M, 12.39M, 12.54M, 13.09M, 13.17M, 13.32M, 13.47M, 14.02M, 14.17M, 14.47M, 15.02M, 15.17M, 15.47M, 15.54M, 16.02M, 16.09M, 16.17M, 16.24M, 16.32M, 16.39M, 16.47M, 16.54M, 17.09M, 17.17M, 17.24M, 17.32M, 17.39M, 17.47M, 17.54M, 18.09M, 18.17M, 18.24M, 18.32M, 18.39M, 18.47M, 18.54M, 19.02M, 19.09M, 19.17M, 19.24M, 19.39M, 19.47M, 19.54M, 20.09M, 20.24M, 20.39M, 21.09M, 21.39M, 22.09M };
            for (int i = 84; i<=bus46.Length; i--)
            {
                if (dt<bus46[i])
                {
                    Minute = bus46[i]-dt;
                    j = bus46[i];
                    
                }
                if (i == 0)
                {
                    string NameBus = "Авт. 46 ";
                    Output(dt, strdt, j, NameBus);
                    break;
                }
            }

            //Авт. 23
            decimal[] bus23 = new decimal[149] { 05.49M, 06.17M, 06.27M, 06.32M, 06.37M, 06.42M, 06.47M, 06.52M, 06.57M, 07.02M, 07.07M, 07.12M, 07.17M, 07.22M, 07.27M, 07.32M, 07.37M, 07.42M, 07.48M, 07.53M, 07.58M, 08.03M, 08.08M, 08.13M, 08.19M, 08.24M, 08.29M, 08.34M, 08.39M, 08.44M, 08.49M, 08.54M, 08.59M, 09.04M, 09.09M, 09.14M, 09.19M, 09.24M, 09.29M, 09.34M, 09.39M, 09.44M, 09.50M, 09.55M, 10.00M, 10.05M, 10.10M, 10.15M, 10.21M, 10.26M, 10.31M, 10.36M, 10.41M, 10.46M, 10.56M, 11.06M, 11.16M, 11.26M, 11.31M, 11.41M, 11.46M, 11.56M, 12.06M, 12.16M, 12.26M, 12.36M, 12.44M, 12.52M, 12.57M, 13.02M, 13.07M, 13.12M, 13.18M, 13.23M, 13.28M, 13.33M, 13.38M, 13.43M, 13.48M, 13.53M, 13.58M, 14.03M, 14.08M, 14.13M, 14.18M, 14.23M, 14.28M, 14.38M, 14.49M, 14.59M, 15.09M, 15.20M, 15.25M, 15.32M, 15.38M, 15.46M, 15.56M, 16.06M, 16.17M, 16.22M, 16.32M, 16.37M, 16.42M, 16.47M, 16.52M, 16.57M, 17.02M, 17.07M, 17.12M, 17.17M, 17.22M, 17.27M, 17.32M, 17.37M, 17.43M, 17.48M, 17.53M, 17.58M, 18.03M, 18.08M, 18.14M, 18.19M, 18.24M, 18.29M, 18.34M, 18.39M, 18.44M, 18.49M, 18.54M, 18.59M, 19.04M, 19.09M, 19.14M, 19.19M, 19.24M, 19.34M, 19.45M, 19.55M, 20.05M, 20.16M, 20.26M, 20.36M, 20.46M, 20.56M, 21.16M, 21.26M, 21.47M, 22.18M, 22.43M };
            for (int i = 148; i <= bus23.Length; i--)
            {
                if (dt < bus23[i])
                {
                    Minute = bus23[i] - dt;
                    j = bus23[i];

                }
                if (i == 0)
                {
                    string NameBus = "Авт. 23 ";
                    Output(dt, strdt, j, NameBus);
                    break;
                }
            }                
        }

        //Метод вывода времени прибытия автобуса
        private static void Output(decimal dt, string strdt, decimal j, string NameBus)
        {
            //Время сейчас
            int WholeNow = Convert.ToInt32(Math.Truncate(dt));
            decimal decimalNow = (dt - WholeNow);
            strdt = Convert.ToString(decimalNow);
            char[] delete = { ',' };
            foreach (char c in delete)
            {
                strdt = strdt.Replace(c.ToString(), "");
            }
            strdt = strdt.Remove(0, 1);
            int DecimalNow = Convert.ToInt32(strdt);
            DateTime dtNow = new DateTime(0001, 01, 01, new GregorianCalendar());
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            dtNow = myCal.AddHours(dtNow, WholeNow);
            dtNow = myCal.AddMinutes(dtNow, DecimalNow);

            //Время прибытия
            int WholeThen = Convert.ToInt32(Math.Truncate(j));
            decimal decimalThen = (j - WholeThen);
            strdt = Convert.ToString(decimalThen);
            foreach (char c in delete)
            {
                strdt = strdt.Replace(c.ToString(), "");
            }
            strdt = strdt.Remove(0, 1);
            int DecimalThen = Convert.ToInt32(strdt);
            DateTime dtThen = new DateTime(0001, 01, 01, new GregorianCalendar());
            Calendar myCalThen = CultureInfo.InvariantCulture.Calendar;
            dtThen = myCalThen.AddHours(dtThen, WholeThen);
            dtThen = myCalThen.AddMinutes(dtThen, DecimalThen);

            Console.WriteLine(NameBus + dtThen.Subtract(dtNow) + " до прибытия.");
        }
    }
}
