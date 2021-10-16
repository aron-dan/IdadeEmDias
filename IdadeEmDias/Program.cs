using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodos

            int dias, diasresult, meses, anos, varAux;
             

            //entrad

            Console.WriteLine("digite quantos dias de vida ja viveu:");
            dias = int.Parse(Console.ReadLine());

            //processamento

            anos = (dias / 365);
            dias -= anos * 365;
            //meses = (dias / 30) - (anos * 12); 
            meses = dias / 30;
            dias -= meses * 30;
            //varAux = ((meses * 30) + (anos * 365));
            //diasresult = dias - varAux;
            diasresult = dias;


            //anos = dias / 365;

            //saida

            Console.WriteLine("a idade é " + anos.ToString("F0"));
            Console.WriteLine("os meses são " + meses.ToString("F0"));
            Console.WriteLine("os dias são " + diasresult.ToString("F0"));
            Console.ReadKey();
        }
    }
}
