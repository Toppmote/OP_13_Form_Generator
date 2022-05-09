namespace Lab4
{
    partial class PodpisiForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Бухгалтер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Руководитель";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 20);
            this.label12.TabIndex = 36;
            this.label12.Text = "Расчёт и справку составил";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Директор, Иванов Иван Иванович",
            "Управляющий, Петров Пётр Петрович",
            "Менеджер, Сидорова Татьяна Олеговна"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 28);
            this.comboBox1.TabIndex = 41;
            // 
            // comboBox4
            // 
            this.comboBox4.AllowDrop = true;
            this.comboBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "Симонов Иван Иванович",
            "Еремин Даниил Викторович",
            "Аносова Татьяна Игоревна"});
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(95, 155);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(340, 28);
            this.comboBox4.TabIndex = 44;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Управляющий, Петров Пётр Петрович",
            "Менеджер, Сидорова Татьяна Олеговна",
            "Старший работник, Тыквин Степан Станиславович"});
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(423, 28);
            this.comboBox2.TabIndex = 45;
            // 
            // PodpisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 200);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Name = "PodpisiForm";
            this.Text = "Подписи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label16;
        private Label label4;
        private Label label12;
        private ComboBox comboBox1;
        private ComboBox comboBox4;
        private ComboBox comboBox2;
    }
}