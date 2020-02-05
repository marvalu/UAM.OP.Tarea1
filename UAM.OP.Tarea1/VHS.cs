using System;
using System.Collections.Generic;
using System.Text;

namespace UAM.OP.Tarea1
{
    class VHS : IReproductores
    {


        private int _id;
        private String _nombre;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Id { get => _id; set => _id = value; }

        public void FW()
        {
            Console.WriteLine("{0} - Play", _nombre); 
        }

        public void Play()
        {
            Console.WriteLine("{0} - FW", _nombre);
        }

        public void RW()
        {
            Console.WriteLine("{0} - RW", _nombre);
        }

        public void Stop()
        {
            Console.WriteLine("{0} - stop", _nombre);
        }
    }
}
