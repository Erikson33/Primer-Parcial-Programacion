using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_de_progra_2do_SEmestre
{
    class SumaVector
    {
        #region Parte1 

        // explicar por constructor
        private List<int> _Componentes;

        //constructor
        public SumaVector(List<int> Componentes)
        {
            this._Componentes = Componentes;

        }

        public SumaVector()
        {
        }
        #endregion

        public List<int> Componentes
        {
            get
            {
                return _Componentes;
            }
        }

        public int this[int i]
        {
            get { return _Componentes[i]; }
            set { _Componentes[i] = value; }
        }
        public int Dimension { get { return _Componentes.Count; } }


        public static SumaVector operator +(SumaVector v1, SumaVector v2)
        {
            return v1.Suma(v2);
        }
        public static SumaVector operator -(SumaVector v1, SumaVector v2)
        {
            return v1.Suma(v2);
        }
        public static SumaVector operator *(SumaVector v1, SumaVector v2)
        {
            return v1.Suma(v2);
        }

        public double PE(SumaVector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado            
            double resultado = 0;

            for (int i = 0; i < Dimension; i++)
            {
                //resultado.Add(this[i] + v2[i]);
                resultado += (this[i]) + (v2[i]);
            }

            return resultado;
        }

        // suma de vectores =  a la suma  de las componentes correspondientes de ambos vectos
        public SumaVector Suma(SumaVector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] + v2[i]);
            }

            return new SumaVector(resultado);
        }
        public SumaVector Resta(SumaVector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] - v2[i]);
            }

            return new SumaVector(resultado);
        }
        public SumaVector Multiplicar(SumaVector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] * v2[i]);
            }

            return new SumaVector(resultado);
        }
        public void r()
        {
            for (int i = 0; i < _Componentes.Count; i++)
            {
                Console.WriteLine(_Componentes[i]);
            }
        }
        public void recorrer()
        {
            for (int i = 0; i < _Componentes.Count; i++)
            {
                Console.WriteLine(_Componentes[i]);
            }
        }

    }
}
