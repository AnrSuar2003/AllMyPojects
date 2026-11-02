namespace SerpeintesEscaleras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

       
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoScroll = true;
            this.pnlBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnlBoard.Location = new System.Drawing.Point(23, 12);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(692, 891);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_cl);
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Image = ((System.Drawing.Image)(resources.GetObject("btnRollDice.Image")));
            this.btnRollDice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRollDice.Location = new System.Drawing.Point(758, 43);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(153, 76);
            this.btnRollDice.TabIndex = 4;
            this.btnRollDice.Text = "TIRAR DADO";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(736, 233);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(0, 22);
            this.lblTurno.TabIndex = 5;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayer1.Image")));
            this.lblPlayer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayer1.Location = new System.Drawing.Point(736, 329);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(64, 22);
            this.lblPlayer1.TabIndex = 6;
            this.lblPlayer1.Text = "label1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayer2.Image")));
            this.lblPlayer2.Location = new System.Drawing.Point(736, 380);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(64, 22);
            this.lblPlayer2.TabIndex = 7;
            this.lblPlayer2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(758, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "REVANCHA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1011, 929);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.pnlBoard);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button button1;
    }
}

