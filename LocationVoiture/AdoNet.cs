using System;
using System.Data.SqlClient;
using System.Data;
namespace LocationVehicule
{
    public class AdoNet
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private SqlDataAdapter adapterVehicule;
        //adapterVehicule
        private SqlDataReader reader;
        private string connectionstr;
        private DataTable dtLocation;
        private DataTable dtVehicule;
        private DataSet dsLocation;


        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public SqlDataAdapter AdapterVehicule { get => adapterVehicule; set => adapterVehicule = value; }
        public string ConnectionStr { get => connectionstr; }
        public DataTable DtLocation { get => dtLocation; set => dtLocation = value; }
        public DataSet Dslocation { get => dsLocation; set => dsLocation = value; }
        public DataTable DtVehicule { get => dtVehicule; set => dtVehicule = value; }


        public AdoNet()
        {
            connectionstr = "Data Source=jihedordi;Initial Catalog=LocationVoiture;Integrated Security=True";
            Conn = new SqlConnection(connectionstr);
            Cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            // adapterVehicule = new SqlDataAdapter();
            dsLocation = new DataSet();
            dtLocation = new DataTable();
            DtVehicule = new DataTable();

        }


    }

}
