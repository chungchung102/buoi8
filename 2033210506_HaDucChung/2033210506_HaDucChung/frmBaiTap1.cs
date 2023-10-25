using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _2033210506_HaDucChung
{
    public partial class frmBaiTap1 : Form
    {
        string _connectionString = "server=.; database=QL_SINHVIEN;integrated security=true";
        private  SqlConnection connect;
        public frmBaiTap1()
        {
            InitializeComponent();

        }

        private  void btn1_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(_connectionString);
            try
            {
                connect = new SqlConnection(_connectionString);

                connect.Open();
                MessageBox.Show("ket noi thanh cong");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var sql = "select *from SINHVIEN";
            var command = new SqlCommand(sql, connect);
            SqlDataReader data = command.ExecuteReader();
            var name = "";
            var id = " ";
            while(data.Read())
            {
                name = data["name"].ToString();
                id = data["id"].ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                string updateString = "update SINHVIEN set ID = " + 10 + "  where ID = " + 1 + "";
                SqlCommand cmd = new SqlCommand(updateString, connect);
                cmd.ExecuteNonQuery();
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
                MessageBox.Show("thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteString = "delete SINHVIEN where ID = " + 10 + " ";
                SqlCommand cmd = new SqlCommand(deleteString, connect);
                cmd.ExecuteNonQuery();
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
                MessageBox.Show("thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai");
            }
        }

        
        
      }
}
