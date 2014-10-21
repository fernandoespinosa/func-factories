namespace FuncFactories.Host
{
    partial class Host
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
            this.buttonFooBlast = new System.Windows.Forms.Button();
            this.buttonBarBlast = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFooBlast
            // 
            this.buttonFooBlast.Location = new System.Drawing.Point(18, 17);
            this.buttonFooBlast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFooBlast.Name = "buttonFooBlast";
            this.buttonFooBlast.Size = new System.Drawing.Size(112, 32);
            this.buttonFooBlast.TabIndex = 0;
            this.buttonFooBlast.Text = "Foo Blast";
            this.buttonFooBlast.UseVisualStyleBackColor = true;
            this.buttonFooBlast.Click += new System.EventHandler(this.buttonFooBlast_Click);
            // 
            // buttonBarBlast
            // 
            this.buttonBarBlast.Location = new System.Drawing.Point(138, 17);
            this.buttonBarBlast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBarBlast.Name = "buttonBarBlast";
            this.buttonBarBlast.Size = new System.Drawing.Size(112, 32);
            this.buttonBarBlast.TabIndex = 1;
            this.buttonBarBlast.Text = "Bar Blast";
            this.buttonBarBlast.UseVisualStyleBackColor = true;
            this.buttonBarBlast.Click += new System.EventHandler(this.buttonBarBlast_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(18, 56);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(680, 307);
            this.textBox.TabIndex = 2;
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 375);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonBarBlast);
            this.Controls.Add(this.buttonFooBlast);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFooBlast;
        private System.Windows.Forms.Button buttonBarBlast;
        private System.Windows.Forms.TextBox textBox;
    }
}

