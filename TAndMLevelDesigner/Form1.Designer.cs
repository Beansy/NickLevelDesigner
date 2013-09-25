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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(46, 45);
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
            this.btnChangeSize.Location = new System.Drawing.Point(700, 144);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSize.TabIndex = 1;
            this.btnChangeSize.Text = "Set Size";
            this.btnChangeSize.UseVisualStyleBackColor = true;
            this.btnChangeSize.Click += new System.EventHandler(this.btnChangeSize_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(700, 64);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 2;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(700, 106);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(700, 45);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(96, 13);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Enter Row Amount";
            // 
            // lblColumnAmount
            // 
            this.lblColumnAmount.AutoSize = true;
            this.lblColumnAmount.Location = new System.Drawing.Point(700, 90);
            this.lblColumnAmount.Name = "lblColumnAmount";
            this.lblColumnAmount.Size = new System.Drawing.Size(109, 13);
            this.lblColumnAmount.TabIndex = 5;
            this.lblColumnAmount.Text = "Enter Column Amount";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(849, 746);
            this.Controls.Add(this.lblColumnAmount);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.btnChangeSize);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChangeSize;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumnAmount;

        
    }
}

