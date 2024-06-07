namespace FirstProject
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
            lbl00 = new Label();
            lbl01 = new Label();
            lbl02 = new Label();
            lbl10 = new Label();
            lbl11 = new Label();
            lbl12 = new Label();
            lbl20 = new Label();
            lbl21 = new Label();
            lbl22 = new Label();
            SuspendLayout();
            // 
            // lbl00
            // 
            lbl00.BackColor = Color.Maroon;
            lbl00.BorderStyle = BorderStyle.FixedSingle;
            lbl00.Location = new Point(185, 95);
            lbl00.Name = "lbl00";
            lbl00.Size = new Size(55, 55);
            lbl00.TabIndex = 0;
            lbl00.TextAlign = ContentAlignment.MiddleCenter;
            lbl00.Click += lbl00_Click;
            lbl00.MouseClick += lblclick;
            // 
            // lbl01
            // 
            lbl01.BackColor = Color.Maroon;
            lbl01.BorderStyle = BorderStyle.FixedSingle;
            lbl01.Location = new Point(246, 95);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(55, 55);
            lbl01.TabIndex = 0;
            lbl01.TextAlign = ContentAlignment.MiddleCenter;
            lbl01.MouseClick += lblclick;
            // 
            // lbl02
            // 
            lbl02.BackColor = Color.Maroon;
            lbl02.BorderStyle = BorderStyle.FixedSingle;
            lbl02.Location = new Point(307, 95);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(55, 55);
            lbl02.TabIndex = 0;
            lbl02.TextAlign = ContentAlignment.MiddleCenter;
            lbl02.MouseClick += lblclick;
            // 
            // lbl10
            // 
            lbl10.BackColor = Color.Maroon;
            lbl10.BorderStyle = BorderStyle.FixedSingle;
            lbl10.Location = new Point(185, 159);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(55, 55);
            lbl10.TabIndex = 0;
            lbl10.TextAlign = ContentAlignment.MiddleCenter;
            lbl10.MouseClick += lblclick;
            // 
            // lbl11
            // 
            lbl11.BackColor = Color.Maroon;
            lbl11.BorderStyle = BorderStyle.FixedSingle;
            lbl11.Location = new Point(246, 159);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(55, 55);
            lbl11.TabIndex = 0;
            lbl11.TextAlign = ContentAlignment.MiddleCenter;
            lbl11.MouseClick += lblclick;
            // 
            // lbl12
            // 
            lbl12.BackColor = Color.Maroon;
            lbl12.BorderStyle = BorderStyle.FixedSingle;
            lbl12.Location = new Point(307, 159);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(55, 55);
            lbl12.TabIndex = 0;
            lbl12.TextAlign = ContentAlignment.MiddleCenter;
            lbl12.MouseClick += lblclick;
            // 
            // lbl20
            // 
            lbl20.BackColor = Color.Maroon;
            lbl20.BorderStyle = BorderStyle.FixedSingle;
            lbl20.Location = new Point(185, 223);
            lbl20.Name = "lbl20";
            lbl20.Size = new Size(55, 55);
            lbl20.TabIndex = 0;
            lbl20.TextAlign = ContentAlignment.MiddleCenter;
            lbl20.MouseClick += lblclick;
            // 
            // lbl21
            // 
            lbl21.BackColor = Color.Maroon;
            lbl21.BorderStyle = BorderStyle.FixedSingle;
            lbl21.Location = new Point(246, 223);
            lbl21.Name = "lbl21";
            lbl21.Size = new Size(55, 55);
            lbl21.TabIndex = 0;
            lbl21.TextAlign = ContentAlignment.MiddleCenter;
            lbl21.MouseClick += lblclick;
            // 
            // lbl22
            // 
            lbl22.BackColor = Color.Maroon;
            lbl22.BorderStyle = BorderStyle.FixedSingle;
            lbl22.Location = new Point(307, 223);
            lbl22.Name = "lbl22";
            lbl22.Size = new Size(55, 55);
            lbl22.TabIndex = 0;
            lbl22.TextAlign = ContentAlignment.MiddleCenter;
            lbl22.MouseClick += lblclick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(555, 414);
            Controls.Add(lbl22);
            Controls.Add(lbl12);
            Controls.Add(lbl02);
            Controls.Add(lbl21);
            Controls.Add(lbl11);
            Controls.Add(lbl01);
            Controls.Add(lbl20);
            Controls.Add(lbl10);
            Controls.Add(lbl00);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "DoozGame";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl00;
        private Label lbl01;
        private Label lbl02;
        private Label lbl10;
        private Label lbl11;
        private Label lbl12;
        private Label lbl20;
        private Label lbl21;
        private Label lbl22;
    }
}
