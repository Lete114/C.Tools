namespace Delete
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lete = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.Zhu = new System.Windows.Forms.Label();
            this.lblVHEX = new System.Windows.Forms.Label();
            this.lblVY = new System.Windows.Forms.Label();
            this.lblVX = new System.Windows.Forms.Label();
            this.lblB255 = new System.Windows.Forms.Label();
            this.lblG255 = new System.Windows.Forms.Label();
            this.lblR255 = new System.Windows.Forms.Label();
            this.lblHEX = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lete
            // 
            this.lete.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.lete.ForeColor = System.Drawing.Color.Black;
            this.lete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lete.Location = new System.Drawing.Point(348, 353);
            this.lete.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.lete.Name = "lete";
            this.lete.Size = new System.Drawing.Size(101, 32);
            this.lete.TabIndex = 31;
            this.lete.Text = "--乐特";
            this.lete.Click += new System.EventHandler(this.lete_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblX.Location = new System.Drawing.Point(36, 169);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(121, 34);
            this.lblX.TabIndex = 18;
            this.lblX.Text = "坐标X:";
            // 
            // tm
            // 
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // Zhu
            // 
            this.Zhu.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Bold);
            this.Zhu.ForeColor = System.Drawing.Color.Red;
            this.Zhu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Zhu.Location = new System.Drawing.Point(25, 311);
            this.Zhu.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.Zhu.Name = "Zhu";
            this.Zhu.Size = new System.Drawing.Size(411, 63);
            this.Zhu.TabIndex = 30;
            this.Zhu.Text = "本工具纯属个人兴趣爱好，因本人常用到该功能写了该工具，请勿用于商业用途，一切后果自负";
            this.Zhu.Click += new System.EventHandler(this.Zhu_Click);
            // 
            // lblVHEX
            // 
            this.lblVHEX.AutoSize = true;
            this.lblVHEX.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblVHEX.ForeColor = System.Drawing.Color.Blue;
            this.lblVHEX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVHEX.Location = new System.Drawing.Point(163, 267);
            this.lblVHEX.Name = "lblVHEX";
            this.lblVHEX.Size = new System.Drawing.Size(69, 34);
            this.lblVHEX.TabIndex = 29;
            this.lblVHEX.Text = "hex";
            // 
            // lblVY
            // 
            this.lblVY.AutoSize = true;
            this.lblVY.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblVY.ForeColor = System.Drawing.Color.Blue;
            this.lblVY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVY.Location = new System.Drawing.Point(163, 217);
            this.lblVY.Name = "lblVY";
            this.lblVY.Size = new System.Drawing.Size(33, 34);
            this.lblVY.TabIndex = 28;
            this.lblVY.Text = "y";
            // 
            // lblVX
            // 
            this.lblVX.AutoSize = true;
            this.lblVX.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblVX.ForeColor = System.Drawing.Color.Blue;
            this.lblVX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVX.Location = new System.Drawing.Point(163, 169);
            this.lblVX.Name = "lblVX";
            this.lblVX.Size = new System.Drawing.Size(33, 34);
            this.lblVX.TabIndex = 27;
            this.lblVX.Text = "x";
            // 
            // lblB255
            // 
            this.lblB255.AutoSize = true;
            this.lblB255.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblB255.ForeColor = System.Drawing.Color.Blue;
            this.lblB255.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblB255.Location = new System.Drawing.Point(163, 117);
            this.lblB255.Name = "lblB255";
            this.lblB255.Size = new System.Drawing.Size(33, 34);
            this.lblB255.TabIndex = 26;
            this.lblB255.Text = "b";
            // 
            // lblG255
            // 
            this.lblG255.AutoSize = true;
            this.lblG255.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblG255.ForeColor = System.Drawing.Color.Blue;
            this.lblG255.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblG255.Location = new System.Drawing.Point(163, 66);
            this.lblG255.Name = "lblG255";
            this.lblG255.Size = new System.Drawing.Size(33, 34);
            this.lblG255.TabIndex = 25;
            this.lblG255.Text = "g";
            // 
            // lblR255
            // 
            this.lblR255.AutoSize = true;
            this.lblR255.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblR255.ForeColor = System.Drawing.Color.Blue;
            this.lblR255.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblR255.Location = new System.Drawing.Point(163, 18);
            this.lblR255.Name = "lblR255";
            this.lblR255.Size = new System.Drawing.Size(33, 34);
            this.lblR255.TabIndex = 24;
            this.lblR255.Text = "r";
            // 
            // lblHEX
            // 
            this.lblHEX.AutoSize = true;
            this.lblHEX.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblHEX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHEX.Location = new System.Drawing.Point(35, 267);
            this.lblHEX.Name = "lblHEX";
            this.lblHEX.Size = new System.Drawing.Size(122, 34);
            this.lblHEX.TabIndex = 23;
            this.lblHEX.Text = "HEX值:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblG.ForeColor = System.Drawing.Color.Green;
            this.lblG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblG.Location = new System.Drawing.Point(89, 66);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(68, 34);
            this.lblG.TabIndex = 22;
            this.lblG.Text = "绿:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblB.ForeColor = System.Drawing.Color.Blue;
            this.lblB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblB.Location = new System.Drawing.Point(89, 117);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(68, 34);
            this.lblB.TabIndex = 21;
            this.lblB.Text = "蓝:";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblR.ForeColor = System.Drawing.Color.Red;
            this.lblR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblR.Location = new System.Drawing.Point(89, 18);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(68, 34);
            this.lblR.TabIndex = 20;
            this.lblR.Text = "红:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("黑体", 20F, System.Drawing.FontStyle.Bold);
            this.lblY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblY.Location = new System.Drawing.Point(36, 217);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(121, 34);
            this.lblY.TabIndex = 19;
            this.lblY.Text = "坐标Y:";
            // 
            // LeteTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 393);
            this.Controls.Add(this.lete);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.Zhu);
            this.Controls.Add(this.lblVHEX);
            this.Controls.Add(this.lblVY);
            this.Controls.Add(this.lblVX);
            this.Controls.Add(this.lblB255);
            this.Controls.Add(this.lblG255);
            this.Controls.Add(this.lblR255);
            this.Controls.Add(this.lblHEX);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LeteTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lete自制实用工具";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LeteTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lete;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Label Zhu;
        private System.Windows.Forms.Label lblVHEX;
        private System.Windows.Forms.Label lblVY;
        private System.Windows.Forms.Label lblVX;
        private System.Windows.Forms.Label lblB255;
        private System.Windows.Forms.Label lblG255;
        private System.Windows.Forms.Label lblR255;
        private System.Windows.Forms.Label lblHEX;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblY;
    }
}