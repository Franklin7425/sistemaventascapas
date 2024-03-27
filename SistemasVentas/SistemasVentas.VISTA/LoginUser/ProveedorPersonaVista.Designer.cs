namespace SistemasVentas.VISTA.LoginUser
{
    partial class ProveedorPersonaVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorPersonaVista));
            label1 = new Label();
            pMenu = new Button();
            panel1 = new Panel();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE PRODUCTOS";
            // 
            // pMenu
            // 
            pMenu.Location = new Point(398, 9);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(75, 23);
            pMenu.TabIndex = 1;
            pMenu.Text = "MENU";
            pMenu.UseVisualStyleBackColor = true;
            pMenu.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Location = new Point(352, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 23);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 2;
            button2.Text = "CERRAR SESION";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(461, 330);
            dataGridView1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(342, 394);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 394);
            button1.Name = "button1";
            button1.Size = new Size(324, 23);
            button1.TabIndex = 17;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // ProveedorPersonaVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(482, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pMenu);
            Controls.Add(label1);
            Name = "ProveedorPersonaVista";
            Text = "ProveedorPersonaVista";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button pMenu;
        private Panel panel1;
        private Button button2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}