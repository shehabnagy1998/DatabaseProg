using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Search for person using his/her ID
        private void search_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB(id_search_txt.Text, name_search_txt.Text);
            string[] arr = db.SearchRecord();
            name_search_txt.Text = arr[1];
        }
        ///

        // Insert new person to the database
        private void insert_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB(id_insert_txt.Text, name_insert_txt.Text);
            db.insertRecord();
        }
        ///

        // Update person data using her/his ID
        private void update_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB(id_update_txt.Text, name_update_txt.Text);
            db.UpdateRecord();
        }
        ///

        /// Delete person from database using his/her ID
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB(id_delete_txt.Text, name_delete_txt.Text);
            db.DeleteRecord();
        }
        ///

        // Check the connection to the database
        private void Form1_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            con_lbl.Text = db.checkConntection();
        }
        ///

        // Close the program and its enviroment
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        


    }
}
