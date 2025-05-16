using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.Naruto;


namespace ConsoleApp.metodo
{
    public class ReponseMethod
    {
        public static string Respuesta(List<NarutoCharacters> listOfCharacters)
        {
            bool elementWater = listOfCharacters.Any(p => p.Element == ElementTypeEnum.Water);
            {

                if (elementWater)
                {
                    return "Hay un elemento de agua";
                }
                else
                {
                    return "No Hay un elemento de agua";
                }

            }
        }
    }
}