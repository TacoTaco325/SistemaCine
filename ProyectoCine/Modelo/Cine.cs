using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cine
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;
        DataTable tbl = new DataTable();

        public DataTable reservacion(int pelicula, int sala, string fecha, string hora,bool estado)
        {
            using (SqlCommand cmd = new SqlCommand("sp_reservacion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idpelicula", SqlDbType.Int).Value = pelicula;
                cmd.Parameters.Add("@idsala", SqlDbType.Int).Value = sala;
                cmd.Parameters.Add("@fecha", SqlDbType.VarChar, 255).Value = fecha;
                cmd.Parameters.Add("@hora", SqlDbType.VarChar, 255).Value = hora;
                cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = estado;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }
        public DataTable cartelera()
        {
            using (SqlCommand cmd = new SqlCommand("sp_cartelera", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable funcion(bool estado, int pelicula, string fecha)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Funcion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = estado;
                cmd.Parameters.Add("@idpelicula", SqlDbType.Int).Value = pelicula;
                cmd.Parameters.Add("@fecha", SqlDbType.VarChar, 250).Value = fecha;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }

        public DataTable IDfuncion(string fecha, string hora, string idsala)
        {
            using (SqlCommand cmd = new SqlCommand("sp_idfuncion", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha", SqlDbType.VarChar, 250).Value = fecha;
                cmd.Parameters.Add("@hora", SqlDbType.VarChar, 250).Value = hora;
                cmd.Parameters.Add("@idsala", SqlDbType.VarChar,250).Value = idsala;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }
    }
}
