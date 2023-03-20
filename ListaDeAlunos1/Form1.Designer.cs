namespace ListaDeAlunos1
{
    partial class Form1
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
            this.RA = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listAlunos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RA
            // 
            this.RA.AutoSize = true;
            this.RA.Location = new System.Drawing.Point(50, 46);
            this.RA.Name = "RA";
            this.RA.Size = new System.Drawing.Size(22, 13);
            this.RA.TabIndex = 0;
            this.RA.Text = "RA";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(50, 84);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(233, 132);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(20, 13);
            this.P2.TabIndex = 2;
            this.P2.Text = "P2";
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Location = new System.Drawing.Point(50, 132);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(20, 13);
            this.P1.TabIndex = 3;
            this.P1.Text = "P1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(409, 102);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(409, 201);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(275, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // listAlunos
            // 
            this.listAlunos.FormattingEnabled = true;
            this.listAlunos.Location = new System.Drawing.Point(53, 239);
            this.listAlunos.Name = "listAlunos";
            this.listAlunos.Size = new System.Drawing.Size(431, 186);
            this.listAlunos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.listAlunos);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.RA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RA;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listAlunos;
    }
}

