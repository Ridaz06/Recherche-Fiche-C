﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Recherche_Fiche_C
{
    public partial class SearchWIndow : Form
    {
        // -- Structure -- //
        public struct Fiche
        {
            public string Nom;
            public string Prenom;
            public string Lieu;
            public string Url;

            public Fiche(string nom, string prenom, string lieu, string url) : this()
            {
                this.Nom = nom;
                this.Prenom = prenom;
                this.Lieu = lieu;
                this.Url = url;
            }

            public Fiche(string nom, string prenom, string lieu) : this()
            {
                this.Nom = nom;
                this.Prenom = prenom;
                this.Lieu = lieu;
            }
        }

        // -- Variables globales -- //
        private List<Fiche> listFiche;
        private List<Fiche> resultFiche;
        private List<ListView> listViewList;
        private List<List<Fiche>> listTabAlpha;
        private Bitmap ficheImage;
        private Bitmap originalBitmap;
        private string path;
        private int originalHeight;
        private int originalWidth;

        // -- Constantes --//
        private const int NOM = 0;
        private const int PRENOM = 1;
        private const int LIEU = 2;
        private const int URL = 3;


        private const string VFICHE = "Voir la fiche";

        public SearchWIndow()
        {
            InitializeComponent();
        }

        public SearchWIndow(String path, List<Fiche> listFiche)
        {
            InitializeComponent();

            this.path = path;
            this.listFiche = listFiche;
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("Nom", -2, HorizontalAlignment.Center);
            this.listView1.Columns.Add("Prenom", -2, HorizontalAlignment.Center);
            this.listView1.Columns.Add("Lieu", -2, HorizontalAlignment.Center);
            this.listView1.FullRowSelect = true;

            // Premier lancement de l'application
            if (Properties.Settings.Default.FirstLunch)
            {
                Properties.Settings.Default.FirstLunch = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Afin d'avoir des recherches rapides veuillez eviter d'utiliser des " +
                                 "mots clefs court comme par exemple \"a\".\n" +
                                 "Vous pouvez changer de répertoire dans le menu \"Options\". ", "Ionformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Si aucune fiche n'est trouvé
            if (listFiche.Count == 0)
            {
                MessageBox.Show("Aucune fiche trouvé dans le répertoire ou le répertoire n'éxiste pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Properties.Settings.Default.URL = "null";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadLoop));
            t.Start();

            listTabAlpha = new List<List<Fiche>>();
            for (int j = 0; j < 28; j++)
            {
                listTabAlpha.Add(new List<Fiche>());
            }
            timer1.Enabled = false;
            int i = 0;
            listViewList = new List<ListView>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listViewList.Add(new ListView());
                TabPage tab = new TabPage(c.ToString());
                tab.Controls.Add(listViewList[i]);
                listeFicheTab.TabPages.Add(tab);

                listViewList[i].Columns.Add("Nom");
                listViewList[i].Columns.Add("Prenom");
                listViewList[i].Columns.Add("Lieu");
                listViewList[i].Dock = DockStyle.Fill;
                listViewList[i].View = View.Details;
                listViewList[i].FullRowSelect = true;

                listViewList[i].DoubleClick += (s, ee) =>
                {
                    char cIndex = (char)listeFicheTab.SelectedIndex;
                    int count = 0;
                    count += listViewList[cIndex].SelectedItems[0].Index;
                    openBitmap(count, OBR_LIST, listTabAlpha[cIndex]);
                };
                i++;
            }

            foreach (Fiche f in listFiche)
            {
                char c = f.Nom.ToUpper().ElementAt(0);
                int index = c - 65;
                listTabAlpha[index].Add(f);
                string[] arr = new string[3];
                arr[NOM] = f.Nom;
                arr[PRENOM] = f.Prenom;
                arr[LIEU] = f.Lieu;

                ListViewItem itm = new ListViewItem(arr);
                listViewList[index].Items.Add(itm);
            }

            for (int c = 'A'; c <= 'Z'; c++)
                listViewList[c - 65].AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            t.Abort();

        }
        // Thread qui sert à afficher le splashscreen au lancement
        private void ThreadLoop()
        {
            Splashscreen w = new Splashscreen();
            w.ShowDialog();
        }

        private void SearchWIndow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (nomText.Text == "" && prenomText.Text == "" && lieuText.Text == "")
            {
                MessageBox.Show("Merci de remplir au minimum un champ.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                search(nomText.Text, prenomText.Text, lieuText.Text, listFiche);
                affineGroupBox.Enabled = true;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            openBitmap(listView1.SelectedItems[0].Index, OBR_RESULT);

            
        }

        // FOnction qui recherche toutes les fiches dans le répertoire donné
        private void listerFiche(FileInfo[] fichiers)
        {
            string[] arr = new string[3];

            foreach (FileInfo fichier in fichiers)
            {
                if (fichier.Name.Contains(".jpg") || fichier.Name.Contains(".JPG"))
                {
                    int i = fichier.Name.IndexOf(".");
                    string file = fichier.Name.Substring(0, i);

                    if (file.Contains("("))
                    {
                        if ((i = file.IndexOf("(")) != -1)
                            file = file.Substring(0, i);
                    }

                    if ((i = file.IndexOf(" ")) != -1)
                    {
                        arr[NOM] = file.Substring(0, i);
                        if (file.Contains("_"))
                        {
                            if ((i = file.IndexOf("_")) != -1)
                            {
                                arr[LIEU] = file.Substring(i + 1);

                                arr[PRENOM] = file.Substring(arr[NOM].Length);
                                if ((i = arr[PRENOM].IndexOf("_")) != -1)
                                {
                                    arr[PRENOM] = arr[PRENOM].Substring(0, i);
                                    arr[URL] = fichier.FullName;
                                    listFiche.Add(new Fiche(arr[NOM], arr[PRENOM], arr[LIEU], arr[URL]));
                                }

                            }
                        }
                        else
                        {
                            arr[LIEU] = "Inconnu";
                            arr[PRENOM] = file.Substring(arr[NOM].Length);
                            arr[URL] = fichier.FullName;
                            listFiche.Add(new Fiche(arr[NOM], arr[PRENOM], arr[LIEU], arr[URL]));
                        }
                    }
                }
            }
        }

        // On redéfinie la fonction drawItem du tabcontrol afin de créer un croix qui permet de fermer l'onglet
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > 2)
            {
                e.Graphics.DrawString("x", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            }
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 15, 15);
                if (closeButton.Contains(e.Location))
                {
                    //Si ce n'est pas l'onglet de recherche ou de resultat on demande la confirmation de la fermeture
                    if (i > 2)
                    {
                        if (MessageBox.Show("Voulez-vous fermer cet onglet ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.tabControl1.TabPages.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        // Fonction de recherche
        private void search(string nom, string prenom, string lieu, List<Fiche> list)
        {
            progressBar1.Value = 0;
            listView1.Items.Clear();
            resultFiche = new List<Fiche>();
            int count = 0;
            progressBar1.Maximum = listFiche.Count;
            Fiche recherche = new Fiche(nom, prenom, lieu);
            foreach (Fiche f in list)
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
                            resultFiche.Add(new Fiche(arr[NOM], arr[PRENOM], arr[LIEU], f.Url));
                            ListViewItem itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);
                        }
                    }
                }
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            if (count == 0)
            {
                MessageBox.Show("Il n'y aucun resultat", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Il y'a " + count + " resultat(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabControl1.SelectedIndex = 1;
            }
        }

        private void affineButton_Click(object sender, EventArgs e)
        {
            if (nomAffineText.Text != "" || prenomAffineText.Text != "" || lieuAffineText.Text != "")
                search(nomAffineText.Text, prenomAffineText.Text, lieuAffineText.Text, resultFiche);
        }

        private void changerDeRépertoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void reinitialiserApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous reinitialiser l'application ?", "Attention", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Properties.Settings.Default.URL = "null";
                Properties.Settings.Default.FirstLunch = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("Application reinitialisé. \nL'application va redemarrer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            
        }

        private void changerDeRépertoireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
                if (path == "")
                {
                    MessageBox.Show("Veuillez choisir un dossier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Directory.Exists(path))
                {
                    if (Directory.GetDirectories(path).Length == 0 && Directory.GetFiles(path).Length == 0)
                    {
                        MessageBox.Show("Le répertoire est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DirectoryInfo dir = new DirectoryInfo(path);
                        FileInfo[] fichiers = dir.GetFiles();
                        DirectoryInfo[] dossiers = dir.GetDirectories();

                        this.path = path;
                        Properties.Settings.Default.URL = path;
                        Properties.Settings.Default.Save();
                        listFiche = new List<SearchWIndow.Fiche>();
                        listerFiche(fichiers);

                        foreach (DirectoryInfo dossier in dossiers)
                        {
                            fichiers = dossier.GetFiles();
                            listerFiche(fichiers);
                        }

                        Properties.Settings.Default.URL = path;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Options sauvegardées", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void répertoireActuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Répertoire actuel:\n" + this.path, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchWIndow_Shown(object sender, EventArgs e)
        {

           
        }

        /* Affiche une fiche en fonction du mode voulue:
        OBR_RESULT: dans les resultats d'une recherche précédente
        OBR_LIST: dans la liste total des fiches trouvées

        On peut passer en argument une liste
    */
        private const int OBR_RESULT = 0;
        private const int OBR_LIST = 1;
        void openBitmap(int index, int mode, List<Fiche> list = null)
        {

            Fiche f;
            if (list == null)
            {
                if (mode == OBR_RESULT)
                    f = resultFiche[index];
                else
                    f = listFiche[index];
            } else
            {
                f = list[index];
            }

            ficheImage = new Bitmap(f.Url);
            originalBitmap = ficheImage;
            originalHeight = ficheImage.Height;
            originalWidth = ficheImage.Width;

            // Creation d'un bouton permetant d'enregistrer l'image
            Button but = new Button();
            but.Text = "Enregistrer l'image";
            but.AutoSize = true;
            but.Anchor = AnchorStyles.None;
            but.Click += (s, ee) =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPG  Image |*.jpg";
                sfd.Title = "Sauvegarder la fiche";
                sfd.FileName = f.Nom
                + "_" + f.Prenom
                + "_" + f.Lieu;
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    
                    ficheImage.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            };

            // Creation d'un nouvelle onglet
            TabPage picTab = new TabPage("Fiche: " + "Nom: " + f.Nom
                + " | Prenom: " + f.Prenom);
            TableLayoutPanel pan = new TableLayoutPanel();
            pan.Dock = DockStyle.Fill;
            pan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));

            pan.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Label text = new Label();
            text.Text = "Nom: " + f.Nom
                + " | Prenom: " + f.Prenom
                + " | Lieu: " + f.Lieu;
            text.TextAlign = ContentAlignment.MiddleCenter;
            text.Dock = DockStyle.Fill;
            pan.Controls.Add(text, 1, pan.RowCount - 1);
            pan.Controls.Add(but, 1, pan.RowCount - 1);

            PictureBox picBox = new PictureBox();
            picBox.Dock = DockStyle.Fill;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.Image = ficheImage;

            pan.Controls.Add(picBox);

            picTab.Controls.Add(pan);
            tabControl1.TabPages.Add(picTab);

            tabControl1.SelectedIndex = tabControl1.TabCount - 1;

        }


        private void fermerToutesLesFichesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous fermer toutes les fiches ?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tabControl1.TabPages.Count > 3)
                {
                    while(tabControl1.TabCount > 3)
                    {
                        tabControl1.TabPages.RemoveAt(tabControl1.TabCount - 1);
                    }
                }
            }
        }
    }
}
