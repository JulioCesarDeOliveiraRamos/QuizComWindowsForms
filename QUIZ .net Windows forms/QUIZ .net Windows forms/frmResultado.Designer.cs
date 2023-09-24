namespace QUIZ_.net_Windows_forms
{
    partial class frmResultado
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
            Label label3;
            Label acertos;
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultado));
            label2 = new Label();
            label4 = new Label();
            buttonSair = new Button();
            label3 = new Label();
            acertos = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Goudy Stout", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 295);
            label3.Name = "label3";
            label3.Size = new Size(245, 44);
            label3.TabIndex = 7;
            label3.Text = "Erros :";
            // 
            // acertos
            // 
            acertos.AutoSize = true;
            acertos.BackColor = Color.Transparent;
            acertos.FlatStyle = FlatStyle.Flat;
            acertos.Font = new Font("Goudy Stout", 24F, FontStyle.Italic, GraphicsUnit.Point);
            acertos.ForeColor = Color.White;
            acertos.Location = new Point(78, 189);
            acertos.Name = "acertos";
            acertos.Size = new Size(317, 44);
            acertos.TabIndex = 6;
            acertos.Text = "Acertos :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Goudy Stout", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(78, 88);
            label1.Name = "label1";
            label1.Size = new Size(372, 44);
            label1.TabIndex = 5;
            label1.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.White;
            label2.Location = new Point(401, 198);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(343, 304);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Transparent;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            buttonSair.ForeColor = SystemColors.ActiveCaption;
            buttonSair.Location = new Point(343, 398);
            buttonSair.Margin = new Padding(4);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(163, 61);
            buttonSair.TabIndex = 12;
            buttonSair.Text = "SAIR";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // frmResultado
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 536);
            Controls.Add(buttonSair);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(acertos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmResultado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmResultado";
            WindowState = FormWindowState.Maximized;
            Load += frmResultado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label4;
        public Label label2;
        private Button buttonSair;
    }
}