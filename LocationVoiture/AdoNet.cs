using System;
using System.Data.SqlClient;
using System.Data;
namespace LocationVehicule
{
    public class AdoNet
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private SqlDataReader reader = null;
        private string connectionstr;
        private DataTable dtLocation = null;
        private DataTable dtVehicule = null;
        private DataSet dsLocation = null;
        private DataSet dsVehicule = null;


        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionStr { get => connectionstr; }
        public DataTable DtLocation { get => dtLocation; set => dtLocation = value; }
        public DataSet Dslocation { get => dsLocation; set => dsLocation = value; }
        public DataTable DtVehicule { get => dtVehicule; set => dtVehicule = value; }
        public DataSet DsVehicule { get => dsVehicule; set => dsVehicule = value; }

        //DtVehicule



        public AdoNet()
        {
            connectionstr = "Data Source=jihedordi;Initial Catalog=LocationVoiture;Integrated Security=True";
            Conn = new SqlConnection(connectionstr);
            Cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsLocation = new DataSet();
            dtLocation = new DataTable();
            dsVehicule = new DataSet();
            DtVehicule = new DataTable();


        }


    }

}
