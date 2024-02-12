// See https://aka.ms/new-console-template for more information

Console.WriteLine("INGRESE SU CONTRASEÑA ");


{
    string contraseñaCorrecta = "123456";
    int intentosMaximos = 3;
    int intentos = 0;

    while (intentos < intentosMaximos)
    {
        Console.Write("Ingresa la contraseña: ");
        string contraseñaIngresada = Console.ReadLine();

        if (contraseñaIngresada == contraseñaCorrecta)
        {
            Console.WriteLine("Contraseña correcta. Acceso permitido.");
            break; // Salir del bucle si la contraseña es correcta.
        }
        else
        {
            intentos++;
            int intentosRestantes = intentosMaximos - intentos;

            if (intentosRestantes > 0)
            {
                Console.WriteLine($"Contraseña incorrecta . Te quedan {intentosRestantes} intentos.");
            }
            else
            {
                Console.WriteLine("Has agotado el número de intentos permitidos. Acceso denegado.");
            }
        }
    }
}
