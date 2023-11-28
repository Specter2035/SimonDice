namespace SimonDiceProyectoFinal
{
    partial class SimonDiceInversoN1
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
            btnRegresar = new Button();
            btnComenzar = new Button();
            lblPuntos = new Label();
            label1 = new Label();
            P_3 = new PictureBox();
            P_2 = new PictureBox();
            P_1 = new PictureBox();
            P_0 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)P_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_0).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Gray;
            btnRegresar.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(386, 525);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(107, 33);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.BackColor = Color.Gray;
            btnComenzar.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComenzar.ForeColor = Color.White;
            btnComenzar.Location = new Point(253, 525);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(113, 33);
            btnComenzar.TabIndex = 6;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = false;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(354, 29);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(33, 34);
            lblPuntos.TabIndex = 17;
            lblPuntos.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 29);
            label1.Name = "label1";
            label1.Size = new Size(125, 34);
            label1.TabIndex = 16;
            label1.Text = "Puntos:";
            // 
            // P_3
            // 
            P_3.Image = Properties.Resources.CAmarillo1;
            P_3.Location = new Point(294, 280);
            P_3.Name = "P_3";
            P_3.Size = new Size(204, 192);
            P_3.TabIndex = 15;
            P_3.TabStop = false;
            P_3.Click += P_0_Click;
            P_3.MouseDown += P_3_MouseDown;
            P_3.MouseUp += P_3_MouseUp;
            // 
            // P_2
            // 
            P_2.Image = Properties.Resources.CRojo_1;
            P_2.Location = new Point(84, 280);
            P_2.Name = "P_2";
            P_2.Size = new Size(204, 192);
            P_2.TabIndex = 14;
            P_2.TabStop = false;
            P_2.Click += P_0_Click;
            P_2.MouseDown += P_2_MouseDown;
            P_2.MouseUp += P_2_MouseUp;
            // 
            // P_1
            // 
            P_1.Image = Properties.Resources.CVerde_1;
            P_1.Location = new Point(294, 82);
            P_1.Name = "P_1";
            P_1.Size = new Size(204, 192);
            P_1.TabIndex = 13;
            P_1.TabStop = false;
            P_1.Click += P_0_Click;
            P_1.MouseDown += P_1_MouseDown;
            P_1.MouseUp += P_1_MouseUp;
            // 
            // P_0
            // 
            P_0.Image = Properties.Resources.CAzul_1;
            P_0.Location = new Point(84, 82);
            P_0.Name = "P_0";
            P_0.Size = new Size(204, 192);
            P_0.TabIndex = 12;
            P_0.TabStop = false;
            P_0.Click += P_0_Click;
            P_0.MouseDown += P_0_MouseDown;
            P_0.MouseUp += P_0_MouseUp;
            // 
            // SimonDiceInverso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(614, 623);
            Controls.Add(lblPuntos);
            Controls.Add(label1);
            Controls.Add(P_3);
            Controls.Add(P_2);
            Controls.Add(P_1);
            Controls.Add(P_0);
            Controls.Add(btnComenzar);
            Controls.Add(btnRegresar);
            Name = "SimonDiceInverso";
            Text = "SimonDiceInverso";
            ((System.ComponentModel.ISupportInitialize)P_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_0).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnComenzar;
        private Label lblPuntos;
        private Label label1;
        private PictureBox P_3;
        private PictureBox P_2;
        private PictureBox P_1;
        private PictureBox P_0;
    }
}