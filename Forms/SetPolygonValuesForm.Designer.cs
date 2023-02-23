
namespace Seeker
{
    partial class SetPolygonValuesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.inscribed = new System.Windows.Forms.ComboBox();
            this.sides = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sides : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status : ";
            // 
            // inscribed
            // 
            this.inscribed.FormattingEnabled = true;
            this.inscribed.Items.AddRange(new object[] {
            "Inscribed in circle",
            "Circumscribed about circle"});
            this.inscribed.Location = new System.Drawing.Point(119, 96);
            this.inscribed.Name = "inscribed";
            this.inscribed.Size = new System.Drawing.Size(325, 24);
            this.inscribed.TabIndex = 2;
            // 
            // sides
            // 
            this.sides.Location = new System.Drawing.Point(119, 40);
            this.sides.Name = "sides";
            this.sides.Size = new System.Drawing.Size(100, 22);
            this.sides.TabIndex = 3;
            this.sides.Text = "3";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(221, 154);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(100, 35);
            this.acceptBtn.TabIndex = 4;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(344, 154);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 35);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SetPolygonValuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 215);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.sides);
            this.Controls.Add(this.inscribed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetPolygonValuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SetPolygonValuesForm";
            this.Load += new System.EventHandler(this.SetPolygonValuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inscribed;
        private System.Windows.Forms.TextBox sides;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}