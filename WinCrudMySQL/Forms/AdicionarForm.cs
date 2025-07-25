
using WinCrudMySQL.Data;
using MySql.Data.MySqlClient;



namespace WinCrudMySQL.Forms
{
    public partial class AdicionarForm : Form
    {
        public AdicionarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string query = "INSERT INTO Clientes (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";
                using (MyConnection connection = Database.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (MySqlConnection cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameteres.Add("@Nome", txtNome.Text);
                            cmd.Parameteres.Add("@Email", txtNome.Text);
                            cmd.Parameteres.Add("@Telefone", txtTelefone.Text);
                            cmd.ExecuteNomeQuery();
                            MessageBox.Show("Cliente adicionado com sucesso!");
                            LimparCampos();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao adicionar cliente: " + ex.Message);


                    }
                }
            }
        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                return false;
            }
            return true;

        private void LimparCampos()
        {
            throw new NotImplementedException();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

