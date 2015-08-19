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

        private List<Fiche> listFiche;
        private List<Fiche> resultFiche;
        private Bitmap ficheImage;
        private Bitmap originalBitmap;
        private int originalHeight;
        private int originalWidth;

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

            this.listFiche = listFiche;
            this.pathText.Text = path;
            this.listView1.Columns.Add("Nom");
            this.listView1.Columns.Add("Prenom");
            this.listView1.Columns.Add("Lieu");

            if (Properties.Settings.Default.FirstLunch)
            {
                Properties.Settings.Default.FirstLunch = false;
                Properties.Settings.Default.Save();
                MessageBox.Show("Afin d'avoir des recherches rapides veuillez eviter d'utiliser des " +
                                 "mots clefs court comme par exemple \"a\".\n" +
                                 "Vous pouvez changer de répertoire dans l'onglet \"Options\" en pensant à bien " + 
                                 "cliquer sur le bouton \"Sauvegarder\". ", "Ionformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (listFiche.Count == 0)
            {
                MessageBox.Show("Aucune fiche trouvé dans le répertoire choisie merci de changer de répertoire dans l'onglet \"Options\"", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                progressBar1.Value = 0;
                listView1.Items.Clear();
                resultFiche = new List<Fiche>();
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
                } else
                {
                    MessageBox.Show("Il y'a " + count + " resultat(s)", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectedIndex = 1;
                }

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ficheImage = new Bitmap(resultFiche[listView1.SelectedItems[0].Index].Url);
            originalBitmap = ficheImage;
            originalHeight = ficheImage.Height;
            originalWidth = ficheImage.Width;

            TabPage picTab = new TabPage("Fiche: " + "Nom: " + resultFiche[listView1.SelectedItems[0].Index].Nom
                + " | Prenom: " + resultFiche[listView1.SelectedItems[0].Index].Prenom);
            TableLayoutPanel pan = new TableLayoutPanel();
            pan.Dock = DockStyle.Fill;
            pan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));

            pan.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Label text = new Label();
            text.Text = "Nom: " + resultFiche[listView1.SelectedItems[0].Index].Nom
                + " | Prenom: " + resultFiche[listView1.SelectedItems[0].Index].Prenom
                + " | Lieu: " + resultFiche[listView1.SelectedItems[0].Index].Lieu; ;
            text.TextAlign = ContentAlignment.MiddleCenter;
            text.Dock = DockStyle.Fill;
            pan.Controls.Add(text, 1, pan.RowCount - 1);

            PictureBox picBox = new PictureBox();
            picBox.Dock = DockStyle.Fill;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.Image = ficheImage;

            pan.Controls.Add(picBox);

            picTab.Controls.Add(pan);
            tabControl1.TabPages.Add(picTab);

            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
        }



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

        private void SearchWIndow_Load(object sender, EventArgs e)
        {

        }

        private void reinitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = "null";
            Properties.Settings.Default.FirstLunch = true;
            Properties.Settings.Default.Save();
            MessageBox.Show("Application reinitialisé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pathText.Text == "")
            {
                MessageBox.Show("Veuillez choisir un dossier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Directory.Exists(pathText.Text))
            {
                if (Directory.GetDirectories(pathText.Text).Length == 0 && Directory.GetFiles(pathText.Text).Length == 0)
                {
                    MessageBox.Show("Le répertoire est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                        Properties.Settings.Default.URL = pathText.Text;
                        Properties.Settings.Default.Save();
                    MessageBox.Show("Options sauvegardées", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Le répertoire n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
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
                    if (i < 3)
                    {
                        MessageBox.Show("Impossiblde de fermet cet onglet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
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
    }
}
