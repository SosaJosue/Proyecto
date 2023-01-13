internal class Program
{
    private static void Main(string[] args)
    {
        string opcion = "0";
        factura factura1 = new factura();
        //**********Instanciar los productos/objetos con sus respectivas variables**********
        producto C1 = new producto("001", "Combo 1: Pollo asado + ensalada rusa + 1 gaseosa  ",1, 5.50);
        producto C2 = new producto("002", "Combo 2: Pollo asado + arroz + 1 gaseosa          ",1, 9.75);
        producto C3 = new producto("003", "Combo 3: Pollo asado + papas fritas + 1 gaseosa   ",1, 8.00);
        producto C4 = new producto("004", "Combo 4: Pollo asado + sandwich chiken + 1 gaseosa",1, 10.25);
        producto C5 = new producto("005", "Combo 5: Pollo asado + postre                     ",1, 5.00);
        //**********************************************************************************

        //**********************La lista con varios procdutos*******************************
        List<producto> Listaproducto = new List<producto>();
        Listaproducto.Add(C1);
        Listaproducto.Add(C2);
        Listaproducto.Add(C3);
        Listaproducto.Add(C4);
        Listaproducto.Add(C5);
        //***********************************************************************************
        //*****************Menu principal de opciones para la aplicacion*********************
        while(opcion!="4"){
            
            Console.WriteLine("------------------------------------");
            Console.WriteLine("  Bienvenido a los pollos hermanos  ");
            Console.WriteLine("       Elija que desea hacer:       ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("(1) Hacer facturacion");
            Console.WriteLine("(2) Ver lista de comida");
            Console.WriteLine("(3) Seleccione un combo");
            Console.WriteLine("(4) Salir de la aplicaciòn");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            
        //******************************Fin de el menu principal******************************
        //***************************Ingresar una opcion por teclado**************************
            opcion = Console.ReadLine();
            
        //************************************************************************************
        //
            switch (opcion)
            {
                case "1":
                {
                    
                    factura1.Crear_Factura();
                    Console.WriteLine("¿Desea imprimir la factura?");
                    Console.WriteLine("(5) Si");
                    Console.WriteLine("(6) No");
                    opcion = Console.ReadLine();
                    if(opcion == "5"){
                        
                        factura1.Imprimir();
                    }
                }
                break;
                case "2":
                {
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("Codigo:    Combos:                                        Cantidad:   Valor:");
                    foreach (producto item in Listaproducto)
                    {
                        
                        item.MostrarMenu();
                    }
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("");
                }
                break;
                case "3":
                {
                    Console.WriteLine("Ingrese el codigo para pedir una orden:");
                    opcion=Console.ReadLine();
                    if(opcion == "001"){
                        cocina pedir1 = new combo1();
                        
                        while (opcion !="8")
                        {
                            Console.WriteLine("¿Desea agregar un extras?");
                            Console.WriteLine("(7) Si");
                            Console.WriteLine("(8) No");
                            opcion = Console.ReadLine();
                            if(opcion == "7"){
                                Console.WriteLine("Que extra dese agregar:");
                                Console.WriteLine("(9) Porcion de arroz");
                                Console.WriteLine("(10) Mas gaseosa");
                                Console.WriteLine("(11) Salsa de tomate y mayonesa");
                                opcion = Console.ReadLine();
                                if(opcion == "9"){
                                    pedir1 = new porcion(pedir1);
                                }
                                if(opcion == "10"){
                                    pedir1 = new masgaseosa(pedir1);
                                }
                                if(opcion == "11"){
                                    pedir1 = new salsas(pedir1);
                                }
                            }
                        }
                        Console.WriteLine($"Su pedido: {pedir1.descripcion}, y ahora tiene un valor de {pedir1.costo}");
                    }
                    if(opcion == "002"){
                        cocina pedir2 = new combo2();
                        while (opcion !="8")
                        {
                            Console.WriteLine("¿Desea agregar un extras?");
                            Console.WriteLine("(7) Si");
                            Console.WriteLine("(8) No");
                            opcion = Console.ReadLine();
                            if(opcion == "7"){
                                Console.WriteLine("Que extra dese agregar:");
                                Console.WriteLine("(9) Porcion de arroz");
                                Console.WriteLine("(10) Mas gaseosa");
                                Console.WriteLine("(11) Salsa de tomate y mayonesa");
                                opcion = Console.ReadLine();
                                if(opcion == "9"){
                                    pedir2 = new porcion(pedir2);
                                }
                                if(opcion == "10"){
                                    pedir2 = new masgaseosa(pedir2);
                                }
                                if(opcion == "11"){
                                    pedir2 = new salsas(pedir2);
                                }
                            }
                        }
                        Console.WriteLine($"Su pedido: {pedir2.descripcion}, y ahora tiene un valor de {pedir2.costo}");
                    }
                    if(opcion == "003"){
                        cocina pedir3 = new combo3();
                        while (opcion !="8")
                        {
                            Console.WriteLine("¿Desea agregar un extras?");
                            Console.WriteLine("(7) Si");
                            Console.WriteLine("(8) No");
                            opcion = Console.ReadLine();
                            if(opcion == "7"){
                                Console.WriteLine("Que extra dese agregar:");
                                Console.WriteLine("(9) Porcion de arroz");
                                Console.WriteLine("(10) Mas gaseosa");
                                Console.WriteLine("(11) Salsa de tomate y mayonesa");
                                opcion = Console.ReadLine();
                                if(opcion == "9"){
                                    pedir3 = new porcion(pedir3);
                                }
                                if(opcion == "10"){
                                    pedir3 = new masgaseosa(pedir3);
                                }
                                if(opcion == "11"){
                                    pedir3 = new salsas(pedir3);
                                }
                            }
                        }
                        Console.WriteLine($"Su pedido: {pedir3.descripcion}, y ahora tiene un valor de {pedir3.costo}");
                    }
                    if(opcion == "004"){
                        cocina pedir4 = new combo4();
                        while (opcion !="8")
                        {
                            Console.WriteLine("¿Desea agregar un extras?");
                            Console.WriteLine("(7) Si");
                            Console.WriteLine("(8) No");
                            opcion = Console.ReadLine();
                            if(opcion == "7"){
                                Console.WriteLine("Que extra dese agregar:");
                                Console.WriteLine("(9) Porcion de arroz");
                                Console.WriteLine("(10) Mas gaseosa");
                                Console.WriteLine("(11) Salsa de tomate y mayonesa");
                                opcion = Console.ReadLine();
                                if(opcion == "9"){
                                    pedir4 = new porcion(pedir4);
                                }
                                if(opcion == "10"){
                                    pedir4 = new masgaseosa(pedir4);
                                }
                                if(opcion == "11"){
                                    pedir4 = new salsas(pedir4);
                                }
                            }
                        }
                        Console.WriteLine($"Su pedido: {pedir4.descripcion}, y ahora tiene un valor de {pedir4.costo}");
                    }
                    if(opcion == "005"){
                        cocina pedir5 = new combo5();
                        while (opcion !="8")
                        {
                            Console.WriteLine("¿Desea agregar un extras?");
                            Console.WriteLine("(7) Si");
                            Console.WriteLine("(8) No");
                            opcion = Console.ReadLine();
                            if(opcion == "7"){
                                Console.WriteLine("Que extra dese agregar:");
                                Console.WriteLine("(9) Porcion de arroz");
                                Console.WriteLine("(10) Mas gaseosa");
                                Console.WriteLine("(11) Salsa de tomate y mayonesa");
                                opcion = Console.ReadLine();
                                if(opcion == "9"){
                                    pedir5 = new porcion(pedir5);
                                }
                                if(opcion == "10"){
                                    pedir5 = new masgaseosa(pedir5);
                                }
                                if(opcion == "11"){
                                    pedir5 = new salsas(pedir5);
                                }
                            }
                        }
                        Console.WriteLine($"Su pedido: {pedir5.descripcion}, y ahora tiene un valor de {pedir5.costo}");
                    }

                }
                break;
            }//Fin del Switch
        }//Fin del While
        Console.WriteLine("------------------------------------");
        Console.WriteLine("       Gracias por elegirnos       ");
        Console.WriteLine("           Vuelva pronto           ");
        Console.WriteLine("------------------------------------");
    }
}