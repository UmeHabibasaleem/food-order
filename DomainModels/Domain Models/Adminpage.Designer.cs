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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Information";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(133, 114);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(160, 51);
            this.cmdRemove.TabIndex = 4;
            this.cmdRemove.Text = "Romove Items";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtAddItems
            // 
            this.txtAddItems.Location = new System.Drawing.Point(133, 28);
            this.txtAddItems.Name = "txtAddItems";
            this.txtAddItems.Size = new System.Drawing.Size(160, 53);
            this.txtAddItems.TabIndex = 3;
            this.txtAddItems.Text = "Add Items";
            this.txtAddItems.UseVisualStyleBackColor = true;
            this.txtAddItems.Click += new System.EventHandler(this.txtAddItems_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Shopping cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "conform order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(405, 28);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(148, 53);
            this.Button4.TabIndex = 9;
            this.Button4.Text = "UserRecord";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 114);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "SeeUserFeedback";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmdAdminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 432);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button button5;
    }
}