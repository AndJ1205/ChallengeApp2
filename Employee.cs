namespace ChallengeApp
{
    public class Employee
    {
        // Pola przechowujące informacje o pracowniku
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private int[] Ratings { get; set; }

        // Konstruktor klasy Employee
        public Employee(string firstName, string lastName, int age, int[] ratings)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Ratings = ratings;
        }

        // Metoda do obliczania sumy ocen pracownika
        public int CalculateTotalRatings()
        {
            return Ratings.Sum();
        }

        // Metoda do wyświetlania informacji o pracowniku
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Informacje o pracowniku:");
            Console.WriteLine($"Imię: {FirstName}");
            Console.WriteLine($"Nazwisko: {LastName}");
            Console.WriteLine($"Wiek: {Age}");
            Console.WriteLine($"Oceny pracownika: {string.Join(", ", Ratings)}");
        }
    }

}
