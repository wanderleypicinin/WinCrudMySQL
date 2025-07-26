
using WinCrudMySQL.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Text;



namespace WinCrudMySQL.Forms
{
    public partial class AdicionarForm : Form
    {
        public AdicionarForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("o campo  nome é obrigatorio");
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            throw new NotImplementedException();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string query = "INSERT INTO Clientes (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";
                using (MySqlConnection connection = Database.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            //cmd.Parameteres.Add("@Nome", txtNome.Text);
                            //cmd.Parameteres.Add("@Email", txtNome.Text);
                            //cmd.Parameteres.Add("@Telefone", txtTelefone.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cliente adicionado com sucesso!");
                            Limpar();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar cliente: " + ex.Message);
                    }
                
                }
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text.Clone();
            txtTelefone.Clear();

        }
    }
}
        

    

