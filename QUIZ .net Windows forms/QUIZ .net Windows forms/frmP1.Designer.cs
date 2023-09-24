namespace QUIZ_.net_Windows_forms
{
    partial class frmP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmP1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            restrue = new RadioButton();
            resfalse3 = new RadioButton();
            resfalse2 = new RadioButton();
            resfalse1 = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(658, 63);
            label1.TabIndex = 0;
            label1.Text = "O que é o CLR (Common Language Runtime) em C#?";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(restrue);
            groupBox1.Controls.Add(resfalse3);
            groupBox1.Controls.Add(resfalse2);
            groupBox1.Controls.Add(resfalse1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 350);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // restrue
            // 
            restrue.AutoSize = true;
            restrue.Location = new Point(14, 267);
            restrue.Name = "restrue";
            restrue.Size = new Size(491, 34);
            restrue.TabIndex = 4;
            restrue.TabStop = true;
            restrue.Text = "d) Um ambiente de desenvolvimento integrado";
            restrue.UseVisualStyleBackColor = true;
            // 
            // resfalse3
            // 
            resfalse3.AutoSize = true;
            resfalse3.Location = new Point(14, 187);
            resfalse3.Name = "resfalse3";
            resfalse3.Size = new Size(352, 34);
            resfalse3.TabIndex = 3;
            resfalse3.TabStop = true;
            resfalse3.Text = "c) Uma ferramenta de depuração";
            resfalse3.UseVisualStyleBackColor = true;
            // 
            // resfalse2
            // 
            resfalse2.AutoSize = true;
            resfalse2.Location = new Point(14, 112);
            resfalse2.Name = "resfalse2";
            resfalse2.Size = new Size(485, 34);
            resfalse2.TabIndex = 2;
            resfalse2.TabStop = true;
            resfalse2.Text = "b) Uma máquina virtual que executa código C#";
            resfalse2.UseVisualStyleBackColor = true;
            // 
            // resfalse1
            // 
            resfalse1.AutoSize = true;
            resfalse1.Location = new Point(14, 30);
            resfalse1.Name = "resfalse1";
            resfalse1.Size = new Size(313, 34);
            resfalse1.TabIndex = 1;
            resfalse1.TabStop = true;
            resfalse1.Text = "a) Uma biblioteca de gráficos";
            resfalse1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(590, 459);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 0;
            button1.Text = "Proximo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmP1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 536);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmP1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PERGUNTA 1";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton restrue;
        private RadioButton resfalse3;
        private RadioButton resfalse2;
        private RadioButton resfalse1;
        private Button button1;
    }
}