﻿
namespace App1.Forms
{
    partial class DogovorForm
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
            this.kursNameText = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chasiText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rukovodText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adresText = new System.Windows.Forms.Label();
            this.orgNameText = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prepodPhoneText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stazText = new System.Windows.Forms.Label();
            this.prepodNameText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kursNameText
            // 
            this.kursNameText.AutoSize = true;
            this.kursNameText.Location = new System.Drawing.Point(6, 18);
            this.kursNameText.Name = "kursNameText";
            this.kursNameText.Size = new System.Drawing.Size(69, 17);
            this.kursNameText.TabIndex = 1;
            this.kursNameText.Text = "testestest";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(43, 360);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(96, 33);
            this.acceptBtn.TabIndex = 2;
            this.acceptBtn.Text = "Оформить";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(208, 360);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 33);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kursNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chasiText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Всё о курсе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена:";
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Location = new System.Drawing.Point(150, 71);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(69, 17);
            this.priceText.TabIndex = 5;
            this.priceText.Text = "testestest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество часов:";
            // 
            // chasiText
            // 
            this.chasiText.AutoSize = true;
            this.chasiText.Location = new System.Drawing.Point(150, 44);
            this.chasiText.Name = "chasiText";
            this.chasiText.Size = new System.Drawing.Size(69, 17);
            this.chasiText.TabIndex = 3;
            this.chasiText.Text = "testestest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rukovodText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.phoneText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.adresText);
            this.groupBox2.Controls.Add(this.orgNameText);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 143);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Всё об организации";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Руководитель";
            // 
            // rukovodText
            // 
            this.rukovodText.AutoSize = true;
            this.rukovodText.Location = new System.Drawing.Point(6, 114);
            this.rukovodText.Name = "rukovodText";
            this.rukovodText.Size = new System.Drawing.Size(69, 17);
            this.rukovodText.TabIndex = 7;
            this.rukovodText.Text = "testestest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер телефона";
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Location = new System.Drawing.Point(133, 74);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(69, 17);
            this.phoneText.TabIndex = 5;
            this.phoneText.Text = "testestest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Адрес";
            // 
            // adresText
            // 
            this.adresText.AutoSize = true;
            this.adresText.Location = new System.Drawing.Point(58, 46);
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(69, 17);
            this.adresText.TabIndex = 3;
            this.adresText.Text = "testestest";
            // 
            // orgNameText
            // 
            this.orgNameText.AutoSize = true;
            this.orgNameText.Location = new System.Drawing.Point(6, 18);
            this.orgNameText.Name = "orgNameText";
            this.orgNameText.Size = new System.Drawing.Size(69, 17);
            this.orgNameText.TabIndex = 1;
            this.orgNameText.Text = "testestest";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.prepodPhoneText);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.stazText);
            this.groupBox3.Controls.Add(this.prepodNameText);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 88);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Всё о преподавателе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер телефона";
            // 
            // prepodPhoneText
            // 
            this.prepodPhoneText.AutoSize = true;
            this.prepodPhoneText.Location = new System.Drawing.Point(133, 68);
            this.prepodPhoneText.Name = "prepodPhoneText";
            this.prepodPhoneText.Size = new System.Drawing.Size(69, 17);
            this.prepodPhoneText.TabIndex = 5;
            this.prepodPhoneText.Text = "testestest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Стаж";
            // 
            // stazText
            // 
            this.stazText.AutoSize = true;
            this.stazText.Location = new System.Drawing.Point(87, 44);
            this.stazText.Name = "stazText";
            this.stazText.Size = new System.Drawing.Size(69, 17);
            this.stazText.TabIndex = 3;
            this.stazText.Text = "testestest";
            // 
            // prepodNameText
            // 
            this.prepodNameText.AutoSize = true;
            this.prepodNameText.Location = new System.Drawing.Point(6, 18);
            this.prepodNameText.Name = "prepodNameText";
            this.prepodNameText.Size = new System.Drawing.Size(69, 17);
            this.prepodNameText.TabIndex = 1;
            this.prepodNameText.Text = "testestest";
            // 
            // DogovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DogovorForm";
            this.Text = "Окно договора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label kursNameText;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chasiText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rukovodText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label adresText;
        private System.Windows.Forms.Label orgNameText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prepodPhoneText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label stazText;
        private System.Windows.Forms.Label prepodNameText;
    }
}