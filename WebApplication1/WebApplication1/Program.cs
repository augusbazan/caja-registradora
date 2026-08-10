Console.WriteLine("==== KIOSCO EL BETO ====");
Console.Write("Nombre del cajero: ");
string cashName =  Console.ReadLine();
Console.WriteLine($"Bienvenido {cashName}, Caja abierta");

int cantProduct = 0;
decimal sumProduct = 0;
int numOption;

do
{

    Console.WriteLine("Qué desea hacer?" +
        "1 - Carga un producto" +
        "2 - Cerrar la ventana ");

    numOption = int.Parse(Console.ReadLine());

    if (numOption == 1)
    {
        Console.WriteLine("Agregue un Producto");
        Console.Write("Nombre del producto: ");
        string productName = Console.ReadLine();
        Console.Write("Precio del producto: ");
        decimal productPrice = decimal.Parse(Console.ReadLine());
        sumProduct += productPrice;
        cantProduct++;

        Console.WriteLine($"=== Producto creado exitosamente ===");
        Console.WriteLine($"Producto: {productName} , Precio: {productPrice} ");
    }
    else if (numOption != 2)
    {
        Console.WriteLine("Input invalido, intente nuevamente");
    }

}

while (numOption != 2);
    Console.WriteLine($"Cantidad total de productos: {cantProduct}");
    Console.WriteLine($"Suma total de los precios: {sumProduct}");


