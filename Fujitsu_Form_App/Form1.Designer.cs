
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.button_Wj = new System.Windows.Forms.Button();
            this.button_Mtg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(687, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // button_Wj
            // 
            this.button_Wj.Location = new System.Drawing.Point(219, 138);
            this.button_Wj.Name = "button_Wj";
            this.button_Wj.Size = new System.Drawing.Size(264, 61);
            this.button_Wj.TabIndex = 2;
            this.button_Wj.Text = "WayFinding Journeyを起動";
            this.button_Wj.UseVisualStyleBackColor = true;
            this.button_Wj.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Mtg
            // 
            this.button_Mtg.Location = new System.Drawing.Point(219, 244);
            this.button_Mtg.Name = "button_Mtg";
            this.button_Mtg.Size = new System.Drawing.Size(264, 61);
            this.button_Mtg.TabIndex = 3;
            this.button_Mtg.Text = "2030年の経営会議を起動\r\n";
            this.button_Mtg.UseVisualStyleBackColor = true;
            this.button_Mtg.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 435);
            this.Controls.Add(this.button_Mtg);
            this.Controls.Add(this.button_Wj);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button button_Wj;
        private System.Windows.Forms.Button button_Mtg;
    }
}

