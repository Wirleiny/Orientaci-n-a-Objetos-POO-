namespace ejer._38
{
    internal class Program
    {
        class Estudiante
        {
            public string Matricula { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Carrera { get; set; }
        }
        

            static void Main(string[] args)
            {
               
                Estudiante[] estudiantes = new Estudiante[5];

               
                for (int i = 0; i < 5; i++)
                {
                    estudiantes[i] = new Estudiante();
                    Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

                    Console.Write("Matrícula: ");
                    estudiantes[i].Matricula = Console.ReadLine();

                    Console.Write("Nombre: ");
                    estudiantes[i].Nombre = Console.ReadLine();

                    Console.Write("Edad: ");
                    estudiantes[i].Edad = int.Parse(Console.ReadLine());

                    Console.Write("Carrera: ");
                    estudiantes[i].Carrera = Console.ReadLine();

                    Console.WriteLine();
                }

                
                Console.WriteLine("Datos de los estudiantes:");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Estudiante {i + 1}: Matrícula: {estudiantes[i].Matricula}, Nombre: {estudiantes[i].Nombre}, Edad: {estudiantes[i].Edad}, Carrera: {estudiantes[i].Carrera}");
                }

                Console.ReadLine();
            }
        }
    }

         
 
        