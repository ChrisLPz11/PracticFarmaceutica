using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmaceutica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Instancias de las pastillas para la gripe
            Acetaminofen acetaminofen = new Acetaminofen();
            Ibuprofeno ibuprofeno = new Ibuprofeno();
            Naxen naxen = new Naxen();
            DolexGripa dolexGripa = new DolexGripa();
            GelocatilGripa gelocatil= new GelocatilGripa();
            Mucosolvan mucosolvan = new Mucosolvan();
            Nastizol nastizol = new Nastizol();
            Tabcin tabcin = new Tabcin();
            //inyecciones para la gripe 
            TIV tIV = new TIV();
            QIV qIV = new QIV();
            IIV iIV= new IIV();
            LAIV lAIV = new LAIV();
            //pomadas para la gripe
            VicksVapoRub vicksVapo = new VicksVapoRub();
            PomadaMentolEucalipto mentolEucalipto = new PomadaMentolEucalipto();


            int Option;

           
            
            do
            {
                Console.Clear();
                Console.WriteLine("_______________Bienvenido/a a la farmaceutica_______________");
                Console.WriteLine("\n1.Comprar medicamentos");
                Console.WriteLine("\n2.Lista de laboratorios");
                Console.WriteLine("\n3.Salir");
                


                Console.Write("\nIngrese un número entero: ");
                string entrada = Console.ReadLine();

                while (!int.TryParse(entrada, out Option))
                {
                    Console.WriteLine("Error: Debe ingresar un número entero.");
                    Console.WriteLine("\nIngrese un numero entero:");
                    entrada = Console.ReadLine();
                }

                switch (Option)
                    {
                        case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Ha seleccionado la opcion 1\n ");
                            Console.WriteLine("__________LISTA DE ENFERMEDADES__________\n");
                            Console.WriteLine("-Seleccione la enfermedad para la que requiere medicamento\n");
                            List<string> listaEnfermedades = new List<string>() { "1-Gripe", "2-Anemia", "3-Diabetes", "4-Artritis", "5-Hipertensión arterial", "6-Neumonía",   "7-Salir" };
                            foreach (string mostrar in listaEnfermedades)
                            {
                                Console.WriteLine($"{mostrar}");
                            }
                            Console.WriteLine("\nIngrese el numero de la opcion (1-7)");
                            
                          
                            string entrada1 = Console.ReadLine();

                            while (!int.TryParse(entrada1, out Option))
                            {
                                Console.WriteLine("Error: Debe ingresar un número entero.");
                                Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                entrada = Console.ReadLine();
                            }
                            switch (Option)
                            {
                                case 1:
                                    do
                                    {
                                        Console.WriteLine("__________ MEDICAMENTOS PARA LA GRIPE__________\n");
                                        Console.WriteLine("1.Pastillas" + "\n2.Inyecciones" + "\n3.Pomadas" + "\n4.Salir");
                                        Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                       
                                        string entrada2 = Console.ReadLine();

                                        while (!int.TryParse(entrada2, out Option))
                                        {
                                            Console.WriteLine("Error: Debe ingresar un número entero.");
                                            Console.WriteLine("\nIngrese el numero de la opcion (1-4)");
                                            entrada = Console.ReadLine();
                                        }
                                        switch (Option)
                                        {
                                            case 1:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pastillas para la gripe__________\n");
                                                    List<string> listaPastillasGripe = new List<string>() { "1.Acetaminofén ", "\n2.Ibuprofeno", "\n3.Naxen ", "\n4.Dolex Gripa ", "\n5.Gelocatil gripa ", "\n6.Mucosolvan ", "\n7.Nastizol ", "\n8.Tabcin ", "\n9.Salir" };
                                                    foreach (string gripeP in listaPastillasGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                                    string entrada3 = Console.ReadLine();

                                                    while (!int.TryParse(entrada3, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-9)");
                                                        entrada = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");
                                                            
                                                            Console.WriteLine($" Nombre: {acetaminofen.Nombre()} \n Laboratorio:  \n Componentes: {acetaminofen.Componentes()} \n Cantigad mg: {acetaminofen.CantidadMG()}\n Precio: $ {acetaminofen.Precio()}\n Descuento: {acetaminofen.Descuento()}\n Clasificación: {acetaminofen.Clasificacion()}\n");
                                                            acetaminofen.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {ibuprofeno.Nombre()} \n Laboratorio:  \n Componentes: {ibuprofeno.Componentes()} \n Cantigad mg: {ibuprofeno.CantidadMG()}\n Precio: $ {ibuprofeno.Precio()}\n Descuento: {ibuprofeno.Descuento()}\n Clasificación: {ibuprofeno.Clasificacion()}\n");
                                                            ibuprofeno.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {naxen.Nombre()} \n Laboratorio:  \n Componentes: {naxen.Componentes()} \n Cantigad mg: {naxen.CantidadMG()}\n Precio: $ {naxen.Precio()}\n Descuento: {naxen.Descuento()}\n Clasificación: {naxen.Clasificacion()}\n");
                                                            naxen.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {dolexGripa.Nombre()} \n Laboratorio:  \n Componentes: {dolexGripa.Componentes()} \n Cantigad mg: {dolexGripa.CantidadMG()}\n Precio: $ {dolexGripa.Precio()}\n Descuento: {dolexGripa.Descuento()}\n Clasificación: {dolexGripa.Clasificacion()}\n");
                                                            dolexGripa.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 5:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {gelocatil.Nombre()} \n Laboratorio:  \n Componentes: {gelocatil.Componentes()} \n Cantigad mg: {gelocatil.CantidadMG()}\n Precio: $ {gelocatil.Precio()}\n Descuento: {gelocatil.Descuento()}\n Clasificación: {gelocatil.Clasificacion()}\n");
                                                            gelocatil.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 6:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {mucosolvan.Nombre()} \n Laboratorio:  \n Componentes: {mucosolvan.Componentes()} \n Cantigad mg: {mucosolvan.CantidadMG()}\n Precio: $ {mucosolvan.Precio()}\n Descuento: {mucosolvan.Descuento()}\n Clasificación: {mucosolvan.Clasificacion()}\n");
                                                            mucosolvan.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 7:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {nastizol.Nombre()} \n Laboratorio:  \n Componentes: {nastizol.Componentes()} \n Cantigad mg: {nastizol.CantidadMG()}\n Precio: $ {nastizol.Precio()}\n Descuento: {nastizol.Descuento()}\n Clasificación: {nastizol.Clasificacion()}\n");
                                                            nastizol.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 8:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {tabcin.Nombre()} \n Laboratorio:  \n Componentes: {tabcin.Componentes()} \n Cantigad mg: {tabcin.CantidadMG()}\n Precio: $ {tabcin.Precio()}\n Descuento: {tabcin.Descuento()}\n Clasificación: {tabcin.Clasificacion()}\n");
                                                            tabcin.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 9:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 9);
                                                break;
                                            case 2:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de inyecciones para la gripe__________\n");
                                                    List<string> listaInyeccionesGripe = new List<string>() { "1.Vacuna contra la gripe trivalente (TIV) ", "\n2.Vacuna contra la gripe cuadrivalente (QIV) ", "\n3.Vacuna contra la gripe de virus fraccionados inactivados (IIV) ", "\n4.Vacuna de virus vivos atenuados (LAIV) ",  "\n5.Salir" };
                                                    foreach (string gripeP in listaInyeccionesGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                                    string entrada3 = Console.ReadLine();

                                                    while (!int.TryParse(entrada3, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-5)");
                                                        entrada = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {tIV.Nombre()} \n Laboratorio:  \n Componentes: {tIV.Componentes()} \n Cantigad mg: {tIV.CantidadML()}\n Precio: $ {tIV.Precio()}\n Descuento: {tIV.Descuento()}\n Clasificación: {tIV.Clasificacion()}\n");
                                                            tIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {qIV.Nombre()} \n Laboratorio:  \n Componentes: {qIV.Componentes()} \n Cantigad mg: {qIV.CantidadML()}\n Precio: $ {qIV.Precio()}\n Descuento: {qIV.Descuento()}\n Clasificación: {qIV.Clasificacion()}\n");
                                                            qIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 3:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {iIV.Nombre()} \n Laboratorio:  \n Componentes: {iIV.Componentes()} \n Cantigad mg: {iIV.CantidadML()}\n Precio: $ {iIV.Precio()}\n Descuento: {iIV.Descuento()}\n Clasificación: {iIV.Clasificacion()}\n");
                                                            iIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 4:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {lAIV.Nombre()} \n Laboratorio:  \n Componentes: {lAIV.Componentes()} \n Cantigad mg: {lAIV.CantidadML()}\n Precio: $ {lAIV.Precio()}\n Descuento: {lAIV.Descuento()}\n Clasificación: {lAIV.Clasificacion()}\n");
                                                            lAIV.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                       
                                                 
                                                        case 5:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 5);
                                                break;
                                            case 3:
                                                do
                                                {
                                                    Console.WriteLine("__________Catalogo de pomadas para la gripe__________\n");
                                                    List<string> listaInyeccionesGripe = new List<string>() { "1.Vicks VapoRub ", "\n2.Pomada de mentol y eucalipto ", "\n3.Salir" };
                                                    foreach (string gripeP in listaInyeccionesGripe)
                                                    {
                                                        Console.WriteLine($"{gripeP}");
                                                    }
                                                    Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                                    string entrada3 = Console.ReadLine();

                                                    while (!int.TryParse(entrada3, out Option))
                                                    {
                                                        Console.WriteLine("Error: Debe ingresar un número entero.");
                                                        Console.WriteLine("\nIngrese el numero de la opcion (1-3)");
                                                        entrada = Console.ReadLine();
                                                    }
                                                    switch (Option)
                                                    {
                                                        case 1:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {vicksVapo.Nombre()} \n Laboratorio:  \n Componentes: {vicksVapo.Componentes()} \n Cantigad mg: {vicksVapo.CantidadGramos()}\n Precio: $ {vicksVapo.Precio()}\n Descuento: {vicksVapo.Descuento()}\n Clasificación: {vicksVapo.Clasificacion()}\n");
                                                            vicksVapo.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        case 2:
                                                            Console.WriteLine("-----DETALLES-----");

                                                            Console.WriteLine($" Nombre: {mentolEucalipto.Nombre()} \n Laboratorio:  \n Componentes: {mentolEucalipto.Componentes()} \n Cantigad mg: {mentolEucalipto.CantidadGramos()}\n Precio: $ {mentolEucalipto.Precio()}\n Descuento: {mentolEucalipto.Descuento()}\n Clasificación: {mentolEucalipto.Clasificacion()}\n");
                                                            mentolEucalipto.comprar();
                                                            Console.ReadLine();
                                                            break;
                                                        

                                                        case 3:
                                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                                            Console.WriteLine("Fin de las consultas");
                                                            Console.ReadLine();
                                                            Environment.Exit(0);

                                                            break;
                                                        default:

                                                            Console.WriteLine("Opción no válida.");
                                                            break;
                                                    }
                                                    Console.ReadKey();

                                                }
                                                while (Option != 3);
                                                break;
                                            case 4:
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Fin de las consultas");
                                                Console.ReadLine();
                                                Environment.Exit(0);

                                                break;
                                            default:

                                                Console.WriteLine("Opción no válida.");
                                                break;
                                        }
                                        Console.ReadKey();

                                    }
                                    while (Option != 4);
                                    break;
                                case 2:
                                    do
                                    {
                                        

                                    }
                                    while (Option != 4);
                                    break;
                                case 7:
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Fin de las consultas");
                                    Console.ReadLine();
                                    Environment.Exit(0);

                                    break;
                                default:

                                    Console.WriteLine("Opción no válida.");
                                    break;

                            }
                            Console.ReadKey();

                        }
                        while (Option != 9);
                        break;

                        case 2:
                        Console.Clear();
                        Console.WriteLine("Ha seleccionado la opcion 2\n ");
                        break;
                       
                        case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Fin de las consultas");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                        default:
                            
                        Console.WriteLine("Opción no válida.");
                       
                        break;

                }
                  
                
                Console.ReadKey();

            }
            while (Option != 3);
        }
    }
}
