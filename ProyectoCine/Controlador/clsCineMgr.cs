using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;


namespace Controlador
{
    public class clsCineMgr
    {
        Cine objCine = new Cine();

        public DataTable reservacion(int pelicula, int sala, string fecha, string hora, bool estado)
        {
            return objCine.reservacion(pelicula,sala,fecha,hora,estado);
        }

        public DataTable cartelera()
        {
            return objCine.cartelera();
        }

        public DataTable funcion(bool estado, int pelicula, string fecha)
        {
            return objCine.funcion(estado,pelicula,fecha);
        }

        public DataTable IDfuncion(string fecha, string hora, string idsala)
        {
            return objCine.IDfuncion(fecha, hora, idsala);
        }
    }
}
