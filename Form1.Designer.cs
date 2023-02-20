namespace Perspectiva_3D
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonEjeX = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonEjeY = new System.Windows.Forms.Button();
            this.ButtonEjeZ = new System.Windows.Forms.Button();
            this.ButtonTodos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.Location = new System.Drawing.Point(11, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonEjeX
            // 
            this.ButtonEjeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonEjeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEjeX.FlatAppearance.BorderSize = 0;
            this.ButtonEjeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEjeX.Font = new System.Drawing.Font("Euclid Circular A", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEjeX.ForeColor = System.Drawing.Color.White;
            this.ButtonEjeX.Location = new System.Drawing.Point(21, 99);
            this.ButtonEjeX.Name = "ButtonEjeX";
            this.ButtonEjeX.Size = new System.Drawing.Size(186, 48);
            this.ButtonEjeX.TabIndex = 1;
            this.ButtonEjeX.Text = "Girar en eje X";
            this.ButtonEjeX.UseVisualStyleBackColor = false;
            this.ButtonEjeX.Click += new System.EventHandler(this.ButtonEjeX_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ButtonEjeY
            // 
            this.ButtonEjeY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonEjeY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEjeY.FlatAppearance.BorderSize = 0;
            this.ButtonEjeY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEjeY.Font = new System.Drawing.Font("Euclid Circular A", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEjeY.ForeColor = System.Drawing.Color.White;
            this.ButtonEjeY.Location = new System.Drawing.Point(306, 99);
            this.ButtonEjeY.Name = "ButtonEjeY";
            this.ButtonEjeY.Size = new System.Drawing.Size(186, 48);
            this.ButtonEjeY.TabIndex = 2;
            this.ButtonEjeY.Text = "Girar en eje Y";
            this.ButtonEjeY.UseVisualStyleBackColor = false;
            this.ButtonEjeY.Click += new System.EventHandler(this.ButtonEjeY_Click);
            // 
            // ButtonEjeZ
            // 
            this.ButtonEjeZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonEjeZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEjeZ.FlatAppearance.BorderSize = 0;
            this.ButtonEjeZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEjeZ.Font = new System.Drawing.Font("Euclid Circular A", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEjeZ.ForeColor = System.Drawing.Color.White;
            this.ButtonEjeZ.Location = new System.Drawing.Point(589, 99);
            this.ButtonEjeZ.Name = "ButtonEjeZ";
            this.ButtonEjeZ.Size = new System.Drawing.Size(186, 48);
            this.ButtonEjeZ.TabIndex = 3;
            this.ButtonEjeZ.Text = "Girar en eje Z";
            this.ButtonEjeZ.UseVisualStyleBackColor = false;
            this.ButtonEjeZ.Click += new System.EventHandler(this.ButtonEjeZ_Click);
            // 
            // ButtonTodos
            // 
            this.ButtonTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTodos.FlatAppearance.BorderSize = 0;
            this.ButtonTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTodos.Font = new System.Drawing.Font("Euclid Circular A", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonTodos.ForeColor = System.Drawing.Color.White;
            this.ButtonTodos.Location = new System.Drawing.Point(267, 165);
            this.ButtonTodos.Name = "ButtonTodos";
            this.ButtonTodos.Size = new System.Drawing.Size(265, 48);
            this.ButtonTodos.TabIndex = 4;
            this.ButtonTodos.Text = "Girar en todos los ejes";
            this.ButtonTodos.UseVisualStyleBackColor = false;
            this.ButtonTodos.Click += new System.EventHandler(this.ButtonTodos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonEjeX);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.ButtonEjeY);
            this.panel1.Controls.Add(this.ButtonEjeZ);
            this.panel1.Controls.Add(this.ButtonTodos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 228);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Euclid Circular A", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cambiar tamaño del cuadrado";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(11, 35);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(776, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Euclid Circular A SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(320, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Perspectiva 3D";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 481);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(799, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perspectiva 3D";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button ButtonEjeX;
        private System.Windows.Forms.Timer Timer;
        private Button ButtonEjeY;
        private Button ButtonEjeZ;
        private Button ButtonTodos;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TrackBar trackBar1;
        private Panel panel2;
    }
}