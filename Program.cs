// Ejercicio de programación
// Cuando resuelvas el mismo pasame el link al repo, github, gitlab o el que uses pero que sea publico asi puedo bajarme el código.
// Una empresa de alquiler de bicicletas tiene las siguientes opciones:
// 1- Alquiler por hora, costo $ 20
// 2- Alquiler por dia, costo $ 100
// 3- Alquiler por semana, costo $ 500
// 4- Alquiler familiar, es una promocion que incluye el alquiler entre 3 y 5 bicicletas con un 30% de descuento del precio total

// Objetivo es la resolucion del mismo recibiendo cantidad de bicicletas y tiempo de alquiler y devolver el costo a pagar.


Console.Write("Ingrese la cantidad de bicicletas que quiere alquilar ");
int cantBik = int.Parse(Console.ReadLine());    
Console.Write("Ingrese el tiempo de alquiler en horas - dias - semanas ");
string tiempoAlq = Console.ReadLine().ToLower();

if (tiempoAlq != "horas" && tiempoAlq != "dias" && tiempoAlq != "semanas")
{
do
{
    Console.Write("-INCORRECTO- \n Ingrese el tiempo de alquiler en 'horas' - 'dias' - 'semanas' ");
    tiempoAlq = Console.ReadLine().ToLower();  
} 
while (tiempoAlq != "horas" && tiempoAlq != "dias" && tiempoAlq != "semanas");
}

double costoTotal = CostoAlquiler(cantBik, tiempoAlq);
Console.WriteLine($"-Usted alquilo: {cantBik} bicicleta/s \n-alquila por: {tiempoAlq} \n-El costo total del alquiler es: {costoTotal} pesos");

static double CostoAlquiler(int cantBicis, string tiempoAlq)
{
    double costoTotal = 0;

    switch (tiempoAlq)
    { 
        case "horas":
        int costoxHora = 20;
        Console.Write("Ingrese la cantidad de horas que quiera ");
        int horas = int.Parse(Console.ReadLine());
        costoTotal = cantBicis * costoxHora * horas;
        break;

        case "dias":
        Console.Write("Ingrese la cantidad de días que quiera ");
         int costoxDia = 100;
        int dias = int.Parse(Console.ReadLine());
        costoTotal = cantBicis * costoxDia * dias;
        break;

        case "semanas":
        Console.Write("Ingrese la cantidad de semanas que quiera ");
        int costoxSemana = 500;
        int semanas = int.Parse(Console.ReadLine());
        costoTotal = cantBicis * costoxSemana * semanas;
        break;

    }

    if (cantBicis >= 3 && cantBicis <= 5)
    {
        double descuento = 0.3;
        costoTotal *= (1 - descuento);
    }
    return costoTotal;
}