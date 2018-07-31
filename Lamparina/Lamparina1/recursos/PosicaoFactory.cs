using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamparina1.recursos
{
    public class PosicaoFactory
    {
        public PosicaoFactory() { }
        public Posicao novo(string tipo)
        {
            Posicao posicao = new Posicao(tipo);
            return posicao;
        }
        public Posicao novo(string tipo, ConsoleColor cor)
        {
            Posicao posicao = new Posicao(tipo,cor);
            return posicao;
        }
    }
}
