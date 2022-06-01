// See https://aka.ms/new-console-template for more information
using ApplicationForConceptsPoo;

//Console.WriteLine("Hello, Mr Eliwt!");
//Console.WriteLine("======================");

Employee employee1 = new SalaryEmployee()
{
    Id = 1001,
    FirstName = "sandara",
    LastName = "Morales",
    BirthDate = new Date (2002,2,18),
    HiringDate= new Date (2021,05,20),
    IsActive = true,
    Salary = 200000

};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 12315,
    FirstName = "GOdEliw",
    LastName = "Fdez",
    BirthDate = new Date(2005, 7, 22),
    HiringDate = new Date(2019, 1, 1),
    IsActive = true,
    Sales = 200000M,
    CommissionPorcentaje = 0.23F,

};
//Console.WriteLine(employee2);


Employee employee3 = new HourlyEmployee()
{
    Id = 12315,
    FirstName = "Manzon",
    LastName = "Morales",
    BirthDate = new Date(2001, 5, 22),
    HiringDate = new Date(2019, 5,18 ),
    IsActive = true,
   HourValue = 112312313.3M,
   Hours =123.5F,

};
//Console.WriteLine(employee3);


Employee employee4 = new BaseCommisionEmployee()
{

    Id = 2029020,
    FirstName = "Porfirio",
    LastName = "Dias",
    BirthDate = new Date(9009,2,16),
    HiringDate = new Date(2012, 5, 18),
    IsActive = true,
    Base = 34234.23M,
    Sales = 333333M,
    CommissionPorcentaje = 0.015F,

};

//Console.WriteLine(employee4);

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


Console.WriteLine("                               ==================");
Console.WriteLine($"Total                           {$"{payroll:C2}",15}");


Invoice invoice1 = new Invoice()
{
    Descripcion = "Macbook pro 2022",
    Id = 1,
    Price = 2000000M,
    Quantity = 12F
};
Invoice invoice2 = new Invoice()
{
    Descripcion = "Ipad Pro 5pulg",
    Id = 2,
    Price = 2300M,
    Quantity = 12F
};


Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
