using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamparina1.recursos
{
    public class Personagem
    {
        public Posicao posicao;
        public int x;
        public int y;
        public bool rastro = false;

        public Personagem() {
            posicao = new Posicao("personagem");
        }
    }
}
