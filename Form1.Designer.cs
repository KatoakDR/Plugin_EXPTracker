﻿namespace Standalone_EXPTracker
{
    partial class Form1
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
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.cbRankGain = new System.Windows.Forms.CheckBox();
            this.cbGagExp = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRankGained = new System.Windows.Forms.TextBox();
            this.txtLearned = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRankGained = new System.Windows.Forms.Button();
            this.lblRankGained = new System.Windows.Forms.Label();
            this.lblLearned = new System.Windows.Forms.Label();
            this.btnLearned = new System.Windows.Forms.Button();
            this.lblNormal = new System.Windows.Forms.Label();
            this.btnNormal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.cbLearningRateNumber = new System.Windows.Forms.CheckBox();
            this.cbLearningRate = new System.Windows.Forms.CheckBox();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Location = new System.Drawing.Point(12, 12);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(157, 17);
            this.cbEnable.TabIndex = 0;
            this.cbEnable.Text = "Enable Experience Window";
            this.cbEnable.UseVisualStyleBackColor = true;
            // 
            // cbRankGain
            // 
            this.cbRankGain.AutoSize = true;
            this.cbRankGain.Location = new System.Drawing.Point(33, 32);
            this.cbRankGain.Name = "cbRankGain";
            this.cbRankGain.Size = new System.Drawing.Size(108, 17);
            this.cbRankGain.TabIndex = 2;
            this.cbRankGain.Text = "Track Rank Gain";
            this.cbRankGain.UseVisualStyleBackColor = true;
            // 
            // cbGagExp
            // 
            this.cbGagExp.AutoSize = true;
            this.cbGagExp.Location = new System.Drawing.Point(12, 127);
            this.cbGagExp.Name = "cbGagExp";
            this.cbGagExp.Size = new System.Drawing.Size(180, 17);
            this.cbGagExp.TabIndex = 3;
            this.cbGagExp.Text = "Gag experience in game window";
            this.cbGagExp.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(17, 300);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRankGained
            // 
            this.txtRankGained.Location = new System.Drawing.Point(13, 211);
            this.txtRankGained.Name = "txtRankGained";
            this.txtRankGained.Size = new System.Drawing.Size(100, 20);
            this.txtRankGained.TabIndex = 7;
            // 
            // txtLearned
            // 
            this.txtLearned.Location = new System.Drawing.Point(12, 264);
            this.txtLearned.Name = "txtLearned";
            this.txtLearned.Size = new System.Drawing.Size(100, 20);
            this.txtLearned.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Color for when you gain a rank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Color for when you learned something in the rank";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRankGained
            // 
            this.btnRankGained.Location = new System.Drawing.Point(207, 211);
            this.btnRankGained.Name = "btnRankGained";
            this.btnRankGained.Size = new System.Drawing.Size(61, 22);
            this.btnRankGained.TabIndex = 11;
            this.btnRankGained.Text = "Color...";
            this.btnRankGained.UseVisualStyleBackColor = true;
            this.btnRankGained.Click += new System.EventHandler(this.btnRankGained_Click);
            // 
            // lblRankGained
            // 
            this.lblRankGained.BackColor = System.Drawing.Color.Black;
            this.lblRankGained.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankGained.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRankGained.Location = new System.Drawing.Point(118, 211);
            this.lblRankGained.Name = "lblRankGained";
            this.lblRankGained.Size = new System.Drawing.Size(83, 20);
            this.lblRankGained.TabIndex = 12;
            this.lblRankGained.Text = "Color";
            this.lblRankGained.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLearned
            // 
            this.lblLearned.BackColor = System.Drawing.Color.Black;
            this.lblLearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearned.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLearned.Location = new System.Drawing.Point(118, 264);
            this.lblLearned.Name = "lblLearned";
            this.lblLearned.Size = new System.Drawing.Size(83, 20);
            this.lblLearned.TabIndex = 13;
            this.lblLearned.Text = "Color";
            this.lblLearned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLearned
            // 
            this.btnLearned.Location = new System.Drawing.Point(207, 264);
            this.btnLearned.Name = "btnLearned";
            this.btnLearned.Size = new System.Drawing.Size(61, 22);
            this.btnLearned.TabIndex = 14;
            this.btnLearned.Text = "Color...";
            this.btnLearned.UseVisualStyleBackColor = true;
            this.btnLearned.Click += new System.EventHandler(this.btnLearned_Click);
            // 
            // lblNormal
            // 
            this.lblNormal.BackColor = System.Drawing.Color.Black;
            this.lblNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNormal.Location = new System.Drawing.Point(118, 164);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(83, 20);
            this.lblNormal.TabIndex = 18;
            this.lblNormal.Text = "Color";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(207, 164);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(61, 22);
            this.btnNormal.TabIndex = 17;
            this.btnNormal.Text = "Color...";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Normal Color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(13, 164);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(100, 20);
            this.txtNormal.TabIndex = 15;
            // 
            // cbLearningRateNumber
            // 
            this.cbLearningRateNumber.AutoSize = true;
            this.cbLearningRateNumber.Location = new System.Drawing.Point(32, 77);
            this.cbLearningRateNumber.Name = "cbLearningRateNumber";
            this.cbLearningRateNumber.Size = new System.Drawing.Size(218, 17);
            this.cbLearningRateNumber.TabIndex = 19;
            this.cbLearningRateNumber.Text = "Show LearningRate Numbers e.g. (4/34)";
            this.cbLearningRateNumber.UseVisualStyleBackColor = true;
            // 
            // cbLearningRate
            // 
            this.cbLearningRate.AutoSize = true;
            this.cbLearningRate.Location = new System.Drawing.Point(33, 54);
            this.cbLearningRate.Name = "cbLearningRate";
            this.cbLearningRate.Size = new System.Drawing.Size(156, 17);
            this.cbLearningRate.TabIndex = 20;
            this.cbLearningRate.Text = "Show LearningRate Names";
            this.cbLearningRate.UseVisualStyleBackColor = true;
            // 
            // comboSort
            // 
            this.comboSort.AutoCompleteCustomSource.AddRange(new string[] {
            "A to Z",
            "Left to Right",
            "Top to Botom"});
            this.comboSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Items.AddRange(new object[] {
            "A to Z",
            "Left to Right",
            "Top to Bottom"});
            this.comboSort.Location = new System.Drawing.Point(95, 97);
            this.comboSort.MaxDropDownItems = 3;
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(151, 21);
            this.comboSort.TabIndex = 21;
            this.comboSort.Text = "A to Z";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(36, 100);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(56, 13);
            this.lblSort.TabIndex = 22;
            this.lblSort.Text = "Sort Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 335);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.cbLearningRate);
            this.Controls.Add(this.cbLearningRateNumber);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNormal);
            this.Controls.Add(this.btnLearned);
            this.Controls.Add(this.lblLearned);
            this.Controls.Add(this.lblRankGained);
            this.Controls.Add(this.btnRankGained);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLearned);
            this.Controls.Add(this.txtRankGained);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbGagExp);
            this.Controls.Add(this.cbRankGain);
            this.Controls.Add(this.cbEnable);
            this.Name = "Form1";
            this.Text = "Experience Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.CheckBox cbEnable;
        public System.Windows.Forms.CheckBox cbRankGain;
        public System.Windows.Forms.CheckBox cbGagExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRankGained;
        private System.Windows.Forms.Label lblRankGained;
        private System.Windows.Forms.Label lblLearned;
        private System.Windows.Forms.Button btnLearned;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Button btnNormal;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNormal;
        public System.Windows.Forms.TextBox txtRankGained;
        protected System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtLearned;
        public System.Windows.Forms.CheckBox cbLearningRateNumber;
        public System.Windows.Forms.CheckBox cbLearningRate;
        private System.Windows.Forms.Label lblSort;
        public System.Windows.Forms.ComboBox comboSort;
    }
}