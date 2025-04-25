namespace Ejer._35
{
    internal class Program
    {
            class Class1
        {
            public string Tipo { get; set; }
            public string Marca { get; set; }
            public string Color { get; set; }

            public void Encender()
            {
                Console.WriteLine("El dispositivo está encendido.");
            }

            public void Apagar()
            {
                Console.WriteLine("El dispositivo está apagado.");
            }
        }

        static void Main(string[] args)
        {
            
            Class1 dispositivo = new Class1();

            
            Console.Write("Ingrese el tipo del dispositivo: ");
            dispositivo.Tipo = Console.ReadLine();

            Console.Write("Ingrese la marca del dispositivo: ");
            dispositivo.Marca = Console.ReadLine();

            Console.Write("Ingrese el color del dispositivo: ");
            dispositivo.Color = Console.ReadLine();

           
            Console.WriteLine($"El dispositivo es un {dispositivo.Tipo}, marca {dispositivo.Marca}, color {dispositivo.Color}.");

           
            dispositivo.Encender();
            dispositivo.Apagar();

            Console.ReadLine();

        }
    }
}
        
    

