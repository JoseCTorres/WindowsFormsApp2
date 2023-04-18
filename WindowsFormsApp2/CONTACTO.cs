using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class CONTACTO : PERSONAS
    {
        private string telefono;
        private string Correo;
        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }
        public string correo
        {
            get { return Correo; }
            set
            {
                Correo = value;
            }
        }


        public CONTACTO() : base()
        {
            telefono = string.Empty;
            Correo = string.Empty;
        }
        public CONTACTO(string nombre, DateTime? fechaNacimiento, string telefono , string Correo) : base(nombre, fechaNacimiento )
        {
            this.telefono = telefono;
            this.Correo = Correo;
        }

        public override string ToString()
        {
            return base.ToString() + " " + telefono + " "+ Correo;
        }
    }
}
