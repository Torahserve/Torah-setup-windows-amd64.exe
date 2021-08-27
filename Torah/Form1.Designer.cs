
namespace Torah
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stupNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activenodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootnodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stupToolStripMenuItem,
            this.bootnodeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stupToolStripMenuItem
            // 
            this.stupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stupNodeToolStripMenuItem,
            this.runNodeToolStripMenuItem,
            this.activenodeToolStripMenuItem});
            this.stupToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.stupToolStripMenuItem.Name = "stupToolStripMenuItem";
            this.stupToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.stupToolStripMenuItem.Text = "setup";
            // 
            // stupNodeToolStripMenuItem
            // 
            this.stupNodeToolStripMenuItem.Name = "stupNodeToolStripMenuItem";
            this.stupNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stupNodeToolStripMenuItem.Text = "setup-node";
            this.stupNodeToolStripMenuItem.Click += new System.EventHandler(this.stupNodeToolStripMenuItem_Click);
            // 
            // runNodeToolStripMenuItem
            // 
            this.runNodeToolStripMenuItem.Name = "runNodeToolStripMenuItem";
            this.runNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runNodeToolStripMenuItem.Text = "run-node";
            this.runNodeToolStripMenuItem.Click += new System.EventHandler(this.runNodeToolStripMenuItem_Click);
            // 
            // activenodeToolStripMenuItem
            // 
            this.activenodeToolStripMenuItem.Name = "activenodeToolStripMenuItem";
            this.activenodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activenodeToolStripMenuItem.Text = "active-node";
            this.activenodeToolStripMenuItem.Click += new System.EventHandler(this.activenodeToolStripMenuItem_Click);
            // 
            // bootnodeToolStripMenuItem
            // 
            this.bootnodeToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.bootnodeToolStripMenuItem.Name = "bootnodeToolStripMenuItem";
            this.bootnodeToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.bootnodeToolStripMenuItem.Text = "bootnode";
            this.bootnodeToolStripMenuItem.Click += new System.EventHandler(this.bootnodeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 1: Stup node";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(66, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Step 2: Run node";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(66, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Step 3: Active node";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Controller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stupNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootnodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activenodeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

