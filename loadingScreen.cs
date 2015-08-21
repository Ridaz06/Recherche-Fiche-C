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
    public partial class loadingScreen : Form
    {

        private const int NOM = 0;
        private const int PRENOM = 1;
        private const int LIEU = 2;
        private const int URL = 3;
        private const string VFICHE = "Voir la fiche";

        private string path;

        private List<SearchWIndow.Fiche> listFiche;
        public loadingScreen(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void listerFiche(FileInfo[] fichiers)
        {
            string[] arr = new string[4];

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
                                    listFiche.Add(new SearchWIndow.Fiche(arr[NOM], arr[PRENOM], arr[LIEU], arr[URL] ));
                                }

                            }
                        }
                        else
                        {
                            arr[LIEU] = "Inconnu";
                            arr[PRENOM] = file.Substring(arr[NOM].Length);
                            arr[URL] = fichier.FullName;
                            listFiche.Add(new SearchWIndow.Fiche(arr[NOM], arr[PRENOM], arr[LIEU], arr[URL]));
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fichiers = dir.GetFiles();
            DirectoryInfo[] dossiers = dir.GetDirectories();

            listFiche = new List<SearchWIndow.Fiche>();
            listerFiche(fichiers);

            foreach (DirectoryInfo dossier in dossiers)
            {
                fichiers = dossier.GetFiles();
                listerFiche(fichiers);
            }

            SearchWIndow w = new SearchWIndow(path, listFiche);
            this.Hide();
            w.ShowDialog();
        }
        private void loadingScreen_Shown(object sender, EventArgs e)
        {

        }
    }
}
