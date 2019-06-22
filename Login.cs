using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace connect_mysql
{
    public partial class Login : Form
    {
        private MySqlConnection conexion = new MySqlConnection();

        public Login()
        {
            InitializeComponent();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            this.CenterToScreen();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_conn_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server = " + txt_host.Text + "; database = " + txt_db.Text + "; uid = " + txt_user.Text + "; pwd = " + txt_pass.Text + ";";
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Btn_disc_Click(object sender, EventArgs e)
        {
            try
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    conexion.Dispose();
                    MessageBox.Show("Descconeccion Exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
