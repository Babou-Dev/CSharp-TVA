namespace CalculTVA
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_htva = new System.Windows.Forms.TextBox();
            this.l_options = new System.Windows.Forms.Label();
            this.gb_pays = new System.Windows.Forms.GroupBox();
            this.rb_fr = new System.Windows.Forms.RadioButton();
            this.rb_lux = new System.Windows.Forms.RadioButton();
            this.rb_bel = new System.Windows.Forms.RadioButton();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.tb_tvac = new System.Windows.Forms.TextBox();
            this.rb_htva = new System.Windows.Forms.RadioButton();
            this.rb_tvac = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_21fr = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_8 = new System.Windows.Forms.RadioButton();
            this.rb_55 = new System.Windows.Forms.RadioButton();
            this.rb_6 = new System.Windows.Forms.RadioButton();
            this.rb_14 = new System.Windows.Forms.RadioButton();
            this.rb_10 = new System.Windows.Forms.RadioButton();
            this.rb_12 = new System.Windows.Forms.RadioButton();
            this.rb_17 = new System.Windows.Forms.RadioButton();
            this.rb_20 = new System.Windows.Forms.RadioButton();
            this.rb_21 = new System.Windows.Forms.RadioButton();
            this.gb_pays.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_htva
            // 
            this.tb_htva.Location = new System.Drawing.Point(46, 83);
            this.tb_htva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_htva.Name = "tb_htva";
            this.tb_htva.Size = new System.Drawing.Size(243, 29);
            this.tb_htva.TabIndex = 0;
            this.tb_htva.Text = "Veuillez entrer le prix hors TVA :";
            // 
            // l_options
            // 
            this.l_options.AutoSize = true;
            this.l_options.Location = new System.Drawing.Point(410, 26);
            this.l_options.Name = "l_options";
            this.l_options.Size = new System.Drawing.Size(72, 21);
            this.l_options.TabIndex = 2;
            this.l_options.Text = "Options :";
            // 
            // gb_pays
            // 
            this.gb_pays.BackColor = System.Drawing.Color.LightGray;
            this.gb_pays.Controls.Add(this.rb_fr);
            this.gb_pays.Controls.Add(this.rb_lux);
            this.gb_pays.Controls.Add(this.rb_bel);
            this.gb_pays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_pays.ForeColor = System.Drawing.Color.Black;
            this.gb_pays.Location = new System.Drawing.Point(487, 49);
            this.gb_pays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_pays.Name = "gb_pays";
            this.gb_pays.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_pays.Size = new System.Drawing.Size(291, 130);
            this.gb_pays.TabIndex = 19;
            this.gb_pays.TabStop = false;
            this.gb_pays.Text = "Pays";
            // 
            // rb_fr
            // 
            this.rb_fr.AutoSize = true;
            this.rb_fr.Location = new System.Drawing.Point(98, 62);
            this.rb_fr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_fr.Name = "rb_fr";
            this.rb_fr.Size = new System.Drawing.Size(74, 25);
            this.rb_fr.TabIndex = 9;
            this.rb_fr.TabStop = true;
            this.rb_fr.Text = "France";
            this.rb_fr.UseVisualStyleBackColor = true;
            // 
            // rb_lux
            // 
            this.rb_lux.AutoSize = true;
            this.rb_lux.Location = new System.Drawing.Point(98, 93);
            this.rb_lux.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_lux.Name = "rb_lux";
            this.rb_lux.Size = new System.Drawing.Size(116, 25);
            this.rb_lux.TabIndex = 8;
            this.rb_lux.TabStop = true;
            this.rb_lux.Text = "Luxembourg";
            this.rb_lux.UseVisualStyleBackColor = true;
            // 
            // rb_bel
            // 
            this.rb_bel.AutoSize = true;
            this.rb_bel.Location = new System.Drawing.Point(98, 30);
            this.rb_bel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_bel.Name = "rb_bel";
            this.rb_bel.Size = new System.Drawing.Size(88, 25);
            this.rb_bel.TabIndex = 7;
            this.rb_bel.TabStop = true;
            this.rb_bel.Text = "Belgique";
            this.rb_bel.UseVisualStyleBackColor = true;
            // 
            // btn_go
            // 
            this.btn_go.BackColor = System.Drawing.Color.DarkGray;
            this.btn_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_go.Location = new System.Drawing.Point(568, 186);
            this.btn_go.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(133, 40);
            this.btn_go.TabIndex = 20;
            this.btn_go.Text = "Afficher les taux";
            this.btn_go.UseVisualStyleBackColor = false;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.DarkGray;
            this.btn_calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calc.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calc.Location = new System.Drawing.Point(124, 234);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(86, 36);
            this.btn_calc.TabIndex = 21;
            this.btn_calc.Text = "Calculer";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // tb_tvac
            // 
            this.tb_tvac.Location = new System.Drawing.Point(46, 186);
            this.tb_tvac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tvac.Name = "tb_tvac";
            this.tb_tvac.Size = new System.Drawing.Size(243, 29);
            this.tb_tvac.TabIndex = 23;
            this.tb_tvac.Text = "Veuillez entrer le prix TVAC : ";
            // 
            // rb_htva
            // 
            this.rb_htva.AutoSize = true;
            this.rb_htva.Location = new System.Drawing.Point(46, 49);
            this.rb_htva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_htva.Name = "rb_htva";
            this.rb_htva.Size = new System.Drawing.Size(147, 25);
            this.rb_htva.TabIndex = 10;
            this.rb_htva.TabStop = true;
            this.rb_htva.Text = "HTVA vers TVAC :";
            this.rb_htva.UseVisualStyleBackColor = true;
            // 
            // rb_tvac
            // 
            this.rb_tvac.AutoSize = true;
            this.rb_tvac.Location = new System.Drawing.Point(46, 154);
            this.rb_tvac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_tvac.Name = "rb_tvac";
            this.rb_tvac.Size = new System.Drawing.Size(147, 25);
            this.rb_tvac.TabIndex = 24;
            this.rb_tvac.TabStop = true;
            this.rb_tvac.Text = "TVAC vers HTVA :";
            this.rb_tvac.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_21fr);
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Controls.Add(this.rb_8);
            this.groupBox1.Controls.Add(this.rb_55);
            this.groupBox1.Controls.Add(this.rb_6);
            this.groupBox1.Controls.Add(this.rb_14);
            this.groupBox1.Controls.Add(this.rb_10);
            this.groupBox1.Controls.Add(this.rb_12);
            this.groupBox1.Controls.Add(this.rb_17);
            this.groupBox1.Controls.Add(this.rb_20);
            this.groupBox1.Controls.Add(this.rb_21);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(478, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 144);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux de TVA :";
            // 
            // rb_21fr
            // 
            this.rb_21fr.AutoSize = true;
            this.rb_21fr.Location = new System.Drawing.Point(218, 68);
            this.rb_21fr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_21fr.Name = "rb_21fr";
            this.rb_21fr.Size = new System.Drawing.Size(62, 25);
            this.rb_21fr.TabIndex = 29;
            this.rb_21fr.TabStop = true;
            this.rb_21fr.Text = "2.1%";
            this.rb_21fr.UseVisualStyleBackColor = true;
            this.rb_21fr.Visible = false;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(222, 100);
            this.rb_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(50, 25);
            this.rb_3.TabIndex = 28;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "3%";
            this.rb_3.UseVisualStyleBackColor = true;
            this.rb_3.Visible = false;
            // 
            // rb_8
            // 
            this.rb_8.AutoSize = true;
            this.rb_8.Location = new System.Drawing.Point(149, 100);
            this.rb_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_8.Name = "rb_8";
            this.rb_8.Size = new System.Drawing.Size(50, 25);
            this.rb_8.TabIndex = 27;
            this.rb_8.TabStop = true;
            this.rb_8.Text = "8%";
            this.rb_8.UseVisualStyleBackColor = true;
            this.rb_8.Visible = false;
            // 
            // rb_55
            // 
            this.rb_55.AutoSize = true;
            this.rb_55.Location = new System.Drawing.Point(149, 68);
            this.rb_55.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_55.Name = "rb_55";
            this.rb_55.Size = new System.Drawing.Size(62, 25);
            this.rb_55.TabIndex = 26;
            this.rb_55.TabStop = true;
            this.rb_55.Text = "5.5%";
            this.rb_55.UseVisualStyleBackColor = true;
            this.rb_55.Visible = false;
            // 
            // rb_6
            // 
            this.rb_6.AutoSize = true;
            this.rb_6.Location = new System.Drawing.Point(149, 37);
            this.rb_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_6.Name = "rb_6";
            this.rb_6.Size = new System.Drawing.Size(50, 25);
            this.rb_6.TabIndex = 25;
            this.rb_6.TabStop = true;
            this.rb_6.Text = "6%";
            this.rb_6.UseVisualStyleBackColor = true;
            this.rb_6.Visible = false;
            // 
            // rb_14
            // 
            this.rb_14.AutoSize = true;
            this.rb_14.Location = new System.Drawing.Point(84, 100);
            this.rb_14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_14.Name = "rb_14";
            this.rb_14.Size = new System.Drawing.Size(59, 25);
            this.rb_14.TabIndex = 24;
            this.rb_14.TabStop = true;
            this.rb_14.Text = "14%";
            this.rb_14.UseVisualStyleBackColor = true;
            this.rb_14.Visible = false;
            // 
            // rb_10
            // 
            this.rb_10.AutoSize = true;
            this.rb_10.Location = new System.Drawing.Point(84, 68);
            this.rb_10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_10.Name = "rb_10";
            this.rb_10.Size = new System.Drawing.Size(59, 25);
            this.rb_10.TabIndex = 23;
            this.rb_10.TabStop = true;
            this.rb_10.Text = "10%";
            this.rb_10.UseVisualStyleBackColor = true;
            this.rb_10.Visible = false;
            // 
            // rb_12
            // 
            this.rb_12.AutoSize = true;
            this.rb_12.Location = new System.Drawing.Point(84, 37);
            this.rb_12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_12.Name = "rb_12";
            this.rb_12.Size = new System.Drawing.Size(59, 25);
            this.rb_12.TabIndex = 22;
            this.rb_12.TabStop = true;
            this.rb_12.Text = "12%";
            this.rb_12.UseVisualStyleBackColor = true;
            this.rb_12.Visible = false;
            // 
            // rb_17
            // 
            this.rb_17.AutoSize = true;
            this.rb_17.Location = new System.Drawing.Point(19, 100);
            this.rb_17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_17.Name = "rb_17";
            this.rb_17.Size = new System.Drawing.Size(59, 25);
            this.rb_17.TabIndex = 21;
            this.rb_17.TabStop = true;
            this.rb_17.Text = "17%";
            this.rb_17.UseVisualStyleBackColor = true;
            this.rb_17.Visible = false;
            // 
            // rb_20
            // 
            this.rb_20.AutoSize = true;
            this.rb_20.Location = new System.Drawing.Point(19, 68);
            this.rb_20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_20.Name = "rb_20";
            this.rb_20.Size = new System.Drawing.Size(59, 25);
            this.rb_20.TabIndex = 20;
            this.rb_20.TabStop = true;
            this.rb_20.Text = "20%";
            this.rb_20.UseVisualStyleBackColor = true;
            this.rb_20.Visible = false;
            // 
            // rb_21
            // 
            this.rb_21.AutoSize = true;
            this.rb_21.Location = new System.Drawing.Point(19, 37);
            this.rb_21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_21.Name = "rb_21";
            this.rb_21.Size = new System.Drawing.Size(59, 25);
            this.rb_21.TabIndex = 19;
            this.rb_21.TabStop = true;
            this.rb_21.Text = "21%";
            this.rb_21.UseVisualStyleBackColor = true;
            this.rb_21.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(842, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rb_tvac);
            this.Controls.Add(this.rb_htva);
            this.Controls.Add(this.tb_tvac);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.gb_pays);
            this.Controls.Add(this.l_options);
            this.Controls.Add(this.tb_htva);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul de TVA";
            this.gb_pays.ResumeLayout(false);
            this.gb_pays.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_htva;
        private System.Windows.Forms.Label l_options;
        private System.Windows.Forms.GroupBox gb_pays;
        private System.Windows.Forms.RadioButton rb_fr;
        private System.Windows.Forms.RadioButton rb_lux;
        private System.Windows.Forms.RadioButton rb_bel;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox tb_tvac;
        private System.Windows.Forms.RadioButton rb_htva;
        private System.Windows.Forms.RadioButton rb_tvac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_21fr;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_8;
        private System.Windows.Forms.RadioButton rb_55;
        private System.Windows.Forms.RadioButton rb_6;
        private System.Windows.Forms.RadioButton rb_14;
        private System.Windows.Forms.RadioButton rb_10;
        private System.Windows.Forms.RadioButton rb_12;
        private System.Windows.Forms.RadioButton rb_17;
        private System.Windows.Forms.RadioButton rb_20;
        private System.Windows.Forms.RadioButton rb_21;
    }
}

