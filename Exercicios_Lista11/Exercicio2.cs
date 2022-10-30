<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Lista11
{
    public partial class frmEx2 : Form
    {
        /*
         * 2. Fazer um programa em VS e com windows Forms.
         * A interface gráfica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - List 
         * - Classe específica
         * 
         * O programa deve possuir botões (como um menu) para com cadastrar emails, listar emails 
         * e limpar conteúdo dos componentes. Os emails digitados devem ser cadastrados em uma lista 
         * e não pode haver emails duplicados, ou seja, o programa deve controlar essa situação. 
         * Quando o usuário solicitar a listagem dos emails, além dessa lista, o programa deve listar
         * os domínios de emails cadastrados no programa. Para isso, usar dois componentes gráficos
         * equivalentes.
         */ 
         
        public frmEx2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            lstEmails.Clear();
            lstDominios.Clear();
            txtNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string[] validaEmail = email.Split("@");

            if (nome.Length < 3)
            {
                MessageBox.Show("Favor preencher um nome!");                
            }

            if (validaEmail.Length < 2)
            {
                MessageBox.Show("Favor preencher um e-mail válido!");                
            }
            else
            {

            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Lista11
{
    public partial class frmEx2 : Form
    {
        /*
         * 2. Fazer um programa em VS e com windows Forms.
         * A interface gráfica precisa ter 
         * - Labels
         * - TextBox
         * - Button
         * - Panel
         * - List 
         * - Classe específica
         * 
         * O programa deve possuir botões (como um menu) para com cadastrar emails, listar emails 
         * e limpar conteúdo dos componentes. Os emails digitados devem ser cadastrados em uma lista 
         * e não pode haver emails duplicados, ou seja, o programa deve controlar essa situação. 
         * Quando o usuário solicitar a listagem dos emails, além dessa lista, o programa deve listar
         * os domínios de emails cadastrados no programa. Para isso, usar dois componentes gráficos
         * equivalentes.
         */ 
        List<Emails> emails = new List<Emails>();
        List<Emails> dominios = new List<Emails>();
        public frmEx2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            lstEmails.Clear();
            lstDominios.Clear();
            txtNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarEmail();
        }

        private void CadastrarEmail()
        {
            string nome = txtNome.Text.ToUpper();
            string emailCompleto = txtEmail.Text.ToUpper();
            
            try
            {
                string[] validaEmail = emailCompleto.Split("@");
                string dominio = validaEmail[1];
                string[] validaDominio = dominio.Split(".");
            
                if (nome.Length < 3)
                {
                    MessageBox.Show("Favor preencher um nome!");
                }

                if (validaEmail.Length < 2 || validaDominio.Length < 2)
                {
                    MessageBox.Show("Favor preencher um e-mail válido!");
                }
                else
                {
                    if (ContemEmail(emailCompleto))
                    {                        
                        lstEmails.Items.Add(emailCompleto);
                        emails.Add(new Emails(emailCompleto));
                    }
                    if (ContemDominio(dominio))
                    {
                        lstDominios.Items.Add(dominio);
                    }
                }
                    
            } catch (Exception ex)
            {
                MessageBox.Show("É necessário preencher os campos.");
            }
        }

        private bool ContemEmail(string email)
        {
            foreach (var e in emails)
            {
                if (e.Email == email)
                {
                    MessageBox.Show($"'{email}' já existe na lista.");
                    return false;
                }
            }
            return true;
        }
        private bool ContemDominio(string dominio)
        {
            foreach (var d in dominios)
            {
                if (d.Dominio == dominio)
                {                    
                    return false;
                }
            }
            return true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                CadastrarEmail();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                CadastrarEmail();
            }
        }
    }
}
>>>>>>> 383c10d (Updating eleventh list of exercises)
