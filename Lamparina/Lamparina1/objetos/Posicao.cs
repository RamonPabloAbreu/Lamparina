using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamparina1.recursos
{
    public class Posicao
    {
        public string tipo { set; get; }
        public ConsoleColor Cor { set; get; }
        public bool bloqueado { set; get; }
        public char caractere { set; get; }
        
        public Posicao() { }
        public Posicao(string tipo)
        {
            SetTipo(tipo);
        }
        public Posicao(string tipo, ConsoleColor cor)
        {
            SetTipo(tipo);
            Cor = cor;
        }
        public void SetTipo(string txt)
        {
            tipo = txt;
            switch (txt)
            {
                case "personagem":
                    caractere = '*';
                    Cor = ConsoleColor.White;
                    break;
                case "parede":
                    caractere = '█';
                    Cor = ConsoleColor.Gray;
                    bloqueado = true;
                    break;
                case "rastro":
                    caractere = '░';
                    Cor = ConsoleColor.Gray;
                    bloqueado = false;
                    break;
                case "mudacor":
                    caractere = '█';
                    bloqueado = false;
                    Cor = ConsoleColor.Gray;
                    break;
                case "levelend":
                    caractere = '#';
                    bloqueado = true;
                    Cor = ConsoleColor.White;
                    break;
                case "caminho":
                    caractere = ' ';
                    break;
                case "passagem":
                    caractere = '¦';
                    bloqueado = true;
                    Cor = ConsoleColor.Gray;
                    break;
                case "chave":
                    caractere = '╬';
                    bloqueado = false;
                    Cor = ConsoleColor.Gray;
                    break;
                case "porta":
                    caractere = '┼';
                    bloqueado = true;
                    Cor = ConsoleColor.Gray;
                    break;
                case "coleta":
                    caractere = '¤';
                    Cor = ConsoleColor.Gray;
                    break;
                case "entrega":
                    caractere = '×';
                    bloqueado = true;
                    Cor = ConsoleColor.Gray;
                    break;
                case "portãofase":
                    caractere = '▒';
                    bloqueado = true;
                    Cor = ConsoleColor.Blue;
                    break;
                case "bônus":
                    caractere = '¥';
                    bloqueado = false;
                    Cor = ConsoleColor.Gray;
                    break;
                case "endgame":
                    caractere = '§';
                    bloqueado = false;
                    Cor = ConsoleColor.White;
                    break;
                default:
                    break;
            }
        }
        public char GetChar()
        {
            return caractere;
        }
    }
}
