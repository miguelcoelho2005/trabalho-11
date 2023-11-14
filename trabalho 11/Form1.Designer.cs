namespace trabalho_11
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mudarCorELetraToolStripMenuItem = new ToolStripMenuItem();
            mudarCorELetraToolStripMenuItem1 = new ToolStripMenuItem();
            letraToolStripMenuItem = new ToolStripMenuItem();
            corToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 170);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "me";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mudarCorELetraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mudarCorELetraToolStripMenuItem
            // 
            mudarCorELetraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mudarCorELetraToolStripMenuItem1 });
            mudarCorELetraToolStripMenuItem.Name = "mudarCorELetraToolStripMenuItem";
            mudarCorELetraToolStripMenuItem.Size = new Size(109, 20);
            mudarCorELetraToolStripMenuItem.Text = "mudar cor e letra";
            // 
            // mudarCorELetraToolStripMenuItem1
            // 
            mudarCorELetraToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { letraToolStripMenuItem, corToolStripMenuItem });
            mudarCorELetraToolStripMenuItem1.Name = "mudarCorELetraToolStripMenuItem1";
            mudarCorELetraToolStripMenuItem1.Size = new Size(180, 22);
            mudarCorELetraToolStripMenuItem1.Text = "mudar cor e letra";
            // 
            // letraToolStripMenuItem
            // 
            letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            letraToolStripMenuItem.Size = new Size(180, 22);
            letraToolStripMenuItem.Text = "letra";
            letraToolStripMenuItem.Click += letraToolStripMenuItem_Click;
            // 
            // corToolStripMenuItem
            // 
            corToolStripMenuItem.Name = "corToolStripMenuItem";
            corToolStripMenuItem.Size = new Size(180, 22);
            corToolStripMenuItem.Text = "cor";
            corToolStripMenuItem.Click += corToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mudarCorELetraToolStripMenuItem;
        private ToolStripMenuItem mudarCorELetraToolStripMenuItem1;
        private ToolStripMenuItem letraToolStripMenuItem;
        private ToolStripMenuItem corToolStripMenuItem;
    }
}