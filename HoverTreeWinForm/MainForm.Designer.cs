namespace HoverTreeWinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip_hewenqi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_apiForm = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_hewenqi.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip_hewenqi
            // 
            this.contextMenuStrip_hewenqi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_apiForm});
            this.contextMenuStrip_hewenqi.Name = "contextMenuStrip_hewenqi";
            this.contextMenuStrip_hewenqi.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuItem_apiForm
            // 
            this.toolStripMenuItem_apiForm.Name = "toolStripMenuItem_apiForm";
            this.toolStripMenuItem_apiForm.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_apiForm.Text = "调用API示例";
            this.toolStripMenuItem_apiForm.Click += new System.EventHandler(this.toolStripMenuItem_apiForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ContextMenuStrip = this.contextMenuStrip_hewenqi;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.contextMenuStrip_hewenqi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_hewenqi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_apiForm;
    }
}