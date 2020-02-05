using System;

namespace UAM.OP.Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            VHS reproductores = new VHS();
            reproductores.FW();

           


            Listas listas = new Listas();
            listas.iNSERTAR(reproductores);

           listas.iNSERTAR(new DVD(1, "DVD"));
            listas.iNSERTAR(new Netflix() {Id=1,Nombre="Ntflix" });

            //Console.WriteLine(listas[0].);


            var item = listas.Buscar(0);
            //para poder validar las opciones de que el objeto es esta encapsulado, polimorfismo
            if (item is VHS) {

                Console.WriteLine(((VHS)item).Id);
            }
            

            Console.ReadKey();



        }
    }
}
