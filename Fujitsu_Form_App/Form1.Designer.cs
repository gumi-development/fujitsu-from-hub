
namespace Fujitsu_Form_App
{
    partial class Form1
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
            this.button_Wj = new System.Windows.Forms.Button();
            this.button_Mtg = new System.Windows.Forms.Button();
            this.hub_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Wj
            // 
            this.button_Wj.BackColor = System.Drawing.SystemColors.Window;
            this.button_Wj.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Wj.Location = new System.Drawing.Point(218, 180);
            this.button_Wj.Name = "button_Wj";
            this.button_Wj.Size = new System.Drawing.Size(264, 61);
            this.button_Wj.TabIndex = 2;
            this.button_Wj.Text = "WayFinding Journeyを起動";
            this.button_Wj.UseVisualStyleBackColor = false;
            this.button_Wj.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Mtg
            // 
            this.button_Mtg.BackColor = System.Drawing.SystemColors.Window;
            this.button_Mtg.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Mtg.Location = new System.Drawing.Point(218, 261);
            this.button_Mtg.Name = "button_Mtg";
            this.button_Mtg.Size = new System.Drawing.Size(264, 61);
            this.button_Mtg.TabIndex = 3;
            this.button_Mtg.Text = "2030年の経営会議を起動\r\n";
            this.button_Mtg.UseVisualStyleBackColor = false;
            this.button_Mtg.Click += new System.EventHandler(this.button2_Click);
            // 
            // hub_txt
            // 
            this.hub_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hub_txt.AutoSize = true;
            this.hub_txt.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hub_txt.Location = new System.Drawing.Point(168, 21);
            this.hub_txt.Name = "hub_txt";
            this.hub_txt.Size = new System.Drawing.Size(352, 64);
            this.hub_txt.TabIndex = 4;
            this.hub_txt.Text = "Uvance Hub";
            this.hub_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("コーポレート・ロゴ（ラウンド）", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(286, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "起動めにゅ～";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hub_txt);
            this.Controls.Add(this.button_Mtg);
            this.Controls.Add(this.button_Wj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Wj;
        private System.Windows.Forms.Button button_Mtg;
        private System.Windows.Forms.Label hub_txt;
        private System.Windows.Forms.Label label1;
    }
}

