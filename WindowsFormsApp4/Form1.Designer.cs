
namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.calculatorTab = new System.Windows.Forms.TabPage();
            this.outputLabel = new System.Windows.Forms.Label();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.textControlTab = new System.Windows.Forms.TabPage();
            this.textControl = new TXTextControl.TextControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexTab = new System.Windows.Forms.TabPage();
            this.hexLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.webPageTab = new System.Windows.Forms.TabPage();
            this.myWebButton = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.webButton = new System.Windows.Forms.Button();
            this.webTextBox = new System.Windows.Forms.TextBox();
            this.webLabel = new System.Windows.Forms.Label();
            this.mailMerge = new TXTextControl.DocumentServer.MailMerge(this.components);
            this.tabControl.SuspendLayout();
            this.calculatorTab.SuspendLayout();
            this.textControlTab.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.hexTab.SuspendLayout();
            this.webPageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.calculatorTab);
            this.tabControl.Controls.Add(this.textControlTab);
            this.tabControl.Controls.Add(this.hexTab);
            this.tabControl.Controls.Add(this.webPageTab);
            this.tabControl.Location = new System.Drawing.Point(-4, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1114, 569);
            this.tabControl.TabIndex = 0;
            // 
            // calculatorTab
            // 
            this.calculatorTab.Controls.Add(this.outputLabel);
            this.calculatorTab.Controls.Add(this.divideButton);
            this.calculatorTab.Controls.Add(this.multiplyButton);
            this.calculatorTab.Controls.Add(this.minusButton);
            this.calculatorTab.Controls.Add(this.plusButton);
            this.calculatorTab.Controls.Add(this.equalsButton);
            this.calculatorTab.Controls.Add(this.dotButton);
            this.calculatorTab.Controls.Add(this.zeroButton);
            this.calculatorTab.Controls.Add(this.eightButton);
            this.calculatorTab.Controls.Add(this.nineButton);
            this.calculatorTab.Controls.Add(this.sevenButton);
            this.calculatorTab.Controls.Add(this.sixButton);
            this.calculatorTab.Controls.Add(this.fiveButton);
            this.calculatorTab.Controls.Add(this.fourButton);
            this.calculatorTab.Controls.Add(this.threeButton);
            this.calculatorTab.Controls.Add(this.twoButton);
            this.calculatorTab.Controls.Add(this.oneButton);
            this.calculatorTab.Location = new System.Drawing.Point(4, 29);
            this.calculatorTab.Name = "calculatorTab";
            this.calculatorTab.Padding = new System.Windows.Forms.Padding(3);
            this.calculatorTab.Size = new System.Drawing.Size(1106, 536);
            this.calculatorTab.TabIndex = 0;
            this.calculatorTab.Text = "Calculator";
            this.calculatorTab.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(310, 120);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 20);
            this.outputLabel.TabIndex = 16;
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(410, 270);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(35, 35);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(410, 230);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(35, 35);
            this.multiplyButton.TabIndex = 14;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(410, 190);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(35, 35);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(410, 150);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(35, 35);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(370, 270);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(35, 35);
            this.equalsButton.TabIndex = 11;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(330, 270);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(35, 35);
            this.dotButton.TabIndex = 10;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(290, 270);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(35, 35);
            this.zeroButton.TabIndex = 9;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(330, 230);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(35, 35);
            this.eightButton.TabIndex = 8;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(370, 230);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(35, 35);
            this.nineButton.TabIndex = 7;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(290, 230);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(35, 35);
            this.sevenButton.TabIndex = 6;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(370, 190);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(35, 35);
            this.sixButton.TabIndex = 5;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(330, 190);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(35, 35);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(290, 190);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(35, 35);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(370, 150);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(35, 35);
            this.threeButton.TabIndex = 2;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(330, 150);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(35, 35);
            this.twoButton.TabIndex = 1;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Transparent;
            this.oneButton.Location = new System.Drawing.Point(290, 150);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(35, 35);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // textControlTab
            // 
            this.textControlTab.Controls.Add(this.textControl);
            this.textControlTab.Controls.Add(this.menuStrip);
            this.textControlTab.Location = new System.Drawing.Point(4, 29);
            this.textControlTab.Name = "textControlTab";
            this.textControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.textControlTab.Size = new System.Drawing.Size(1106, 536);
            this.textControlTab.TabIndex = 1;
            this.textControlTab.Text = "Text Control";
            this.textControlTab.UseVisualStyleBackColor = true;
            // 
            // textControl
            // 
            this.textControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl.Location = new System.Drawing.Point(3, 36);
            this.textControl.Name = "textControl";
            this.textControl.PageMargins.Bottom = 78.75D;
            this.textControl.PageMargins.Left = 78.75D;
            this.textControl.PageMargins.Right = 78.75D;
            this.textControl.PageMargins.Top = 78.75D;
            this.textControl.PageSize.Height = 1169.31D;
            this.textControl.PageSize.Width = 826.81D;
            this.textControl.Size = new System.Drawing.Size(1100, 497);
            this.textControl.TabIndex = 0;
            this.textControl.UserNames = null;
            this.textControl.ViewMode = TXTextControl.ViewMode.Normal;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.mergeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(3, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1100, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.costToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.addToolStripMenuItem.Text = "Tokens";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.nameToolStripMenuItem.Text = "name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.companyToolStripMenuItem.Text = "company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // costToolStripMenuItem
            // 
            this.costToolStripMenuItem.Name = "costToolStripMenuItem";
            this.costToolStripMenuItem.Size = new System.Drawing.Size(188, 34);
            this.costToolStripMenuItem.Text = "cost";
            this.costToolStripMenuItem.Click += new System.EventHandler(this.costToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeToolStripMenuItem1,
            this.addPersonToolStripMenuItem});
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.mergeToolStripMenuItem.Text = "Merge";
            // 
            // mergeToolStripMenuItem1
            // 
            this.mergeToolStripMenuItem1.Name = "mergeToolStripMenuItem1";
            this.mergeToolStripMenuItem1.Size = new System.Drawing.Size(206, 34);
            this.mergeToolStripMenuItem1.Text = "Merge";
            this.mergeToolStripMenuItem1.Click += new System.EventHandler(this.mergeToolStripMenuItem1_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // hexTab
            // 
            this.hexTab.Controls.Add(this.hexLabel);
            this.hexTab.Controls.Add(this.convertButton);
            this.hexTab.Controls.Add(this.stringTextBox);
            this.hexTab.Location = new System.Drawing.Point(4, 29);
            this.hexTab.Name = "hexTab";
            this.hexTab.Padding = new System.Windows.Forms.Padding(3);
            this.hexTab.Size = new System.Drawing.Size(1106, 536);
            this.hexTab.TabIndex = 2;
            this.hexTab.Text = "Hex Converter";
            this.hexTab.UseVisualStyleBackColor = true;
            // 
            // hexLabel
            // 
            this.hexLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(170, 250);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(0, 20);
            this.hexLabel.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(695, 193);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(100, 40);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(160, 200);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(500, 26);
            this.stringTextBox.TabIndex = 0;
            this.stringTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stringTextBox_KeyDown);
            // 
            // webPageTab
            // 
            this.webPageTab.Controls.Add(this.myWebButton);
            this.webPageTab.Controls.Add(this.webBrowser);
            this.webPageTab.Controls.Add(this.webButton);
            this.webPageTab.Controls.Add(this.webTextBox);
            this.webPageTab.Controls.Add(this.webLabel);
            this.webPageTab.Location = new System.Drawing.Point(4, 29);
            this.webPageTab.Name = "webPageTab";
            this.webPageTab.Padding = new System.Windows.Forms.Padding(3);
            this.webPageTab.Size = new System.Drawing.Size(1106, 536);
            this.webPageTab.TabIndex = 3;
            this.webPageTab.Text = "Web Page";
            this.webPageTab.UseVisualStyleBackColor = true;
            // 
            // myWebButton
            // 
            this.myWebButton.Location = new System.Drawing.Point(900, 17);
            this.myWebButton.Name = "myWebButton";
            this.myWebButton.Size = new System.Drawing.Size(124, 34);
            this.myWebButton.TabIndex = 4;
            this.myWebButton.Text = "My Web Page";
            this.myWebButton.UseVisualStyleBackColor = true;
            this.myWebButton.Click += new System.EventHandler(this.myWebButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 52);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1103, 478);
            this.webBrowser.TabIndex = 3;
            // 
            // webButton
            // 
            this.webButton.Location = new System.Drawing.Point(630, 17);
            this.webButton.Name = "webButton";
            this.webButton.Size = new System.Drawing.Size(58, 34);
            this.webButton.TabIndex = 2;
            this.webButton.Text = "Go";
            this.webButton.UseVisualStyleBackColor = true;
            this.webButton.Click += new System.EventHandler(this.webButton_Click);
            // 
            // webTextBox
            // 
            this.webTextBox.Location = new System.Drawing.Point(237, 20);
            this.webTextBox.Name = "webTextBox";
            this.webTextBox.Size = new System.Drawing.Size(387, 26);
            this.webTextBox.TabIndex = 1;
            this.webTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webTextBox_KeyDown);
            // 
            // webLabel
            // 
            this.webLabel.AutoSize = true;
            this.webLabel.Location = new System.Drawing.Point(45, 23);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(186, 20);
            this.webLabel.TabIndex = 0;
            this.webLabel.Text = "Enter a web page to view";
            // 
            // mailMerge
            // 
            this.mailMerge.TextComponent = this.textControl;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 567);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.calculatorTab.ResumeLayout(false);
            this.calculatorTab.PerformLayout();
            this.textControlTab.ResumeLayout(false);
            this.textControlTab.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.hexTab.ResumeLayout(false);
            this.hexTab.PerformLayout();
            this.webPageTab.ResumeLayout(false);
            this.webPageTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage calculatorTab;
        private System.Windows.Forms.TabPage textControlTab;
        private System.Windows.Forms.TabPage hexTab;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private TXTextControl.TextControl textControl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem;
        private TXTextControl.DocumentServer.MailMerge mailMerge;
        private System.Windows.Forms.TabPage webPageTab;
        private System.Windows.Forms.Button webButton;
        private System.Windows.Forms.TextBox webTextBox;
        private System.Windows.Forms.Label webLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button myWebButton;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
    }
}

