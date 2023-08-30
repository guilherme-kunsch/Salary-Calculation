using System;

class Calculate
{
    public static void Main(string[] args)
    {
        Console.Write("Quantas horas semanais: ");
        int hours = int.Parse(Console.ReadLine()!);

        Console.Write("Digite sua matricula: ");
        int mat = int.Parse(Console.ReadLine()!);
        

        Console.Write("Cargos abaixo:\n[E] Especialista\n[M] Mestre\n[D] Doutor\n");
        Console.Write("Digite sua opção: ");
        string chosenOption = Console.ReadLine()!;
        string uppercaseChosenOption = chosenOption.ToUpper();

        int percentage = 15;

        int valueHours = 0;
        switch (uppercaseChosenOption)
        {
            case "E": valueHours = 15; break;
            case "M": valueHours = 20; break;
            case "D": valueHours = 30; break;
            default:
                Console.WriteLine("Opção inválida!"); break;

        }

        int weekHoursOld = hours * valueHours * 4;
        int weekHours = weekHoursOld + ((weekHoursOld * percentage) / 100);

        double weekHoursNew = 0;
        double inss = 0;
        if (weekHours >= 151 && weekHours < 256) 
        {
            inss = weekHours * 0.8;
            weekHoursNew = weekHours - inss;
        } else if (weekHours >= 256.01 && weekHours < 510)
        {
            inss = weekHours * 0.9;
            weekHoursNew = weekHours - inss;
        } else if (weekHours >= 510.01 && weekHours < 1200)
        {
            inss = weekHours * 0.10;
            weekHoursNew = weekHours - inss;
        } else
        {
            inss = weekHours * 0.11;
            weekHoursNew = weekHours - inss;
        }

        double incomeTax = 0;
        double wageNew = 0;

        if (weekHoursNew < 800)
        {
            incomeTax = 0;
        } else if (weekHoursNew > 801.01 && weekHoursNew < 1200)
        {
            incomeTax = weekHoursNew * 0.10;
            wageNew = weekHoursNew - incomeTax;

        } else if (weekHoursNew > 1200.01 && weekHoursNew < 2400)
        {
            incomeTax = weekHoursNew * 0.15;
            wageNew = weekHoursNew - incomeTax;
        }else if (weekHoursNew > 2400.01 && weekHoursNew < 3200)
        {
            incomeTax = weekHoursNew * 0.20;
            wageNew = weekHoursNew - incomeTax;
        }
        else if (weekHoursNew > 3200.01 && weekHoursNew < 5750)
        {
            incomeTax = weekHoursNew * 0.25;
            wageNew = weekHoursNew - incomeTax;
        } else
        {
            incomeTax = weekHoursNew * 0.27;
            wageNew = weekHoursNew - incomeTax;
        }


        Console.WriteLine($@"
            Matricula: {mat},
            Horas Semanais: {hours},
            Salario Bruto: {weekHours},
            Desconto INSS: {inss},
            Desconto IR: {incomeTax}
            Salario Liquido: {wageNew}
        ");
    }


}
