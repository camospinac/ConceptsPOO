
using ConceptsPOO;

Console.WriteLine("Nómina Basica");
Console.WriteLine("=============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Mauricio",
    LastName = "Rodriguez",
    BirthDay = new Date(1987, 6, 26),
    HiringDate = new Date(2015, 3, 5),
    IsActive = true,
    Salary = 3574499M
};

Employee employee2 = new ComissionEmployee()
{
    Id = 2020,
    FirstName = "Camilo",
    LastName = "Acevedo",
    BirthDay = new Date(1998, 5, 24),
    HiringDate = new Date(2019, 2, 3),
    IsActive = true,
    ComissionPercent = 0.03F,
    Sales = 380000000M
};

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Ximena",
    LastName = "Alvarez",
    BirthDay = new Date(1993, 9, 23),
    HiringDate = new Date(2021, 1, 28),
    IsActive = true,
    Hours = 18.5F,
    HourValue = 5500M
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Sandra",
    LastName = "Martinez",
    BirthDay = new Date(1996, 4, 13),
    HiringDate = new Date(2022, 3, 14),
    IsActive = true,
    Base = 850000M,
    Sales = 48000000,
    ComissionPercent = 0.01F
};

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("\n============= Total Nomina of total employees =============");
Console.WriteLine($"Total: {payroll:C2}");


Invoice invoice1 = new Invoice()
{
    Id = 0001,
    Description = "BMW SUV M300 4V 1890 HP",
    Price = 458899990M,
    Quantity = 4F
};
Invoice invoice2 = new Invoice()
{
    Id = 0002,
    Description = "CHAINS FOR MOTOSPORT TOYOTA SUV 120 PINS",
    Price = 78950M,
    Quantity = 15
};

Console.WriteLine("\n============= Simple Invoice =============");
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);