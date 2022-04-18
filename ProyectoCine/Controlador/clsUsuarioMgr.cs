using System;
using Modelo;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class clsUsuarioMgr
    {
        Conexion objconexion = new Conexion();

        public bool Validar(string usuario, string contraseña)
        {
            return objconexion.validar(usuario, contraseña);
        }

        public DataTable EjecutaQueryID(string opcion)
        {
            return objconexion.EjecutaQueryID(opcion);
        }

        public void EjecutaQuery(string opcion)
        {
            objconexion.EjecutaQuery(opcion);
        }

        public bool AlertaStock()
        {
            return objconexion.AlertaStock();
        }

        public DataTable TotalVentasHoy(string dia)
        {
            return objconexion.TotalVentasHoy(dia);
        }
        public DataTable TotalVentasMes(string mes)
        {
            return objconexion.TotalVentasMes(mes);
        }
        public DataTable CineVentasHoy(string dia)
        {
            return objconexion.CineVentasHoy(dia);
        }
        public DataTable CineVentasMes(string mes)
        {
            return objconexion.CineVentasMes(mes);
        }

    }
}
