namespace QUIZ_.net_Windows_forms
{
    partial class frm_P2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_P2));
            groupBox1 = new GroupBox();
            restrue = new RadioButton();
            resfalse3 = new RadioButton();
            resfalse2 = new RadioButton();
            resfalse1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(restrue);
            groupBox1.Controls.Add(resfalse3);
            groupBox1.Controls.Add(resfalse2);
            groupBox1.Controls.Add(resfalse1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(93, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 350);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // restrue
            // 
            restrue.AutoSize = true;
            restrue.Location = new Point(20, 120);
            restrue.Name = "restrue";
            restrue.Size = new Size(97, 34);
            restrue.TabIndex = 4;
            restrue.TabStop = true;
            restrue.Text = "b) new";
            restrue.UseVisualStyleBackColor = true;
            // 
            // resfalse3
            // 
            resfalse3.AutoSize = true;
            resfalse3.Location = new Point(20, 183);
            resfalse3.Name = "resfalse3";
            resfalse3.Size = new Size(132, 34);
            resfalse3.TabIndex = 3;
            resfalse3.TabStop = true;
            resfalse3.Text = "c) instance";
            resfalse3.UseVisualStyleBackColor = true;
            // 
            // resfalse2
            // 
            resfalse2.AutoSize = true;
            resfalse2.Location = new Point(20, 246);
            resfalse2.Name = "resfalse2";
            resfalse2.Size = new Size(101, 34);
            resfalse2.TabIndex = 2;
            resfalse2.TabStop = true;
            resfalse2.Text = "d) class";
            resfalse2.UseVisualStyleBackColor = true;
            // 
            // resfalse1
            // 
            resfalse1.AutoSize = true;
            resfalse1.Location = new Point(20, 57);
            resfalse1.Name = "resfalse1";
            resfalse1.Size = new Size(115, 34);
            resfalse1.TabIndex = 1;
            resfalse1.TabStop = true;
            resfalse1.Text = "a) create";
            resfalse1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 41);
            label1.Name = "label1";
            label1.Size = new Size(738, 79);
            label1.TabIndex = 2;
            label1.Text = "Qual é a palavra-chave usada para criar uma instância de uma classe em C#?";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(671, 441);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 3;
            button1.Text = "Proximo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frm_P2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(893, 536);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "frm_P2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PERGUNTA 2";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton restrue;
        private RadioButton resfalse3;
        private RadioButton resfalse2;
        private RadioButton resfalse1;
        private Label label1;
        private Button button1;
    }
}