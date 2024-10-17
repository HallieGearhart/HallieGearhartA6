namespace HallieGearhartA6
{
    partial class ReadWriteMain
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
            btnChooseFile = new Button();
            SuspendLayout();
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(190, 97);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 29);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += this.btnChooseFile_Click;
            // 
            // ReadWriteMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(btnChooseFile);
            Name = "ReadWriteMain";
            Text = "Hallie Gearhart Assignment 6";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChooseFile;
    }
}
