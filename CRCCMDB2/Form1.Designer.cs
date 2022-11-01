namespace CRCCMDB2
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
            this.manageMoviesButton = new System.Windows.Forms.Button();
            this.manageActorsButton = new System.Windows.Forms.Button();
            this.manageGenresButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageMoviesButton
            // 
            this.manageMoviesButton.Location = new System.Drawing.Point(57, 38);
            this.manageMoviesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageMoviesButton.Name = "manageMoviesButton";
            this.manageMoviesButton.Size = new System.Drawing.Size(154, 52);
            this.manageMoviesButton.TabIndex = 0;
            this.manageMoviesButton.Text = "Manage Movies";
            this.manageMoviesButton.UseVisualStyleBackColor = true;
            this.manageMoviesButton.Click += new System.EventHandler(this.manageMoviesButton_Click);
            // 
            // manageActorsButton
            // 
            this.manageActorsButton.Location = new System.Drawing.Point(234, 38);
            this.manageActorsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageActorsButton.Name = "manageActorsButton";
            this.manageActorsButton.Size = new System.Drawing.Size(142, 52);
            this.manageActorsButton.TabIndex = 1;
            this.manageActorsButton.Text = "Manage Actors";
            this.manageActorsButton.UseVisualStyleBackColor = true;
            this.manageActorsButton.Click += new System.EventHandler(this.manageActorsButton_Click);
            // 
            // manageGenresButton
            // 
            this.manageGenresButton.Location = new System.Drawing.Point(416, 38);
            this.manageGenresButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageGenresButton.Name = "manageGenresButton";
            this.manageGenresButton.Size = new System.Drawing.Size(147, 59);
            this.manageGenresButton.TabIndex = 2;
            this.manageGenresButton.Text = "Manage Genres";
            this.manageGenresButton.UseVisualStyleBackColor = true;
            this.manageGenresButton.Click += new System.EventHandler(this.manageGenresButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(256, 147);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(79, 29);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 191);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.manageGenresButton);
            this.Controls.Add(this.manageActorsButton);
            this.Controls.Add(this.manageMoviesButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageMoviesButton;
        private System.Windows.Forms.Button manageActorsButton;
        private System.Windows.Forms.Button manageGenresButton;
        private System.Windows.Forms.Button closeButton;
    }
}

