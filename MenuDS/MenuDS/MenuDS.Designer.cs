
namespace MenuDS
{
    partial class MenuDS
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraCientíficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcOrientadaAObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcOrientadaAObjetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(135, 17);
            this.StatusLabel.Text = "Selecione um aplicativo.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplicativosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraSimplesToolStripMenuItem,
            this.calculadoraCientíficaToolStripMenuItem,
            this.calcOrientadaAObjetoToolStripMenuItem,
            this.calcOrientadaAObjetoToolStripMenuItem1});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            // 
            // calculadoraSimplesToolStripMenuItem
            // 
            this.calculadoraSimplesToolStripMenuItem.Name = "calculadoraSimplesToolStripMenuItem";
            this.calculadoraSimplesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.calculadoraSimplesToolStripMenuItem.Text = "Calculadora Simples";
            this.calculadoraSimplesToolStripMenuItem.Click += new System.EventHandler(this.calculadoraSimplesToolStripMenuItem_Click);
            // 
            // calculadoraCientíficaToolStripMenuItem
            // 
            this.calculadoraCientíficaToolStripMenuItem.Name = "calculadoraCientíficaToolStripMenuItem";
            this.calculadoraCientíficaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.calculadoraCientíficaToolStripMenuItem.Text = "Calculadora Científica";
            this.calculadoraCientíficaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraCientíficaToolStripMenuItem_Click);
            // 
            // calcOrientadaAObjetoToolStripMenuItem
            // 
            this.calcOrientadaAObjetoToolStripMenuItem.Name = "calcOrientadaAObjetoToolStripMenuItem";
            this.calcOrientadaAObjetoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.calcOrientadaAObjetoToolStripMenuItem.Text = "Calculadora Selecionável";
            this.calcOrientadaAObjetoToolStripMenuItem.Click += new System.EventHandler(this.calcOrientadaAObjetoToolStripMenuItem_Click);
            // 
            // calcOrientadaAObjetoToolStripMenuItem1
            // 
            this.calcOrientadaAObjetoToolStripMenuItem1.Name = "calcOrientadaAObjetoToolStripMenuItem1";
            this.calcOrientadaAObjetoToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.calcOrientadaAObjetoToolStripMenuItem1.Text = "Calculadora RadioButton";
            this.calcOrientadaAObjetoToolStripMenuItem1.Click += new System.EventHandler(this.calcOrientadaAObjetoToolStripMenuItem1_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(394, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(521, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu DS - Menu de Aplicativos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraCientíficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcOrientadaAObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem calcOrientadaAObjetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}