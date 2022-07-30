|public class cliente : interfaze
{
    public string Nombre;

    public cliente(string Nombre)
    {
        this.Nombre=Nombre;
    }
    public void mostrar()
    {
        Console.WriteLine("Datos del cliente: "+ Nombre);
    }
}