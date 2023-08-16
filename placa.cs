using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pico_placa
{
    public class placa
    {
        public int id { get; set; }
        public string Placa_Auto { get; set; } 
        public string fecha { get; set; }
        public string hora { get; set; }
        public string respuesta { get; set; }


        public placa() { }
        public placa(Int32 pid,string pPlaca_Auto,string pfecha,string phora,string prespuesta)
        {

            this.id = pid;
            this.Placa_Auto= pPlaca_Auto;
            this.fecha = pfecha;
            this.hora=phora;
            this.respuesta = prespuesta;
        }


    }
}
