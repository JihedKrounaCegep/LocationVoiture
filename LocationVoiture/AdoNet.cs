using System;
using System.Data.SqlClient;
using System.Data;
namespace LocationVehicule
{
    /// <summary>
    /// classe AdoNet afin d'établir la connection avec la base de donnée
    /// </summary>
    public class AdoNet
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private SqlDataReader reader;
        private string connectionstr;
        private DataTable dtClient;
        private DataTable dtVehicule;
        private DataTable dtLocation;
        private DataSet dsLocation;


        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionStr { get => connectionstr; }
        public DataTable DtClient { get => dtClient; set => dtClient = value; }
        public DataSet Dslocation { get => dsLocation; set => dsLocation = value; }
        public DataTable DtVehicule { get => dtVehicule; set => dtVehicule = value; }
        public DataTable DtLocation { get => dtLocation; set => dtLocation = value; }

        public AdoNet()
        {
            connectionstr = "Data Source=jihedordi;Initial Catalog=LocationVoiture;Integrated Security=True";
            Conn = new SqlConnection(connectionstr);
            Cmd = new SqlCommand();
            Adapter = new SqlDataAdapter();
            Dslocation = new DataSet();
            DtLocation = new DataTable();
            DtClient = new DataTable();
            DtVehicule = new DataTable();

        }


    }

}
