Console.WriteLine("==== KIOSCO EL BETO ====");
Console.Write("Nombre del cajero: ");
string cashName =  Console.ReadLine();
Console.WriteLine($"Bienvenido {cashName}, Caja abierta");

int cantProduct = 0;
decimal sumProduct = 0;
int numOption;
decimal maxDsct = 0.10m;
decimal minDsct = 0.05m;

do
{
    Console.WriteLine("====================");
    Console.WriteLine(" Qué desea hacer?" +
        "  1 - Carga un producto" +
        "  2 - Cerrar la ventana ");

    numOption = int.Parse(Console.ReadLine());

    if (numOption == 1)
    {
        Console.WriteLine("====================");
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
    Console.WriteLine("====================");
    Console.WriteLine($"Cantidad total de productos: {cantProduct}");
    if (sumProduct <= 20000) 
        {
            Console.WriteLine($"Suma total de los precios: {sumProduct}");
        }
    else if ( sumProduct < 50000) 
        {
        decimal discount = sumProduct * minDsct;
        Console.WriteLine($"Subtotal de los precios: {sumProduct}");
        Console.WriteLine($"Descuento aplicado: {discount} (5%)");
        Console.WriteLine($"Total de los precios: {sumProduct - discount}");
    }
    else if (sumProduct >= 50000)
    {
        decimal discount = sumProduct * maxDsct;
        Console.WriteLine($"Subtotal de los precios: {sumProduct}");
        Console.WriteLine($"Descuento aplicado: {discount} (10%)");
        Console.WriteLine($"Total de los precios: {sumProduct - discount}");
    }



