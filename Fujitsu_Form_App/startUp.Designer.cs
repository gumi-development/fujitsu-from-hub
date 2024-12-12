
namespace Fujitsu_Form_App
{
    partial class startUp
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
            this.SuspendLayout();
            // 
            // button_Wj
            // 
            this.button_Wj.BackColor = System.Drawing.SystemColors.Window;
            this.button_Wj.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Wj.Location = new System.Drawing.Point(201, 134);
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
            this.button_Mtg.Location = new System.Drawing.Point(201, 245);
            this.button_Mtg.Name = "button_Mtg";
            this.button_Mtg.Size = new System.Drawing.Size(264, 61);
            this.button_Mtg.TabIndex = 3;
            this.button_Mtg.Text = "2030年の経営会議を起動\r\n";
            this.button_Mtg.UseVisualStyleBackColor = false;
            this.button_Mtg.Click += new System.EventHandler(this.button2_Click);
            // 
            // startUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 435);
            this.Controls.Add(this.button_Mtg);
            this.Controls.Add(this.button_Wj);
            this.Name = "startUp";
            this.Text = "Fujitsu_Uvance_StartUp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Wj;
        private System.Windows.Forms.Button button_Mtg;
    }
}

