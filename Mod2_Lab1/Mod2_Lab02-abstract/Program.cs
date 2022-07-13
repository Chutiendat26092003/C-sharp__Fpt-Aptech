using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
abstract class Employee
{
    private string employeeName;
    private double employeeBaseSalary;
    private int employeeId;

    public string Name
    {
        get
        {
            return employeeName;
        }
        set
        {
            employeeName = value;
        }
    }

    public double BaseSalary
    {
        get
        {
            return employeeBaseSalary;
        }
        set
        {
            employeeBaseSalary = value;
        }
    }

    public int ID
    {
        get
        {
            return employeeId;
        }
        set
        {
            employeeId = value;
        }
    }


    private static int employeeCount = 1;

    public Employee(string name, double baseSalary)
    {
        this.Name = name;
        this.BaseSalary = baseSalary;
        this.ID = employeeCount++;
    }

    public double getBaseSalary()
    {
        return this.BaseSalary;
    }

    public String getName()
    {
        return this.Name;
    }


    public int getEmployeeID()
    {
        return this.ID;
    }

    public String toString()
    {
        return this.ID + " " + this.Name;
    }

    public abstract String employeeStatus();
}

class TechnicalEmployee : Employee
{
    public TechnicalEmployee(String name) : base(name, 75000)
    {

    }

    public int successfullCheckIns = 5;

    public override string employeeStatus()
    {
        return this.toString() + " has " + this.successfullCheckIns + " successful check ins";
    }
}

class BusinessEmployee : Employee
{
    public BusinessEmployee(String name) : base(name, 50000)
    {

    }

    public double bonusBudget = 1000;

    public override string employeeStatus()
    {
        return this.toString() + " with a budget of " + this.bonusBudget;
    }
}

class Test
{
    static void Main(string[] args)
    {
        var employee1 = new TechnicalEmployee("Libby");
        var employee2 = new TechnicalEmployee("Zaynah");
        var employee3 = new BusinessEmployee("Winter");

        Console.WriteLine(employee1.employeeStatus() + "...\n" + employee2.employeeStatus() + "...\n" + employee3.employeeStatus());
    }
}
