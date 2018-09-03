namespace WindowsFormsDatabase
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.born = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.debug_Text = new System.Windows.Forms.TextBox();
            this.debug_Button = new System.Windows.Forms.Button();
            this.debug_panel = new System.Windows.Forms.Panel();
            this.debug_label = new System.Windows.Forms.Label();
            this.debug_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.debug_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.born,
            this.sex});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(492, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // born
            // 
            this.born.HeaderText = "born";
            this.born.Name = "born";
            this.born.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "sex";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(173, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(382, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 92);
            this.button2.TabIndex = 2;
            this.button2.Text = "del by ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(13, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(465, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Clean Database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Сергей";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(13, 413);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "2000";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.comboBox1.Location = new System.Drawing.Point(13, 445);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "man";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(268, 404);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(108, 38);
            this.numericUpDown1.TabIndex = 8;
            // 
            // debug_Text
            // 
            this.debug_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debug_Text.Location = new System.Drawing.Point(104, 168);
            this.debug_Text.Name = "debug_Text";
            this.debug_Text.PasswordChar = 'Θ';
            this.debug_Text.Size = new System.Drawing.Size(282, 38);
            this.debug_Text.TabIndex = 10;
            // 
            // debug_Button
            // 
            this.debug_Button.Font = new System.Drawing.Font("Adobe Fangsong Std R", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debug_Button.ForeColor = System.Drawing.Color.ForestGreen;
            this.debug_Button.Location = new System.Drawing.Point(92, 247);
            this.debug_Button.Name = "debug_Button";
            this.debug_Button.Size = new System.Drawing.Size(312, 113);
            this.debug_Button.TabIndex = 11;
            this.debug_Button.Text = "Show DataBase ";
            this.debug_Button.UseVisualStyleBackColor = true;
            this.debug_Button.Click += new System.EventHandler(this.debug_Button_Click);
            // 
            // debug_panel
            // 
            this.debug_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.debug_panel.Controls.Add(this.debug_label1);
            this.debug_panel.Controls.Add(this.debug_label);
            this.debug_panel.Controls.Add(this.debug_Button);
            this.debug_panel.Controls.Add(this.debug_Text);
            this.debug_panel.ForeColor = System.Drawing.Color.FloralWhite;
            this.debug_panel.Location = new System.Drawing.Point(-2, 1);
            this.debug_panel.Name = "debug_panel";
            this.debug_panel.Size = new System.Drawing.Size(492, 539);
            this.debug_panel.TabIndex = 12;
            // 
            // debug_label
            // 
            this.debug_label.AutoSize = true;
            this.debug_label.Font = new System.Drawing.Font("Tiger Expert", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debug_label.ForeColor = System.Drawing.Color.Black;
            this.debug_label.Location = new System.Drawing.Point(11, 57);
            this.debug_label.Name = "debug_label";
            this.debug_label.Size = new System.Drawing.Size(471, 67);
            this.debug_label.TabIndex = 13;
            this.debug_label.Text = "Access denied";
            this.debug_label.Visible = false;
            // 
            // debug_label1
            // 
            this.debug_label1.AutoSize = true;
            this.debug_label1.Font = new System.Drawing.Font("Tiger Expert", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debug_label1.ForeColor = System.Drawing.Color.Black;
            this.debug_label1.Location = new System.Drawing.Point(11, 417);
            this.debug_label1.Name = "debug_label1";
            this.debug_label1.Size = new System.Drawing.Size(471, 67);
            this.debug_label1.TabIndex = 14;
            this.debug_label1.Text = "Access denied";
            this.debug_label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 537);
            this.Controls.Add(this.debug_panel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working with DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.debug_panel.ResumeLayout(false);
            this.debug_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn born;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.TextBox debug_Text;
        private System.Windows.Forms.Button debug_Button;
        private System.Windows.Forms.Panel debug_panel;
        private System.Windows.Forms.Label debug_label1;
        private System.Windows.Forms.Label debug_label;
    }
}

