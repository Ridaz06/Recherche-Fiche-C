using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recherche_Fiche_C
{
    public partial class SearchWIndow : Form
    {
        public struct Fiche
        {
            public string Nom;
            public string Prenom;
            public string Lieu;

            public Fiche(string nom, string prenom, string lieu) : this()
            {
                this.Nom = nom;
                this.Prenom = prenom;
                this.Lieu = lieu;
            }
        }

        public List<Fiche> listFiche;
        public const int NOM = 0;
        public const int PRENOM = 1;
        public const int LIEU = 2;


        public SearchWIndow()
        {
            InitializeComponent();
        }

        public SearchWIndow(String path)
        {
            InitializeComponent();
            this.pathText.Text = path;
            this.listView1.Columns.Add("Nom");
            this.listView1.Columns.Add("Prenom");
            this.listView1.Columns.Add("Lieu");
            string[] arr = new string[3];

            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fichiers = dir.GetFiles();

            listFiche = new List<Fiche>();

            foreach (FileInfo fichier in fichiers)
            {
                if (fichier.Name.Contains(".jpg") || fichier.Name.Contains(".JPG"))
                {
                    int i = fichier.Name.IndexOf(".");
                    string file = fichier.Name.Substring(0, i);

                    if (file.Contains("("))
                    {
                        if ((i = file.IndexOf("(") ) != -1)
                            file = file.Substring(0, i);
                    }

                    if ((i = file.IndexOf(" ")) != -1)
                    {
                        arr[NOM] = file.Substring(0, i);
                        if (file.Contains("_")){
                            if ((i = file.IndexOf("_")) != -1)
                            {
                                arr[LIEU] = file.Substring(i + 1);

                                arr[PRENOM] = file.Substring(arr[NOM].Length + 1);
                                i = arr[PRENOM].IndexOf("_");
                                arr[PRENOM] = arr[PRENOM].Substring(0, i);

                                listFiche.Add(new Fiche(arr[NOM], arr[PRENOM], arr[LIEU]));
                            }
                        } else
                        {
                            arr[LIEU] = "Inconnu";
                            arr[PRENOM] = file.Substring(arr[NOM].Length);

                            listFiche.Add(new Fiche(arr[NOM], arr[PRENOM], arr[LIEU]));
                        }
                    }
                }
            }
        }

        private void SearchWIndow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (nomText.Text == "" && prenomText.Text == "" && lieuText.Text == "")
            {
                MessageBox.Show("Merci de remplir au minimum un champ.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                listView1.Items.Clear();
                int count = 0;
                progressBar1.Maximum = listFiche.Count;
                Fiche recherche = new Fiche(nomText.Text, prenomText.Text, lieuText.Text);
                foreach (Fiche f in listFiche)
                {
                    progressBar1.Value++;
                    bool valid = true;
                    if (recherche.Nom != "")
                        if (f.Nom.IndexOf(recherche.Nom, StringComparison.OrdinalIgnoreCase) < 0)
                            valid = false;
                    if (valid)
                    {
                        if (recherche.Prenom != "")
                            if (f.Prenom.IndexOf(recherche.Prenom, StringComparison.OrdinalIgnoreCase) < 0)
                                valid = false;
                        if (valid)
                        {
                            if (recherche.Lieu != "")
                                if (f.Lieu.IndexOf(recherche.Lieu, StringComparison.OrdinalIgnoreCase) < 0)
                                    valid = false;
                            if (valid)
                            {
                                count++;
                                string[] arr = new string[3];
                                arr[NOM] = f.Nom;
                                arr[PRENOM] = f.Prenom;
                                arr[LIEU] = f.Lieu;
                                ListViewItem itm = new ListViewItem(arr);
                                listView1.Items.Add(itm);
                            }
                        }
                    }
                }
                progressBar1.Value = 0;
                if (count == 0)
                {
                    MessageBox.Show("Il n'y aucun resultat", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show("Il y'a " + count + " resultat(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


    }
}
