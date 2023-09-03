namespace ShutDownPc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            hour = new TextBox();
            Minute = new TextBox();
            button1 = new Button();
            timer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 0;
            label1.Text = "Windows Shutdown App";
            label1.Click += label1_Click;
            // 
            // hour
            // 
            hour.BorderStyle = BorderStyle.None;
            hour.Location = new Point(12, 105);
            hour.Name = "hour";
            hour.Size = new Size(100, 16);
            hour.TabIndex = 1;
            hour.Text = "Hour";
            hour.TextChanged += textBox1_TextChanged_1;
            // 
            // Minute
            // 
            Minute.BorderStyle = BorderStyle.None;
            Minute.Location = new Point(12, 152);
            Minute.Name = "Minute";
            Minute.Size = new Size(100, 16);
            Minute.TabIndex = 2;
            Minute.Text = "Minute";
            Minute.TextChanged += Form1_Load;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(122, 105);
            button1.Name = "button1";
            button1.Size = new Size(125, 63);
            button1.TabIndex = 3;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer
            // 
            timer.AutoSize = true;
            timer.Font = new Font("Segoe UI", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            timer.Location = new Point(63, 208);
            timer.Name = "timer";
            timer.Size = new Size(122, 62);
            timer.TabIndex = 4;
            timer.Text = "0:0:0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 310);
            Controls.Add(timer);
            Controls.Add(button1);
            Controls.Add(Minute);
            Controls.Add(hour);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox hour;
        private TextBox Minute;
        private Button button1;
        private Label timer;
        private System.Windows.Forms.Timer timer1;
    }
}