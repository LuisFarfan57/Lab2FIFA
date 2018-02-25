using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{    
    public class Nodo<T>
    {
        public T info;
        public Nodo<T> Izquierda;
        public Nodo<T> Derecha;
		
		public Nodo(T datos)
		{
			info = datos;
			Izquierda = null;
			Derecha = null;
		}
    }

    public class ArbolBB<T>
    {
        public Nodo<T> Raiz;
        public List<T> nodosHoja;
        int altura;
        public ArbolBB()
        {
            Raiz = null;
        }

        public void Insertar(T datos)
        {
            Nodo<T> nuevo = new Nodo<T>(datos);            

            if (Raiz == null)
            {
                Raiz = nuevo;
            }
            else
            {
                Nodo<T> aux = Raiz;
                Nodo<T> Padre = Raiz;
                bool derecha = false;

                while (aux != null)
                {
                    Padre = aux;
                    if (nuevo.info.CompareTo(aux.info) == 1)
                    {
                        aux = aux.Derecha;
                        derecha = true;
                    }
                    else
                    {
                        aux = aux.Izquierda;
                        derecha = false;
                    }
                }

                if (derecha)
                {
                    Padre.Derecha = nuevo;
                }
                else
                {
                    Padre.Izquierda = nuevo;
                }                                
            }
        }      

        public List<T> BuscarHojas()
        {
            nodosHoja = null;            
            BuscarHojas(Raiz);
            return nodosHoja;
        }

        public void BuscarHojas(Nodo<T> aux)
        {
            if (aux != null)
            {
                if ((aux.Derecha == null)&&(aux.Izquierda == null))
                {
                    nodosHoja.Add(aux.info);
                }
                BuscarHojas(aux.Izquierda);
                BuscarHojas(aux.Derecha);
            }
        }

        public int VerAltura()
        {
            altura = 0;
            VerAltura(Raiz, altura);
            return altura;
        }

        public void VerAltura(Nodo<T> aux, int nivel)
        {
            if (aux != null)
            {
                VerAltura(aux.Izquierda, nivel + 1);
                if (nivel>altura)
                {
                    altura = nivel;
                }
                VerAltura(aux.Derecha, nivel + 1);
            }
        }

        private void InOrden(Nodo<T> nAux)
        {
            if (nAux != null)
            {
                InOrden(nAux.Izquierda);
                dt.Rows.Add(nAux.info, nAux->info.id);
                InOrden(nAux.nderecha);
            }
        }

        private void PostOrden(Nodo<T> nAux)
        {
            if (nAux != null)
            {
                InOrden(nAux.Izquierda);
                InOrden(nAux.nderecha);
                dt.Rows.Add(nAux.info, nAux->info.id);
            }
        }

        private void PreOrden(Nodo<T> nAux)
        {
            if (nAux != null)
            {
                dt.Rows.Add(nAux->info.car, nAux->info.id);
                InOrden(nAux.Izquierda);
                InOrden(nAux.Derecha);
            }
        }
    }
}
