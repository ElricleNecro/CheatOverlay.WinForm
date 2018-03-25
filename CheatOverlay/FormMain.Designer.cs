namespace CheatOverlay
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.aimBot = new System.Windows.Forms.CheckBox();
            this.kill = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.DisplayOverlay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aimBot
            // 
            this.aimBot.AutoSize = true;
            this.aimBot.Location = new System.Drawing.Point(13, 13);
            this.aimBot.Name = "aimBot";
            this.aimBot.Size = new System.Drawing.Size(58, 17);
            this.aimBot.TabIndex = 0;
            this.aimBot.Text = "Aimbot";
            this.aimBot.UseVisualStyleBackColor = true;
            // 
            // kill
            // 
            this.kill.AutoSize = true;
            this.kill.Location = new System.Drawing.Point(13, 37);
            this.kill.Name = "kill";
            this.kill.Size = new System.Drawing.Size(73, 17);
            this.kill.TabIndex = 1;
            this.kill.Text = "Instant kill";
            this.kill.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // DisplayOverlay
            // 
            this.DisplayOverlay.AutoSize = true;
            this.DisplayOverlay.Location = new System.Drawing.Point(13, 421);
            this.DisplayOverlay.Name = "DisplayOverlay";
            this.DisplayOverlay.Size = new System.Drawing.Size(99, 17);
            this.DisplayOverlay.TabIndex = 3;
            this.DisplayOverlay.Text = "Display Overlay";
            this.DisplayOverlay.UseVisualStyleBackColor = true;
            this.DisplayOverlay.CheckedChanged += new System.EventHandler(this.DisplayOverlay_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayOverlay);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.kill);
            this.Controls.Add(this.aimBot);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aimBot;
        private System.Windows.Forms.CheckBox kill;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox DisplayOverlay;
    }
}

