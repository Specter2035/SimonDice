namespace SimonDiceProyectoFinal
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
            groupBox1 = new GroupBox();
            btnSimonBrinca = new Button();
            btnSimonSorpresa = new Button();
            btnSimonInverso = new Button();
            btnSimonClasico = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSimonBrinca);
            groupBox1.Controls.Add(btnSimonSorpresa);
            groupBox1.Controls.Add(btnSimonInverso);
            groupBox1.Controls.Add(btnSimonClasico);
            groupBox1.Location = new Point(29, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSimonBrinca
            // 
            btnSimonBrinca.BackColor = Color.DeepSkyBlue;
            btnSimonBrinca.Location = new Point(307, 26);
            btnSimonBrinca.Name = "btnSimonBrinca";
            btnSimonBrinca.Size = new Size(94, 49);
            btnSimonBrinca.TabIndex = 3;
            btnSimonBrinca.Text = "Simon brinca";
            btnSimonBrinca.UseVisualStyleBackColor = false;
            // 
            // btnSimonSorpresa
            // 
            btnSimonSorpresa.BackColor = Color.Yellow;
            btnSimonSorpresa.Location = new Point(207, 26);
            btnSimonSorpresa.Name = "btnSimonSorpresa";
            btnSimonSorpresa.Size = new Size(94, 49);
            btnSimonSorpresa.TabIndex = 2;
            btnSimonSorpresa.Text = "Simon sopresa";
            btnSimonSorpresa.UseVisualStyleBackColor = false;
            // 
            // btnSimonInverso
            // 
            btnSimonInverso.BackColor = Color.Red;
            btnSimonInverso.Location = new Point(107, 26);
            btnSimonInverso.Name = "btnSimonInverso";
            btnSimonInverso.Size = new Size(94, 49);
            btnSimonInverso.TabIndex = 1;
            btnSimonInverso.Text = "Simon dice inverso";
            btnSimonInverso.UseVisualStyleBackColor = false;
            btnSimonInverso.Click += btnSimonInverso_Click;
            // 
            // btnSimonClasico
            // 
            btnSimonClasico.BackColor = Color.Chartreuse;
            btnSimonClasico.Location = new Point(7, 26);
            btnSimonClasico.Name = "btnSimonClasico";
            btnSimonClasico.Size = new Size(94, 49);
            btnSimonClasico.TabIndex = 0;
            btnSimonClasico.Text = "Simon dice";
            btnSimonClasico.UseVisualStyleBackColor = false;
            btnSimonClasico.Click += btnSimonClasico_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(63, 64);
            label1.Name = "label1";
            label1.Size = new Size(345, 27);
            label1.TabIndex = 1;
            label1.Text = "Selecciona modo de juego";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(151, 9);
            label2.Name = "label2";
            label2.Size = new Size(179, 33);
            label2.TabIndex = 2;
            label2.Text = "Simon Dice";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(330, 456);
            button1.Name = "button1";
            button1.Size = new Size(107, 33);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(470, 524);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSimonBrinca;
        private Button btnSimonSorpresa;
        private Button btnSimonInverso;
        private Button btnSimonClasico;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
