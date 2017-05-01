namespace TraverseAdjustmentDemo
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btu_Close = new System.Windows.Forms.Button();
            this.Btu_NoClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择：";
            // 
            // Btu_Close
            // 
            this.Btu_Close.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btu_Close.Location = new System.Drawing.Point(33, 97);
            this.Btu_Close.Name = "Btu_Close";
            this.Btu_Close.Size = new System.Drawing.Size(227, 42);
            this.Btu_Close.TabIndex = 1;
            this.Btu_Close.TabStop = false;
            this.Btu_Close.Text = "闭合导线计算";
            this.Btu_Close.UseVisualStyleBackColor = true;
            this.Btu_Close.Click += new System.EventHandler(this.Btu_Close_Click);
            // 
            // Btu_NoClose
            // 
            this.Btu_NoClose.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btu_NoClose.Location = new System.Drawing.Point(33, 179);
            this.Btu_NoClose.Name = "Btu_NoClose";
            this.Btu_NoClose.Size = new System.Drawing.Size(227, 42);
            this.Btu_NoClose.TabIndex = 2;
            this.Btu_NoClose.TabStop = false;
            this.Btu_NoClose.Text = "附和导线计算";
            this.Btu_NoClose.UseVisualStyleBackColor = true;
            this.Btu_NoClose.Click += new System.EventHandler(this.Btu_NoClose_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 311);
            this.Controls.Add(this.Btu_NoClose);
            this.Controls.Add(this.Btu_Close);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btu_Close;
        private System.Windows.Forms.Button Btu_NoClose;
    }
}