using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormwithBardHelp
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void findBtn_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection("Data Source=SUNLYGF63\\SQLEXPRESS;Initial Catalog=SimpleData;Integrated Security=True");
            connection.Open();
            string findId = txtFindID.Text;
            var cmdfind = new SqlCommand("SELECT * FROM Customers WHERE CusId = @editID", connection);
            cmdfind.Parameters.AddWithValue("@editID", findId);
            try
            {
                var readsql = cmdfind.ExecuteReader();
                while (readsql.Read())
                {
                    txtFindName.Text = readsql["Name"].ToString();
                    txtFindAddress.Text = readsql["Address"].ToString();
                }

                }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                throw;
            }

        }

        private void updateF2Btn_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection("Data Source=SUNLYGF63\\SQLEXPRESS;Initial Catalog=SimpleData;Integrated Security=True");
            connection.Open();

            // Create a command object.
            using (var command = new SqlCommand("UPDATE Customers SET Name = @Name, Address = @Address WHERE CusId = @IDedit", connection))
            {
                // Bind the command's parameters to the form's controls.
                command.Parameters.AddWithValue("@Name", txtFindName.Text);
                command.Parameters.AddWithValue("@Address", txtFindAddress.Text);
                command.Parameters.AddWithValue("@IDedit", txtFindID.Text);

                try { command.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully updated");
                    Close();
                }
                  catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                    throw;
                }
            }
        }
    }
}
