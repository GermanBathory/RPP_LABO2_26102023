namespace FabricaDeVehiculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstVehiculos = new ListBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 14);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(465, 424);
            lstVehiculos.TabIndex = 0;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(533, 277);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(229, 64);
            btnFabricar.TabIndex = 1;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(533, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(229, 64);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(544, 50);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(218, 23);
            cmbTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(565, 14);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(182, 30);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de vehiculo:";
            lblTipo.TextAlign = ContentAlignment.TopRight;
            lblTipo.Click += lblTipo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(587, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Button btnFabricar;
        private Button btnEliminar;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private PictureBox pictureBox1;
    }
}