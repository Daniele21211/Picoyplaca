using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pico_placa
{
    public class placaDAL
    {
        public static int agregar(placa pplaca) {
            int retorno = 0;
            using (SqlConnection Conn = BDcomun.Obtenerconexion())
            {
                string consulta = "INSERT INTO dbo.PicoyPlaca(Placa_Auto,fecha,hora,respuesta) VALUES (@Placa_Auto, @fecha, @hora, @respuesta)";

                using (SqlCommand comando = new SqlCommand(consulta, Conn))
                {
                    comando.Parameters.AddWithValue("@Placa_Auto", pplaca.Placa_Auto);
                    comando.Parameters.AddWithValue("@fecha", pplaca.fecha);
                    comando.Parameters.AddWithValue("@hora", pplaca.hora);
                    comando.Parameters.AddWithValue("@respuesta", pplaca.respuesta);

                    retorno = comando.ExecuteNonQuery();
                }
            }

            return retorno;
        }
    }
}
