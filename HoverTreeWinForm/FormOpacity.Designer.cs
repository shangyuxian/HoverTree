namespace HoverTreeWinForm
{
    partial class FormOpacity
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
            this.label_tips = new System.Windows.Forms.Label();
            this.panel_hovertree = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_tips
            // 
            this.label_tips.AutoSize = true;
            this.label_tips.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tips.Location = new System.Drawing.Point(34, 42);
            this.label_tips.Name = "label_tips";
            this.label_tips.Size = new System.Drawing.Size(216, 16);
            this.label_tips.TabIndex = 0;
            this.label_tips.Text = "我是部分透明窗体,by 何问起";
            // 
            // panel_hovertree
            // 
            this.panel_hovertree.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_hovertree.Location = new System.Drawing.Point(37, 113);
            this.panel_hovertree.Name = "panel_hovertree";
            this.panel_hovertree.Size = new System.Drawing.Size(200, 100);
            this.panel_hovertree.TabIndex = 1;
            // 
            // FormOpacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel_hovertree);
            this.Controls.Add(this.label_tips);
            this.Name = "FormOpacity";
            this.Text = "FormOpacity";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormOpacity_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_tips;
        private System.Windows.Forms.Panel panel_hovertree;
    }
}