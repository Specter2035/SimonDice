namespace SimonDiceProyectoFinal
{
    partial class SeleccionaNivel
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
            label2 = new Label();
            btnNivel1 = new Button();
            btnNivel2 = new Button();
            btnNivel3 = new Button();
            btnNivel4 = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(27, 28);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 2;
            label2.Text = "Selecciona nivel";
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(63, 55);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 3;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // btnNivel2
            // 
            btnNivel2.Location = new Point(63, 90);
            btnNivel2.Name = "btnNivel2";
            btnNivel2.Size = new Size(94, 29);
            btnNivel2.TabIndex = 4;
            btnNivel2.Text = "Nivel 2";
            btnNivel2.UseVisualStyleBackColor = true;
            btnNivel2.Click += btnNivel2_Click;
            // 
            // btnNivel3
            // 
            btnNivel3.Location = new Point(63, 125);
            btnNivel3.Name = "btnNivel3";
            btnNivel3.Size = new Size(94, 29);
            btnNivel3.TabIndex = 5;
            btnNivel3.Text = "Nivel 3";
            btnNivel3.UseVisualStyleBackColor = true;
            btnNivel3.Click += btnNivel3_Click;
            // 
            // btnNivel4
            // 
            btnNivel4.Location = new Point(63, 160);
            btnNivel4.Name = "btnNivel4";
            btnNivel4.Size = new Size(94, 29);
            btnNivel4.TabIndex = 6;
            btnNivel4.Text = "Nivel 4";
            btnNivel4.UseVisualStyleBackColor = true;
            btnNivel4.Click += btnNivel4_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(108, 214);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // SeleccionaNivel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(228, 269);
            Controls.Add(btnRegresar);
            Controls.Add(btnNivel4);
            Controls.Add(btnNivel3);
            Controls.Add(btnNivel2);
            Controls.Add(btnNivel1);
            Controls.Add(label2);
            Name = "SeleccionaNivel";
            Text = "SeleccionaNivel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnNivel1;
        private Button btnNivel2;
        private Button btnNivel3;
        private Button btnNivel4;
        private Button btnRegresar;
    }
}