namespace TAndMLevelDesigner
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChangeSize = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumnAmount = new System.Windows.Forms.Label();
            this.mapEditPanel = new System.Windows.Forms.Panel();
            this.minotaurImageBackPanel = new System.Windows.Forms.Panel();
            this.pictureBoxMinotaur = new System.Windows.Forms.PictureBox();
            this.thesuesImageBackPanel = new System.Windows.Forms.Panel();
            this.pictureBoxTheseus = new System.Windows.Forms.PictureBox();
            this.superPanel = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mapEditPanel.SuspendLayout();
            this.minotaurImageBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinotaur)).BeginInit();
            this.thesuesImageBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheseus)).BeginInit();
            this.superPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            // 
            // btnChangeSize
            // 
            this.btnChangeSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeSize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangeSize.FlatAppearance.BorderSize = 2;
            this.btnChangeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeSize.Location = new System.Drawing.Point(34, 114);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(100, 28);
            this.btnChangeSize.TabIndex = 1;
            this.btnChangeSize.Text = "Set Size";
            this.btnChangeSize.UseVisualStyleBackColor = false;
            this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(34, 35);
            this.txtRows.Name = "txtRows";
            this.txtRows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 2;
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(34, 77);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(34, 16);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(112, 13);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Enter Row Amount";
            // 
            // lblColumnAmount
            // 
            this.lblColumnAmount.AutoSize = true;
            this.lblColumnAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnAmount.Location = new System.Drawing.Point(34, 61);
            this.lblColumnAmount.Name = "lblColumnAmount";
            this.lblColumnAmount.Size = new System.Drawing.Size(128, 13);
            this.lblColumnAmount.TabIndex = 5;
            this.lblColumnAmount.Text = "Enter Column Amount";
            // 
            // mapEditPanel
            // 
            this.mapEditPanel.Controls.Add(this.minotaurImageBackPanel);
            this.mapEditPanel.Controls.Add(this.thesuesImageBackPanel);
            this.mapEditPanel.Controls.Add(this.lblRows);
            this.mapEditPanel.Controls.Add(this.lblColumnAmount);
            this.mapEditPanel.Controls.Add(this.btnChangeSize);
            this.mapEditPanel.Controls.Add(this.txtRows);
            this.mapEditPanel.Controls.Add(this.txtColumns);
            this.mapEditPanel.Location = new System.Drawing.Point(622, 12);
            this.mapEditPanel.Name = "mapEditPanel";
            this.mapEditPanel.Size = new System.Drawing.Size(180, 544);
            this.mapEditPanel.TabIndex = 6;
            // 
            // minotaurImageBackPanel
            // 
            this.minotaurImageBackPanel.Controls.Add(this.pictureBoxMinotaur);
            this.minotaurImageBackPanel.Location = new System.Drawing.Point(13, 345);
            this.minotaurImageBackPanel.Name = "minotaurImageBackPanel";
            this.minotaurImageBackPanel.Size = new System.Drawing.Size(149, 162);
            this.minotaurImageBackPanel.TabIndex = 9;
            // 
            // pictureBoxMinotaur
            // 
            this.pictureBoxMinotaur.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMinotaur.Name = "pictureBoxMinotaur";
            this.pictureBoxMinotaur.Size = new System.Drawing.Size(140, 153);
            this.pictureBoxMinotaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMinotaur.TabIndex = 7;
            this.pictureBoxMinotaur.TabStop = false;
            this.pictureBoxMinotaur.Click += new System.EventHandler(this.pictureBoxMinotaur_Click);
            // 
            // thesuesImageBackPanel
            // 
            this.thesuesImageBackPanel.Controls.Add(this.pictureBoxTheseus);
            this.thesuesImageBackPanel.Location = new System.Drawing.Point(13, 167);
            this.thesuesImageBackPanel.Name = "thesuesImageBackPanel";
            this.thesuesImageBackPanel.Size = new System.Drawing.Size(149, 161);
            this.thesuesImageBackPanel.TabIndex = 8;
            // 
            // pictureBoxTheseus
            // 
            this.pictureBoxTheseus.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTheseus.Name = "pictureBoxTheseus";
            this.pictureBoxTheseus.Size = new System.Drawing.Size(140, 153);
            this.pictureBoxTheseus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTheseus.TabIndex = 6;
            this.pictureBoxTheseus.TabStop = false;
            this.pictureBoxTheseus.UseWaitCursor = true;
            this.pictureBoxTheseus.Click += new System.EventHandler(this.pictureBoxTheseus_Click);
            // 
            // superPanel
            // 
            this.superPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.superPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.superPanel.Controls.Add(this.lblHeading);
            this.superPanel.Controls.Add(this.mapEditPanel);
            this.superPanel.Controls.Add(this.pictureBox1);
            this.superPanel.Location = new System.Drawing.Point(6, 12);
            this.superPanel.Name = "superPanel";
            this.superPanel.Size = new System.Drawing.Size(831, 700);
            this.superPanel.TabIndex = 7;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(36, 5);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(521, 36);
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "Theseus and the Minotaur Level Designer";
            // 
            // Form1
            // 
            this.AccessibleName = "theGameForm";
            this.ClientSize = new System.Drawing.Size(849, 746);
            this.Controls.Add(this.superPanel);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mapEditPanel.ResumeLayout(false);
            this.mapEditPanel.PerformLayout();
            this.minotaurImageBackPanel.ResumeLayout(false);
            this.minotaurImageBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinotaur)).EndInit();
            this.thesuesImageBackPanel.ResumeLayout(false);
            this.thesuesImageBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheseus)).EndInit();
            this.superPanel.ResumeLayout(false);
            this.superPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeSize;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumnAmount;
        private System.Windows.Forms.Panel mapEditPanel;
        private System.Windows.Forms.PictureBox pictureBoxMinotaur;
        private System.Windows.Forms.PictureBox pictureBoxTheseus;
        private System.Windows.Forms.Panel thesuesImageBackPanel;
        private System.Windows.Forms.Panel minotaurImageBackPanel;
        private System.Windows.Forms.Panel superPanel;
        private System.Windows.Forms.Label lblHeading;

        
    }
}

