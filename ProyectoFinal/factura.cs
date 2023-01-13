class factura:facturacion
{
    //Inciamos los datos de la factura, algunos datos ya estan ingresados porque no varian
    public string numero_Factura="000330762";
    public string tipo_Emision="Normal";

    public string id="";
    public string codigo_Comida="";
    public string direccion_Sucursal="Calle 13 y AV. 20";
    public string nombre_Comida="";
    public string valor="";
    //*************************************************************************************
    //Metodos:
    //**********Metodo para empesar ingresar los datos a las factura por teclado***********
    public override void Crear_Factura()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Ingrese los datos para la factura:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("(1)Con datos o (2)consumidor final");
        id=Console.ReadLine();
            if(id=="1"){
            Console.WriteLine("Ingrese la identificacion del cliente");
            id=Console.ReadLine();
            }
            else{id="999999";}
        Console.WriteLine("Ingrese el codigo de la comida");
        codigo_Comida=Console.ReadLine();
        if(codigo_Comida=="001"){
            nombre_Comida="Combo 1";
        }
        if(codigo_Comida=="002"){
            nombre_Comida="Combo 2";
        }
        if(codigo_Comida=="003"){
            nombre_Comida="Combo 3";
        }
        if(codigo_Comida=="004"){
            nombre_Comida="Combo 4";
        }
        if(codigo_Comida=="005"){
            nombre_Comida="Combo 5";
        }
        Console.WriteLine("Ingrese el valor del combo");
        valor=Console.ReadLine();
    }
    //************************Metodo para imprimir la factura creada************************
    public override void Imprimir()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("-----No. de Factura electronica------");
        Console.WriteLine("              "+numero_Factura);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("-------Tipo de emision:"+tipo_Emision+"-------");
        Console.WriteLine("-------Direcciòn de sucursal --------");
        Console.WriteLine("         "+direccion_Sucursal);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Codigo:   Descripcion:    Valor:");
        Console.WriteLine(codigo_Comida+"       "+nombre_Comida+"         "+valor);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("-------Cedula de identificaiòn-------");
        Console.WriteLine("              "+id);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("      No comparta esta factura :)    ");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("                 |                   ");
        Console.WriteLine("                 |                   ");
        Console.WriteLine("                 |                   ");
        Console.WriteLine("(0) Para volver al menu principal");
        Console.ReadLine();
    }
}