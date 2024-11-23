using System.Data;
using Microsoft.Data.SqlClient;

namespace L1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable T = GetAllTable();


            dataGridView1.DataSource = T;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public static DataTable GetAllTable()
        {
            string DB = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=YAKOVLEVA-LAB1;Integrated Security=True";
            string Query = "select * from MyLovelyFastfoods";
            using (SqlConnection Conn = new SqlConnection(DB))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, DB);
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
        }
    
}
}
