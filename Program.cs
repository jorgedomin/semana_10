using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<int> todosUsuarios = new HashSet<int>(Enumerable.Range(1, 500)); // Crear de forma ficticia en el conjunto los 500 usuarios
        HashSet<int> usuariosPfizer = new HashSet<int>(Enumerable.Range(1, 75)); // Crear un conjunto ficticio de 75 usuarios vacunados con Pfizer
        HashSet<int> usuariosAstrazeneca = new HashSet<int>(Enumerable.Range(76, 75)); // Crear un conjunto ficticio de 75 usuarios vacunados con Astrazeneca
        HashSet<int> usuariosVacunados = new HashSet<int>(usuariosPfizer); // Conjunto de usuarios vacunados (Pfizer o Astrazeneca)
        usuariosVacunados.UnionWith(usuariosAstrazeneca);

        // Listado de ciudadanos que no se han vacunado
        HashSet<int> ciudadanosNoVacunados = new HashSet<int>(todosUsuarios);
        ciudadanosNoVacunados.ExceptWith(usuariosVacunados);

        // Listado de ciudadanos que han recibido las dos vacunas (no aplicable en este caso, se hace con intersección)
        HashSet<int> ciudadanosDosVacunas = new HashSet<int>(usuariosPfizer);
        ciudadanosDosVacunas.IntersectWith(usuariosAstrazeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        HashSet<int> ciudadanosSoloPfizer = new HashSet<int>(usuariosPfizer);
        ciudadanosSoloPfizer.ExceptWith(usuariosAstrazeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de Astrazeneca
        HashSet<int> ciudadanosSoloAstrazeneca = new HashSet<int>(usuariosAstrazeneca);
        ciudadanosSoloAstrazeneca.ExceptWith(usuariosPfizer);

        // Mostrar resultados
        Console.WriteLine("Ciudadanos que no se han vacunado:");
        Console.WriteLine(string.Join(", ", ciudadanosNoVacunados));

        Console.WriteLine("\nCiudadanos que han recibido las dos vacunas:");
        Console.WriteLine(string.Join(", ", ciudadanosDosVacunas));

        Console.WriteLine("\nCiudadanos que solamente han recibido la vacuna de Pfizer:");
        Console.WriteLine(string.Join(", ", ciudadanosSoloPfizer));

        Console.WriteLine("\nCiudadanos que solamente han recibido la vacuna de Astrazeneca:");
        Console.WriteLine(string.Join(", ", ciudadanosSoloAstrazeneca));
    }

}