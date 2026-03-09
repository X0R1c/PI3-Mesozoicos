namespace Mesozoicos {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnListGame = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersionLabel = new System.Windows.Forms.Label();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.txtNameGame = new System.Windows.Forms.TextBox();
            this.lblCreateGameName = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.textResultGame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListGame
            // 
            this.btnListGame.Location = new System.Drawing.Point(12, 279);
            this.btnListGame.Name = "btnListGame";
            this.btnListGame.Size = new System.Drawing.Size(91, 50);
            this.btnListGame.TabIndex = 0;
            this.btnListGame.Text = "Listar Jogo";
            this.btnListGame.UseVisualStyleBackColor = true;
            this.btnListGame.Click += new System.EventHandler(this.btnListGame_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(712, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "[Version]";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblVersionLabel
            // 
            this.lblVersionLabel.AutoSize = true;
            this.lblVersionLabel.Location = new System.Drawing.Point(671, 9);
            this.lblVersionLabel.Name = "lblVersionLabel";
            this.lblVersionLabel.Size = new System.Drawing.Size(43, 13);
            this.lblVersionLabel.TabIndex = 2;
            this.lblVersionLabel.Text = "Versão:";
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(12, 9);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(180, 264);
            this.listBoxGames.TabIndex = 4;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.AutoSize = true;
            this.lblNameGroup.Location = new System.Drawing.Point(674, 39);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(63, 13);
            this.lblNameGroup.TabIndex = 5;
            this.lblNameGroup.Text = "Mesozoicos";
            // 
            // txtNameGame
            // 
            this.txtNameGame.Location = new System.Drawing.Point(220, 31);
            this.txtNameGame.Name = "txtNameGame";
            this.txtNameGame.Size = new System.Drawing.Size(100, 20);
            this.txtNameGame.TabIndex = 6;
            // 
            // lblCreateGameName
            // 
            this.lblCreateGameName.AutoSize = true;
            this.lblCreateGameName.Location = new System.Drawing.Point(217, 15);
            this.lblCreateGameName.Name = "lblCreateGameName";
            this.lblCreateGameName.Size = new System.Drawing.Size(86, 13);
            this.lblCreateGameName.TabIndex = 7;
            this.lblCreateGameName.Text = "Nome da Partida";
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(220, 279);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(92, 50);
            this.btnCreateGame.TabIndex = 8;
            this.btnCreateGame.Text = "Criar Partida";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(220, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Senha:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(223, 130);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(82, 13);
            this.lblGroupName.TabIndex = 11;
            this.lblGroupName.Text = "Nome do Grupo";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(220, 146);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 20);
            this.txtGroupName.TabIndex = 12;
            // 
            // textResultGame
            // 
            this.textResultGame.Location = new System.Drawing.Point(354, 9);
            this.textResultGame.Multiline = true;
            this.textResultGame.Name = "textResultGame";
            this.textResultGame.Size = new System.Drawing.Size(293, 264);
            this.textResultGame.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResultGame);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.lblCreateGameName);
            this.Controls.Add(this.txtNameGame);
            this.Controls.Add(this.lblNameGroup);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.lblVersionLabel);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnListGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListGame;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersionLabel;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Label lblNameGroup;
        private System.Windows.Forms.TextBox txtNameGame;
        private System.Windows.Forms.Label lblCreateGameName;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox textResultGame;
    }
}

