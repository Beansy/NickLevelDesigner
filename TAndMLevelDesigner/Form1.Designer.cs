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
            this.pictureBoxTheseus = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinotaur = new System.Windows.Forms.PictureBox();
            this.thesuesImageBackPanel = new System.Windows.Forms.Panel();
            this.minotaurImageBackPanel = new System.Windows.Forms.Panel();
            this.superPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mapEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheseus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinotaur)).BeginInit();
            this.thesuesImageBackPanel.SuspendLayout();
            this.minotaurImageBackPanel.SuspendLayout();
            this.superPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
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
            this.btnChangeSize.Location = new System.Drawing.Point(13, 112);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSize.TabIndex = 1;
            this.btnChangeSize.Text = "Set Size";
            this.btnChangeSize.UseVisualStyleBackColor = true;
            this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(13, 32);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 2;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(13, 74);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(13, 13);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(96, 13);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Enter Row Amount";
            // 
            // lblColumnAmount
            // 
            this.lblColumnAmount.AutoSize = true;
            this.lblColumnAmount.Location = new System.Drawing.Point(13, 58);
            this.lblColumnAmount.Name = "lblColumnAmount";
            this.lblColumnAmount.Size = new System.Drawing.Size(109, 13);
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
            // minotaurImageBackPanel
            // 
            this.minotaurImageBackPanel.Controls.Add(this.pictureBoxMinotaur);
            this.minotaurImageBackPanel.Location = new System.Drawing.Point(13, 345);
            this.minotaurImageBackPanel.Name = "minotaurImageBackPanel";
            this.minotaurImageBackPanel.Size = new System.Drawing.Size(149, 162);
            this.minotaurImageBackPanel.TabIndex = 9;
            // 
            // superPanel
            // 
            this.superPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.superPanel.Controls.Add(this.mapEditPanel);
            this.superPanel.Controls.Add(this.pictureBox1);
            this.superPanel.Location = new System.Drawing.Point(6, 12);
            this.superPanel.Name = "superPanel";
            this.superPanel.Size = new System.Drawing.Size(831, 700);
            this.superPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(849, 746);
            this.Controls.Add(this.superPanel);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mapEditPanel.ResumeLayout(false);
            this.mapEditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheseus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinotaur)).EndInit();
            this.thesuesImageBackPanel.ResumeLayout(false);
            this.thesuesImageBackPanel.PerformLayout();
            this.minotaurImageBackPanel.ResumeLayout(false);
            this.minotaurImageBackPanel.PerformLayout();
            this.superPanel.ResumeLayout(false);
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

        
    }
}

