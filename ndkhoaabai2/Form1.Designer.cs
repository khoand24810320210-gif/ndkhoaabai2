namespace ndkhoaabai2
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
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(255, 56);
            mtxtPhone.Mask = "000-00-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(125, 27);
            mtxtPhone.TabIndex = 0;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(252, 110);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 1;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(252, 163);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(151, 28);
            cboCourse.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(203, 219);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Đăng nhập";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 63);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 4;
            label1.Text = "số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 117);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 171);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "khóa học";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
