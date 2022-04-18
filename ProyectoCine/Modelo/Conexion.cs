using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Conexion
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        SqlCommand cmd = null;
        SqlDataAdapter dap = null;
        DataTable dt = new DataTable();

        public bool validar(string usuario, string contraseña)
        {
            SqlCommand cmd = new SqlCommand("sp_validar", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usu", usuario);
            cmd.Parameters.AddWithValue("@cont", contraseña);
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        clsEmpleado.idEmp = Convert.ToInt32(dt.Rows[0][0]);
                        clsEmpleado.nombre = dt.Rows[0][1].ToString();
                        clsEmpleado.apellido = dt.Rows[0][2].ToString();
                        clsEmpleado.DNI = Convert.ToInt32(dt.Rows[0][3]);
                        clsEmpleado.edad = Convert.ToInt32(dt.Rows[0][4]);
                        clsEmpleado.idCargo = Convert.ToInt32(dt.Rows[0][5]);
                        clsEmpleado.usuario = dt.Rows[0][6].ToString();
                        clsEmpleado.contraseña = dt.Rows[0][7].ToString();
                        clsEmpleado.estado = Convert.ToBoolean(dt.Rows[0][8]);
                        clsEmpleado.nomcargo = dt.Rows[0][9].ToString();
                        clsEmpleado.salario = float.Parse(dt.Rows[0][10].ToString());
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public Boolean AlertaStock()
        {
            dt = new DataTable();
            dap = new SqlDataAdapter();
            dap = new SqlDataAdapter("Select idpro, nombre, stock From Producto where stock <= 10", cn);
            cn.Open();
            dap.Fill(dt);
            cn.Close();
            if (dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void EjecutaQuery(string opcion)
        {
            cmd = new SqlCommand();

            switch (opcion)
            {
                case "RV":
                    cmd = new SqlCommand("INSERT INTO Boleta ( Tipo,Fecha,Costo,Cliente,Pago,idEmp,Efectivo,Devolucion,Hora) VALUES ('" + clsBoleta.tipo + "','" + clsBoleta.fecha + "','" + clsBoleta.Costo + "','" + clsBoleta.cliente + "','" + clsBoleta.pago + "','" + clsBoleta.idEmp + "','" + clsBoleta.Efectivo + "','" + clsBoleta.devolucion + "','" + clsBoleta.Hora + "')", cn);
                    break;
                case "RDV":
                    cmd = new SqlCommand("INSERT INTO DetalleBoleta (idPro,Cantidad,Costo,idBoleta,PrecioUnitario) VALUES ('" + clsDetalleBoleta.idpro + "','" + clsDetalleBoleta.Cantidad + "','" + clsDetalleBoleta.Costo + "','" + clsDetalleBoleta.idBoleta + "','" + clsDetalleBoleta.precioUni + "')", cn);
                    break;
                case "ASV":
                    cmd = new SqlCommand("UPDATE Producto SET stock = stock - " + clsDetalleBoleta.Cantidad + " WHERE idpro=" + clsDetalleBoleta.idpro + "", cn);
                    break;
                case "RT":
                    cmd = new SqlCommand("INSERT INTO Ticket(Fecha,Costo,Cliente,Pago,idEmp,Efectivo,Devolucion,Hora,idfun) VALUES ('"+clsTicket.fecha+ "','" + clsTicket.Costo + "','" + clsTicket.cliente + "','" + clsTicket.pago + "','" + clsTicket.idEmp + "','" + clsTicket.Efectivo + "','" + clsTicket.devolucion + "','" + clsTicket.Hora + "','" + clsTicket.idfun + "')", cn);
                    break;
                case "RDT":
                    cmd = new SqlCommand("INSERT INTO DetalleTicket(codbutaca,idticket) VALUES ('"+clsDetalleTicket.codbutaca+ "','" + clsDetalleTicket.idticket + "')", cn);
                    break;
            }
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable EjecutaQueryID(string opcion)
        {
            dt = new DataTable();
            dap = new SqlDataAdapter();

            switch (opcion)
            {
                case "IDB":
                    dap = new SqlDataAdapter("SELECT MAX(idBoleta) FROM Boleta", cn);
                    break;
                case "IDT":
                    dap = new SqlDataAdapter("SELECT MAX(idTicket) FROM Ticket", cn);
                    break;
            }
            try
            {
                cn.Open();
                dap.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public DataTable TotalVentasHoy(string Dia)
        {
            dt = new DataTable();
            dap = new SqlDataAdapter();
            dap = new SqlDataAdapter("Select SUM(Costo),COUNT(idBoleta) from Boleta where Fecha='" + Dia + "'", cn);
            try
            {
                cn.Open();
                dap.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public DataTable TotalVentasMes(string Mes)
        {
            dt = new DataTable();
            dap = new SqlDataAdapter();
            dap = new SqlDataAdapter("Select SUM(Costo),COUNT(idBoleta) from Boleta where MONTH(Fecha)='" + Mes + "'", cn);
            try
            {
                cn.Open();
                dap.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public DataTable CineVentasHoy(string Dia)
        {
            dt = new DataTable();
            dap = new SqlDataAdapter();
            dap = new SqlDataAdapter("Select SUM(Costo),COUNT(idTicket) from Ticket where Fecha='" + Dia + "'", cn);
            try
            {
                cn.Open();
                dap.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public DataTable CineVentasMes(string Mes)
        {
            dt = new DataTable();
            dap = new SqlDataAdapter();
            dap = new SqlDataAdapter("Select SUM(Costo),COUNT(idTicket) from Ticket where MONTH(Fecha)='" + Mes + "'", cn);
            try
            {
                cn.Open();
                dap.Fill(dt);
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

    }
}
