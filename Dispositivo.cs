class  Dispositivo: ordenReparacion
{
    public Dispositivo(cliente orden,string IMEI,string Modelo,string Marca,string Sisoperativo, string tipo, string chip, string fabricacion) : base(orden, IMEI, Modelo, Marca, Sisoperativo, tipo, chip, fabricacion)
    {

    }

    public override void mostrar()
    {
        Console.WriteLine("los datos del dispo son");
        Console.WriteLine(IMEI);
        Console.WriteLine(Marca);
        Console.WriteLine(Modelo);
        Console.WriteLine(Sisoperativo);
        Console.WriteLine(chip);
        Console.WriteLine(fabricacion);

    }
}