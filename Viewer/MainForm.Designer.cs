
namespace Viewer
{
    partial class MainForm
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
            this.tripButton = new System.Windows.Forms.Button();
            this.timeTableButton = new System.Windows.Forms.Button();
            this.routeButton = new System.Windows.Forms.Button();
            this.stationButon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WagonButton = new System.Windows.Forms.Button();
            this.trainButton = new System.Windows.Forms.Button();
            this.tiketButton = new System.Windows.Forms.Button();
            this.personButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tripButton);
            this.groupBox1.Controls.Add(this.timeTableButton);
            this.groupBox1.Controls.Add(this.routeButton);
            this.groupBox1.Controls.Add(this.stationButon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Раписание";
            // 
            // tripButton
            // 
            this.tripButton.Location = new System.Drawing.Point(7, 133);
            this.tripButton.Name = "tripButton";
            this.tripButton.Size = new System.Drawing.Size(167, 31);
            this.tripButton.TabIndex = 3;
            this.tripButton.Text = "Рейсы";
            this.tripButton.UseVisualStyleBackColor = true;
            this.tripButton.Click += new System.EventHandler(this.tripButton_Click);
            // 
            // timeTableButton
            // 
            this.timeTableButton.Location = new System.Drawing.Point(7, 59);
            this.timeTableButton.Name = "timeTableButton";
            this.timeTableButton.Size = new System.Drawing.Size(167, 31);
            this.timeTableButton.TabIndex = 2;
            this.timeTableButton.Text = "Расписание";
            this.timeTableButton.UseVisualStyleBackColor = true;
            this.timeTableButton.Click += new System.EventHandler(this.timeTableButton_Click);
            // 
            // routeButton
            // 
            this.routeButton.Location = new System.Drawing.Point(6, 96);
            this.routeButton.Name = "routeButton";
            this.routeButton.Size = new System.Drawing.Size(167, 31);
            this.routeButton.TabIndex = 1;
            this.routeButton.Text = "Список маршрутов";
            this.routeButton.UseVisualStyleBackColor = true;
            this.routeButton.Click += new System.EventHandler(this.routeButton_Click);
            // 
            // stationButon
            // 
            this.stationButon.Location = new System.Drawing.Point(7, 22);
            this.stationButon.Name = "stationButon";
            this.stationButon.Size = new System.Drawing.Size(167, 31);
            this.stationButon.TabIndex = 0;
            this.stationButon.Text = "Список станций";
            this.stationButon.UseVisualStyleBackColor = true;
            this.stationButon.Click += new System.EventHandler(this.stationButon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WagonButton);
            this.groupBox2.Controls.Add(this.trainButton);
            this.groupBox2.Controls.Add(this.tiketButton);
            this.groupBox2.Controls.Add(this.personButton);
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кассы";
            // 
            // WagonButton
            // 
            this.WagonButton.Location = new System.Drawing.Point(9, 130);
            this.WagonButton.Name = "WagonButton";
            this.WagonButton.Size = new System.Drawing.Size(209, 34);
            this.WagonButton.TabIndex = 3;
            this.WagonButton.Text = "Данные о вагонах";
            this.WagonButton.UseVisualStyleBackColor = true;
            this.WagonButton.Click += new System.EventHandler(this.WagonButton_Click);
            // 
            // trainButton
            // 
            this.trainButton.Location = new System.Drawing.Point(7, 96);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(210, 31);
            this.trainButton.TabIndex = 2;
            this.trainButton.Text = "Данные о поездах ";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // tiketButton
            // 
            this.tiketButton.Location = new System.Drawing.Point(7, 59);
            this.tiketButton.Name = "tiketButton";
            this.tiketButton.Size = new System.Drawing.Size(209, 31);
            this.tiketButton.TabIndex = 1;
            this.tiketButton.Text = "Данные о билетах";
            this.tiketButton.UseVisualStyleBackColor = true;
            this.tiketButton.Click += new System.EventHandler(this.tiketButton_Click);
            // 
            // personButton
            // 
            this.personButton.Location = new System.Drawing.Point(7, 21);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(209, 32);
            this.personButton.TabIndex = 0;
            this.personButton.Text = "Данные о пассажирах";
            this.personButton.UseVisualStyleBackColor = true;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(341, 193);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 228);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tripButton;
        private System.Windows.Forms.Button timeTableButton;
        private System.Windows.Forms.Button routeButton;
        private System.Windows.Forms.Button stationButon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button WagonButton;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button tiketButton;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button exitButton;
    }
}