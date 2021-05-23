
namespace Viewer.ControlsInput
{
    partial class TimeTableControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.Saturday = new System.Windows.Forms.CheckBox();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.weekDays = new System.Windows.Forms.RadioButton();
            this.oddDays = new System.Windows.Forms.RadioButton();
            this.evenDays = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Расписание";
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Enabled = false;
            this.Sunday.Location = new System.Drawing.Point(382, 97);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(115, 21);
            this.Sunday.TabIndex = 16;
            this.Sunday.Text = "Воскресенье";
            this.Sunday.UseVisualStyleBackColor = true;
            this.Sunday.CheckedChanged += new System.EventHandler(this.Sunday_CheckedChanged);
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Enabled = false;
            this.Saturday.Location = new System.Drawing.Point(382, 70);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(85, 21);
            this.Saturday.TabIndex = 15;
            this.Saturday.Text = "Суббота";
            this.Saturday.UseVisualStyleBackColor = true;
            this.Saturday.CheckedChanged += new System.EventHandler(this.Saturday_CheckedChanged);
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Enabled = false;
            this.Friday.Location = new System.Drawing.Point(266, 70);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(87, 21);
            this.Friday.TabIndex = 14;
            this.Friday.Text = "Пятница";
            this.Friday.UseVisualStyleBackColor = true;
            this.Friday.CheckedChanged += new System.EventHandler(this.Friday_CheckedChanged);
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Enabled = false;
            this.Thursday.Location = new System.Drawing.Point(382, 43);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(83, 21);
            this.Thursday.TabIndex = 13;
            this.Thursday.Text = "Четверг";
            this.Thursday.UseVisualStyleBackColor = true;
            this.Thursday.CheckedChanged += new System.EventHandler(this.Thursday_CheckedChanged);
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Enabled = false;
            this.Wednesday.Location = new System.Drawing.Point(266, 42);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(71, 21);
            this.Wednesday.TabIndex = 12;
            this.Wednesday.Text = "Среда";
            this.Wednesday.UseVisualStyleBackColor = true;
            this.Wednesday.CheckedChanged += new System.EventHandler(this.Wednesday_CheckedChanged);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Enabled = false;
            this.Tuesday.Location = new System.Drawing.Point(382, 16);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(85, 21);
            this.Tuesday.TabIndex = 11;
            this.Tuesday.Text = "Вторник";
            this.Tuesday.UseVisualStyleBackColor = true;
            this.Tuesday.CheckedChanged += new System.EventHandler(this.Tuesday_CheckedChanged);
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Enabled = false;
            this.Monday.Location = new System.Drawing.Point(266, 15);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(110, 21);
            this.Monday.TabIndex = 10;
            this.Monday.Text = "Поедельник";
            this.Monday.UseVisualStyleBackColor = true;
            this.Monday.CheckedChanged += new System.EventHandler(this.Monday_CheckedChanged);
            // 
            // weekDays
            // 
            this.weekDays.AutoSize = true;
            this.weekDays.Location = new System.Drawing.Point(5, 11);
            this.weekDays.Name = "weekDays";
            this.weekDays.Size = new System.Drawing.Size(136, 21);
            this.weekDays.TabIndex = 17;
            this.weekDays.TabStop = true;
            this.weekDays.Text = "По дням недели";
            this.weekDays.UseVisualStyleBackColor = true;
            this.weekDays.CheckedChanged += new System.EventHandler(this.weekDays_CheckedChanged);
            // 
            // oddDays
            // 
            this.oddDays.AutoSize = true;
            this.oddDays.Location = new System.Drawing.Point(6, 65);
            this.oddDays.Name = "oddDays";
            this.oddDays.Size = new System.Drawing.Size(142, 21);
            this.oddDays.TabIndex = 18;
            this.oddDays.TabStop = true;
            this.oddDays.Text = "По чётным дням ";
            this.oddDays.UseVisualStyleBackColor = true;
            this.oddDays.CheckedChanged += new System.EventHandler(this.oddDays_CheckedChanged);
            // 
            // evenDays
            // 
            this.evenDays.AutoSize = true;
            this.evenDays.Location = new System.Drawing.Point(6, 38);
            this.evenDays.Name = "evenDays";
            this.evenDays.Size = new System.Drawing.Size(138, 21);
            this.evenDays.TabIndex = 19;
            this.evenDays.TabStop = true;
            this.evenDays.Text = "По чётным дням";
            this.evenDays.UseVisualStyleBackColor = true;
            this.evenDays.CheckedChanged += new System.EventHandler(this.evenDays_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.evenDays);
            this.groupBox1.Controls.Add(this.weekDays);
            this.groupBox1.Controls.Add(this.oddDays);
            this.groupBox1.Location = new System.Drawing.Point(113, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 97);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // TimeTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.label1);
            this.Name = "TimeTableControl";
            this.Size = new System.Drawing.Size(521, 128);
            this.Load += new System.EventHandler(this.TimeTableControlcs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.CheckBox Saturday;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.RadioButton weekDays;
        private System.Windows.Forms.RadioButton oddDays;
        private System.Windows.Forms.RadioButton evenDays;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
