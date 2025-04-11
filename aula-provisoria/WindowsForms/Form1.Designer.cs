namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            txtUsuario = new Label();
            txtSenha = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.AccessibleDescription = "Usuario";
            txtUsuario.AccessibleName = "Usuario";
            txtUsuario.AutoSize = true;
            txtUsuario.Location = new Point(91, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(47, 15);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            txtUsuario.Click += usuario_Click;
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Location = new Point(91, 93);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(39, 15);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 90);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '#';
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(129, 155);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 155);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(419, 229);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(textBox2);
            Controls.Add(txtUsuario);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label txtUsuario;
        private Label txtSenha;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
