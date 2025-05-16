using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.DTOs;
using ConsoleApp.Naruto;

namespace ConsoleApp.ReceiveLista
{
    public class ReceiveCharacters
    {
        public static int FilterElement(List<NinjaResponseDto> ninjasDto)
        {
            List<NinjaResponseDto> lista = ninjasDto.Where(x => x.Element == ElementTypeEnum.Earth).ToList();
            return lista.Count;
        }
    }
}