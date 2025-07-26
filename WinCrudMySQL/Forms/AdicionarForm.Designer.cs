namespace WinCrudMySQL.Forms
{
    partial class AdicionarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label4 = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 86);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 146);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(184, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(142, 146);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(184, 23);
            txtTelefone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 27);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(142, 218);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // AdicionarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdicionarForm";
            Text = "AdicionarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        // Add the missing event handler method for the button click event.  
        private void button1_Click(object sender, EventArgs e)
        {
            // Add your logic here for what should happen when the button is clicked.  
            MessageBox.Show("Button clicked!");
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label4;
        private Button btnSalvar;
    }
}