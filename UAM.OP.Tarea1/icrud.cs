using System;
using System.Collections.Generic;
using System.Text;

namespace UAM.OP.Tarea1
{
   public interface ICRUD<T>
    {
        void iNSERTAR(T item);

        void Eliminar(int indice);

        T Buscar(int indice);

    }
}
