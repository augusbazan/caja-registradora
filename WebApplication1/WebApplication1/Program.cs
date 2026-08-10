Console.WriteLine("==== KIOSCO EL BETO ====");
Console.Write("Nombre del cajero: ");
string cashName =  Console.ReadLine();
Console.WriteLine($"Bienvenido {cashName}, Caja abierta");

Console.WriteLine("Agregue un Producto");
Console.Write("Nombre del producto: ");
string productName = Console.ReadLine();
Console.Write("Precio del producto: ");
decimal productPrice = decimal.Parse(Console.ReadLine());

Console.WriteLine($"=== Producto creado exitosamente ===");
Console.WriteLine($"Producto: {productName}, Precio: {productPrice} ");