using Microsoft.AspNetCore.Mvc;
using palindromos.Entities;
using System;
using System.Linq;
using System.Collections;
using System.Text.RegularExpressions;

namespace palindromos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
         [HttpPost]

        public string Post (Palabra dto)
        {
            string Frase = dto.Frase.Replace(" ", "").ToLower();
            string  letras;
            string ine = "";
            string mens;

            int i = Frase.Length;
            MatchCollection wordColl = Regex.Matches(dto.Frase, @"[\W]+");

            for(int x = (i - 1); x >= 0; x--)
            {
                letras = Frase.Substring(x, 1);
                ine = ine + letras;
            }

            if (Frase == ine)
            {
                mens = "es palindromio";
            }
            else
            {
                mens = "no es palindromo";
            }
            return (mens+ "\n"+"Numero de palabras:"+(wordColl.Count+1));
          
        }

    }
}
/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 2, Ejercicio 2: Palindromos
    Nombre del alumno: Erika Guadalupe Bojon Martinez 
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */