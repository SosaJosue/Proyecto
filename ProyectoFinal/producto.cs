class producto
{
    public string codigo {get; set;}
    public string comida {get; set;}
    public int cantidad {get; set;}
    public double valorC {get; set;}

    public producto(string codigo, string comida, int cantidad, double valorC){
        this.codigo = codigo;
        this.comida = comida;
        this.cantidad = cantidad;
        this.valorC = valorC;
    }
    public  void MostrarMenu(){
        Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine(codigo+ "        "+comida+"   "+cantidad+"     "+valorC);
    }
    
}