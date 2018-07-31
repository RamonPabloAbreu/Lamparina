using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using Lamparina1.objetos;

namespace Lamparina
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.SetWindowSize(120, 26);
            Tutorial();
            Console.Clear();
            Jogo novoJogo = new Jogo();
            novoJogo.StartGame();
            Environment.Exit(0);
        }

        public static void Tutorial()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Bem vindo ao Lamparina!!");
            Console.WriteLine("Você é uma energia disposta em um circuíto.");
            Console.WriteLine("Seu objetivo é conectar fontes de poder(¤) à receptáculos(×) para que possa prosseguir pelo mapa até alcançar uma saída(§).");
            Console.WriteLine("Para isso vocÊ deve resolver uma série de puzzles que contarão com os seguintes elementos:");
            Console.WriteLine("Pontos de mudança de voltagem (█): São aonde vocÊ pode mudar sua voltagem (representada pela cor) para acessar diferentes lugares do mapa e interagir com chaves (╬) e fontes de energia");
            Console.WriteLine("Passagens (¦): São barreiras que limitam seu movimento a não ser que você tenha a mesma voltagem (cor) delas.");
            Console.WriteLine("Chaves (╬): São intens que você coleta pelo jogo, sua função é liberar sua passagem por portas (┼). Para coletar uma chave você precisa ter a mesma voltagem (cor) dela.");
            Console.WriteLine("Portas (┼): Funcionam como bloqueios que impedem seu avanço, independente de sua voltagem (cor). Para liberar uma porta você precisa de sua respectiva chave.");
            Console.WriteLine("Créditos (¥): Aumentam sua pontução.");
            Console.WriteLine("Saída (§): É o seu objetivo final. Chegando á ele você termina o jogo !");
            Console.WriteLine("Preparado?");
            Console.ReadKey();
        }
    }
}

