
namespace Exam_NamedSharedMemory
{
    partial class FrmSnowfallDebugger
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
            this.TxtFrameCount = new System.Windows.Forms.TextBox();
            this.TmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.LvwSnowflakeInfo = new System.Windows.Forms.ListView();
            this.colIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colXPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAngle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TtlFrameCount = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.GrpSnowflakeInfo = new System.Windows.Forms.GroupBox();
            this.PnlFill = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuMonitoring = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMonitoring_Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlTop.SuspendLayout();
            this.GrpSnowflakeInfo.SuspendLayout();
            this.PnlFill.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFrameCount
            // 
            this.TxtFrameCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtFrameCount.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFrameCount.Location = new System.Drawing.Point(8, 26);
            this.TxtFrameCount.Name = "TxtFrameCount";
            this.TxtFrameCount.ReadOnly = true;
            this.TxtFrameCount.Size = new System.Drawing.Size(508, 19);
            this.TxtFrameCount.TabIndex = 1;
            this.TxtFrameCount.TabStop = false;
            // 
            // TmrRefresh
            // 
            this.TmrRefresh.Enabled = true;
            this.TmrRefresh.Tick += new System.EventHandler(this.TmrRefresh_Tick);
            // 
            // LvwSnowflakeInfo
            // 
            this.LvwSnowflakeInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIndex,
            this.colXPos,
            this.colYPos,
            this.colAngle});
            this.LvwSnowflakeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvwSnowflakeInfo.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LvwSnowflakeInfo.FullRowSelect = true;
            this.LvwSnowflakeInfo.GridLines = true;
            this.LvwSnowflakeInfo.HideSelection = false;
            this.LvwSnowflakeInfo.Location = new System.Drawing.Point(8, 20);
            this.LvwSnowflakeInfo.MultiSelect = false;
            this.LvwSnowflakeInfo.Name = "LvwSnowflakeInfo";
            this.LvwSnowflakeInfo.Size = new System.Drawing.Size(492, 517);
            this.LvwSnowflakeInfo.TabIndex = 0;
            this.LvwSnowflakeInfo.UseCompatibleStateImageBehavior = false;
            this.LvwSnowflakeInfo.View = System.Windows.Forms.View.Details;
            // 
            // colIndex
            // 
            this.colIndex.Text = "インデックス";
            this.colIndex.Width = 100;
            // 
            // colXPos
            // 
            this.colXPos.Text = "X位置";
            this.colXPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colYPos
            // 
            this.colYPos.Text = "Y位置";
            this.colYPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colAngle
            // 
            this.colAngle.Text = "角度値";
            this.colAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TtlFrameCount
            // 
            this.TtlFrameCount.AutoSize = true;
            this.TtlFrameCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.TtlFrameCount.Location = new System.Drawing.Point(8, 8);
            this.TtlFrameCount.Name = "TtlFrameCount";
            this.TtlFrameCount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.TtlFrameCount.Size = new System.Drawing.Size(80, 18);
            this.TtlFrameCount.TabIndex = 0;
            this.TtlFrameCount.Text = "経過フレーム数:";
            // 
            // PnlTop
            // 
            this.PnlTop.Controls.Add(this.TxtFrameCount);
            this.PnlTop.Controls.Add(this.TtlFrameCount);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 24);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Padding = new System.Windows.Forms.Padding(8);
            this.PnlTop.Size = new System.Drawing.Size(524, 56);
            this.PnlTop.TabIndex = 0;
            // 
            // GrpSnowflakeInfo
            // 
            this.GrpSnowflakeInfo.Controls.Add(this.LvwSnowflakeInfo);
            this.GrpSnowflakeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpSnowflakeInfo.Location = new System.Drawing.Point(8, 8);
            this.GrpSnowflakeInfo.Margin = new System.Windows.Forms.Padding(32);
            this.GrpSnowflakeInfo.Name = "GrpSnowflakeInfo";
            this.GrpSnowflakeInfo.Padding = new System.Windows.Forms.Padding(8);
            this.GrpSnowflakeInfo.Size = new System.Drawing.Size(508, 545);
            this.GrpSnowflakeInfo.TabIndex = 0;
            this.GrpSnowflakeInfo.TabStop = false;
            this.GrpSnowflakeInfo.Text = "雪片";
            // 
            // PnlFill
            // 
            this.PnlFill.Controls.Add(this.GrpSnowflakeInfo);
            this.PnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFill.Location = new System.Drawing.Point(0, 80);
            this.PnlFill.Name = "PnlFill";
            this.PnlFill.Padding = new System.Windows.Forms.Padding(8);
            this.PnlFill.Size = new System.Drawing.Size(524, 561);
            this.PnlFill.TabIndex = 1;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMonitoring});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(524, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MnuMonitoring
            // 
            this.MnuMonitoring.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMonitoring_Pause});
            this.MnuMonitoring.Name = "MnuMonitoring";
            this.MnuMonitoring.Size = new System.Drawing.Size(91, 20);
            this.MnuMonitoring.Text = "モニタリング(&M)";
            // 
            // MnuMonitoring_Pause
            // 
            this.MnuMonitoring_Pause.CheckOnClick = true;
            this.MnuMonitoring_Pause.Name = "MnuMonitoring_Pause";
            this.MnuMonitoring_Pause.Size = new System.Drawing.Size(137, 22);
            this.MnuMonitoring_Pause.Text = "一時停止(&P)";
            // 
            // FrmSnowfallDebugger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 641);
            this.Controls.Add(this.PnlFill);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmSnowfallDebugger";
            this.Text = "雪景色デバッガー";
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.GrpSnowflakeInfo.ResumeLayout(false);
            this.PnlFill.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFrameCount;
        private System.Windows.Forms.Timer TmrRefresh;
        private System.Windows.Forms.ListView LvwSnowflakeInfo;
        private System.Windows.Forms.ColumnHeader colIndex;
        private System.Windows.Forms.ColumnHeader colXPos;
        private System.Windows.Forms.ColumnHeader colYPos;
        private System.Windows.Forms.ColumnHeader colAngle;
        private System.Windows.Forms.Label TtlFrameCount;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.GroupBox GrpSnowflakeInfo;
        private System.Windows.Forms.Panel PnlFill;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuMonitoring;
        private System.Windows.Forms.ToolStripMenuItem MnuMonitoring_Pause;
    }
}