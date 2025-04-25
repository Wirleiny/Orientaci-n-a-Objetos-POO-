namespace Ejer._40
{
        internal class Program
        {
            public abstract class Transporte
            {
                public string Destino { get; set; }
                public double Distancia { get; set; }
                public double Tiempo { get; set; }

                public Transporte(string destino, double distancia, double tiempo)
                {
                    Destino = destino;
                    Distancia = distancia;
                    Tiempo = tiempo;
                }

                public abstract double CalcularCosto();

                public void MostrarBoleto()
                {
                    Console.WriteLine($"Boleto de Transporte:");
                    Console.WriteLine($"Destino: {Destino}");
                    Console.WriteLine($"Distancia: {Distancia} km");
                    Console.WriteLine($"Tiempo de viaje: {Tiempo} horas");
                    Console.WriteLine($"Costo del boleto: {CalcularCosto()}");
                }
            }

            public class BusInterurbano : Transporte
            {
                public BusInterurbano(string destino, double distancia, double tiempo) : base(destino, distancia, tiempo) { }

                public override double CalcularCosto()
                {
                    return Distancia * 1.2;
                }
            }

            public class BusUrbano : Transporte
            {
                public BusUrbano(string destino, double distancia, double tiempo) : base(destino, distancia, tiempo) { }

                public override double CalcularCosto()
                {
                    return Distancia * 0.5;
                }
            }

            public class Taxi : Transporte
            {
                public double TarifaBase { get; set; }

                public Taxi(string destino, double distancia, double tiempo, double tarifaBase) : base(destino, distancia, tiempo)
                {
                    TarifaBase = tarifaBase;
                }

                public override double CalcularCosto()
                {
                    return TarifaBase + (Distancia * 2);
                }
            }

            public class Metro : Transporte
            {
                public Metro(string destino, double distancia, double tiempo) : base(destino, distancia, tiempo) { }

                public override double CalcularCosto()
                {
                    return 2.0;
                }
            }

            public class Teleferico : Transporte
            {
                public Teleferico(string destino, double distancia, double tiempo) : base(destino, distancia, tiempo) { }

                public override double CalcularCosto()
                {
                    return 3.0;
                }
            }

            static void Main()
            {
                Console.WriteLine("Elija el tipo de transporte: ");
                Console.WriteLine("1. Bus Interurbano");
                Console.WriteLine("2. Bus Urbano");
                Console.WriteLine("3. Taxi");
                Console.WriteLine("4. Metro");
                Console.WriteLine("5. Teleférico");
                int opcion = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el destino: ");
                string destino = Console.ReadLine();
                Console.Write("Ingrese la distancia: ");
                double distancia = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el tiempo de viaje: ");
                double tiempo = double.Parse(Console.ReadLine());

                Transporte transporte = null;

                switch (opcion)
                {
                    case 1:
                        transporte = new BusInterurbano(destino, distancia, tiempo);
                        break;
                    case 2:
                        transporte = new BusUrbano(destino, distancia, tiempo);
                        break;
                    case 3:
                        Console.Write("Ingrese la tarifa base del taxi: ");
                        double tarifaBase = double.Parse(Console.ReadLine());
                        transporte = new Taxi(destino, distancia, tiempo, tarifaBase);
                        break;
                    case 4:
                        transporte = new Metro(destino, distancia, tiempo);
                        break;
                    case 5:
                        transporte = new Teleferico(destino, distancia, tiempo);
                        break;
                    default:
                        Console.WriteLine("Error. inténtelo de nuevo."); 
                        return;
                }

                transporte.MostrarBoleto();
            }
        }
    }
