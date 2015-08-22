namespace Recherche_Fiche_C
{
    partial class SearchWIndow
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prenomText = new System.Windows.Forms.TextBox();
            this.lieuText = new System.Windows.Forms.TextBox();
            this.nomText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.affineGroupBox = new System.Windows.Forms.GroupBox();
            this.affineButton = new System.Windows.Forms.Button();
            this.lieuAffineText = new System.Windows.Forms.TextBox();
            this.prenomAffineText = new System.Windows.Forms.TextBox();
            this.nomAffineText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listeFicheTab = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.répertoireActuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDeRépertoireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDeRépertoireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reinitialiserApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fermerToutesLesFichesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.resultTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.affineGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchTab);
            this.tabControl1.Controls.Add(this.resultTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 431);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.tableLayoutPanel3);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(568, 402);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Rechercher une fiche";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(562, 396);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.progressBar1, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.searchButton, 0, 6);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(140, 100);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(282, 195);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rechercher une fiche :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.prenomText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lieuText, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.nomText, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(275, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prenom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lieu :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prenomText
            // 
            this.prenomText.Location = new System.Drawing.Point(81, 32);
            this.prenomText.Name = "prenomText";
            this.prenomText.Size = new System.Drawing.Size(182, 23);
            this.prenomText.TabIndex = 4;
            // 
            // lieuText
            // 
            this.lieuText.Location = new System.Drawing.Point(81, 61);
            this.lieuText.Name = "lieuText";
            this.lieuText.Size = new System.Drawing.Size(182, 23);
            this.lieuText.TabIndex = 5;
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(81, 3);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(182, 23);
            this.nomText.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(26, 160);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(229, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(95, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 26);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Chercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultTab
            // 
            this.resultTab.Controls.Add(this.tableLayoutPanel5);
            this.resultTab.Location = new System.Drawing.Point(4, 25);
            this.resultTab.Name = "resultTab";
            this.resultTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultTab.Size = new System.Drawing.Size(568, 402);
            this.resultTab.TabIndex = 1;
            this.resultTab.Text = "Resultats de la recherche";
            this.resultTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.affineGroupBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(562, 396);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 302);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // affineGroupBox
            // 
            this.affineGroupBox.Controls.Add(this.affineButton);
            this.affineGroupBox.Controls.Add(this.lieuAffineText);
            this.affineGroupBox.Controls.Add(this.prenomAffineText);
            this.affineGroupBox.Controls.Add(this.nomAffineText);
            this.affineGroupBox.Controls.Add(this.label8);
            this.affineGroupBox.Controls.Add(this.label6);
            this.affineGroupBox.Controls.Add(this.label2);
            this.affineGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.affineGroupBox.Enabled = false;
            this.affineGroupBox.Location = new System.Drawing.Point(3, 311);
            this.affineGroupBox.Name = "affineGroupBox";
            this.affineGroupBox.Size = new System.Drawing.Size(556, 82);
            this.affineGroupBox.TabIndex = 2;
            this.affineGroupBox.TabStop = false;
            this.affineGroupBox.Text = "Affiner la recherche";
            // 
            // affineButton
            // 
            this.affineButton.Location = new System.Drawing.Point(6, 57);
            this.affineButton.Name = "affineButton";
            this.affineButton.Size = new System.Drawing.Size(75, 23);
            this.affineButton.TabIndex = 6;
            this.affineButton.Text = "Affiner";
            this.affineButton.UseVisualStyleBackColor = true;
            this.affineButton.Click += new System.EventHandler(this.affineButton_Click);
            // 
            // lieuAffineText
            // 
            this.lieuAffineText.Location = new System.Drawing.Point(376, 28);
            this.lieuAffineText.Name = "lieuAffineText";
            this.lieuAffineText.Size = new System.Drawing.Size(100, 23);
            this.lieuAffineText.TabIndex = 5;
            // 
            // prenomAffineText
            // 
            this.prenomAffineText.Location = new System.Drawing.Point(227, 28);
            this.prenomAffineText.Name = "prenomAffineText";
            this.prenomAffineText.Size = new System.Drawing.Size(100, 23);
            this.prenomAffineText.TabIndex = 4;
            // 
            // nomAffineText
            // 
            this.nomAffineText.Location = new System.Drawing.Point(56, 28);
            this.nomAffineText.Name = "nomAffineText";
            this.nomAffineText.Size = new System.Drawing.Size(100, 23);
            this.nomAffineText.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lieu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prenom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listeFicheTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(568, 402);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Liste des fiches";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listeFicheTab
            // 
            this.listeFicheTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listeFicheTab.Location = new System.Drawing.Point(0, 0);
            this.listeFicheTab.Name = "listeFicheTab";
            this.listeFicheTab.SelectedIndex = 0;
            this.listeFicheTab.Size = new System.Drawing.Size(568, 402);
            this.listeFicheTab.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(582, 462);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.répertoireActuelToolStripMenuItem,
            this.changerDeRépertoireToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // répertoireActuelToolStripMenuItem
            // 
            this.répertoireActuelToolStripMenuItem.Name = "répertoireActuelToolStripMenuItem";
            this.répertoireActuelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.répertoireActuelToolStripMenuItem.Text = "Répertoire actuel";
            this.répertoireActuelToolStripMenuItem.Click += new System.EventHandler(this.répertoireActuelToolStripMenuItem_Click);
            // 
            // changerDeRépertoireToolStripMenuItem
            // 
            this.changerDeRépertoireToolStripMenuItem.Name = "changerDeRépertoireToolStripMenuItem";
            this.changerDeRépertoireToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.changerDeRépertoireToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.changerDeRépertoireToolStripMenuItem.Text = "Quitter";
            this.changerDeRépertoireToolStripMenuItem.Click += new System.EventHandler(this.changerDeRépertoireToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerDeRépertoireToolStripMenuItem1,
            this.reinitialiserApplicationToolStripMenuItem,
            this.fermerToutesLesFichesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changerDeRépertoireToolStripMenuItem1
            // 
            this.changerDeRépertoireToolStripMenuItem1.Name = "changerDeRépertoireToolStripMenuItem1";
            this.changerDeRépertoireToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.changerDeRépertoireToolStripMenuItem1.Text = "Changer de répertoire";
            this.changerDeRépertoireToolStripMenuItem1.Click += new System.EventHandler(this.changerDeRépertoireToolStripMenuItem1_Click);
            // 
            // reinitialiserApplicationToolStripMenuItem
            // 
            this.reinitialiserApplicationToolStripMenuItem.Name = "reinitialiserApplicationToolStripMenuItem";
            this.reinitialiserApplicationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.reinitialiserApplicationToolStripMenuItem.Text = "Reinitialiser application";
            this.reinitialiserApplicationToolStripMenuItem.Click += new System.EventHandler(this.reinitialiserApplicationToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fermerToutesLesFichesToolStripMenuItem
            // 
            this.fermerToutesLesFichesToolStripMenuItem.Name = "fermerToutesLesFichesToolStripMenuItem";
            this.fermerToutesLesFichesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fermerToutesLesFichesToolStripMenuItem.Text = "Fermer toutes les fiches";
            this.fermerToutesLesFichesToolStripMenuItem.Click += new System.EventHandler(this.fermerToutesLesFichesToolStripMenuItem_Click);
            // 
            // SearchWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 462);
            this.Controls.Add(this.tableLayoutPanel6);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchWIndow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chercher une fiche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchWIndow_FormClosing);
            this.Shown += new System.EventHandler(this.SearchWIndow_Shown);
            this.tabControl1.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.resultTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.affineGroupBox.ResumeLayout(false);
            this.affineGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage resultTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prenomText;
        private System.Windows.Forms.TextBox lieuText;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox affineGroupBox;
        private System.Windows.Forms.TextBox lieuAffineText;
        private System.Windows.Forms.TextBox prenomAffineText;
        private System.Windows.Forms.TextBox nomAffineText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button affineButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerDeRépertoireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerDeRépertoireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reinitialiserApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem répertoireActuelToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl listeFicheTab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fermerToutesLesFichesToolStripMenuItem;
    }
}