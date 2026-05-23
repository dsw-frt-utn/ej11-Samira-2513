using System;
using System.Collections.Generic;
using System.Linq;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros = new List<Libro>();

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    // 1. Obtener el primer libro (GetPrimero)
    public Libro GetPrimero()
    {
        var consulta = from l in libros
                       select l;

        // .First() ejecuta la consulta y extrae el primer elemento de la secuencia
        return consulta.First();
    }

    // 2. Obtener el último libro (GetUltimo)
    public Libro GetUltimo()
    {
        var consulta = from l in libros
                       select l;

        // .Last() ejecuta la consulta y extrae el último elemento de la secuencia
        return consulta.Last();
    }

    // 3. Obtener la suma de precios (GetTotalPrecios)
    public double GetTotalPrecios()
    {
        // Proyectamos primero los precios y luego aplicamos la función de agregación Sum()
        return (double)(from l in libros select l.Precio).Sum();
    }

    // 4. Obtener el promedio de precios (GetPromedioPrecios)
    public double GetPromedioPrecios()
    {
        // Proyectamos los precios y aplicamos la función de agregación Average()
        return (double)(from l in libros select l.Precio).Average();
    }

    // 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
    public List<Libro> GetListById()
    {
        var consulta = from l in libros
                       where l.Id > 15
                       select l;

        return consulta.ToList();
    }

    // 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros)
    public List<string> GetLibros()
    {
        // Usamos la interpolación de cadenas con :C para darle formato de moneda local de C#
        var consulta = from l in libros
                       select $"{l.Titulo} - {l.Precio:C}";

        return consulta.ToList();
    }

    // 7. Obtener el libro con el precio más alto (GetMayorPrecio)
    public Libro GetMayorPrecio()
    {
        // Primero obtenemos numéricamente cuál es el precio máximo en la lista
        decimal precioMaximo = (from l in libros select l.Precio).Max();

        // Luego buscamos el libro que coincida con ese precio máximo
        var consulta = from l in libros
                       where l.Precio == precioMaximo
                       select l;

        return consulta.First();
    }

    // 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
    public Libro GetMenorPrecio()
    {
        // Primero obtenemos numéricamente cuál es el precio mínimo en la lista
        decimal precioMinimo = (from l in libros select l.Precio).Min();

        // Luego buscamos el libro que coincida con ese precio mínimo
        var consulta = from l in libros
                       where l.Precio == precioMinimo
                       select l;

        return consulta.First();
    }

    // 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
    public List<Libro> GetMayorPromedio()
    {
        // Calculamos primero el promedio de la colección
        decimal promedio = (from l in libros select l.Precio).Average();

        // Filtramos los libros que superen dicho promedio calulado
        var consulta = from l in libros
                       where l.Precio > promedio
                       select l;

        return consulta.ToList();
    }

    // 10. Obtener los libros ordenados por título de forma descendente
    public List<Libro> GetLibrosOrdenadosPorTituloDesc()
    {
        // Como explica el libro, para el orden inverso usamos la palabra clave 'descending'
        var consulta = from l in libros
                       orderby l.Titulo descending
                       select l;

        return consulta.ToList();
    }
}

