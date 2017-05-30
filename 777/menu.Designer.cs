namespace _777
{
    partial class menu
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализСуществующихЗапросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вызватьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.анализДанныхToolStripMenuItem,
            this.toolStripMenuItem1,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // button1
            // 
            this.button1.Image = global::_777.Properties.Resources.соединение1;
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "Проверка соединения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискДанныхToolStripMenuItem});
            this.поискToolStripMenuItem.Image = global::_777.Properties.Resources.Search_icon;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискДанныхToolStripMenuItem
            // 
            this.поискДанныхToolStripMenuItem.Image = global::_777.Properties.Resources.Search_icon;
            this.поискДанныхToolStripMenuItem.Name = "поискДанныхToolStripMenuItem";
            this.поискДанныхToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поискДанныхToolStripMenuItem.Text = "Поиск данных";
            this.поискДанныхToolStripMenuItem.Click += new System.EventHandler(this.поискДанныхToolStripMenuItem_Click);
            // 
            // анализДанныхToolStripMenuItem
            // 
            this.анализДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.анализСуществующихЗапросовToolStripMenuItem,
            this.создатьToolStripMenuItem});
            this.анализДанныхToolStripMenuItem.Image = global::_777.Properties.Resources.market_research_tools;
            this.анализДанныхToolStripMenuItem.Name = "анализДанныхToolStripMenuItem";
            this.анализДанныхToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.анализДанныхToolStripMenuItem.Text = "Анализ данных";
            // 
            // анализСуществующихЗапросовToolStripMenuItem
            // 
            this.анализСуществующихЗапросовToolStripMenuItem.Image = global::_777.Properties.Resources.market_research_tools;
            this.анализСуществующихЗапросовToolStripMenuItem.Name = "анализСуществующихЗапросовToolStripMenuItem";
            this.анализСуществующихЗапросовToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.анализСуществующихЗапросовToolStripMenuItem.Text = "Анализ существующих запросов";
            this.анализСуществующихЗапросовToolStripMenuItem.Click += new System.EventHandler(this.анализСуществующихЗапросовToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соToolStripMenuItem,
            this.создатьВChartToolStripMenuItem});
            this.создатьToolStripMenuItem.Image = global::_777.Properties.Resources.новый;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.создатьToolStripMenuItem.Text = "Создать новый";
            // 
            // соToolStripMenuItem
            // 
            this.соToolStripMenuItem.Image = global::_777.Properties.Resources.power;
            this.соToolStripMenuItem.Name = "соToolStripMenuItem";
            this.соToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.соToolStripMenuItem.Text = "Создать в MS Power BI";
            this.соToolStripMenuItem.Click += new System.EventHandler(this.соToolStripMenuItem_Click);
            // 
            // создатьВChartToolStripMenuItem
            // 
            this.создатьВChartToolStripMenuItem.Image = global::_777.Properties.Resources.диаг;
            this.создатьВChartToolStripMenuItem.Name = "создатьВChartToolStripMenuItem";
            this.создатьВChartToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.создатьВChartToolStripMenuItem.Text = "Создать в chart";
            this.создатьВChartToolStripMenuItem.Click += new System.EventHandler(this.создатьВChartToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызватьСправкуToolStripMenuItem});
            this.справкаToolStripMenuItem1.Image = global::_777.Properties.Resources.вопросл;
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // вызватьСправкуToolStripMenuItem
            // 
            this.вызватьСправкуToolStripMenuItem.Image = global::_777.Properties.Resources.вопросл;
            this.вызватьСправкуToolStripMenuItem.Name = "вызватьСправкуToolStripMenuItem";
            this.вызватьСправкуToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вызватьСправкуToolStripMenuItem.Text = "Вызвать справку";
            this.вызватьСправкуToolStripMenuItem.Click += new System.EventHandler(this.вызватьСправкуToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализСуществующихЗапросовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вызватьСправкуToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}