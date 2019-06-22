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
            DialogResult option;
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Debe desconectarse", "Sistema administrativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            option = MessageBox.Show("Desea salir de la aplicación", "Sistema administrativo", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (option == DialogResult.Yes) { this.Close(); }
        }

        private void Btn_conn_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "server = " + txt_host.Text + "; database = " + txt_db.Text + "; uid = " + txt_user.Text + "; pwd = " + txt_pass.Text + ";";
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion Exitosa" , "Sistema administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema administrativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Sistema administrativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
