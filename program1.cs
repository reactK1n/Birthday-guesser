using System;

namespace Task_After_Week1
{
    public class SuperBirthday
    {
        public static  string myBirthdayTeller()
        {
            return myBirthdayDate();
        }

        private static string myBirthdayDate()
        {

                Console.Write("How old are you? ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("if there is an additional Month, please put it down else just type 0 ? ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("if there is an additional day, please put it down else just type 0 ? ");
                int date = int.Parse(Console.ReadLine());

                myDetails Details = new myDetails(age, month, date);
                DateTime myBirthday = DateTime.Now;
                int _age = myBirthday.Year - Details.Age;
                int _month = myBirthday.Month - Details.Month;
                var _day = myBirthday.Day - Details.Date;
                if (_month < 1)
                {
                    _month = 12 + _month; 
                    _age = _age - 1;  
                  
                }
            
                DateTime myBirthdayy = new DateTime(_age, _month, _day);
                return ($"Your Birthday is {myBirthdayy.ToLongDateString()}") ;        
        }
    }
    
    public class myDetails
    {
        public int Age{get; set;}
        public int Month{get; set;}
        public int Date{get; set;}

        public myDetails( int age, int month, int date)
        {
            Age = age;
            Month = month;
            Date = date;
        }
    }
}