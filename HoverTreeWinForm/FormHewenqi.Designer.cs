namespace HoverTreeWinForm
{
    partial class FormHewenqi
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_hewenqi = new System.Windows.Forms.Button();
            this.linkLabel_help = new System.Windows.Forms.LinkLabel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_hoverc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_hewenqi
            // 
            this.button_hewenqi.Location = new System.Drawing.Point(70, 111);
            this.button_hewenqi.Name = "button_hewenqi";
            this.button_hewenqi.Size = new System.Drawing.Size(130, 23);
            this.button_hewenqi.TabIndex = 0;
            this.button_hewenqi.Text = "使用Win API弹出窗口";
            this.button_hewenqi.UseVisualStyleBackColor = true;
            this.button_hewenqi.Click += new System.EventHandler(this.button_hewenqi_Click);
            // 
            // linkLabel_help
            // 
            this.linkLabel_help.AutoSize = true;
            this.linkLabel_help.Location = new System.Drawing.Point(12, 241);
            this.linkLabel_help.Name = "linkLabel_help";
            this.linkLabel_help.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_help.TabIndex = 1;
            this.linkLabel_help.TabStop = true;
            this.linkLabel_help.Text = "帮助";
            this.linkLabel_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_help_LinkClicked);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_title.Location = new System.Drawing.Point(66, 28);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(142, 22);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "何问起C#教程";
            // 
            // button_hoverc
            // 
            this.button_hoverc.Location = new System.Drawing.Point(58, 140);
            this.button_hoverc.Name = "button_hoverc";
            this.button_hoverc.Size = new System.Drawing.Size(160, 23);
            this.button_hoverc.TabIndex = 3;
            this.button_hoverc.Text = "指定句柄弹出模式对话框";
            this.button_hoverc.UseVisualStyleBackColor = true;
            this.button_hoverc.Click += new System.EventHandler(this.button_hoverc_Click);
            // 
            // FormHewenqi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_hoverc);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.linkLabel_help);
            this.Controls.Add(this.button_hewenqi);
            this.Name = "FormHewenqi";
            this.Text = "C#调用Windows API - 何问起";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hewenqi;
        private System.Windows.Forms.LinkLabel linkLabel_help;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_hoverc;
    }
}

