namespace Captura
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label1 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            listView3 = new ListView();
            columnHeader3 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            panel2 = new Panel();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonCuenta = new Button();
            buttonSubcuenta = new Button();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dataGridViewPoliza = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPoliza).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Menu;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox12);
            panel3.Controls.Add(textBox11);
            panel3.Controls.Add(textBox10);
            panel3.Location = new Point(59, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 39);
            panel3.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(458, 6);
            label13.Name = "label13";
            label13.Size = new Size(63, 21);
            label13.TabIndex = 5;
            label13.Text = "Balance";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(220, 9);
            label12.Name = "label12";
            label12.Size = new Size(52, 21);
            label12.TabIndex = 4;
            label12.Text = "Haber";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 3;
            label1.Text = "Debe";
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 12F);
            textBox12.Location = new Point(527, 3);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(159, 29);
            textBox12.TabIndex = 2;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 12F);
            textBox11.Location = new Point(293, 6);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(159, 29);
            textBox11.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 12F);
            textBox10.Location = new Point(55, 6);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(159, 29);
            textBox10.TabIndex = 0;
            // 
            // listView3
            // 
            listView3.BackColor = SystemColors.Window;
            listView3.BorderStyle = BorderStyle.None;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            listView3.Location = new Point(853, 48);
            listView3.Name = "listView3";
            listView3.Size = new Size(148, 119);
            listView3.TabIndex = 38;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Folios Fiscales";
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.Window;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listView2.Location = new Point(685, 48);
            listView2.Name = "listView2";
            listView2.Size = new Size(162, 119);
            listView2.TabIndex = 37;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PDF cargados";
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.BackColor = SystemColors.Window;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(531, 48);
            listView1.Name = "listView1";
            listView1.Size = new Size(148, 119);
            listView1.TabIndex = 36;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Xml cargados";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(59, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 159);
            panel2.TabIndex = 30;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI", 12F);
            textBox9.Location = new Point(107, 124);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(346, 22);
            textBox9.TabIndex = 15;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(248, 97);
            label11.Name = "label11";
            label11.Size = new Size(73, 22);
            label11.TabIndex = 14;
            label11.Text = "Número";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI", 12F);
            textBox8.Location = new Point(107, 68);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(346, 22);
            textBox8.TabIndex = 11;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(7, 68);
            label9.Name = "label9";
            label9.Size = new Size(81, 22);
            label9.TabIndex = 10;
            label9.Text = "RFC";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F);
            textBox7.Location = new Point(107, 96);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(126, 22);
            textBox7.TabIndex = 9;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(7, 96);
            label8.Name = "label8";
            label8.Size = new Size(64, 22);
            label8.TabIndex = 8;
            label8.Text = "Monto";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(327, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 22);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(107, 40);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(346, 22);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(107, 12);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(346, 22);
            textBox6.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(7, 124);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 4;
            label5.Text = "Folio fiscal";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(7, 40);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 3;
            label6.Text = "Concepto";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(7, 9);
            label7.Name = "label7";
            label7.Size = new Size(94, 22);
            label7.TabIndex = 2;
            label7.Text = "Beneficiario";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = SystemColors.Menu;
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(buttonCuenta);
            flowLayoutPanel2.Controls.Add(buttonSubcuenta);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(42, 450);
            flowLayoutPanel2.TabIndex = 33;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(36, 42);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(3, 51);
            button3.Name = "button3";
            button3.Size = new Size(36, 42);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(3, 99);
            button4.Name = "button4";
            button4.Size = new Size(36, 42);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(3, 147);
            button5.Name = "button5";
            button5.Size = new Size(36, 42);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // buttonCuenta
            // 
            buttonCuenta.Image = (Image)resources.GetObject("buttonCuenta.Image");
            buttonCuenta.Location = new Point(3, 195);
            buttonCuenta.Name = "buttonCuenta";
            buttonCuenta.Size = new Size(36, 42);
            buttonCuenta.TabIndex = 9;
            buttonCuenta.UseVisualStyleBackColor = true;
            buttonCuenta.Click += buttonCuenta_Click_1;
            // 
            // buttonSubcuenta
            // 
            buttonSubcuenta.Image = (Image)resources.GetObject("buttonSubcuenta.Image");
            buttonSubcuenta.Location = new Point(3, 243);
            buttonSubcuenta.Name = "buttonSubcuenta";
            buttonSubcuenta.Size = new Size(36, 42);
            buttonSubcuenta.TabIndex = 10;
            buttonSubcuenta.UseVisualStyleBackColor = true;
            buttonSubcuenta.Click += buttonSubcuenta_Click_1;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Info;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(863, 8);
            label10.Name = "label10";
            label10.Size = new Size(138, 29);
            label10.TabIndex = 34;
            label10.Text = "Cheque No.";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(531, 8);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(302, 29);
            dateTimePicker2.TabIndex = 35;
            // 
            // dataGridViewPoliza
            // 
            dataGridViewPoliza.BackgroundColor = SystemColors.Window;
            dataGridViewPoliza.BorderStyle = BorderStyle.None;
            dataGridViewPoliza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPoliza.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPoliza.GridColor = SystemColors.ControlLight;
            dataGridViewPoliza.Location = new Point(59, 218);
            dataGridViewPoliza.Name = "dataGridViewPoliza";
            dataGridViewPoliza.Size = new Size(942, 224);
            dataGridViewPoliza.TabIndex = 32;
            dataGridViewPoliza.CellEndEdit += dataGridViewPoliza_CellEndEdit_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.Menu;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 450);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1013, 450);
            Controls.Add(panel3);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(dataGridViewPoliza);
            Controls.Add(flowLayoutPanel1);
            Name = "Form5";
            Text = "Capturar Cheque";
            Resize += Form5_Resize;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPoliza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Label label13;
        private Label label12;
        private Label label1;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private ListView listView3;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private ColumnHeader columnHeader2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Panel panel2;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridViewPoliza;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCuenta;
        private Button buttonSubcuenta;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}