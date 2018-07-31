using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lamparina1.objetos
{
    public class Hud
    {
        public int pontos = 0;
        public int segundos = 59;
        public int minutos = 9;
        public bool rodando = true;
        //imprime o layout da hud
        public void MascaraDaHud()
        {

            while (rodando)
            {
                segundos--;
                if (segundos == 00)
                {
                    minutos--;
                    segundos = 60;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
