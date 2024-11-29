using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccesADades
    {
        private string connectionString;
        private SqlConnection conn;

        public AccesADades(string connectionString)
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings[connectionString];
            if (conf != null) connectionString = conf.ConnectionString;
            this.connectionString = connectionString;
            Connectar();
        }

        private void Connectar()
        {
            conn = new SqlConnection(connectionString);
        }

        public DataSet PortarTaula(string nomTaula)
        {
            SqlDataAdapter adapter;
            DataSet dts = new DataSet();

            string query = $"SELECT * FROM {nomTaula}";
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, nomTaula);

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string query)
        {
            SqlDataAdapter adapter;
            DataSet dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts);

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string query, string nomTaula)
        {
            SqlDataAdapter adapter;
            DataSet dts = new DataSet();

            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, nomTaula);

            conn.Close();

            return dts;
        }

        public int Actualitzar(string query, DataSet dts)
        {
            int modificats = -1;
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                modificats = adapter.Update(dts.Tables[0]);
            }

            conn.Close();

            return modificats;
        }

        public void Executa(string query)
        {
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}




