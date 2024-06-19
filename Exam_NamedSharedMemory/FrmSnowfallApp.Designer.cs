
namespace Exam_NamedSharedMemory
{
    partial class FrmSnowfallApp
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDebug_LaunchDebugger = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmrAnimation
            // 
            this.TmrAnimation.Interval = 16;
            this.TmrAnimation.Tick += new System.EventHandler(this.TmrAnimation_Tick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDebug});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MnuDebug
            // 
            this.MnuDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuDebug_LaunchDebugger});
            this.MnuDebug.Name = "MnuDebug";
            this.MnuDebug.Size = new System.Drawing.Size(71, 20);
            this.MnuDebug.Text = "デバッグ(&D)";
            // 
            // MnuDebug_LaunchDebugger
            // 
            this.MnuDebug_LaunchDebugger.Name = "MnuDebug_LaunchDebugger";
            this.MnuDebug_LaunchDebugger.Size = new System.Drawing.Size(213, 22);
            this.MnuDebug_LaunchDebugger.Text = "デバッグ用プログラムを起動(&L)";
            this.MnuDebug_LaunchDebugger.Click += new System.EventHandler(this.MnuDebug_LaunchDebugger_Click);
            // 
            // FrmSnowfallApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "FrmSnowfallApp";
            this.Text = "雪景色ビューアー";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSnowfallApp_FormClosed);
            this.Load += new System.EventHandler(this.FrmSnowfallApp_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmSnowfallScene_Paint);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TmrAnimation;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuDebug;
        private System.Windows.Forms.ToolStripMenuItem MnuDebug_LaunchDebugger;
    }
}

