using System;
using System.Collections.Generic;
using System.Text;

namespace UAM.OP.Tarea1
{
    class Listas : ICRUD<IReproductores>
    {
        List<IReproductores> Lista = new List<IReproductores>();

        public IReproductores Buscar(int indice)
        {
            return Lista[indice];
        }

        public void Eliminar(int indice)
        {
            Lista.RemoveAt(indice);
        }

        public void iNSERTAR(IReproductores item)
        {
            Lista.Add(item);
        }
    }
}
