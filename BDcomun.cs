using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace pico_placa
{
    public class BDcomun
    {
        public static SqlConnection Obtenerconexion()
        {
            string connectionString = "Data Source=DESKTOP-P0E39IM\\SQLEXPRESS;Initial Catalog=PicoyPlaca;User Id=sa; Password=2872";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }
    }
}
