﻿namespace Recherche_Fiche_C
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontSizeBox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pathText = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rechercher une fiche";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(568, 430);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(88, 132);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(391, 166);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(73, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 78);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prenom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lieu :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prenomText
            // 
            this.prenomText.Location = new System.Drawing.Point(58, 29);
            this.prenomText.Name = "prenomText";
            this.prenomText.Size = new System.Drawing.Size(182, 20);
            this.prenomText.TabIndex = 4;
            // 
            // lieuText
            // 
            this.lieuText.Location = new System.Drawing.Point(58, 55);
            this.lieuText.Name = "lieuText";
            this.lieuText.Size = new System.Drawing.Size(182, 20);
            this.lieuText.TabIndex = 5;
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(58, 3);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(182, 20);
            this.nomText.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(81, 134);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(229, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(161, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(69, 22);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Chercher";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultat de la recherche";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 430);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(574, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Option";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fontSizeBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 436);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Changer de répertoire:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taille de la police:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.Location = new System.Drawing.Point(123, 37);
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.Size = new System.Drawing.Size(43, 20);
            this.fontSizeBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(4, 64);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Enregistrer";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pathText);
            this.flowLayoutPanel1.Controls.Add(this.pathButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(447, 26);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(3, 3);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(178, 20);
            this.pathText.TabIndex = 0;
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(187, 3);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(26, 23);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // SearchWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchWIndow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chercher une fiche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchWIndow_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fontSizeBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}