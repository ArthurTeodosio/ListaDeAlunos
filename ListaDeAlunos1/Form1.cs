using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ListaDeAlunos1
{
    public partial class Form1 : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.RA = RA.Text;
            aluno.Nome = Nome.Text;
            aluno.P1 = float.Parse(P1.Text);
            aluno.P2 = float.Parse(P2.Text);

            Repositorio.Incluir(aluno);
            MessageBox.Show("Aluno incluido com sucesso");

            RA.Text = "";
            Nome.Text = "";
            P1.Text = "";
            P2.Text = "";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listAlunos.Items.Clear();
            foreach (var al in Repositorio.Alunos)
            {
                listAlunos.Items.Add(al);

            }
        }
    }
}
