namespace WinFormsApp4
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            lblNome = new Label();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(123, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(621, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(123, 207);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(621, 23);
            txtPreco.TabIndex = 1;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(352, 307);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(36, 103);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(36, 210);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            lblPreco.Click += label2_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Label lblNome;
        private Label lblPreco;
    }
}