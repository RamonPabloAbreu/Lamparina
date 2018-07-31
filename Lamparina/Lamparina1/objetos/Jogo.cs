using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Lamparina1.recursos;

namespace Lamparina1.objetos
{
    public class Jogo
    {
        public static PosicaoFactory pos = new PosicaoFactory();
        ConsoleKey botaoApertado = new ConsoleKey();
        Hud hud = new Hud();
        public static Mapa mapa = new Mapa();
        public Personagem personagem = new Personagem();
        List<Posicao> chaves = new List<Posicao>();
        bool teveMovimento = true;
        public bool endgame = false;

        public void StartGame()
        {
            Console.CursorVisible = false;
            personagem.x = 1;
            personagem.y = 1;

            DesenharTela();

            hud.rodando = true;
            Thread threadHud = new Thread(new ThreadStart(hud.MascaraDaHud));
            threadHud.Start();

            while (botaoApertado != ConsoleKey.Escape){
                botaoApertado = Console.ReadKey().Key;
                ProcessarMovimento(botaoApertado);
                if (teveMovimento)
                {
                    DesenharTela();
                    Console.CursorVisible = false;
                    teveMovimento = false;
                }
            }
            hud.rodando = false;
        }

        public void ProcessarMovimento(ConsoleKey botaoApertado)
        {
            int moveX = 0;
            int moveY = 0;
            switch (botaoApertado)
            {
                case ConsoleKey.LeftArrow:
                    moveX = -1;
                    teveMovimento = true;
                    break;
                case ConsoleKey.RightArrow:
                    moveX = 1;
                    teveMovimento = true;
                    break;
                case ConsoleKey.UpArrow:
                    moveY = -1;
                    teveMovimento = true;
                    break;
                case ConsoleKey.DownArrow:
                    moveY = 1;
                    teveMovimento = true;
                    break;
                case ConsoleKey.R:
                    hud = new Hud();
                    mapa = new Mapa();
                    personagem = new Personagem();
                    chaves = new List<Posicao>();
                    this.StartGame();
                    break;
                default:
                    teveMovimento = false;
                    break;
            }
            if (teveMovimento)
            {
                int newX = personagem.x + moveX;
                int newY = personagem.y + moveY;
                switch (mapa.Grid[newY, newX].tipo)
                {
                    case "caminho":
                        if (!personagem.rastro)
                        {
                            personagem.x = newX;
                            personagem.y = newY;
                        }
                        else
                        {
                            mapa.Grid[newY, newX] = pos.novo("rastro", personagem.posicao.Cor);
                            personagem.x = newX;
                            personagem.y = newY;
                        }
                        break;
                    case "parede":
                        teveMovimento = false;
                        break;
                    case "rastro":
                        personagem.x = newX;
                        personagem.y = newY;
                        break;
                    case "chave":
                        if (personagem.posicao.Cor == mapa.Grid[newY, newX].Cor)
                        {
                            chaves.Add(mapa.Grid[newY, newX]);
                            mapa.Grid[newY, newX] = pos.novo("caminho");
                        }
                        personagem.x = newX;
                        personagem.y = newY;
                        break;
                    case "porta":
                        if (AbrePorta(mapa.Grid[newY, newX]))
                        {
                            personagem.x = newX;
                            personagem.y = newY;
                        }
                        else
                        {
                            teveMovimento = false;
                        }
                        break;
                    case "mudacor":
                        personagem.posicao.Cor = mapa.Grid[newY, newX].Cor;
                        personagem.x = newX;
                        personagem.y = newY;
                        break;
                    case "passagem":
                        if (!personagem.rastro)
                        {
                            if (personagem.posicao.Cor == mapa.Grid[newY, newX].Cor)
                            {
                                //mapa.Grid[newY, newX] = pos.novo("caminho");
                                personagem.x = newX;
                                personagem.y = newY;
                            }
                            else
                            {
                                teveMovimento = false;
                            }
                        }
                        else
                        {
                            if (personagem.posicao.Cor == mapa.Grid[newY, newX].Cor)
                            {
                                mapa.Grid[newY, newX] = pos.novo("rastro", personagem.posicao.Cor);
                                personagem.x = newX;
                                personagem.y = newY;
                            }
                            else
                            {
                                teveMovimento = false;
                            }

                        }
                        break;
                    case "coleta":
                        if (personagem.posicao.Cor == mapa.Grid[newY, newX].Cor)
                        {
                            personagem.rastro = true;
                            mapa.Grid[newY, newX] = pos.novo("rastro", personagem.posicao.Cor);
                            personagem.x = newX;
                            personagem.y = newY;
                        }
                        else
                        {
                            personagem.x = newX;
                            personagem.y = newY;
                        }
                        break;
                    case "entrega":
                        if (personagem.posicao.Cor == mapa.Grid[newY, newX].Cor && personagem.rastro)
                        {
                            chaves.Clear();
                            mapa.Grid[newY, newX] = pos.novo("rastro", personagem.posicao.Cor);
                            personagem.rastro = false;
                            if (mapa.Grid[newY, newX].Cor == mapa.Grid[11, 13].Cor)
                            {
                                mapa.Grid[11, 13] = pos.novo("caminho");
                            }
                            if (mapa.Grid[newY, newX].Cor == mapa.Grid[11, 27].Cor)
                            {
                                mapa.Grid[11, 27] = pos.novo("caminho");
                            }
                            if (mapa.Grid[newY, newX].Cor == mapa.Grid[11, 41].Cor)
                            {
                                mapa.Grid[11, 41] = pos.novo("caminho");
                            }
                            if (mapa.Grid[newY, newX].Cor == mapa.Grid[12, 55].Cor)
                            {
                                mapa.Grid[12, 55] = pos.novo("caminho");
                            }
                            personagem.x = newX;
                            personagem.y = newY;
                        }
                        else
                        {
                            teveMovimento = false;
                        }
                        break;
                    case "portãofase":
                        teveMovimento = false;
                        break;
                    case "bônus":
                        hud.pontos = +500;
                        mapa.Grid[newY, newX] = pos.novo("caminho");
                        personagem.x = newX;
                        personagem.y = newY;
                        break;
                    case "endgame":
                        mapa.Grid[newY, newX] = pos.novo("caminho");
                        personagem.x = newX;
                        personagem.y = newY;
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("PARABÉNS!!! Você concluiu o Lamparina");
                        Console.WriteLine("sua pontuação foi de {0}. Com um tempo de sobra de {1}{2}", hud.pontos, hud.minutos, hud.segundos);
                        Console.WriteLine("Aperte esc para sair !", hud.pontos, hud.minutos, hud.segundos);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }

        void DesenharTela()
        {
            int x, y, a;
            int numLinha = 3; // espaçamento da HUD

            //Cria uma copia zerada do mapa
            Mapas temp = new Mapas();
            Mapa mapaDesenho = new Mapa(mapa.Grid);

            var originalColor = Console.ForegroundColor;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("PONTUAÇÃO: {0}    TEMPO: {1}:{2}", hud.pontos, hud.minutos, hud.segundos);
            Console.SetCursorPosition(0, 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, 1);
            Console.Write("CHAVES: ");

            for (a = 0; a < chaves.Count(); a++)
            {
                Console.ForegroundColor = chaves[a].Cor;
                Console.Write(chaves[a].caractere.ToString());
                Console.Write(" ");
            }
            Console.ForegroundColor = originalColor;
            for (x = 0; x < mapaDesenho.Grid.GetLength(0); x++)
            {
                Console.SetCursorPosition(0, numLinha);
                for (y = 0; y < mapaDesenho.Grid.GetLength(1); y++)
                {
                    if (y == personagem.x && x == personagem.y)
                    {
                        Console.ForegroundColor = personagem.posicao.Cor;
                        Console.Write(personagem.posicao.caractere.ToString());
                    }
                    else
                    {
                        Console.ForegroundColor = mapaDesenho.Grid[x, y].Cor;
                        Console.Write(mapaDesenho.Grid[x, y].GetChar().ToString());
                    }
                }
                numLinha++;

            }
            Console.CursorVisible = false;
            Console.ForegroundColor = originalColor;
        }

        bool AbrePorta(Posicao porta)
        {
            int a;
            for (a = 0; a < chaves.Count(); a++)
            {
                if (chaves[a].Cor == porta.Cor)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
