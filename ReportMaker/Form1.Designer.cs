namespace ReportMaker
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
            this.pnlMenuBg = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTopmenuBg = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenuBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBg
            // 
            this.pnlMenuBg.BackColor = System.Drawing.Color.Black;
            this.pnlMenuBg.Controls.Add(this.panel4);
            this.pnlMenuBg.Controls.Add(this.btnVisualizar);
            this.pnlMenuBg.Controls.Add(this.panel3);
            this.pnlMenuBg.Controls.Add(this.btnCriar);
            this.pnlMenuBg.Controls.Add(this.panel2);
            this.pnlMenuBg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuBg.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBg.Name = "pnlMenuBg";
            this.pnlMenuBg.Size = new System.Drawing.Size(158, 450);
            this.pnlMenuBg.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 205);
            this.panel4.TabIndex = 3;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisualizar.Location = new System.Drawing.Point(0, 205);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(158, 40);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 46);
            this.panel3.TabIndex = 2;
            // 
            // btnCriar
            // 
            this.btnCriar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCriar.Location = new System.Drawing.Point(0, 119);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(158, 40);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 119);
            this.panel2.TabIndex = 1;
            // 
            // pnlTopmenuBg
            // 
            this.pnlTopmenuBg.BackColor = System.Drawing.Color.Gray;
            this.pnlTopmenuBg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopmenuBg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTopmenuBg.Location = new System.Drawing.Point(158, 0);
            this.pnlTopmenuBg.Name = "pnlTopmenuBg";
            this.pnlTopmenuBg.Size = new System.Drawing.Size(642, 24);
            this.pnlTopmenuBg.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(158, 24);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(623, 426);
            this.pnlContainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(781, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 426);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopmenuBg);
            this.Controls.Add(this.pnlMenuBg);
            this.Name = "Form1";
            this.Text = "Home";
            this.pnlMenuBg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMenuBg;
        private Panel panel4;
        private Button btnVisualizar;
        private Panel panel3;
        private Button btnCriar;
        private Panel panel2;
        private Panel pnlTopmenuBg;
        private Panel pnlContainer;
        private Panel panel1;
    }
}