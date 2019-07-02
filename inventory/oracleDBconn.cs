using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace inventory
{
    class oracleDBconn
    {
      //  OracleConnection con;
        public class Connection_Query
        {

            
           public OracleConnection con = null;
           public string ConnectionString = "Data Source=localhost:1521/XE; User ID=admin; Password=admin";


            public void OpenConection()
            {
                con = new OracleConnection(ConnectionString);
                try { con.Open(); }
                catch(Exception expr) { }
            }


            public void CloseConnection()
            {
                con.Close();
            }


            public bool ExecuteQueries(string Query_)
            {
                OracleCommand cmd = new OracleCommand(Query_, con);
                cmd.ExecuteNonQuery();
                return true;
            }

            public OracleDataReader DataReader(string Query_)
            {
                OracleCommand cmd = new OracleCommand(Query_, con);
                OracleDataReader dr = cmd.ExecuteReader();
                return dr;
            }


           /* public object ShowDataInGridView(string Query_)
            {
                OracleDataAdapter dr = new OracleDataAdapter(Query_, ConnectionString);
                DataTable ds = new DataTable();
                dr.Fill(ds);
                object dataum = ds.Tables[0];
                return dataum;
            }*/
        }
    }
}
