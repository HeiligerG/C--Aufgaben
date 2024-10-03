using System;

namespace AlterRechner
{
    public class AgeCalculator
    {
        public void CalculateAge()
        {
            Console.Write("Bitte geben Sie Ihr Geburtsdatum ein (TT.MM.YYYY): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dob))
            {
                var age = CalculateExactAge(dob, DateTime.Today);
                Console.WriteLine($"Alter: {age.Years} Jahre, {age.Months} Monate, {age.Weeks} Wochen und {age.Days} Tage");
            }
            else
            {
                Console.WriteLine("Ungültiges Datumsformat. Bitte versuchen Sie es erneut.");
            }
        }

        private (int Years, int Months, int Weeks, int Days) CalculateExactAge(DateTime birthDate, DateTime currentDate)
        {
            int years = currentDate.Year - birthDate.Year;
            int months = currentDate.Month - birthDate.Month;
            int days = currentDate.Day - birthDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(currentDate.Year, currentDate.AddMonths(-1).Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            int totalDays = (int)(currentDate - birthDate.AddYears(years).AddMonths(months)).TotalDays;
            int weeks = totalDays / 7;
            days = totalDays % 7;

            return (years, months, weeks, days);
        }
    }
}