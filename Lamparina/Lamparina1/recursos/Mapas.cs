﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamparina1.recursos
{
    public class Mapas
    {
        public static PosicaoFactory pos = new PosicaoFactory();
        public Posicao[,] mapa1 = new Posicao[,]
        {
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("levelend"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede"),pos.novo("parede"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("caminho"),pos.novo("parede") },
            { pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede"),pos.novo("parede") },
        };

        public Posicao[,] getMapa1()
        {
            mapa1[1, 4] = pos.novo("mudacor",ConsoleColor.Green);
            mapa1[1, 20] = pos.novo("mudacor", ConsoleColor.Blue);
            mapa1[4, 1] = pos.novo("mudacor", ConsoleColor.Magenta);
            mapa1[4, 7] = pos.novo("mudacor", ConsoleColor.Yellow);
            mapa1[2, 9] = pos.novo("passagem", ConsoleColor.Green);
            mapa1[7, 1] = pos.novo("passagem", ConsoleColor.Blue);
            mapa1[8, 22] = pos.novo("passagem", ConsoleColor.Magenta);
            mapa1[1, 17] = pos.novo("chave", ConsoleColor.Green);
            mapa1[1, 27] = pos.novo("chave", ConsoleColor.Yellow);
            mapa1[4, 2] = pos.novo("porta", ConsoleColor.Green);
            mapa1[9, 22] = pos.novo("porta", ConsoleColor.Yellow);
            mapa1[5, 27] = pos.novo("coleta", ConsoleColor.Blue);
            mapa1[10, 4] = pos.novo("entrega", ConsoleColor.Blue);
            mapa1[9, 24] = pos.novo("bônus");
            mapa1[11, 13] = pos.novo("portãofase", ConsoleColor.Blue);

            mapa1[17, 1] = pos.novo("mudacor", ConsoleColor.Green);
            mapa1[12, 9] = pos.novo("mudacor", ConsoleColor.Blue);
            mapa1[21, 1] = pos.novo("mudacor", ConsoleColor.Cyan);
            mapa1[21, 10] = pos.novo("mudacor", ConsoleColor.Yellow);
            mapa1[16, 20] = pos.novo("passagem", ConsoleColor.Cyan);
            mapa1[17, 27] = pos.novo("chave", ConsoleColor.Green);
            mapa1[19, 1] = pos.novo("chave", ConsoleColor.Yellow);
            mapa1[15, 17] = pos.novo("chave", ConsoleColor.Blue);
            mapa1[14, 18] = pos.novo("chave", ConsoleColor.Cyan);
            mapa1[20, 8] = pos.novo("porta", ConsoleColor.Green);
            mapa1[17, 2] = pos.novo("porta", ConsoleColor.Yellow);
            mapa1[21, 11] = pos.novo("porta", ConsoleColor.Blue);
            mapa1[21, 24] = pos.novo("porta", ConsoleColor.Cyan);
            mapa1[15, 27] = pos.novo("coleta", ConsoleColor.Cyan);
            mapa1[12, 20] = pos.novo("entrega", ConsoleColor.Cyan);
            mapa1[21, 27] = pos.novo("bônus");
            mapa1[11, 27] = pos.novo("portãofase", ConsoleColor.Cyan);

            mapa1[7, 52] = pos.novo("mudacor", ConsoleColor.Green);
            mapa1[12, 9] = pos.novo("mudacor", ConsoleColor.Blue);
            mapa1[9, 32] = pos.novo("mudacor", ConsoleColor.Cyan);
            mapa1[2, 31] = pos.novo("mudacor", ConsoleColor.Magenta);
            mapa1[8, 48] = pos.novo("mudacor", ConsoleColor.Yellow);
            mapa1[1, 55] = pos.novo("mudacor", ConsoleColor.Red);
            mapa1[2, 38] = pos.novo("passagem", ConsoleColor.Green);
            mapa1[9, 39] = pos.novo("chave", ConsoleColor.Red);
            mapa1[8, 37] = pos.novo("chave", ConsoleColor.Yellow);
            mapa1[9, 26] = pos.novo("chave", ConsoleColor.Magenta);
            mapa1[1, 40] = pos.novo("chave", ConsoleColor.Cyan);
            mapa1[2, 32] = pos.novo("porta", ConsoleColor.Red);
            mapa1[5, 49] = pos.novo("porta", ConsoleColor.Yellow);
            mapa1[5, 51] = pos.novo("porta", ConsoleColor.Magenta);
            mapa1[1, 54] = pos.novo("porta", ConsoleColor.Cyan);
            mapa1[7, 40] = pos.novo("coleta", ConsoleColor.Green);
            mapa1[10, 34] = pos.novo("entrega", ConsoleColor.Green);
            mapa1[1, 38] = pos.novo("bônus");
            mapa1[11, 41] = pos.novo("portãofase", ConsoleColor.Green);

            mapa1[12, 40] = pos.novo("mudacor", ConsoleColor.Green);
            mapa1[21, 43] = pos.novo("mudacor", ConsoleColor.Blue);
            mapa1[20, 29] = pos.novo("mudacor", ConsoleColor.Cyan);
            mapa1[21, 32] = pos.novo("mudacor", ConsoleColor.Magenta);
            mapa1[21, 38] = pos.novo("mudacor", ConsoleColor.Yellow);
            mapa1[21, 55] = pos.novo("mudacor", ConsoleColor.Red);
            //mapa1[15, 54] = pos.novo("passagem", ConsoleColor.Green);
            mapa1[21, 39] = pos.novo("porta", ConsoleColor.Magenta);
            mapa1[20, 43] = pos.novo("passagem", ConsoleColor.Blue);
            mapa1[15, 35] = pos.novo("passagem", ConsoleColor.Cyan);
            mapa1[19, 53] = pos.novo("chave", ConsoleColor.Red);
            mapa1[17, 31] = pos.novo("chave", ConsoleColor.Yellow);
            mapa1[18, 34] = pos.novo("chave", ConsoleColor.Magenta);
            mapa1[16, 35] = pos.novo("chave", ConsoleColor.Cyan);
            mapa1[21, 37] = pos.novo("chave", ConsoleColor.Blue);
            mapa1[16, 29] = pos.novo("chave", ConsoleColor.Green);
            mapa1[21, 36] = pos.novo("porta", ConsoleColor.Red);
            mapa1[17, 41] = pos.novo("porta", ConsoleColor.Red);
            mapa1[21, 44] = pos.novo("porta", ConsoleColor.Yellow);
            mapa1[20, 49] = pos.novo("porta", ConsoleColor.Magenta);
            mapa1[17, 54] = pos.novo("porta", ConsoleColor.Magenta);
            mapa1[21, 33] = pos.novo("porta", ConsoleColor.Cyan);
            mapa1[20, 55] = pos.novo("porta", ConsoleColor.Green);
            mapa1[17, 39] = pos.novo("porta", ConsoleColor.Blue);
            mapa1[19, 29] = pos.novo("porta", ConsoleColor.Blue);
            mapa1[17, 40] = pos.novo("coleta", ConsoleColor.Yellow);
            mapa1[12, 53] = pos.novo("entrega", ConsoleColor.Yellow);
            mapa1[21, 40] = pos.novo("bônus");
            mapa1[12, 55] = pos.novo("portãofase", ConsoleColor.Yellow);
            mapa1[3, 55] = pos.novo("endgame");



            return mapa1;
        }
    }
}