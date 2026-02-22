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
Console.WriteLine("Ingrese el tipo de atención");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatria");
Console.WriteLine("4. Traumatologia");
Console.WriteLine("Elija una opción");
opcionPrioridad = int.Parse(Console.ReadLine());

Console.WriteLine("Resultados:\n");

if(edad >= 0 && (nivelDolor  >= 0 && nivelDolor <= 10) && oxigeno > 0 && presionSistolica > 0 && temperatura > 0)
{
    switch(opcionPrioridad)
    {
        case 1:
            if(oxigeno < 90)
            {
                Console.WriteLine("Prioriedad media");
                Console.WriteLine("Se recomienda observación");
            }
            else if(temperatura >= 39 && nivelDolor >= 8)
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Se recomienda ingreso a revisión");
            }
            else
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Se recomienda asistencia medica");
            }
        break;

        case 2:
            Console.WriteLine("Prioridad Baja");
            Console.WriteLine("Consulta normal"); 
        break;

        case 3:
            if(edad < 12 && temperatura >= 39)
            {
                Console.WriteLine("Prioridad Mayor");
                Console.WriteLine("Se recomienda ingreso a revisión");
            }
            else
            {
                Console.WriteLine("Prioridad Baja");
                Console.WriteLine("Consulta normal");
            }
        break;

        case 4:
            Console.WriteLine("Prioridad Mayor");
            Console.WriteLine("Ingrese a tratamiento inmediato");
        break;
    }
}
else
{
    Console.WriteLine("Algun dato es incorrecto");
}