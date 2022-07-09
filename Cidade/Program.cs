using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string mesporextenso = null;
            string dataPrincipal;
            int codigo, dia, ano, mes;
            
            Console.WriteLine("1 – Atibaia 2 – Bragança Paulista 3 – Mairiporã 4 – Nazaré 5 – Terra Preta 6 – Extrema 7 – Vargem ");
            Console.Write("Digite o código da cidade: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("00/00/0000 Digite a data: ");
            var diaA = Convert.ToDateTime(Console.ReadLine());
            dia = diaA.Day;
            mes = diaA.Month;
            ano = diaA.Year;


            switch (mes)
            {
                case 01:
                    mesporextenso = "Janeiro";
                    break;
                case 02:
                    mesporextenso = "Fevereiro";
                    break;
                case 03:
                    mesporextenso = "Março";
                    break;
                case 04:
                    mesporextenso = "Abril";
                    break;
                case 05:
                    mesporextenso = "Maio";
                    break;
                case 06:
                    mesporextenso = "Junho";
                    break;
                case 07:
                    mesporextenso = "Julho";
                    break;
                case 08:
                    mesporextenso = "Agosto";
                    break;
                case 09:
                    mesporextenso = "Setembro";
                    break;
                case 10:
                    mesporextenso = "Outubro";
                    break;
                case 11:
                    mesporextenso = "Novembro";
                    break;
                case 12:
                    mesporextenso = "Dezembro";
                    break;
            }

            dataPrincipal = dia + " de " + mesporextenso + " de " + ano;

            if (codigo == 1)
            {
                Console.WriteLine("Atibaia, " + dataPrincipal);
            }
            if (codigo == 2)
            {
                Console.WriteLine("Bragança Paulista, " + dataPrincipal);
            }
            if (codigo == 3)
            {
                Console.WriteLine("Mairiporã, " + dataPrincipal);
            }
            if (codigo == 4)
            {
                Console.WriteLine("Nazaré, " + dataPrincipal);
            }
            if (codigo == 5)
            {
                Console.WriteLine("Terra Preta, " + dataPrincipal);
            }
            if (codigo == 6)
            {
                Console.WriteLine("Extrema, " + dataPrincipal);
            }
            if (codigo == 7)
            {
                Console.WriteLine("Vargem, " + dataPrincipal);
            }

            Console.ReadKey();
        }
    }
}
