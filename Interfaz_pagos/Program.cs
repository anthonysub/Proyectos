using System;

namespace Ejemplo2Interfaz
{

    //interfaz Sistema de pagos
    interface ISistemaPagos
    {
        void ProcesarPago(string monto);
        void CancelarPago(string idPago);
    }

    // Implementación de la interfaz ISistemaPagos
    class PagoTarjeta : ISistemaPagos
    {
        public void ProcesarPago(string monto)
        {
            Console.WriteLine("Procesando pago con tarjeta: " + monto);
        }

        public void CancelarPago(string idPago)
        {
            Console.WriteLine("Cancelando pago con tarjeta, ID: " + idPago);
        }
    }

    class BilleteraDigital : ISistemaPagos
    {
        public void ProcesarPago(string monto)
        {
            Console.WriteLine("Procesando pago con billetera digital: " + monto);
        }

        public void CancelarPago(string idPago)
        {
            Console.WriteLine("Cancelando pago con billetera digital, ID: " + idPago);
        }
    }

    class TransferenciaBancaria : ISistemaPagos
    {
        public void ProcesarPago(string monto)
        {
            Console.WriteLine("Procesando transferencia bancaria: " + monto);
        }

        public void CancelarPago(string idPago)
        {
            Console.WriteLine("Cancelando transferencia bancaria, ID: " + idPago);
        }
    }

    // Clase principal para probar las interfaces y sus implementaciones
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            try
            {
                while (!salir)
                {
                    Console.Clear();
                    Console.WriteLine("--- Interfaz de pago ---");
                    Console.WriteLine("1. Pago con tarjeta");
                    Console.WriteLine("2. Billeteras digitales");
                    Console.WriteLine("3. Transferencias bancarias");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opción: ");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            PagoTarjetaMenu();
                            break;
                        case "2":
                            BilleteraDigitalMenu();
                            break;
                        case "3":
                            TransferenciaBancariaMenu();
                            break;
                        case "4":
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void PagoTarjetaMenu()
        {
            Console.Clear(); // Limpia la consola al entrar al menú
            ISistemaPagos pagoTarjeta = new PagoTarjeta();
            Console.WriteLine("Pago con tarjeta seleccionado.");
            Console.WriteLine("1. Procesar pago");
            Console.WriteLine("2. Cancelar pago");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.Clear();
                Console.Write("Ingrese el monto a pagar: ");
                string monto = Console.ReadLine();
                pagoTarjeta.ProcesarPago(monto);
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el ID del pago a cancelar: ");
                string idPago = Console.ReadLine();
                pagoTarjeta.CancelarPago(idPago);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void BilleteraDigitalMenu()
        {
            ISistemaPagos billetera = new BilleteraDigital();
            Console.WriteLine("Billetera digital seleccionada.");
            Console.WriteLine("1. Procesar pago");
            Console.WriteLine("2. Cancelar pago");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.Write("Ingrese el monto a pagar: ");
                string monto = Console.ReadLine();
                billetera.ProcesarPago(monto);
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el ID del pago a cancelar: ");
                string idPago = Console.ReadLine();
                billetera.CancelarPago(idPago);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void TransferenciaBancariaMenu()
        {
            ISistemaPagos transferencia = new TransferenciaBancaria();
            Console.WriteLine("Transferencia bancaria seleccionada.");
            Console.WriteLine("1. Procesar pago");
            Console.WriteLine("2. Cancelar pago");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.Write("Ingrese el monto a pagar: ");
                string monto = Console.ReadLine();
                transferencia.ProcesarPago(monto);
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el ID del pago a cancelar: ");
                string idPago = Console.ReadLine();
                transferencia.CancelarPago(idPago);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}