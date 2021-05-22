
namespace Viewer.ControlsInput
{
    partial class TimeTableControlcs
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
            this.Sunday.Location = new System.Drawing.Point(380, 56);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(115, 21);
            this.Sunday.TabIndex = 16;
            this.Sunday.Text = "Воскресенье";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(291, 56);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(85, 21);
            this.Saturday.TabIndex = 15;
            this.Saturday.Text = "Суббота";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(380, 30);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(87, 21);
            this.Friday.TabIndex = 14;
            this.Friday.Text = "Пятница";
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(291, 29);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(83, 21);
            this.Thursday.TabIndex = 13;
            this.Thursday.Text = "Четверг";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(214, 29);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(71, 21);
            this.Wednesday.TabIndex = 12;
            this.Wednesday.Text = "Среда";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(123, 29);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(85, 21);
            this.Tuesday.TabIndex = 11;
            this.Tuesday.Text = "Вторник";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(7, 29);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(110, 21);
            this.Monday.TabIndex = 10;
            this.Monday.Text = "Поедельник";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // weekDays
            // 
            this.weekDays.AutoSize = true;
            this.weekDays.Location = new System.Drawing.Point(96, 2);
            this.weekDays.Name = "weekDays";
            this.weekDays.Size = new System.Drawing.Size(136, 21);
            this.weekDays.TabIndex = 17;
            this.weekDays.TabStop = true;
            this.weekDays.Text = "По дням недели";
            this.weekDays.UseVisualStyleBackColor = true;
            // 
            // oddDays
            // 
            this.oddDays.AutoSize = true;
            this.oddDays.Location = new System.Drawing.Point(235, 2);
            this.oddDays.Name = "oddDays";
            this.oddDays.Size = new System.Drawing.Size(142, 21);
            this.oddDays.TabIndex = 18;
            this.oddDays.TabStop = true;
            this.oddDays.Text = "По чётным дням ";
            this.oddDays.UseVisualStyleBackColor = true;
            // 
            // evenDays
            // 
            this.evenDays.AutoSize = true;
            this.evenDays.Location = new System.Drawing.Point(383, 3);
            this.evenDays.Name = "evenDays";
            this.evenDays.Size = new System.Drawing.Size(138, 21);
            this.evenDays.TabIndex = 19;
            this.evenDays.TabStop = true;
            this.evenDays.Text = "По чётным дням";
            this.evenDays.UseVisualStyleBackColor = true;
            // 
            // TimeTableControlcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.evenDays);
            this.Controls.Add(this.oddDays);
            this.Controls.Add(this.weekDays);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.label1);
            this.Name = "TimeTableControlcs";
            this.Size = new System.Drawing.Size(521, 82);
            this.Load += new System.EventHandler(this.TimeTableControlcs_Load);
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
    }
}
