namespace Boom
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartCatch = new System.Windows.Forms.Button();
            this.tbcount = new System.Windows.Forms.TextBox();
            this.lbcount = new System.Windows.Forms.Label();
            this.lbmsg = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbEnter = new System.Windows.Forms.CheckBox();
            this.plImgs = new System.Windows.Forms.Panel();
            this.rbtnNone = new System.Windows.Forms.RadioButton();
            this.rbtnFunny = new System.Windows.Forms.RadioButton();
            this.rbtnSweat = new System.Windows.Forms.RadioButton();
            this.rbtnSick = new System.Windows.Forms.RadioButton();
            this.rbtnPity = new System.Windows.Forms.RadioButton();
            this.lbInterval = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.lams = new System.Windows.Forms.Label();
            this.rbtnEmbarrass = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.plImgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(29, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(405, 253);
            this.dgv.TabIndex = 1;
            this.dgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "句柄";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "进程类名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "进程标题";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSendMsg.Location = new System.Drawing.Point(481, 300);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(149, 38);
            this.btnSendMsg.TabIndex = 2;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMsg.Location = new System.Drawing.Point(481, 82);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(149, 183);
            this.tbMsg.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartCatch
            // 
            this.btnStartCatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartCatch.Location = new System.Drawing.Point(135, 300);
            this.btnStartCatch.Name = "btnStartCatch";
            this.btnStartCatch.Size = new System.Drawing.Size(289, 38);
            this.btnStartCatch.TabIndex = 4;
            this.btnStartCatch.Text = "开始检测";
            this.btnStartCatch.UseVisualStyleBackColor = true;
            this.btnStartCatch.Click += new System.EventHandler(this.btnStartCatch_Click);
            // 
            // tbcount
            // 
            this.tbcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcount.Location = new System.Drawing.Point(544, 7);
            this.tbcount.Name = "tbcount";
            this.tbcount.Size = new System.Drawing.Size(86, 21);
            this.tbcount.TabIndex = 5;
            // 
            // lbcount
            // 
            this.lbcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcount.AutoSize = true;
            this.lbcount.Location = new System.Drawing.Point(479, 12);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(59, 12);
            this.lbcount.TabIndex = 6;
            this.lbcount.Text = "发送次数:";
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Location = new System.Drawing.Point(479, 61);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(59, 12);
            this.lbmsg.TabIndex = 7;
            this.lbmsg.Text = "发送内容:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(29, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbEnter
            // 
            this.cbEnter.AutoSize = true;
            this.cbEnter.Location = new System.Drawing.Point(481, 271);
            this.cbEnter.Name = "cbEnter";
            this.cbEnter.Size = new System.Drawing.Size(96, 16);
            this.cbEnter.TabIndex = 9;
            this.cbEnter.Text = "发送时带回车";
            this.cbEnter.UseVisualStyleBackColor = true;
            // 
            // plImgs
            // 
            this.plImgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plImgs.Controls.Add(this.rbtnEmbarrass);
            this.plImgs.Controls.Add(this.rbtnPity);
            this.plImgs.Controls.Add(this.rbtnSick);
            this.plImgs.Controls.Add(this.rbtnSweat);
            this.plImgs.Controls.Add(this.rbtnFunny);
            this.plImgs.Controls.Add(this.rbtnNone);
            this.plImgs.Location = new System.Drawing.Point(649, 82);
            this.plImgs.Name = "plImgs";
            this.plImgs.Size = new System.Drawing.Size(86, 226);
            this.plImgs.TabIndex = 11;
            // 
            // rbtnNone
            // 
            this.rbtnNone.AutoSize = true;
            this.rbtnNone.Checked = true;
            this.rbtnNone.Location = new System.Drawing.Point(14, 15);
            this.rbtnNone.Name = "rbtnNone";
            this.rbtnNone.Size = new System.Drawing.Size(35, 16);
            this.rbtnNone.TabIndex = 0;
            this.rbtnNone.TabStop = true;
            this.rbtnNone.Text = "无";
            this.rbtnNone.UseVisualStyleBackColor = true;
            this.rbtnNone.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnFunny
            // 
            this.rbtnFunny.AutoSize = true;
            this.rbtnFunny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnFunny.Image = ((System.Drawing.Image)(resources.GetObject("rbtnFunny.Image")));
            this.rbtnFunny.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbtnFunny.Location = new System.Drawing.Point(14, 35);
            this.rbtnFunny.Name = "rbtnFunny";
            this.rbtnFunny.Size = new System.Drawing.Size(43, 30);
            this.rbtnFunny.TabIndex = 1;
            this.rbtnFunny.UseVisualStyleBackColor = true;
            this.rbtnFunny.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnSweat
            // 
            this.rbtnSweat.AutoSize = true;
            this.rbtnSweat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSweat.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSweat.Image")));
            this.rbtnSweat.Location = new System.Drawing.Point(14, 73);
            this.rbtnSweat.Name = "rbtnSweat";
            this.rbtnSweat.Size = new System.Drawing.Size(43, 30);
            this.rbtnSweat.TabIndex = 2;
            this.rbtnSweat.UseVisualStyleBackColor = true;
            this.rbtnSweat.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnSick
            // 
            this.rbtnSick.AutoSize = true;
            this.rbtnSick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnSick.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSick.Image")));
            this.rbtnSick.Location = new System.Drawing.Point(14, 111);
            this.rbtnSick.Name = "rbtnSick";
            this.rbtnSick.Size = new System.Drawing.Size(43, 30);
            this.rbtnSick.TabIndex = 3;
            this.rbtnSick.UseVisualStyleBackColor = true;
            this.rbtnSick.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnPity
            // 
            this.rbtnPity.AutoSize = true;
            this.rbtnPity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnPity.Image = ((System.Drawing.Image)(resources.GetObject("rbtnPity.Image")));
            this.rbtnPity.Location = new System.Drawing.Point(14, 149);
            this.rbtnPity.Name = "rbtnPity";
            this.rbtnPity.Size = new System.Drawing.Size(43, 30);
            this.rbtnPity.TabIndex = 4;
            this.rbtnPity.UseVisualStyleBackColor = true;
            this.rbtnPity.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // lbInterval
            // 
            this.lbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInterval.AutoSize = true;
            this.lbInterval.Location = new System.Drawing.Point(479, 36);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(59, 12);
            this.lbInterval.TabIndex = 12;
            this.lbInterval.Text = "发送频率:";
            // 
            // tbInterval
            // 
            this.tbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInterval.Location = new System.Drawing.Point(544, 34);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(86, 21);
            this.tbInterval.TabIndex = 13;
            this.tbInterval.Text = "10";
            // 
            // lams
            // 
            this.lams.AutoSize = true;
            this.lams.Location = new System.Drawing.Point(636, 40);
            this.lams.Name = "lams";
            this.lams.Size = new System.Drawing.Size(53, 12);
            this.lams.TabIndex = 14;
            this.lams.Text = "（毫秒）";
            // 
            // rbtnEmbarrass
            // 
            this.rbtnEmbarrass.AutoSize = true;
            this.rbtnEmbarrass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnEmbarrass.Image = ((System.Drawing.Image)(resources.GetObject("rbtnEmbarrass.Image")));
            this.rbtnEmbarrass.Location = new System.Drawing.Point(14, 189);
            this.rbtnEmbarrass.Name = "rbtnEmbarrass";
            this.rbtnEmbarrass.Size = new System.Drawing.Size(43, 30);
            this.rbtnEmbarrass.TabIndex = 5;
            this.rbtnEmbarrass.TabStop = true;
            this.rbtnEmbarrass.UseVisualStyleBackColor = true;
            this.rbtnEmbarrass.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 371);
            this.Controls.Add(this.lams);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.lbInterval);
            this.Controls.Add(this.plImgs);
            this.Controls.Add(this.cbEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.tbcount);
            this.Controls.Add(this.btnStartCatch);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "轰炸机";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.plImgs.ResumeLayout(false);
            this.plImgs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartCatch;
        private System.Windows.Forms.TextBox tbcount;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbEnter;
        private System.Windows.Forms.Panel plImgs;
        private System.Windows.Forms.RadioButton rbtnNone;
        private System.Windows.Forms.RadioButton rbtnFunny;
        private System.Windows.Forms.RadioButton rbtnSick;
        private System.Windows.Forms.RadioButton rbtnSweat;
        private System.Windows.Forms.RadioButton rbtnPity;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label lams;
        private System.Windows.Forms.RadioButton rbtnEmbarrass;


    }
}

