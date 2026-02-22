int edad;
int opcionPrioridad;
int temperatura;
int oxigeno;
int presionSistolica;
int nivelDolor;
Console.WriteLine("Se verificara los datos del paciente");
Console.WriteLine("Ingrese la edad del paciente");
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su temperatura");
temperatura = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su saturación de oxigeno");
oxigeno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su presión sistólica");
presionSistolica = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su nivel de dolor (0 a 10)");
nivelDolor = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nivel de prioridad");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatria");
Console.WriteLine("4. Traumatologia");
Console.WriteLine("Elija una opción");
opcionPrioridad = int.Parse(Console.ReadLine());

if(edad >= 0 && (nivelDolor  >= 0 && nivelDolor <= 10) && oxigeno > 0 && presionSistolica > 0 && temperatura > 0)
{
    switch(opcionPrioridad)
    {
        case 1:
            Console.WriteLine();
        break;

        case 2:
            Console.WriteLine(); 
        break;

        case 3:
            Console.WriteLine();
        break;

        case 4:
            Console.WriteLine();
        break;
    }
}
else
{
    Console.WriteLine("Algun dato es incorrecto");
}