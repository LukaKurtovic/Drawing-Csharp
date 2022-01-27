namespace LV2
{
    partial class Form1
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
            this.gbShape = new System.Windows.Forms.GroupBox();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.gbShape.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbShape
            // 
            this.gbShape.Controls.Add(this.rbElipse);
            this.gbShape.Controls.Add(this.rbSquare);
            this.gbShape.Controls.Add(this.rbCircle);
            this.gbShape.Controls.Add(this.rbLine);
            this.gbShape.Location = new System.Drawing.Point(715, 12);
            this.gbShape.Name = "gbShape";
            this.gbShape.Size = new System.Drawing.Size(84, 118);
            this.gbShape.TabIndex = 0;
            this.gbShape.TabStop = false;
            this.gbShape.Text = "Shape";
            this.gbShape.Enter += new System.EventHandler(this.gbShape_Enter);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(0, 65);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(59, 17);
            this.rbSquare.TabIndex = 2;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(0, 42);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(0, 19);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Location = new System.Drawing.Point(715, 192);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(85, 100);
            this.gbColor.TabIndex = 1;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Checked = true;
            this.rbBlack.Location = new System.Drawing.Point(0, 19);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(52, 17);
            this.rbBlack.TabIndex = 3;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(0, 42);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 4;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbBlue.Location = new System.Drawing.Point(0, 65);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 5;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.Location = new System.Drawing.Point(0, 89);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(53, 17);
            this.rbElipse.TabIndex = 3;
            this.rbElipse.TabStop = true;
            this.rbElipse.Text = "Elipse";
            this.rbElipse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbShape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gbShape.ResumeLayout(false);
            this.gbShape.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbShape;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbElipse;
    }
}

