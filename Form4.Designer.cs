namespace Captura
{
    partial class CapturaPoliza
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturaPoliza));
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            pegarToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            panel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPoliza).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            panel3.Location = new Point(48, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 39);
            panel3.TabIndex = 28;
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
            listView3.Location = new Point(828, 57);
            listView3.Name = "listView3";
            listView3.Size = new Size(162, 110);
            listView3.TabIndex = 27;
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
            listView2.Location = new Point(681, 57);
            listView2.Name = "listView2";
            listView2.Size = new Size(141, 110);
            listView2.TabIndex = 26;
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
            listView1.Location = new Point(524, 57);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 110);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Xml cargados";
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
            flowLayoutPanel2.Size = new Size(42, 456);
            flowLayoutPanel2.TabIndex = 22;
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
            button4.Click += button4_Click;
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
            buttonCuenta.TabIndex = 7;
            buttonCuenta.UseVisualStyleBackColor = true;
            buttonCuenta.Click += buttonCuenta_Click;
            // 
            // buttonSubcuenta
            // 
            buttonSubcuenta.Image = (Image)resources.GetObject("buttonSubcuenta.Image");
            buttonSubcuenta.Location = new Point(3, 243);
            buttonSubcuenta.Name = "buttonSubcuenta";
            buttonSubcuenta.Size = new Size(36, 42);
            buttonSubcuenta.TabIndex = 8;
            buttonSubcuenta.UseVisualStyleBackColor = true;
            buttonSubcuenta.Click += buttonSubcuenta_Click;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Info;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(380, 17);
            label10.Name = "label10";
            label10.Size = new Size(138, 29);
            label10.TabIndex = 23;
            label10.Text = "Poliza No.";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(48, 16);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(302, 29);
            dateTimePicker2.TabIndex = 24;
            // 
            // dataGridViewPoliza
            // 
            dataGridViewPoliza.BackgroundColor = SystemColors.Window;
            dataGridViewPoliza.BorderStyle = BorderStyle.None;
            dataGridViewPoliza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPoliza.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPoliza.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPoliza.GridColor = SystemColors.ControlLight;
            dataGridViewPoliza.Location = new Point(48, 218);
            dataGridViewPoliza.Name = "dataGridViewPoliza";
            dataGridViewPoliza.Size = new Size(942, 224);
            dataGridViewPoliza.TabIndex = 21;
            dataGridViewPoliza.CellEndEdit += dataGridViewPoliza_CellEndEdit_1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pegarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(146, 26);
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pegarToolStripMenuItem.Size = new Size(145, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.Menu;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 456);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(48, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 114);
            panel1.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(93, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 22);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(93, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 22);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(93, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 22);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 68);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 4;
            label4.Text = "Folio fiscal";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 40);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 3;
            label3.Text = "Concepto";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 2;
            label2.Text = "RFC";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // CapturaPoliza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1001, 456);
            Controls.Add(panel3);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label10);
            Controls.Add(dateTimePicker2);
            Controls.Add(dataGridViewPoliza);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "CapturaPoliza";
            Text = "Captura Poliza";
            Resize += CapturaPoliza_Resize;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPoliza).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridViewPoliza;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button buttonCuenta;
        private Button buttonSubcuenta;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pegarToolStripMenuItem;
    }
}