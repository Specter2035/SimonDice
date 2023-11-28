namespace SimonDiceProyectoFinal
{
    partial class SeleccionaNivelInverso
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
            btnNivel3 = new Button();
            btnNivel2 = new Button();
            btnNivel1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(122, 216);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnNivel3
            // 
            btnNivel3.Location = new Point(77, 152);
            btnNivel3.Name = "btnNivel3";
            btnNivel3.Size = new Size(94, 29);
            btnNivel3.TabIndex = 11;
            btnNivel3.Text = "Nivel 3";
            btnNivel3.UseVisualStyleBackColor = true;
            // 
            // btnNivel2
            // 
            btnNivel2.Location = new Point(77, 117);
            btnNivel2.Name = "btnNivel2";
            btnNivel2.Size = new Size(94, 29);
            btnNivel2.TabIndex = 10;
            btnNivel2.Text = "Nivel 2";
            btnNivel2.UseVisualStyleBackColor = true;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(77, 82);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 9;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(41, 55);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 8;
            label2.Text = "Selecciona nivel";
            // 
            // SeleccionaNivelInverso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(268, 283);
            Controls.Add(btnRegresar);
            Controls.Add(btnNivel3);
            Controls.Add(btnNivel2);
            Controls.Add(btnNivel1);
            Controls.Add(label2);
            Name = "SeleccionaNivelInverso";
            Text = "SeleccionaNivelInverso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnNivel3;
        private Button btnNivel2;
        private Button btnNivel1;
        private Label label2;
    }
}