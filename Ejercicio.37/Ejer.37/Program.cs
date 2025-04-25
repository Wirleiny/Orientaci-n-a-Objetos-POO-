namespace Ejer._37
{
    internal class Program
    {
           class Articulo
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public string Categoria { get; set; }
        }
        
            static void Main(string[] args)
            {
                
                Articulo articulo1 = new Articulo();
                Articulo articulo2 = new Articulo();

                
                Console.WriteLine("Ingrese el nombre del artículo 1:");
                articulo1.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del artículo 1:");
                articulo1.Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la categoría del artículo 1:");
                articulo1.Categoria = Console.ReadLine();

                Console.WriteLine("\nIngrese el nombre del artículo 2:");
                articulo2.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el precio del artículo 2:");
                articulo2.Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la categoría del artículo 2:");
                articulo2.Categoria = Console.ReadLine();

              
                Console.WriteLine("\nDatos de los artículos:");
                Console.WriteLine($"Artículo 1: {articulo1.Nombre}, Precio: {articulo1.Precio}, Categoría: {articulo1.Categoria}");
                Console.WriteLine($"Artículo 2: {articulo2.Nombre}, Precio: {articulo2.Precio}, Categoría: {articulo2.Categoria}");

                Console.ReadLine();
            }
        }
    }
