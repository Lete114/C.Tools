namespace Delete
{
    partial class Delete
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.lblPathName = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPathName
            // 
            this.lblPathName.AutoSize = true;
            this.lblPathName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPathName.Location = new System.Drawing.Point(12, 41);
            this.lblPathName.Name = "lblPathName";
            this.lblPathName.Size = new System.Drawing.Size(129, 20);
            this.lblPathName.TabIndex = 1;
            this.lblPathName.Text = "请输入路径：";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(135, 37);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(272, 104);
            this.txtPath.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "开始";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(422, 33);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(72, 39);
            this.btnLL.TabIndex = 5;
            this.btnLL.Text = "浏览";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 153);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPathName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lete自制删除空目录";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLL;
    }
}

