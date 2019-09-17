using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda();
            //abb.agregar(58);
            //abb.agregar(59);
            //abb.agregar(60);
            //abb.agregar(61);
            //abb.agregar(62);
            //abb.agregar(63);
            //abb.agregar(64);
            abb.agregar(5);
            abb.agregar(4);
            abb.agregar(7);
            abb.agregar(2);
            abb.agregar(6);
            abb.agregar(8);
            Program.Opciones(abb);
        }
        static void Opciones(ArbolBinarioBusqueda abb)
        {
            Console.WriteLine("");

            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Recorrido Inorden");
            Console.WriteLine("3. Recorrido Preorden");
            Console.WriteLine("4. Recorrido Post");
            Console.WriteLine("5. Buscar en arbol");
            Console.WriteLine("6. Contar Hojas");
            Console.WriteLine("7. Contar entre niveles");
           

            
            try
            {
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese un elemento comparable");
                        int elemento = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            abb.agregar(elemento);
                            Console.WriteLine("se agrego" + " " + elemento);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    case 2:
                        abb.ImprimirInorden();
                        break;
                    case 3:
                        abb.ImprimirPreorden();
                        break;
                    case 4:
                        abb.ImprimirPostOrden();
                        break;
                    case 5:
                        Console.WriteLine("ingrese un elemento comparable Para buscarlo");
                        int elemento2 = Convert.ToInt32(Console.ReadLine());
                        if (abb.incuye(elemento2))
                            Console.WriteLine("el elemento existe");
                        else
                            Console.WriteLine("el elemento no se encontro en el arbol");
                        break;
                    case 6:
                       Console.WriteLine("El arbol tiene "+ abb.ContarHojas() + " hojas");
                        ArbolBinarioBusqueda.cant= 0;
                        break;
                    case 7:
                        abb.RecorrerPorNiveles();
                        break;
                }
            }
            catch (Exception err)
            {

                Console.WriteLine("seleccione una opcion correcta " +err.Message);
            }
            Program.Opciones(abb);
        }
    }
}
