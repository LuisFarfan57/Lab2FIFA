﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Nodo<T>
    {
        public T info { get; set; }
        public Nodo<T> siguiente { get; set; }
        public Nodo<T> anterior { get; set; }
        public Nodo<T> Derecha { get; set; }
        public Nodo<T> Izquierda { get; set; }

        public Nodo(T Info)
        {
            info = Info;
            siguiente = null;
            anterior = null;
            Derecha = null;
            Izquierda = null;
        }
    }
}
