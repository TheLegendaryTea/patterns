using System;

class Computer
{
    public void PowerOn()
    {
        Console.WriteLine("Компьютер включен");
    }

    public void PowerOff()
    {
        Console.WriteLine("Компьютер выключен");
    }

    public void BootOS()
    {
        Console.WriteLine("ОС загружается");
    }

    public void LaunchProgram(string programName)
    {
        Console.WriteLine($"Программа {programName} запущена");
    }
}

class ComputerFacade
{
    private Computer computer;

    public ComputerFacade()
    {
        computer = new Computer();
    }

    public void TurnOn()
    {
        computer.PowerOn();
        computer.BootOS();
    }

    public void TurnOff()
    {
        computer.PowerOff();
    }

    public void StartProgram(string programName)
    {
        computer.PowerOn();
        computer.BootOS();
        computer.LaunchProgram(programName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ComputerFacade facade = new ComputerFacade();

        facade.TurnOn();

        facade.StartProgram("Notepad");

        facade.TurnOff();
    }
}
