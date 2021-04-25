namespace osuSTDEVpp
{
    partial class osuSTDEVpp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osuSTDEVpp));
            this.edt1 = new System.Windows.Forms.TextBox();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.edt2 = new System.Windows.Forms.TextBox();
            this.edt3 = new System.Windows.Forms.TextBox();
            this.edt4 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.whatsStandardDeviatedPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edt1
            // 
            this.edt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt1.Location = new System.Drawing.Point(56, 28);
            this.edt1.Margin = new System.Windows.Forms.Padding(4);
            this.edt1.Name = "edt1";
            this.edt1.Size = new System.Drawing.Size(120, 29);
            this.edt1.TabIndex = 0;
            this.edt1.Text = "0";
            this.edt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edt1_KeyDown);
            // 
            // memo
            // 
            this.memo.BackColor = System.Drawing.SystemColors.Control;
            this.memo.Font = new System.Drawing.Font("Segoe UI", 19.5F, System.Drawing.FontStyle.Bold);
            this.memo.Location = new System.Drawing.Point(220, 28);
            this.memo.Margin = new System.Windows.Forms.Padding(4);
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            this.memo.Size = new System.Drawing.Size(168, 192);
            this.memo.TabIndex = 6;
            this.memo.TabStop = false;
            this.memo.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(56, 186);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 34);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // edt2
            // 
            this.edt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt2.Location = new System.Drawing.Point(56, 67);
            this.edt2.Margin = new System.Windows.Forms.Padding(4);
            this.edt2.Name = "edt2";
            this.edt2.Size = new System.Drawing.Size(120, 29);
            this.edt2.TabIndex = 1;
            this.edt2.Text = "0";
            this.edt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edt2_KeyDown);
            // 
            // edt3
            // 
            this.edt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt3.Location = new System.Drawing.Point(56, 107);
            this.edt3.Margin = new System.Windows.Forms.Padding(4);
            this.edt3.Name = "edt3";
            this.edt3.Size = new System.Drawing.Size(120, 29);
            this.edt3.TabIndex = 2;
            this.edt3.Text = "0";
            this.edt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edt3_KeyDown);
            // 
            // edt4
            // 
            this.edt4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt4.Location = new System.Drawing.Point(56, 146);
            this.edt4.Margin = new System.Windows.Forms.Padding(4);
            this.edt4.Name = "edt4";
            this.edt4.Size = new System.Drawing.Size(120, 29);
            this.edt4.TabIndex = 3;
            this.edt4.Text = "0";
            this.edt4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edt4_KeyDown);
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt2.Location = new System.Drawing.Point(13, 31);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(40, 21);
            this.txt2.TabIndex = 7;
            this.txt2.Text = "osu!";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt3.Location = new System.Drawing.Point(8, 70);
            this.txt3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(45, 21);
            this.txt3.TabIndex = 8;
            this.txt3.Text = "Taiko";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt4.Location = new System.Drawing.Point(4, 110);
            this.txt4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(49, 21);
            this.txt4.TabIndex = 9;
            this.txt4.Text = "Catch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(0, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "pp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "pp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "pp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "pp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatsStandardDeviatedPPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // whatsStandardDeviatedPPToolStripMenuItem
            // 
            this.whatsStandardDeviatedPPToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.whatsStandardDeviatedPPToolStripMenuItem.Name = "whatsStandardDeviatedPPToolStripMenuItem";
            this.whatsStandardDeviatedPPToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.whatsStandardDeviatedPPToolStripMenuItem.Text = "What\'s Standard Deviated PP?";
            this.whatsStandardDeviatedPPToolStripMenuItem.Click += new System.EventHandler(this.whatsStandardDeviatedPPToolStripMenuItem_Click);
            // 
            // osuSTDEVpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.edt4);
            this.Controls.Add(this.edt3);
            this.Controls.Add(this.edt2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.edt1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "osuSTDEVpp";
            this.Text = "Standard Deviated PP Calculator V1.0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt1;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox edt2;
        private System.Windows.Forms.TextBox edt3;
        private System.Windows.Forms.TextBox edt4;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem whatsStandardDeviatedPPToolStripMenuItem;
    }
}

