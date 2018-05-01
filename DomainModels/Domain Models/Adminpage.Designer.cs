namespace Domain_Models
{
    partial class cmdAdminpage
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
            this.button3 = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtAddItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Information";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(146, 114);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(160, 51);
            this.cmdRemove.TabIndex = 4;
            this.cmdRemove.Text = "Romove items";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtAddItems
            // 
            this.txtAddItems.Location = new System.Drawing.Point(146, 41);
            this.txtAddItems.Name = "txtAddItems";
            this.txtAddItems.Size = new System.Drawing.Size(160, 53);
            this.txtAddItems.TabIndex = 3;
            this.txtAddItems.Text = "AddItems";
            this.txtAddItems.UseVisualStyleBackColor = true;
            this.txtAddItems.Click += new System.EventHandler(this.txtAddItems_Click);
            // 
            // cmdAdminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 320);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.txtAddItems);
            this.Name = "cmdAdminpage";
            this.Text = "Adminpage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button txtAddItems;
    }
}