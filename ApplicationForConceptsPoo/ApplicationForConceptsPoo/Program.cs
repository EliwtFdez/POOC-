// See https://aka.ms/new-console-template for more information
using ApplicationForConceptsPoo;

Console.WriteLine("Hello, Mr Eliwt!");
Console.WriteLine("======================");

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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);