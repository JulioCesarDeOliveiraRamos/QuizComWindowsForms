namespace QUIZ_.net_Windows_forms
{
    partial class frmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmin));
            buttonIniciar = new Button();
            button2 = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // buttonIniciar
            // 
            buttonIniciar.BackColor = SystemColors.Highlight;
            buttonIniciar.Cursor = Cursors.Hand;
            buttonIniciar.FlatStyle = FlatStyle.Flat;
            buttonIniciar.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            buttonIniciar.Location = new Point(357, 164);
            buttonIniciar.Margin = new Padding(4);
            buttonIniciar.Name = "buttonIniciar";
            buttonIniciar.Size = new Size(163, 61);
            buttonIniciar.TabIndex = 0;
            buttonIniciar.Text = "INICIAR😎";
            buttonIniciar.UseVisualStyleBackColor = false;
            buttonIniciar.Click += buttonIniciar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(357, 256);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(163, 61);
            button2.TabIndex = 1;
            button2.Text = "CRÉDITOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = SystemColors.Highlight;
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            buttonSair.Location = new Point(357, 348);
            buttonSair.Margin = new Padding(4);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(163, 61);
            buttonSair.TabIndex = 2;
            buttonSair.Text = "SAIR";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // frmin
            // 
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 536);
            Controls.Add(buttonSair);
            Controls.Add(button2);
            Controls.Add(buttonIniciar);
            Cursor = Cursors.Hand;
            Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUIZ";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonIniciar;
        private Button button2;
        private Button buttonSair;
    }
}