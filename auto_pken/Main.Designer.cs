namespace auto_pken
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.missBox = new System.Windows.Forms.TextBox();
            this.typingspeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(45, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "実行する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startButtonClicked);
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(213, 27);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(114, 19);
            this.delayBox.TabIndex = 1;
            this.delayBox.Text = "0";
            this.delayBox.TextChanged += new System.EventHandler(this.delayBox_TextChanged);
            this.delayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayBox_KeyPress);
            // 
            // missBox
            // 
            this.missBox.Location = new System.Drawing.Point(213, 85);
            this.missBox.Name = "missBox";
            this.missBox.Size = new System.Drawing.Size(114, 19);
            this.missBox.TabIndex = 2;
            this.missBox.Text = "0";
            this.missBox.TextChanged += new System.EventHandler(this.missBox_TextChanged);
            this.missBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.missBox_KeyPress);
            // 
            // typingspeed
            // 
            this.typingspeed.Location = new System.Drawing.Point(60, 33);
            this.typingspeed.Name = "typingspeed";
            this.typingspeed.Size = new System.Drawing.Size(112, 13);
            this.typingspeed.TabIndex = 3;
            this.typingspeed.Text = "タイピングディレイ (ms)";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ミスタップ確率 (%)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typingspeed);
            this.Controls.Add(this.missBox);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "自動タイピングテスト";
            this.Load += new System.EventHandler(this.mainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.TextBox missBox;
        private System.Windows.Forms.Label typingspeed;
        private System.Windows.Forms.Label label1;
    }
}

