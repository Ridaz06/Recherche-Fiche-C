using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recherche_Fiche_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (pathText.Text == "")
            {
                MessageBox.Show("Veuillez choisir un dossier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Directory.Exists(pathText.Text))
            {
                if (Directory.GetDirectories(pathText.Text).Length == 0 && Directory.GetFiles(pathText.Text).Length == 0)
                {
                    MessageBox.Show("Le répertoire est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    SearchWIndow w = new SearchWIndow(pathText.Text);
                    w.Show(this);
                    this.Hide();
                }
            } else
            {
                MessageBox.Show("Le répertoire n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathText.Text = fbd.SelectedPath;
            }
        }
    }
}
