class masgaseosa:decorator
{
    public masgaseosa(cocina Cocina):base(Cocina){}

    public override double costo => _Cocina.costo + 1;
    public override string descripcion => String.Format($"{_Cocina.descripcion}, una gaseosa más");
}