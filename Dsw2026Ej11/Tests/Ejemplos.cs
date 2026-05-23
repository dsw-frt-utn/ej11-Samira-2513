using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        //1. Agregar 3 alumnos a la lista

        Alumno alumno1 = new Alumno(01, "Joaquin Cendoya", 9.50);
        Alumno alumno2 = new Alumno(02, "Samira Ruiz", 8.75);
        Alumno alumno3 = new Alumno(03, "Gonzalo Gonzalez", 8.50);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        //2. Listar por consola los alumnos

        Console.WriteLine("--- Listado de Alumnos ---");
        List<Alumno> alumnos = casoList.ObtenerAlumnos();
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine($"ID: {alumno.Id} - Nombre: {alumno.Nombre} - Promedio: {alumno.Promedio}");
        }

        //3. Buscar por nombre un alumno que exista y mostrar por consola

        Console.WriteLine("--- Buscando Alumno por Nombre (Existente) ---");
        Alumno? alumnoEncontrado = casoList.BuscarAlumnoPorNombre("Samira Ruiz");
        if (alumnoEncontrado is not null)
        {
            Console.WriteLine($"Alumno encontrado: ID: {alumnoEncontrado.Id} - Nombre: {alumnoEncontrado.Nombre} - Promedio: {alumnoEncontrado.Promedio}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        //4. Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"

        Console.WriteLine("--- Buscando Alumno por Nombre (No Existente) ---");
        Alumno? alumnoNoEncontrado = casoList.BuscarAlumnoPorNombre("Peter Parker");
        if(alumnoNoEncontrado is not null)
        {
            Console.WriteLine($"Alumno encontrado: ID: {alumnoNoEncontrado.Id} - Nombre: {alumnoNoEncontrado.Nombre} - Promedio: {alumnoNoEncontrado.Promedio}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        //5. Eliminar un alumno y listar por consola los alumnos
        
        Console.WriteLine("--- Listado de Alumnos después de una Eliminacion ---");
        casoList.EliminarAlumno(alumno2);
        List <Alumno> alumnosDespuesEliminacion = casoList.ObtenerAlumnos();
        foreach (Alumno alumno in alumnosDespuesEliminacion)
        {
            Console.WriteLine($"ID: {alumno.Id} - Nombre: {alumno.Nombre} - Promedio: {alumno.Promedio}");
        }

        //6. Eliminar el primer elemento de la lista y listar por consola los alumnos

        Console.WriteLine("--- Listado de Alumnos después de Eliminar el Primer Elemento ---");
        casoList.EliminarAlumnoEnPosicion(0);
        List<Alumno> alumnosDespuesEliminacionPrimerElemento = casoList.ObtenerAlumnos();
        foreach (Alumno alumno in alumnosDespuesEliminacionPrimerElemento)
        {
            Console.WriteLine($"ID: {alumno.Id} - Nombre: {alumno.Nombre} - Promedio: {alumno.Promedio}");
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        //1. Agregar 3 alumnos al diccionario

        Alumno alumno1 = new Alumno(01, "Joaquin Cendoya", 9.50);
        Alumno alumno2 = new Alumno(02, "Samira Ruiz", 8.75);
        Alumno alumno3 = new Alumno(03, "Gonzalo Gonzalez", 8.50);

        casoDictionary.AgregarAlumno(56184, alumno1);
        casoDictionary.AgregarAlumno(58023, alumno2);
        casoDictionary.AgregarAlumno(56797, alumno3);

        //2. Listar por consola los alumnos

        Console.WriteLine("--- Listado de Alumnos ---");
        Dictionary<int, Alumno> alumnos = casoDictionary.ObtenerAlumnos();
        foreach (KeyValuePair<int, Alumno> alumno in alumnos)
        {
            Console.WriteLine($"Legajo: {alumno.Key} - ID: {alumno.Value.Id} - Nombre: {alumno.Value.Nombre} - Promedio: {alumno.Value.Promedio}");
        }

        //3. Buscar un alumno por clave y mostrar por consola
        
        Console.WriteLine("--- Buscando Alumno por Clave (Existente) ---");
        Alumno? alumnoEncontrado = casoDictionary.BuscarAlumnoPorClave(58023);
        if (alumnoEncontrado is not null)
        {
            Console.WriteLine($"Alumno encontrado: ID: {alumnoEncontrado.Id} - Nombre: {alumnoEncontrado.Nombre} - Promedio: {alumnoEncontrado.Promedio}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        //4. Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"

        Console.WriteLine("--- Buscando Alumno por Clave (No Existente) ---");
        Alumno? alumnoNoEncontrado = casoDictionary.BuscarAlumnoPorClave(56199);
        if (alumnoNoEncontrado is not null)
        {
            Console.WriteLine($"Alumno encontrado: ID: {alumnoNoEncontrado.Id} - Nombre: {alumnoNoEncontrado.Nombre} - Promedio: {alumnoNoEncontrado.Promedio}");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        //5. Eliminar un alumno por clave y listar por consola los alumnos

        Console.WriteLine("--- Listado de Alumnos después de una Eliminación ---");
        casoDictionary.EliminarAlumno(56184);
        Dictionary<int, Alumno> alumnosDespuesEliminacion = casoDictionary.ObtenerAlumnos();
        foreach (KeyValuePair<int, Alumno> alumno in alumnosDespuesEliminacion)
        {
            Console.WriteLine($"Legajo: {alumno.Key} - ID: {alumno.Value} - Nombre: {alumno.Value.Nombre} - Promedio: {alumno.Value.Promedio}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        // 1. Instanciamos nuestra clase de lógica CasoLinq
        CasoLinq casoLinq = new CasoLinq();

        // 2. Cargamos los libros llamando al método estático CrearLista() de la clase Libro
        List<Libro> listaDeLibros = Libro.CrearLista();
        foreach (Libro libro in listaDeLibros)
        {
            casoLinq.AgregarLibro(libro);
        }

        Console.WriteLine("==================================================");
        Console.WriteLine("          PRUEBAS DE CONSULTAS LINQ               ");
        Console.WriteLine("==================================================");
        Console.WriteLine();

        // Punto 1 y 2: Primer y Último libro
        Libro primero = casoLinq.GetPrimero();
        Libro ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"1. Primer Libro: ID: {primero.Id} - Título: {primero.Titulo}");
        Console.WriteLine($"2. Último Libro: ID: {ultimo.Id} - Título: {ultimo.Titulo}");
        Console.WriteLine();

        // Punto 3 y 4: Suma y Promedio de Precios
        double totalPrecios = casoLinq.GetTotalPrecios();
        double promedioPrecios = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"3. Suma Total de Precios: {totalPrecios:C}");
        Console.WriteLine($"4. Promedio de Precios: {promedioPrecios:C}");
        Console.WriteLine();

        // Punto 5: Lista de libros con Id mayor a 15
        Console.WriteLine("5. --- Libros con ID mayor a 15 ---");
        List<Libro> librosIdMayor15 = casoLinq.GetListById();
        foreach (Libro l in librosIdMayor15)
        {
            Console.WriteLine($"   ID: {l.Id} - Título: {l.Titulo}");
        }
        Console.WriteLine();

        // Punto 6: Lista formateada de cadenas (Título - Precio Moneda)
        Console.WriteLine("6. --- Lista de Libros en Formato Moneda ---");
        List<string> librosFormateados = casoLinq.GetLibros();
        // Mostramos solo los primeros 5 para no saturar la pantalla de consola
        foreach (string item in librosFormateados.Take(5))
        {
            Console.WriteLine($"   {item}");
        }
        Console.WriteLine("   ...");
        Console.WriteLine();

        // Punto 7 y 8: Libro con Mayor y Menor precio
        Libro masCaro = casoLinq.GetMayorPrecio();
        Libro masBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"7. Libro más Caro: {masCaro.Titulo} ({masCaro.Precio:C})");
        Console.WriteLine($"8. Libro más Barato: {masBarato.Titulo} ({masBarato.Precio:C})");
        Console.WriteLine();

        // Punto 9: Libros con precio mayor al promedio
        Console.WriteLine($"9. --- Libros cuyo Precio supera al Promedio ({promedioPrecios:C}) ---");
        List<Libro> sobrePromedio = casoLinq.GetMayorPromedio();
        foreach (Libro l in sobrePromedio.Take(5)) // Muestra las primeras 5 coincidencias
        {
            Console.WriteLine($"   {l.Titulo} -> {l.Precio:C}");
        }
        Console.WriteLine("   ...");
        Console.WriteLine();

        // Punto 10: Libros ordenados por título de forma descendente
        Console.WriteLine("10. --- Libros Ordenados por Título Descendente (Z-A) ---");
        List<Libro> ordenadosDesc = casoLinq.GetLibrosOrdenadosPorTituloDesc();
        foreach (Libro l in ordenadosDesc.Take(5)) // Muestra los primeros 5 alfabéticamente inversos
        {
            Console.WriteLine($"   {l.Titulo}");
        }
        Console.WriteLine("   ...");
    }
}
