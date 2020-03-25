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

namespace GestaoStock
{
    class DAL
    {
        private string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jnmma\source\repos\GestaoStock\BaseDados.mdf;Integrated Security=True";

        public int login(string user, string pass)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand command = new SqlCommand("Select * from tbl_login where username=@username and passwd=@password", con);
                command.Parameters.AddWithValue("@username", user);
                command.Parameters.AddWithValue("@password", pass);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet dset = new DataSet();
                adapt.Fill(dset);
                con.Close();
                updateDeHLastLogin(user);
                return dset.Tables[0].Rows.Count;
            }catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro na Base de Dados: " + e.Message);
                return 0;
            }
        }

        public bool isAdmin(string user)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand command = new SqlCommand("Select * from tbl_login where username=@username and privlg=1", con);
                command.Parameters.AddWithValue("@username", user);                
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet dset = new DataSet();
                adapt.Fill(dset);
                con.Close();
                if(dset.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro na Base de Dados: " + e.Message);
                return false;
            }
            
        }

        public void updateDeHLastLogin(string user)
        {
            
            try
            {
                
                SqlConnection con = new SqlConnection(constr);
                string dat = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                string cmd = "UPDATE tbl_login set last_login='" + dat + "'" + " where username='" + user + "'";

                SqlCommand command = new SqlCommand(cmd, con);         
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                
            }catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro na Base de Dados: " + e.Message);
            }
        }

        public int userExist(string user)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand command = new SqlCommand("Select * from tbl_login where username=@username", con);
                command.Parameters.AddWithValue("@username", user);                
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet dset = new DataSet();
                adapt.Fill(dset);
                con.Close();                
                return dset.Tables[0].Rows.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro na Base de Dados: " + e.Message);
                return 0;
            }
        }

        public void inserirUser(string nome, string email, int tel, string user, string pass, int priv)
        {
            try
            {

                SqlConnection con = new SqlConnection(constr);
                string dat = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                

                SqlCommand command = new SqlCommand("INSERT INTO tbl_login VALUES (@user, @pass, @priv, '2000-1-1 00:00:00', @nome, @email, @tel)", con);

                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@priv", priv);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro na Base de Dados: " + e.Message);
            }
        }

        public DataTable preencherDGV(string cmd)
        {
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmmd = new SqlCommand(cmd, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmmd);
            da.Fill(dt);

            return dt;

        }
    }
}
