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
using System.Media;


namespace FachaAlcohol
{
    public partial class frmMain : Form
    {
        
        SqlConnection cn=new SqlConnection("Data Source=.;Initial Catalog=Alcoholinador;Integrated Security=True");
       
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
               // MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("error: ", ex.ToString());
            }
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnModify.Visible = false;
            lblName2.Visible = false;
            cbDrinks.Visible = false;
            SqlCommand command = new SqlCommand("Select * from Drinks", cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dgvDrinks.DataSource = tabla;
            dgvDrinks.Columns[0].Visible = false;

            SqlCommand command3 = new SqlCommand("SELECT Name from Drinks", cn);
            SqlDataReader register = command3.ExecuteReader();
            while (register.Read())
            {
                cbDrinks.Items.Add(register["Name"].ToString());
            }




            SoundPlayer sound = new SoundPlayer(@"C:\Users\nacho\source\repos\FachaAlcohol\FachaAlcohol\Resources\TavernMusic.wav");
            sound.PlayLooping();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ingrese una bebida primero");
            }
            else
            {
                string query = "INSERT INTO Drinks (Name,Price,Quantity) VALUES (@name,@price,@quantity)";
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.AddWithValue("@name", txtName.Text);
                comando.Parameters.AddWithValue("@price", nudPrice.Value);
                comando.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto Insertado");

                txtName.Text = "";
                nudPrice.Value = 1;
                nudQuantity.Value = 1;


                
                








                SqlCommand command = new SqlCommand("Select * from Drinks", cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                dgvDrinks.DataSource = tabla;
                dgvDrinks.Columns[0].Visible = false;
            }
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrWhiteSpace(txtName.Name))
                //{
                //    MessageBox.Show("Seleccione bebida para eliminar");
                //}

                    

                    string query = "DELETE FROM Drinks WHERE Name=@Name";
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Producto Eliminado");
                    txtName.Text = "";
                    nudPrice.Value = 1;
                    nudQuantity.Value = 1;

                    SqlCommand command2 = new SqlCommand("Select * from Drinks", cn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command2;
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgvDrinks.DataSource = tabla;
                    dgvDrinks.Columns[0].Visible = false;
                

                
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());

                
            }
           
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrWhiteSpace(txtName.Text))
                //{
                //    MessageBox.Show("Ingrese bebida para modificar primero");
                //}

               

                string query = "UPDATE Drinks SET Name=@Name,Price=@Price,Quantity=@Quantity WHERE Name=@Name";
                    SqlCommand command3 = new SqlCommand(query, cn);
                    command3.Parameters.AddWithValue("@Name", txtName.Text);
                    command3.Parameters.AddWithValue("@Price", nudPrice.Value);
                    command3.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                    command3.ExecuteNonQuery();
                    MessageBox.Show("Acualizado");

                    txtName.Text = "";
                    nudPrice.Value = 1;
                    nudQuantity.Value = 1;

                    SqlCommand command2 = new SqlCommand("Select * from Drinks", cn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command2;
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgvDrinks.DataSource = tabla;
                    dgvDrinks.Columns[0].Visible = false;
                
                
               


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo modificar", ex.ToString());
            }
           
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtName.Visible = true;
            lblName.Visible = true;
            lblName2.Visible = false;
            cbDrinks.Visible = false;
            btnAdd.Visible = true;
            lblPrice.Visible = true;
            lblQuantity.Visible = true;
            nudPrice.Visible = true;
            nudQuantity.Visible = true;
            btnModify.Visible = false;
            btnDelete.Visible = false;
            lblName2.Visible = false;
            cbDrinks.Visible = false;


        }

        private void rbModify_CheckedChanged(object sender, EventArgs e)
        {
            cbDrinks.DataSource = null;
            cbDrinks.Items.Clear();
            SqlCommand command3 = new SqlCommand("SELECT Name from Drinks", cn);
            SqlDataReader register = command3.ExecuteReader();
            
            while (register.Read())
            {
                cbDrinks.Items.Add(register["Name"].ToString());
            }
            register.Close();
            lblName.Visible = false;
            txtName.ReadOnly = true;
            txtName.Visible = false;
            lblName2.Visible = true;
            cbDrinks.Visible = true;
            btnModify.Visible = true;
            lblPrice.Visible = true;
            lblQuantity.Visible = true;
            nudPrice.Visible = true;
            nudQuantity.Visible = true;
            btnAdd.Visible = false;
            btnDelete.Visible = false;

           

        }

        private void rbDelete_CheckedChanged(object sender, EventArgs e)
        {
            cbDrinks.DataSource = null;
            cbDrinks.Items.Clear();
            SqlCommand command3 = new SqlCommand("SELECT Name from Drinks", cn);
            SqlDataReader register = command3.ExecuteReader();
            while (register.Read())
            {
                cbDrinks.Items.Add(register["Name"].ToString());
            }
            register.Close();
            lblName.Visible = false;
            txtName.ReadOnly = true;
            txtName.Visible = false;
            lblName2.Visible = true;
            cbDrinks.Visible = true;
            btnDelete.Visible = true;
            lblPrice.Visible = false;
            lblQuantity.Visible = false;
            btnAdd.Visible = false;
            btnModify.Visible = false;
            nudPrice.Visible = false;
            nudQuantity.Visible = false;
            
        }

        private void cbDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDrinks.SelectedIndex;
            txtName.Text = cbDrinks.Items[index].ToString();
        }

        private void dgvDrinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
