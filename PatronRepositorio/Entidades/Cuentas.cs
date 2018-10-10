using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
   public class Cuentas
    {
        [key]
        public int CuentaID { get; set; }
        public string Descripcion { get; set; }

        public Cuentas()
        {
            CuentaID = 0;
            Descripcion = string.Empty;
        }

    }
}
