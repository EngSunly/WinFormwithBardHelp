using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace WinFormwithBardHelp
{
    public partial class SqlCustomer : Form
    {
        public SqlCustomer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Load(sender, e, txtName);
        }

        private void Form1_Load(object sender, EventArgs e, TextBox txtName)
        {
            reloadFORM();

        }

        public void reloadFORM()
        {
            // Create a connection to the database.
            using (var connection = new SqlConnection("Data Source=SUNLYGF63\\SQLEXPRESS;Initial Catalog=SimpleData;Integrated Security=True"))
            {
                // Open the connection.
                connection.Open();

                // Create a command object.
                using (var command = new SqlCommand("SELECT * FROM Customers", connection))
                {
                    Display.Rows.Clear();
                    // Execute the command.
                    var reader = command.ExecuteReader();

                    // Populate the form's controls with the data from the database.
                    while (reader.Read())
                    {
                        var cuss = new clCustomer();

                        /* txtCusId.Text = reader["CusId"].ToString();
                         txtName.Text = reader["Name"].ToString();
                         txtAddress.Text = reader["Address"].ToString();*/

                        cuss.clCusId = int.Parse(s: reader["CusId"].ToString());
                        cuss.clName = reader["Name"].ToString();
                        cuss.clAddress = reader["Address"].ToString();

                        Display.Rows.Add(cuss.clCusId, cuss.clName, cuss.clAddress);
                    }
                }
            }
        }
        public class clCustomer
        {
            public int clCusId { get; set; }
            public string clName { get; set; }
            public string clAddress { get; set; }
        }
        private void insert_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection("Data Source=SUNLYGF63\\SQLEXPRESS;Initial Catalog=SimpleData;Integrated Security=True"))
            {
                // Open the connection.
                connection.Open();

                // Create a command object.
                using (var command = new SqlCommand("INSERT INTO Customers (CusId, Name, Address) VALUES (@CusId,@Name, @Address)", connection))
                {
                    // Bind the command's parameters to the form's controls.
                    command.Parameters.AddWithValue("@CusId", txtCusId.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);

                    // Execute the command.
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("succesfully inserted");
                        txtCusId.Clear();
                        txtName.Clear();
                        txtAddress.Clear();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                reloadFORM();
            }
        }

        private void ReloadBTN_Click(object sender, EventArgs e)
        {
            reloadFORM();
        }

        private void update_Click(object sender, EventArgs e)
        {
            EditForm form2 = new EditForm();
            form2.ShowDialog();
            reloadFORM();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection("Data Source=SUNLYGF63\\SQLEXPRESS;Initial Catalog=SimpleData;Integrated Security=True");
            connection.Open();
            string delId = txtDelete.Text;

            SqlCommand delcmd = new SqlCommand("DELETE FROM Customers WHERE CusId = @delId", connection);
            delcmd.Parameters.AddWithValue("@delId", delId);
            try
            {
                delcmd.ExecuteNonQuery();
                MessageBox.Show("Success deleted");
                reloadFORM();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        //create cellclick event
        private void Display_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Display.Rows[e.RowIndex];
                txtCusId.Text = row.Cells["CID"].Value.ToString();
                txtName.Text = row.Cells["CName"].Value.ToString();
                txtAddress.Text = row.Cells["CAddress"].Value.ToString();
            }
        }

    }
}