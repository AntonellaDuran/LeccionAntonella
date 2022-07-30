class hardware : interfaze
{
    public string adicional;

    public hardware(string adicional)
    {
        this.adicional=adicional;
    }

    public virtual void mostrar()
    {
        Console.WriteLine("con el adicional de :");
        Console.WriteLine(adicional);

    }
}