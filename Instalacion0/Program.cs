// See https://aka.ms/new-console-template for more information


/*Console.WriteLine("Hello, World!");
Console.WriteLine("Buen Dia");

Console.WriteLine(“ingrese su numero de dni”);
String ingresoDelUsuario = console.Readline();
Long numerodedni = long.parse(ingresodelusuario);

Console.writeLine(“ingrese precio del producto”);
ingresodelusuario = console.readline();
decimal precio = decimal.parse(ingresodelusuario);*/



//para pedirle datos del usuario: conseguir el dni
//tomar la captura
//veirificar si esta bien
//y darle un mensaje de error
long numeroDeDocumento;
Console.WriteLine("Ingrese su numero de dni");
//empieza hacer validaciones y reinicia el ciclo
//se busca si algo esta mal emitir un mensaje
//hacer validaciones para que el usuario ingrese los datos
do
{
    string ingresoDelUsuario = Console.ReadLine();
    bool ok = long.TryParse(ingresoDelUsuario, out numeroDeDocumento);
    if (!ok)
    {
        Console.WriteLine("Ingrese solo digitos, ni coma ni puntos");
        continue;
    }
    if (numeroDeDocumento < 10_000_000)
    {
        Console.WriteLine("El numero debe ser mayor a 10 millones");
        continue;

    }
    if (numeroDeDocumento > 99_999_999)
    {
        Console.WriteLine("El numero debe ser menor a 100 millones");
        continue;
    }
   
    break;
}
while (true);

Console.WriteLine("Usted ha ingresado los datos de forma correcta"); 

//como guardar los cambions al proyecto INstalacion0
//buscando como gaurdar cambios
