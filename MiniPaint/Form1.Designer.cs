namespace MiniPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.lblpen = new System.Windows.Forms.Label();
            this.lblback = new System.Windows.Forms.Label();
            this.btnCanvasColor = new System.Windows.Forms.Button();
            this.lblfigure = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.rect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.undoToolStripMenuItem.Text = "Назад";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.redoToolStripMenuItem.Text = "Вперед";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDraw.Location = new System.Drawing.Point(17, 94);
            this.pnlDraw.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(822, 525);
            this.pnlDraw.TabIndex = 2;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            this.pnlDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseClick);
            this.pnlDraw.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDoubleClick);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            // 
            // lblpen
            // 
            this.lblpen.AutoSize = true;
            this.lblpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpen.ForeColor = System.Drawing.Color.Black;
            this.lblpen.Location = new System.Drawing.Point(1021, 94);
            this.lblpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpen.Name = "lblpen";
            this.lblpen.Size = new System.Drawing.Size(64, 20);
            this.lblpen.TabIndex = 1;
            this.lblpen.Text = "Кисть";
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblback.ForeColor = System.Drawing.Color.Black;
            this.lblback.Location = new System.Drawing.Point(13, 28);
            this.lblback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(48, 20);
            this.lblback.TabIndex = 1;
            this.lblback.Text = "Фон";
            // 
            // btnCanvasColor
            // 
            this.btnCanvasColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnCanvasColor.Location = new System.Drawing.Point(17, 52);
            this.btnCanvasColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCanvasColor.Name = "btnCanvasColor";
            this.btnCanvasColor.Size = new System.Drawing.Size(163, 34);
            this.btnCanvasColor.TabIndex = 4;
            this.btnCanvasColor.UseVisualStyleBackColor = false;
            this.btnCanvasColor.Click += new System.EventHandler(this.btnCanvasColor_Click_1);
            // 
            // lblfigure
            // 
            this.lblfigure.AutoSize = true;
            this.lblfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfigure.ForeColor = System.Drawing.Color.Black;
            this.lblfigure.Location = new System.Drawing.Point(847, 94);
            this.lblfigure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfigure.Name = "lblfigure";
            this.lblfigure.Size = new System.Drawing.Size(79, 20);
            this.lblfigure.TabIndex = 1;
            this.lblfigure.Text = "Фигуры";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(17, 627);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(132, 34);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "все фигуры";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // rect
            // 
            this.rect.Location = new System.Drawing.Point(846, 591);
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(121, 28);
            this.rect.TabIndex = 13;
            this.rect.Text = "добавить ";
            this.rect.UseVisualStyleBackColor = true;
            this.rect.Click += new System.EventHandler(this.rect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(846, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1183, 684);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rect);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCanvasColor);
            this.Controls.Add(this.lblfigure);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.lblpen);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblpen;
        private System.Windows.Forms.Label lblback;
        private System.Windows.Forms.Button btnCanvasColor;
        private System.Windows.Forms.Label lblfigure;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button rect;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

