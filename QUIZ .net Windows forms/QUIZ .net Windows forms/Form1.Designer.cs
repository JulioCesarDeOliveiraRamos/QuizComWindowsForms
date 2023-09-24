namespace QUIZ_.net_Windows_forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSair = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSair
            // 
            buttonSair.BackColor = SystemColors.Highlight;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            buttonSair.Location = new Point(299, 415);
            buttonSair.Margin = new Padding(4);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(296, 61);
            buttonSair.TabIndex = 3;
            buttonSair.Text = "SAIR";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(340, 197);
            label1.Name = "label1";
            label1.Size = new Size(213, 36);
            label1.TabIndex = 4;
            label1.Text = "Julio Ramos";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(192, 255, 255);
            linkLabel1.Location = new Point(224, 313);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(448, 24);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/JulioCesarDeOliveiraRamos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(376, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 536);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(buttonSair);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Créditos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSair;
        private Label label1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}