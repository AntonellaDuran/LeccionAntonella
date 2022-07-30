

Console.Clear();
    Console.WriteLine("Orden de reparacion");
cliente CLIENTE = new cliente("Juan Martinez");
CLIENTE.mostrar();
Dispositivo dispositivo3 = new Dispositivo(CLIENTE,"3", "Huawei", "h6", "android", "telefono", "tiene chip", "taiwan");
hardware hardware1 = new hardware("audifonos");
hardware hardware2 = new hardware("cargador");
Console.WriteLine("reparar :");
Dispositivo dispositivo1 = new Dispositivo(CLIENTE,"1", "Samsug", "note 2", "android", "tableta", "sin chip", "china");
dispositivo1.mostrar();
Console.WriteLine("fallos en:");
func1 funcion1 = new func1();
funcion1.mostrar();
Console.WriteLine("harware adicional:");
hardware1.mostrar();
Console.WriteLine("reparar :");
Dispositivo dispositivo2 = new Dispositivo(CLIENTE,"2", "Sansug", "galaxi 8", "android", "telefono", "tiene chip", "china");
dispositivo2.mostrar();
Console.WriteLine("fallos en:");
func2 funcion2 = new func2();
funcion2.mostrar();
func3 funcion3 = new func3();
funcion3.mostrar();
Console.WriteLine("harware adicional:");
hardware2.mostrar();