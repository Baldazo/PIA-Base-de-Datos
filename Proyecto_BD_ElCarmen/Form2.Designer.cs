namespace Proyecto_BD_ElCarmen
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Link1 = new System.Windows.Forms.LinkLabel();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Link1
            // 
            this.Link1.AutoSize = true;
            this.Link1.LinkColor = System.Drawing.Color.Gold;
            this.Link1.Location = new System.Drawing.Point(79, 227);
            this.Link1.Name = "Link1";
            this.Link1.Size = new System.Drawing.Size(253, 20);
            this.Link1.TabIndex = 15;
            this.Link1.TabStop = true;
            this.Link1.Text = "¿No tienes cuenta?, Registrate aquí....";
            this.Link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link1_LinkClicked);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(143, 124);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(125, 27);
            this.Txt2.TabIndex = 14;
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(143, 60);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(125, 27);
            this.Txt1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.ForeColor = System.Drawing.Color.Gold;
            this.btn1.Location = new System.Drawing.Point(125, 183);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(165, 29);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Iniciar Sesión";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.ForeColor = System.Drawing.Color.Gold;
            this.btn2.Location = new System.Drawing.Point(425, 267);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(132, 29);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Cerrar Sesión";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Link1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre del Proyecto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private LinkLabel Link1;
        private TextBox Txt2;
        private TextBox Txt1;
        private Label label2;
        private Label label1;
        private Button btn1;
        private Button btn2;
    }
}