namespace SimonDiceProyectoFinal
{
    partial class SimonDiceN2
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
            lblPuntos = new Label();
            button2 = new Button();
            label1 = new Label();
            P_3 = new PictureBox();
            P_2 = new PictureBox();
            P_1 = new PictureBox();
            P_0 = new PictureBox();
            P_4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)P_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_4).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Gray;
            btnRegresar.Font = new Font("Stencil", 10.8F);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(509, 485);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 33);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(373, 41);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(33, 34);
            lblPuntos.TabIndex = 19;
            lblPuntos.Text = "0";
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(328, 485);
            button2.Name = "button2";
            button2.Size = new Size(112, 33);
            button2.TabIndex = 18;
            button2.Text = "Comenzar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 41);
            label1.Name = "label1";
            label1.Size = new Size(125, 34);
            label1.TabIndex = 17;
            label1.Text = "Puntos:";
            // 
            // P_3
            // 
            P_3.Image = Properties.Resources.CAmarillo1;
            P_3.Location = new Point(363, 280);
            P_3.Name = "P_3";
            P_3.Size = new Size(204, 161);
            P_3.TabIndex = 16;
            P_3.TabStop = false;
            P_3.Click += P_0_Click;
            P_3.MouseDown += P_3_MouseDown;
            P_3.MouseUp += P_3_MouseUp;
            // 
            // P_2
            // 
            P_2.Image = Properties.Resources.CRojo_1;
            P_2.Location = new Point(153, 280);
            P_2.Name = "P_2";
            P_2.Size = new Size(204, 161);
            P_2.TabIndex = 15;
            P_2.TabStop = false;
            P_2.Click += P_0_Click;
            P_2.MouseDown += P_2_MouseDown;
            P_2.MouseUp += P_2_MouseUp;
            // 
            // P_1
            // 
            P_1.Image = Properties.Resources.CVerde_1;
            P_1.Location = new Point(255, 113);
            P_1.Name = "P_1";
            P_1.Size = new Size(204, 161);
            P_1.TabIndex = 14;
            P_1.TabStop = false;
            P_1.Click += P_0_Click;
            P_1.MouseDown += P_1_MouseDown;
            P_1.MouseUp += P_1_MouseUp;
            // 
            // P_0
            // 
            P_0.Image = Properties.Resources.CAzul_1;
            P_0.Location = new Point(45, 113);
            P_0.Name = "P_0";
            P_0.Size = new Size(204, 161);
            P_0.TabIndex = 13;
            P_0.TabStop = false;
            P_0.Click += P_0_Click;
            P_0.MouseDown += P_0_MouseDown;
            P_0.MouseUp += P_0_MouseUp;
            // 
            // P_4
            // 
            P_4.Image = Properties.Resources.CNegro_1;
            P_4.Location = new Point(465, 113);
            P_4.Name = "P_4";
            P_4.Size = new Size(204, 161);
            P_4.TabIndex = 20;
            P_4.TabStop = false;
            P_4.Click += P_0_Click;
            P_4.MouseDown += P_4_MouseDown;
            P_4.MouseUp += P_4_MouseUp;
            // 
            // SimonDiceN2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(700, 551);
            Controls.Add(P_4);
            Controls.Add(lblPuntos);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(P_3);
            Controls.Add(P_2);
            Controls.Add(P_1);
            Controls.Add(P_0);
            Controls.Add(btnRegresar);
            Name = "SimonDiceN2";
            Text = "SimonDiceN2";
            ((System.ComponentModel.ISupportInitialize)P_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_0).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label lblPuntos;
        private Button button2;
        private Label label1;
        private PictureBox P_3;
        private PictureBox P_2;
        private PictureBox P_1;
        private PictureBox P_0;
        private PictureBox P_4;
    }
}