using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Lamparina1.recursos;

namespace Lamparina1.objetos
{
    public class Mapa
    {
        public Posicao[,] Grid;
        public Mapa()
        {
            Mapas mapas = new Mapas();
            Grid = mapas.getMapa1();
        }
        public Mapa(Posicao[,] grid)
        {
            Grid = grid;
        }
    }
}
