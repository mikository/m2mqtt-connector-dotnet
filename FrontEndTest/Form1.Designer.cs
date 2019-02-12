namespace FrontEndTest
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
            this.gbxConnect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtCnn = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.gbxSubscribe = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.gbxChat = new System.Windows.Forms.GroupBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.gbxConnect.SuspendLayout();
            this.gbxSubscribe.SuspendLayout();
            this.gbxChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConnect
            // 
            this.gbxConnect.Controls.Add(this.txtPass);
            this.gbxConnect.Controls.Add(this.txtUser);
            this.gbxConnect.Controls.Add(this.txtCnn);
            this.gbxConnect.Controls.Add(this.btnConnect);
            this.gbxConnect.Controls.Add(this.label3);
            this.gbxConnect.Controls.Add(this.label2);
            this.gbxConnect.Controls.Add(this.label1);
            this.gbxConnect.Location = new System.Drawing.Point(12, 12);
            this.gbxConnect.Name = "gbxConnect";
            this.gbxConnect.Size = new System.Drawing.Size(237, 164);
            this.gbxConnect.TabIndex = 0;
            this.gbxConnect.TabStop = false;
            this.gbxConnect.Text = "Connect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(133, 123);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 35);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtCnn
            // 
            this.txtCnn.Location = new System.Drawing.Point(93, 30);
            this.txtCnn.Name = "txtCnn";
            this.txtCnn.Size = new System.Drawing.Size(138, 22);
            this.txtCnn.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(93, 61);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(138, 22);
            this.txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(93, 95);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(138, 22);
            this.txtPass.TabIndex = 6;
            // 
            // gbxSubscribe
            // 
            this.gbxSubscribe.Controls.Add(this.btnSubscribe);
            this.gbxSubscribe.Controls.Add(this.txtTopic);
            this.gbxSubscribe.Controls.Add(this.label4);
            this.gbxSubscribe.Location = new System.Drawing.Point(268, 12);
            this.gbxSubscribe.Name = "gbxSubscribe";
            this.gbxSubscribe.Size = new System.Drawing.Size(241, 164);
            this.gbxSubscribe.TabIndex = 1;
            this.gbxSubscribe.TabStop = false;
            this.gbxSubscribe.Text = "Subscribe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Topic";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(65, 32);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(170, 22);
            this.txtTopic.TabIndex = 1;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(114, 123);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(121, 35);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // gbxChat
            // 
            this.gbxChat.Controls.Add(this.txtChat);
            this.gbxChat.Location = new System.Drawing.Point(13, 197);
            this.gbxChat.Name = "gbxChat";
            this.gbxChat.Size = new System.Drawing.Size(496, 268);
            this.gbxChat.TabIndex = 2;
            this.gbxChat.TabStop = false;
            this.gbxChat.Text = "Chat";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(9, 21);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(481, 241);
            this.txtChat.TabIndex = 0;
            this.txtChat.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 477);
            this.Controls.Add(this.gbxChat);
            this.Controls.Add(this.gbxSubscribe);
            this.Controls.Add(this.gbxConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxConnect.ResumeLayout(false);
            this.gbxConnect.PerformLayout();
            this.gbxSubscribe.ResumeLayout(false);
            this.gbxSubscribe.PerformLayout();
            this.gbxChat.ResumeLayout(false);
            this.gbxChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConnect;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtCnn;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxSubscribe;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxChat;
        private System.Windows.Forms.TextBox txtChat;
    }
}

