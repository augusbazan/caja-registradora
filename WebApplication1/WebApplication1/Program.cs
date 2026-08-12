Console.WriteLine("==== KIOSCO EL BETO ====");
Console.Write("Nombre del cajero: ");
string cashName =  Console.ReadLine();
Console.WriteLine($"Bienvenido {cashName}, Caja abierta");

int cantProduct = 0;
decimal sumProduct = 0;
int numOption;
decimal maxDsct = 0.10m;
decimal minDsct = 0.05m;
decimal totalDsct = 0.0m;
decimal totalCharge = 0.0m;

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
decimal totalwDiscount = sumProduct;
    if (sumProduct <= 20000) 
    {
        Console.WriteLine($"Suma total de los precios: {sumProduct}");
        Console.WriteLine("====================");
    }
    else if ( sumProduct < 50000) 
    {
        totalDsct = sumProduct * minDsct;
        totalwDiscount = sumProduct - totalDsct;
        Console.WriteLine($"Subtotal de los precios: {sumProduct}");
        Console.WriteLine($"Descuento aplicado: {totalDsct} (5%)");
        Console.WriteLine($"Total de los precios: {totalwDiscount}");
        Console.WriteLine("====================");
    }
    else if (sumProduct >= 50000)
    {
        totalDsct = sumProduct * maxDsct;
        totalwDiscount = sumProduct - totalDsct;
        Console.WriteLine($"Subtotal de los precios: {sumProduct}");
        Console.WriteLine($"Descuento aplicado: {totalDsct} (10%)");
        Console.WriteLine($"Total de los precios: {totalwDiscount}");
        Console.WriteLine("====================");
    }

    int optChosen;
    do
    {

    Console.WriteLine("Medio de pago: ");
    Console.WriteLine("1 - Efectivo ");
    Console.WriteLine("2 - Débito ");
    Console.WriteLine("3 - Crédito ");
    Console.Write("Marque el número del método que prefiera: ");
    optChosen = int.Parse(Console.ReadLine());

    switch (optChosen)
    {
        case 1:
            decimal discount = totalwDiscount * maxDsct;
            totalDsct += discount;
            Console.WriteLine("Tiene un 10% de descuento adicional!");
            Console.WriteLine($"Su total a pagar ahora es de: {totalwDiscount - discount}");
            break;

        case 2:
            Console.WriteLine($"El total a pagar es de: {totalwDiscount}");
            break;

        case 3:
            decimal maxCharge = 0.15m;
            decimal extCharge = totalwDiscount * maxCharge;
            totalCharge += extCharge;
            Console.WriteLine("Tiene un 15% de RECARGO");
            Console.WriteLine($"Su total a pagar ahora es de: {totalwDiscount + extCharge} ");
            break;

        default:
            Console.WriteLine("Input desconocido, marque nuevamente");
            break;
        }

        Console.WriteLine("Presione enter para imprimir su ticket: ");
        Console.ReadKey();

        decimal total = sumProduct - totalDsct + totalCharge;

        for (int i = 0; i < 30; i++) Console.Write('-');
        Console.WriteLine();
        Console.WriteLine("KIOSCO EL BETO");
        for (int i = 0; i < 30; i++) Console.Write('-');
        Console.WriteLine();
        Console.WriteLine($"Cajero: {cashName}");
        Console.WriteLine($"Productos: {cantProduct}");
        Console.WriteLine($"Subtotal: {sumProduct}");
        Console.WriteLine($"Descuento: {totalDsct}");
        Console.WriteLine($"Recargo: {totalCharge}");
        for (int i = 0; i < 30; i++) Console.Write('-');
        Console.WriteLine();
        Console.WriteLine($"Total: {total}");
        for (int i = 0; i < 30; i++) Console.Write('-');


} while (optChosen > 3 || optChosen < 1);

    

Console.ReadKey();
    
