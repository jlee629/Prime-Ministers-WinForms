
namespace PrimeMinisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstPrimeMinisters = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPrimeMinisters
            // 
            this.lstPrimeMinisters.FormattingEnabled = true;
            this.lstPrimeMinisters.ItemHeight = 15;
            this.lstPrimeMinisters.Location = new System.Drawing.Point(431, 38);
            this.lstPrimeMinisters.Name = "lstPrimeMinisters";
            this.lstPrimeMinisters.Size = new System.Drawing.Size(178, 319);
            this.lstPrimeMinisters.TabIndex = 1;
            this.lstPrimeMinisters.SelectedIndexChanged += new System.EventHandler(this.lstPrimeMinisters_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(38, 385);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(38, 421);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(52, 15);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "lblTerm";
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(38, 453);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(55, 15);
            this.lblParty.TabIndex = 4;
            this.lblParty.Text = "lblParty";
            // 
            // picPhoto
            // 
            this.picPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPhoto.Location = new System.Drawing.Point(42, 38);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(342, 319);
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 505);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstPrimeMinisters);
            this.Controls.Add(this.picPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prime Ministers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPrimeMinisters;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.PictureBox picPhoto;
    }
}

