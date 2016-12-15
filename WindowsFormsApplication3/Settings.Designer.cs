namespace WindowsFormsApplication3
{
    partial class Settings
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
            this.treeSize = new System.Windows.Forms.TextBox();
            this.brenchFrequency = new System.Windows.Forms.TextBox();
            this.lushness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brenchWeaking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.leafQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minLeaf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.brenchWidth = new System.Windows.Forms.TextBox();
            this.branchWidthChange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.spawnOffsetFromTop = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spawnOffsetFromTop)).BeginInit();
            this.SuspendLayout();
            // 
            // treeSize
            // 
            this.treeSize.Location = new System.Drawing.Point(198, 19);
            this.treeSize.Name = "treeSize";
            this.treeSize.Size = new System.Drawing.Size(140, 20);
            this.treeSize.TabIndex = 0;
            this.treeSize.TextChanged += new System.EventHandler(this.Changes);
            // 
            // brenchFrequency
            // 
            this.brenchFrequency.Location = new System.Drawing.Point(198, 83);
            this.brenchFrequency.Name = "brenchFrequency";
            this.brenchFrequency.Size = new System.Drawing.Size(140, 20);
            this.brenchFrequency.TabIndex = 1;
            this.brenchFrequency.TextChanged += new System.EventHandler(this.Changes);
            // 
            // lushness
            // 
            this.lushness.Location = new System.Drawing.Point(198, 51);
            this.lushness.Name = "lushness";
            this.lushness.Size = new System.Drawing.Size(140, 20);
            this.lushness.TabIndex = 2;
            this.lushness.TextChanged += new System.EventHandler(this.Changes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер Дерева";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Максимальная длина ветки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Частота веток";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ослабевание отростков";
            // 
            // brenchWeaking
            // 
            this.brenchWeaking.Location = new System.Drawing.Point(198, 114);
            this.brenchWeaking.Name = "brenchWeaking";
            this.brenchWeaking.Size = new System.Drawing.Size(140, 20);
            this.brenchWeaking.TabIndex = 7;
            this.brenchWeaking.TextChanged += new System.EventHandler(this.Changes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество листвы";
            // 
            // leafQuantity
            // 
            this.leafQuantity.Location = new System.Drawing.Point(198, 140);
            this.leafQuantity.Name = "leafQuantity";
            this.leafQuantity.Size = new System.Drawing.Size(140, 20);
            this.leafQuantity.TabIndex = 9;
            this.leafQuantity.TextChanged += new System.EventHandler(this.Changes);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Минимальный лист";
            // 
            // minLeaf
            // 
            this.minLeaf.Location = new System.Drawing.Point(198, 169);
            this.minLeaf.Name = "minLeaf";
            this.minLeaf.Size = new System.Drawing.Size(140, 20);
            this.minLeaf.TabIndex = 11;
            this.minLeaf.TextChanged += new System.EventHandler(this.Changes);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ширина ветки";
            // 
            // brenchWidth
            // 
            this.brenchWidth.Location = new System.Drawing.Point(198, 204);
            this.brenchWidth.Name = "brenchWidth";
            this.brenchWidth.Size = new System.Drawing.Size(140, 20);
            this.brenchWidth.TabIndex = 13;
            this.brenchWidth.TextChanged += new System.EventHandler(this.Changes);
            // 
            // branchWidthChange
            // 
            this.branchWidthChange.Location = new System.Drawing.Point(198, 242);
            this.branchWidthChange.Name = "branchWidthChange";
            this.branchWidthChange.Size = new System.Drawing.Size(140, 20);
            this.branchWidthChange.TabIndex = 14;
            this.branchWidthChange.TextChanged += new System.EventHandler(this.Changes);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Изменение ширины ветки";
            // 
            // spawnOffsetFromTop
            // 
            this.spawnOffsetFromTop.Location = new System.Drawing.Point(198, 268);
            this.spawnOffsetFromTop.Maximum = 100;
            this.spawnOffsetFromTop.Name = "spawnOffsetFromTop";
            this.spawnOffsetFromTop.Size = new System.Drawing.Size(481, 45);
            this.spawnOffsetFromTop.TabIndex = 16;
            this.spawnOffsetFromTop.Scroll += new System.EventHandler(this.Changes);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Корень";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Вершина";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Область спавна веток";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 448);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spawnOffsetFromTop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.branchWidthChange);
            this.Controls.Add(this.brenchWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minLeaf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leafQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brenchWeaking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lushness);
            this.Controls.Add(this.brenchFrequency);
            this.Controls.Add(this.treeSize);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.spawnOffsetFromTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox treeSize;
        private System.Windows.Forms.TextBox brenchFrequency;
        private System.Windows.Forms.TextBox lushness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brenchWeaking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox leafQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minLeaf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox brenchWidth;
        private System.Windows.Forms.TextBox branchWidthChange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar spawnOffsetFromTop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}