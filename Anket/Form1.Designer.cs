namespace Anket
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
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            save_bt = new Button();
            birthday = new Label();
            city_text = new TextBox();
            phone_text = new TextBox();
            country_text = new TextBox();
            father_text = new TextBox();
            name_text = new TextBox();
            surname_textbox = new TextBox();
            label1 = new Label();
            date_time = new DateTimePicker();
            telephone = new Label();
            city = new Label();
            country = new Label();
            father_name = new Label();
            name = new Label();
            surname = new Label();
            search = new TextBox();
            search_name = new Label();
            load_bt = new Button();
            message = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(save_bt);
            groupBox1.Controls.Add(birthday);
            groupBox1.Controls.Add(city_text);
            groupBox1.Controls.Add(phone_text);
            groupBox1.Controls.Add(country_text);
            groupBox1.Controls.Add(father_text);
            groupBox1.Controls.Add(name_text);
            groupBox1.Controls.Add(surname_textbox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(date_time);
            groupBox1.Controls.Add(telephone);
            groupBox1.Controls.Add(city);
            groupBox1.Controls.Add(country);
            groupBox1.Controls.Add(father_name);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(surname);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 431);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(127, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 30);
            panel1.TabIndex = 18;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(72, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // save_bt
            // 
            save_bt.Location = new Point(60, 398);
            save_bt.Name = "save_bt";
            save_bt.Size = new Size(310, 29);
            save_bt.TabIndex = 17;
            save_bt.Text = "Save";
            save_bt.UseVisualStyleBackColor = true;
            save_bt.Click += save_bt_Click;
            // 
            // birthday
            // 
            birthday.AutoSize = true;
            birthday.Location = new Point(28, 280);
            birthday.Name = "birthday";
            birthday.Size = new Size(64, 20);
            birthday.TabIndex = 16;
            birthday.Text = "Birthday";
            // 
            // city_text
            // 
            city_text.Location = new Point(120, 182);
            city_text.Name = "city_text";
            city_text.Size = new Size(168, 27);
            city_text.TabIndex = 15;
            // 
            // phone_text
            // 
            phone_text.Location = new Point(120, 215);
            phone_text.Name = "phone_text";
            phone_text.Size = new Size(168, 27);
            phone_text.TabIndex = 14;
            // 
            // country_text
            // 
            country_text.Location = new Point(120, 149);
            country_text.Name = "country_text";
            country_text.Size = new Size(168, 27);
            country_text.TabIndex = 13;
            // 
            // father_text
            // 
            father_text.Location = new Point(120, 82);
            father_text.Name = "father_text";
            father_text.Size = new Size(168, 27);
            father_text.TabIndex = 12;
            // 
            // name_text
            // 
            name_text.Location = new Point(120, 49);
            name_text.Name = "name_text";
            name_text.Size = new Size(168, 27);
            name_text.TabIndex = 11;
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(120, 16);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(168, 27);
            surname_textbox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 328);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "Gender";
            // 
            // date_time
            // 
            date_time.Format = DateTimePickerFormat.Custom;
            date_time.Location = new Point(127, 275);
            date_time.Name = "date_time";
            date_time.Size = new Size(250, 27);
            date_time.TabIndex = 6;
            // 
            // telephone
            // 
            telephone.AutoSize = true;
            telephone.Location = new Point(21, 222);
            telephone.Name = "telephone";
            telephone.Size = new Size(78, 20);
            telephone.TabIndex = 5;
            telephone.Text = "Telephone";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(21, 189);
            city.Name = "city";
            city.Size = new Size(34, 20);
            city.TabIndex = 4;
            city.Text = "City";
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new Point(21, 156);
            country.Name = "country";
            country.Size = new Size(60, 20);
            country.TabIndex = 3;
            country.Text = "Country";
            // 
            // father_name
            // 
            father_name.AutoSize = true;
            father_name.Location = new Point(21, 85);
            father_name.Name = "father_name";
            father_name.Size = new Size(93, 20);
            father_name.TabIndex = 2;
            father_name.Text = "Father Name";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(21, 52);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 1;
            name.Text = "Name";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(21, 19);
            surname.Name = "surname";
            surname.Size = new Size(67, 20);
            surname.TabIndex = 0;
            surname.Text = "Surname";
            // 
            // search
            // 
            search.Location = new Point(95, 4);
            search.Name = "search";
            search.Size = new Size(243, 27);
            search.TabIndex = 1;
            // 
            // search_name
            // 
            search_name.AutoSize = true;
            search_name.Location = new Point(40, 7);
            search_name.Name = "search_name";
            search_name.Size = new Size(53, 20);
            search_name.TabIndex = 2;
            search_name.Text = "Search";
            // 
            // load_bt
            // 
            load_bt.Location = new Point(333, 3);
            load_bt.Name = "load_bt";
            load_bt.Size = new Size(94, 29);
            load_bt.TabIndex = 3;
            load_bt.Text = "Load";
            load_bt.UseVisualStyleBackColor = true;
            load_bt.Click += load_bt_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.ForeColor = Color.Red;
            message.Location = new Point(95, 35);
            message.Name = "message";
            message.Size = new Size(0, 20);
            message.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 501);
            Controls.Add(message);
            Controls.Add(load_bt);
            Controls.Add(search_name);
            Controls.Add(search);
            Controls.Add(groupBox1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label telephone;
        private Label city;
        private Label country;
        private Label father_name;
        private Label name;
        private Label surname;
        private Label label1;
        private DateTimePicker date_time;
        private TextBox name_text;
        private TextBox surname_textbox;
        private Label birthday;
        private TextBox city_text;
        private TextBox phone_text;
        private TextBox country_text;
        private TextBox father_text;
        private Button save_bt;
        private TextBox search;
        private Label search_name;
        private Button load_bt;
        private Panel panel1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label message;
    }
}