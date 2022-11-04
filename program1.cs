using System;

namespace Task_After_Week1
{
    public class UserInput
    {
        public static string InputInfo()
        {
                Console.Write("How old are you? ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("if there is an additional Month, please put it down else just type 0 ? ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("if there is an additional day, please put it down else just type 0 ? ");
                int day = int.Parse(Console.ReadLine());

                return SuperBirthday.MyBirthdayDate(age, month, day);
        } 
    }
    
    public class SuperBirthday
    {
        public static string MyBirthdayDate(int getAge, int getMonth, int getDay)
        {
                MyDetails details = new MyDetails(getAge, getMonth, getDay);
                DateTime myBirthday = DateTime.Now;
                int age = myBirthday.Year - details.Age;
                int month = myBirthday.Month - details.Month;
                var day = myBirthday.Day - details.Day;
                if (month < 1)
                {
                    month = 12 + month; 
                    age = age - 1;  
                  
                }
            
                DateTime myBirthdayy = new DateTime(age, month, day);
                return ($"Your Birthday is {myBirthdayy.ToLongDateString()}") ;        
        }
    }
    
    public class MyDetails
    {
        public int Age{get; set;}
        public int Month{get; set;}
        public int Day{get; set;}

        public MyDetails( int age, int month, int day)
        {
            Age = age;
            Month = month;
            Day = day;
        }
    }
}