class salsas:decorator
{
    public salsas(cocina Cocina):base(Cocina){}

    public override double costo => _Cocina.costo + 1;
    public override string descripcion => String.Format($"{_Cocina.descripcion}, mas salsa de tomates y mayonesa");
}