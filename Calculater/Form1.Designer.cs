namespace Calculater
{
    partial class ttlCalculator
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.bunMinus = new System.Windows.Forms.Button();
            this.bunKakeru = new System.Windows.Forms.Button();
            this.btnWaru = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResultNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(40, 56);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(30, 15);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "値1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(40, 112);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(30, 15);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "値2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(139, 56);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(139, 112);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(40, 179);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 15);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "結果";
            this.lblResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 298);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(49, 47);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "＋";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunMinus
            // 
            this.bunMinus.Location = new System.Drawing.Point(79, 298);
            this.bunMinus.Name = "bunMinus";
            this.bunMinus.Size = new System.Drawing.Size(49, 47);
            this.bunMinus.TabIndex = 7;
            this.bunMinus.Text = "ー";
            this.bunMinus.UseVisualStyleBackColor = true;
            this.bunMinus.Click += new System.EventHandler(this.bunMinus_Click);
            // 
            // bunKakeru
            // 
            this.bunKakeru.Location = new System.Drawing.Point(149, 298);
            this.bunKakeru.Name = "bunKakeru";
            this.bunKakeru.Size = new System.Drawing.Size(49, 47);
            this.bunKakeru.TabIndex = 8;
            this.bunKakeru.Text = "×";
            this.bunKakeru.UseVisualStyleBackColor = true;
            this.bunKakeru.Click += new System.EventHandler(this.bunKakeru_Click);
            // 
            // btnWaru
            // 
            this.btnWaru.Location = new System.Drawing.Point(216, 298);
            this.btnWaru.Name = "btnWaru";
            this.btnWaru.Size = new System.Drawing.Size(49, 47);
            this.btnWaru.TabIndex = 9;
            this.btnWaru.Text = "÷";
            this.btnWaru.UseVisualStyleBackColor = true;
            this.btnWaru.Click += new System.EventHandler(this.btnWaru_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(286, 298);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(49, 47);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblResultNum
            // 
            this.lblResultNum.AutoSize = true;
            this.lblResultNum.Location = new System.Drawing.Point(136, 179);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(0, 15);
            this.lblResultNum.TabIndex = 11;
            // 
            // ttlCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 414);
            this.Controls.Add(this.lblResultNum);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWaru);
            this.Controls.Add(this.bunKakeru);
            this.Controls.Add(this.bunMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "ttlCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button bunMinus;
        private System.Windows.Forms.Button bunKakeru;
        private System.Windows.Forms.Button btnWaru;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResultNum;
    }
}

