using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
        string id, name;
        SqlConnection cnn = new SqlConnection(@"Data Source=SHEHAB\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True;");

        public DB() {
            id = "";
            name = "";
        }

        public DB(string id, string name) {
            this.id = id;
            this.name = name;
        }

        public string checkConntection() {
            string re = "";
            try
            {
                cnn.Open();
                re = "connected";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally {
                cnn.Close();
            }
            return re;
        }

        public void insertRecord() {
            SqlCommand cmd = new SqlCommand("insert into myTable values('" + id + "', '" + name + "')", cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("inserted");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public string[] SearchRecord()
        {
            string[] arr = new string[2];
            SqlCommand cmd = new SqlCommand("select * from myTable where id='"+id+"'", cnn);
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    arr[0] = reader[0].ToString();
                    arr[1] = reader[1].ToString();
                }
                if (arr[0] == null)
                {
                    System.Windows.Forms.MessageBox.Show("person not found");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
            return arr;
        }

        public void UpdateRecord()
        {
            SqlCommand cmd = new SqlCommand("update myTable set name='"+name+"' where id='"+id+"'", cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        public void DeleteRecord()
        {
            SqlCommand cmd = new SqlCommand("delete from myTable where id='"+id+"'", cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
