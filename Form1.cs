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
            if (Properties.Settings.Default.URL != "null")
            {
                string path = Properties.Settings.Default.URL;

                if (path == "")
                {
                    MessageBox.Show("Le répertoire enregistré n'existe pas. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Directory.Exists(path))
                {
                    if (Directory.GetDirectories(path).Length == 0 && Directory.GetFiles(path).Length == 0)
                    {
                        MessageBox.Show("Le répertoire enregistré est vide. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        loadingScreen w = new loadingScreen(path);
                        this.Hide();
                        w.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Le répertoire enregistré n'existe pas. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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
                    if (saveCheckBox.Checked)
                    {
                        Properties.Settings.Default.URL = pathText.Text;
                        Properties.Settings.Default.Save();
                    }
                    loadingScreen w = new loadingScreen(pathText.Text);
                    this.Hide();
                    w.ShowDialog();
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
