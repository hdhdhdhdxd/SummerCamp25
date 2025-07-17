using System.Security.Cryptography.X509Certificates;

internal class Program
{


    public static void Main()
    {
        string nombreDia = "";

        Console.WriteLine("Introduce el día de la semana");
        var diaSemana = Console.ReadLine();

        while (diaSemana != "0")
        {
            switch (diaSemana)
            {
                default:
                    nombreDia = "Valor no válido";
                    Console.WriteLine(nombreDia);
                    break;
                case "1":
                    nombreDia = "Lunes";
                    Console.WriteLine(nombreDia);
                    break;
                case "2":
                    nombreDia = "Martes";
                    Console.WriteLine(nombreDia);
                    break;
                case "3":
                    nombreDia = "Miercoles";
                    Console.WriteLine(nombreDia);
                    break;
                case "4":
                    nombreDia = "Jueves";
                    Console.WriteLine(nombreDia);
                    break;
                case "5":
                    nombreDia = "Viernes";
                    Console.WriteLine(nombreDia);
                    break;
                case "6":
                    nombreDia = "Sabado";
                    Console.WriteLine(nombreDia);
                    break;
                case "7":
                    nombreDia = "Domingo";
                    Console.WriteLine(nombreDia);
                    break;
            }
            Console.WriteLine("Introduce el día de la semana");
            diaSemana = Console.ReadLine();
            if (diaSemana == "0")
            {
                nombreDia = "Saliendo, ¡Hasta luego!";
                Console.WriteLine(nombreDia);
            }
        }



        /*Console.WriteLine("Hola mundo!");
        Console.WriteLine("===========");

        Console.WriteLine(@"   /\                 /\");
        Console.WriteLine(@"  / \'._   (\_/)   _.'/ \");
        Console.WriteLine(@" /_.''._'--('.')--'_.''._\");
        Console.WriteLine(@" | \_ / `;=/   \=;` \ _ / | ");
        Console.WriteLine(@"  \/ `\__|`\___/`|__/`  \/");
        Console.WriteLine(@"   `      \(/|\)/       `");
        Console.WriteLine(@"           "" ` """);
        */
    }
}
