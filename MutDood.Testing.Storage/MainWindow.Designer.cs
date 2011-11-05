namespace MutDood.Testing.Storage
{
    partial class MainWindow
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
            this.btnSerializationTest = new System.Windows.Forms.Button();
            this.btnCreateStorage = new System.Windows.Forms.Button();
            this.btnCreateMetadata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerializationTest
            // 
            this.btnSerializationTest.Location = new System.Drawing.Point(12, 300);
            this.btnSerializationTest.Name = "btnSerializationTest";
            this.btnSerializationTest.Size = new System.Drawing.Size(113, 23);
            this.btnSerializationTest.TabIndex = 0;
            this.btnSerializationTest.Text = "TestSerialization";
            this.btnSerializationTest.UseVisualStyleBackColor = true;
            this.btnSerializationTest.Click += new System.EventHandler(this.btnSerializationTest_Click);
            // 
            // btnCreateStorage
            // 
            this.btnCreateStorage.Location = new System.Drawing.Point(12, 8);
            this.btnCreateStorage.Name = "btnCreateStorage";
            this.btnCreateStorage.Size = new System.Drawing.Size(113, 23);
            this.btnCreateStorage.TabIndex = 1;
            this.btnCreateStorage.Text = "Create storage";
            this.btnCreateStorage.UseVisualStyleBackColor = true;
            this.btnCreateStorage.Click += new System.EventHandler(this.btnCreateStorage_Click);
            // 
            // btnCreateMetadata
            // 
            this.btnCreateMetadata.Location = new System.Drawing.Point(12, 66);
            this.btnCreateMetadata.Name = "btnCreateMetadata";
            this.btnCreateMetadata.Size = new System.Drawing.Size(113, 23);
            this.btnCreateMetadata.TabIndex = 2;
            this.btnCreateMetadata.Text = "Create Metadata";
            this.btnCreateMetadata.UseVisualStyleBackColor = true;
            this.btnCreateMetadata.Click += new System.EventHandler(this.btnCreateMetadata_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 335);
            this.Controls.Add(this.btnCreateMetadata);
            this.Controls.Add(this.btnCreateStorage);
            this.Controls.Add(this.btnSerializationTest);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerializationTest;
        private System.Windows.Forms.Button btnCreateStorage;
        private System.Windows.Forms.Button btnCreateMetadata;
    }
}