
namespace WindowsFormsApp4
{
    partial class PopupEmailForm
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(82, 60);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(111, 20);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email Address";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(130, 110);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(63, 20);
            this.subjectLabel.TabIndex = 1;
            this.subjectLabel.Text = "Subject";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(200, 60);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(300, 26);
            this.emailTextBox.TabIndex = 3;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(200, 110);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(300, 26);
            this.subjectTextBox.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(220, 215);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 35);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(120, 160);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(74, 20);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(200, 160);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(300, 26);
            this.messageTextBox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(380, 215);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 35);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // PopupEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 295);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "PopupEmailForm";
            this.Text = "PopupEmailForm";
            this.Load += new System.EventHandler(this.PopupEmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}