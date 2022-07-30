class ordenReparacion : interfaze
{

    public string IMEI;
    public string Modelo;
    public string Marca;
    public string Sisoperativo;
    public string tipo;

    public string chip;
    public string fabricacion;

    cliente orden;


    public ordenReparacion (cliente orden ,string IMEI,string Modelo,string Marca,string Sisoperativo, string tipo, string chip, string fabricacion)
    {
        this.orden=orden;
        this.IMEI=IMEI;
        this.Modelo=Modelo;
        this.Marca=Marca;
        this.Sisoperativo=Sisoperativo;
        this.tipo=tipo;
        this.chip=chip;
        this.fabricacion=fabricacion;
    }
    public virtual void mostrar()
    {
        Console.WriteLine("");
    }
}