namespace Captura
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


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            Copiar = new ToolStripMenuItem();
            Pegar = new ToolStripMenuItem();
            button1 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            buttonMenu = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            openFileDialog1 = new OpenFileDialog();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Copiar, Pegar });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(68, 48);
            // 
            // Copiar
            // 
            Copiar.Name = "Copiar";
            Copiar.Size = new Size(67, 22);
            // 
            // Pegar
            // 
            Pegar.Name = "Pegar";
            Pegar.Size = new Size(67, 22);
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(3, 105);
            button1.Name = "button1";
            button1.Size = new Size(50, 45);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = SystemColors.Menu;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(buttonMenu);
            flowLayoutPanel3.Controls.Add(button4);
            flowLayoutPanel3.Controls.Add(button1);
            flowLayoutPanel3.Controls.Add(button2);
            flowLayoutPanel3.Controls.Add(button3);
            flowLayoutPanel3.Controls.Add(button5);
            flowLayoutPanel3.Controls.Add(button6);
            flowLayoutPanel3.Dock = DockStyle.Right;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(1071, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(55, 514);
            flowLayoutPanel3.TabIndex = 12;
            // 
            // buttonMenu
            // 
            buttonMenu.Image = (Image)resources.GetObject("buttonMenu.Image");
            buttonMenu.Location = new Point(3, 3);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(50, 45);
            buttonMenu.TabIndex = 6;
            buttonMenu.TextAlign = ContentAlignment.MiddleLeft;
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += button14_Click;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(3, 54);
            button4.Name = "button4";
            button4.Size = new Size(50, 45);
            button4.TabIndex = 9;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(3, 156);
            button2.Name = "button2";
            button2.Size = new Size(50, 45);
            button2.TabIndex = 7;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(3, 207);
            button3.Name = "button3";
            button3.Size = new Size(50, 45);
            button3.TabIndex = 8;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(3, 258);
            button5.Name = "button5";
            button5.Size = new Size(50, 45);
            button5.TabIndex = 10;
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(3, 309);
            button6.Name = "button6";
            button6.Size = new Size(50, 45);
            button6.TabIndex = 11;
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 514);
            Controls.Add(flowLayoutPanel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capptura libre";
            contextMenuStrip1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Copiar;
        private ToolStripMenuItem Pegar;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button buttonMenu;
        private Button button2;
        private Button button3;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private Button button5;
        private Button button6;
        private NotifyIcon notifyIcon1;
    }
}
