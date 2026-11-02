namespace PicoyPlaca
{
    partial class AppConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppConsulta));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dataGridConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(29, 469);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(153, 40);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consulta";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(451, 479);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(331, 469);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(408, 359);
            this.nudHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudHora.Size = new System.Drawing.Size(56, 26);
            this.nudHora.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFecha.Location = new System.Drawing.Point(351, 277);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFecha.Size = new System.Drawing.Size(228, 26);
            this.dtpFecha.TabIndex = 14;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(351, 191);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlaca.Size = new System.Drawing.Size(223, 26);
            this.txtPlaca.TabIndex = 13;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(9, 359);
            this.lblhora.Name = "lblhora";
            this.lblhora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblhora.Size = new System.Drawing.Size(316, 20);
            this.lblhora.TabIndex = 12;
            this.lblhora.Text = "Ingresar la hora en la que va a circular";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(9, 283);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(310, 20);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Ingresar la fecha en la que va circular";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(9, 194);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlaca.Size = new System.Drawing.Size(262, 20);
            this.lblPlaca.TabIndex = 10;
            this.lblPlaca.Text = "Ingresar la placa de su vehiculo";
            // 
            // dataGridConsulta
            // 
            this.dataGridConsulta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsulta.Location = new System.Drawing.Point(609, 184);
            this.dataGridConsulta.Name = "dataGridConsulta";
            this.dataGridConsulta.RowHeadersWidth = 62;
            this.dataGridConsulta.RowTemplate.Height = 28;
            this.dataGridConsulta.Size = new System.Drawing.Size(627, 319);
            this.dataGridConsulta.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "SISTEMA DE CONSULTA PICO Y PLACA";
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(470, 359);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(63, 26);
            this.nudMinutos.TabIndex = 18;
            this.nudMinutos.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1071, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "HH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "MIN";
            // 
            // AppConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1257, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridConsulta);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConsultar);
            this.Name = "AppConsulta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "AppConsulta";
            this.Load += new System.EventHandler(this.AppConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DataGridView dataGridConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}