namespace BestOIL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdb_money = new System.Windows.Forms.RadioButton();
            this.rdb_count = new System.Windows.Forms.RadioButton();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_fuels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_fuel_volume = new System.Windows.Forms.TextBox();
            this.txt_fuel_money = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_fuel_total = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.txt_hotdog_price = new System.Windows.Forms.TextBox();
            this.txt_gumburger_price = new System.Windows.Forms.TextBox();
            this.txt_kartoha_price = new System.Windows.Forms.TextBox();
            this.txt_cocacola_price = new System.Windows.Forms.TextBox();
            this.txt_cocacola_count = new System.Windows.Forms.TextBox();
            this.txt_kartoha_count = new System.Windows.Forms.TextBox();
            this.txt_gumburger_count = new System.Windows.Forms.TextBox();
            this.txt_hotdog_count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_kafe_total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fuel_money);
            this.groupBox1.Controls.Add(this.txt_fuel_volume);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbx_fuels);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdb_money);
            this.groupBox6.Controls.Add(this.rdb_count);
            this.groupBox6.Location = new System.Drawing.Point(22, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(249, 137);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // rdb_money
            // 
            this.rdb_money.AutoSize = true;
            this.rdb_money.Location = new System.Drawing.Point(23, 86);
            this.rdb_money.Name = "rdb_money";
            this.rdb_money.Size = new System.Drawing.Size(73, 28);
            this.rdb_money.TabIndex = 1;
            this.rdb_money.TabStop = true;
            this.rdb_money.Text = "Сума";
            this.rdb_money.UseVisualStyleBackColor = true;
            this.rdb_money.CheckedChanged += new System.EventHandler(this.rdb_count_CheckedChanged);
            // 
            // rdb_count
            // 
            this.rdb_count.AutoSize = true;
            this.rdb_count.Checked = true;
            this.rdb_count.Location = new System.Drawing.Point(23, 40);
            this.rdb_count.Name = "rdb_count";
            this.rdb_count.Size = new System.Drawing.Size(109, 28);
            this.rdb_count.TabIndex = 0;
            this.rdb_count.TabStop = true;
            this.rdb_count.Text = "Кількість";
            this.rdb_count.UseVisualStyleBackColor = true;
            this.rdb_count.CheckedChanged += new System.EventHandler(this.rdb_count_CheckedChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(143, 175);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(427, 29);
            this.txt_price.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ціна";
            // 
            // cmbx_fuels
            // 
            this.cmbx_fuels.FormattingEnabled = true;
            this.cmbx_fuels.Location = new System.Drawing.Point(143, 81);
            this.cmbx_fuels.Name = "cmbx_fuels";
            this.cmbx_fuels.Size = new System.Drawing.Size(427, 32);
            this.cmbx_fuels.TabIndex = 2;
            this.cmbx_fuels.SelectedIndexChanged += new System.EventHandler(this.cmbx_fuels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Паливо";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_fuel_total);
            this.groupBox4.Location = new System.Drawing.Point(22, 483);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 101);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Паливо до оплати";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_cocacola_count);
            this.groupBox2.Controls.Add(this.txt_kartoha_count);
            this.groupBox2.Controls.Add(this.txt_gumburger_count);
            this.groupBox2.Controls.Add(this.txt_hotdog_count);
            this.groupBox2.Controls.Add(this.txt_cocacola_price);
            this.groupBox2.Controls.Add(this.txt_kartoha_price);
            this.groupBox2.Controls.Add(this.txt_gumburger_price);
            this.groupBox2.Controls.Add(this.txt_hotdog_price);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(642, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 590);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Міні-кафе";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_kafe_total);
            this.groupBox5.Location = new System.Drawing.Point(28, 483);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(548, 101);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Кафе до оплати";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(12, 625);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1226, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ВСЬОГО до оплати";
            // 
            // txt_fuel_volume
            // 
            this.txt_fuel_volume.Location = new System.Drawing.Point(295, 297);
            this.txt_fuel_volume.Name = "txt_fuel_volume";
            this.txt_fuel_volume.Size = new System.Drawing.Size(202, 29);
            this.txt_fuel_volume.TabIndex = 6;
            this.txt_fuel_volume.Text = "0";
            this.txt_fuel_volume.TextChanged += new System.EventHandler(this.txt_fuel_volume_TextChanged);
            // 
            // txt_fuel_money
            // 
            this.txt_fuel_money.Location = new System.Drawing.Point(295, 391);
            this.txt_fuel_money.Name = "txt_fuel_money";
            this.txt_fuel_money.ReadOnly = true;
            this.txt_fuel_money.Size = new System.Drawing.Size(202, 29);
            this.txt_fuel_money.TabIndex = 7;
            this.txt_fuel_money.Text = "0";
            this.txt_fuel_money.TextChanged += new System.EventHandler(this.txt_fuel_money_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "літри";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "грн.";
            // 
            // lbl_fuel_total
            // 
            this.lbl_fuel_total.AutoSize = true;
            this.lbl_fuel_total.Location = new System.Drawing.Point(269, 46);
            this.lbl_fuel_total.Name = "lbl_fuel_total";
            this.lbl_fuel_total.Size = new System.Drawing.Size(20, 24);
            this.lbl_fuel_total.TabIndex = 0;
            this.lbl_fuel_total.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Хот-дог";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 142);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 28);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Гамбургер";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 200);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(149, 28);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Картопля-фрі";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(28, 254);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(114, 28);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Coca-cola";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // txt_hotdog_price
            // 
            this.txt_hotdog_price.Location = new System.Drawing.Point(341, 79);
            this.txt_hotdog_price.Name = "txt_hotdog_price";
            this.txt_hotdog_price.ReadOnly = true;
            this.txt_hotdog_price.Size = new System.Drawing.Size(100, 29);
            this.txt_hotdog_price.TabIndex = 6;
            this.txt_hotdog_price.Text = "0";
            // 
            // txt_gumburger_price
            // 
            this.txt_gumburger_price.Location = new System.Drawing.Point(341, 131);
            this.txt_gumburger_price.Name = "txt_gumburger_price";
            this.txt_gumburger_price.ReadOnly = true;
            this.txt_gumburger_price.Size = new System.Drawing.Size(100, 29);
            this.txt_gumburger_price.TabIndex = 7;
            this.txt_gumburger_price.Text = "0";
            // 
            // txt_kartoha_price
            // 
            this.txt_kartoha_price.Location = new System.Drawing.Point(341, 188);
            this.txt_kartoha_price.Name = "txt_kartoha_price";
            this.txt_kartoha_price.ReadOnly = true;
            this.txt_kartoha_price.Size = new System.Drawing.Size(100, 29);
            this.txt_kartoha_price.TabIndex = 8;
            this.txt_kartoha_price.Text = "0";
            // 
            // txt_cocacola_price
            // 
            this.txt_cocacola_price.Location = new System.Drawing.Point(341, 244);
            this.txt_cocacola_price.Name = "txt_cocacola_price";
            this.txt_cocacola_price.ReadOnly = true;
            this.txt_cocacola_price.Size = new System.Drawing.Size(100, 29);
            this.txt_cocacola_price.TabIndex = 9;
            this.txt_cocacola_price.Text = "0";
            // 
            // txt_cocacola_count
            // 
            this.txt_cocacola_count.Location = new System.Drawing.Point(193, 244);
            this.txt_cocacola_count.Name = "txt_cocacola_count";
            this.txt_cocacola_count.ReadOnly = true;
            this.txt_cocacola_count.Size = new System.Drawing.Size(100, 29);
            this.txt_cocacola_count.TabIndex = 13;
            this.txt_cocacola_count.Text = "0";
            // 
            // txt_kartoha_count
            // 
            this.txt_kartoha_count.Location = new System.Drawing.Point(193, 188);
            this.txt_kartoha_count.Name = "txt_kartoha_count";
            this.txt_kartoha_count.ReadOnly = true;
            this.txt_kartoha_count.Size = new System.Drawing.Size(100, 29);
            this.txt_kartoha_count.TabIndex = 12;
            this.txt_kartoha_count.Text = "0";
            // 
            // txt_gumburger_count
            // 
            this.txt_gumburger_count.Location = new System.Drawing.Point(193, 131);
            this.txt_gumburger_count.Name = "txt_gumburger_count";
            this.txt_gumburger_count.ReadOnly = true;
            this.txt_gumburger_count.Size = new System.Drawing.Size(100, 29);
            this.txt_gumburger_count.TabIndex = 11;
            this.txt_gumburger_count.Text = "0";
            // 
            // txt_hotdog_count
            // 
            this.txt_hotdog_count.Location = new System.Drawing.Point(193, 79);
            this.txt_hotdog_count.Name = "txt_hotdog_count";
            this.txt_hotdog_count.ReadOnly = true;
            this.txt_hotdog_count.Size = new System.Drawing.Size(100, 29);
            this.txt_hotdog_count.TabIndex = 10;
            this.txt_hotdog_count.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ціна";
            // 
            // lbl_kafe_total
            // 
            this.lbl_kafe_total.AutoSize = true;
            this.lbl_kafe_total.Location = new System.Drawing.Point(268, 46);
            this.lbl_kafe_total.Name = "lbl_kafe_total";
            this.lbl_kafe_total.Size = new System.Drawing.Size(20, 24);
            this.lbl_kafe_total.TabIndex = 1;
            this.lbl_kafe_total.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 790);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Oil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbx_fuels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdb_money;
        private System.Windows.Forms.RadioButton rdb_count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fuel_money;
        private System.Windows.Forms.TextBox txt_fuel_volume;
        private System.Windows.Forms.Label lbl_fuel_total;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_cocacola_price;
        private System.Windows.Forms.TextBox txt_kartoha_price;
        private System.Windows.Forms.TextBox txt_gumburger_price;
        private System.Windows.Forms.TextBox txt_hotdog_price;
        private System.Windows.Forms.TextBox txt_cocacola_count;
        private System.Windows.Forms.TextBox txt_kartoha_count;
        private System.Windows.Forms.TextBox txt_gumburger_count;
        private System.Windows.Forms.TextBox txt_hotdog_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_kafe_total;
    }
}

