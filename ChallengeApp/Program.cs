using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowal", 25, new int[] { 8, 9, 7, 8, 1 });
Employee employee2 = new Employee("Anna", "Mucha", 32, new int[] { 6, 6, 9, 8, 7 });
Employee employee3 = new Employee("Damian", "Dąb", 28, new int[] { 9, 9, 8, 7, 8 });

// Tablica pracowników
Employee[] employees = { employee1, employee2, employee3 };

// Znajdowanie pracownika z najwyższą sumą ocen
Employee employeeWithHighestRatings = employees.OrderByDescending(e => e.CalculateTotalRatings()).First();

// Wyświetlanie informacji o pracowniku z najwyższą sumą ocen
Console.WriteLine("Pracownik z najwyższą sumą ocen:");
employeeWithHighestRatings.DisplayEmployeeInfo();
int totalRatings = employeeWithHighestRatings.CalculateTotalRatings();
Console.WriteLine($"Suma ocen: {totalRatings}");
