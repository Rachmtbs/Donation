namespace shapes1
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
            this.btnShape = new System.Windows.Forms.Button();
            this.lblTypeOfShape = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ShapeWeight = new System.Windows.Forms.GroupBox();
            this.Square = new System.Windows.Forms.CheckBox();
            this.Rectangle = new System.Windows.Forms.CheckBox();
            this.RightTriangle = new System.Windows.Forms.CheckBox();
            this.Quadrilateral = new System.Windows.Forms.CheckBox();
            this.Triangle = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ShapeWeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShape
            // 
            this.btnShape.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShape.Location = new System.Drawing.Point(12, 56);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(116, 55);
            this.btnShape.TabIndex = 0;
            this.btnShape.Text = "Weight";
            this.btnShape.UseVisualStyleBackColor = false;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // lblTypeOfShape
            // 
            this.lblTypeOfShape.AutoSize = true;
            this.lblTypeOfShape.Location = new System.Drawing.Point(346, 56);
            this.lblTypeOfShape.Name = "lblTypeOfShape";
            this.lblTypeOfShape.Size = new System.Drawing.Size(99, 16);
            this.lblTypeOfShape.TabIndex = 1;
            this.lblTypeOfShape.Text = "Type of Shape:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(345, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // ShapeWeight
            // 
            this.ShapeWeight.BackColor = System.Drawing.Color.Linen;
            this.ShapeWeight.Controls.Add(this.Square);
            this.ShapeWeight.Controls.Add(this.Rectangle);
            this.ShapeWeight.Controls.Add(this.RightTriangle);
            this.ShapeWeight.Controls.Add(this.Quadrilateral);
            this.ShapeWeight.Controls.Add(this.Triangle);
            this.ShapeWeight.Location = new System.Drawing.Point(12, 149);
            this.ShapeWeight.Name = "ShapeWeight";
            this.ShapeWeight.Size = new System.Drawing.Size(718, 114);
            this.ShapeWeight.TabIndex = 4;
            this.ShapeWeight.TabStop = false;
            this.ShapeWeight.Text = "Shape";
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(337, 33);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(73, 20);
            this.Square.TabIndex = 10;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(144, 68);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(91, 20);
            this.Rectangle.TabIndex = 9;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // RightTriangle
            // 
            this.RightTriangle.AutoSize = true;
            this.RightTriangle.Location = new System.Drawing.Point(144, 33);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(113, 20);
            this.RightTriangle.TabIndex = 8;
            this.RightTriangle.Text = "Right Triangle";
            this.RightTriangle.UseVisualStyleBackColor = true;
            this.RightTriangle.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Quadrilateral
            // 
            this.Quadrilateral.AutoSize = true;
            this.Quadrilateral.Location = new System.Drawing.Point(6, 68);
            this.Quadrilateral.Name = "Quadrilateral";
            this.Quadrilateral.Size = new System.Drawing.Size(106, 20);
            this.Quadrilateral.TabIndex = 7;
            this.Quadrilateral.Text = "Quadrilateral";
            this.Quadrilateral.UseVisualStyleBackColor = true;
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(6, 33);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(79, 20);
            this.Triangle.TabIndex = 6;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(31, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 52);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShapeWeight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTypeOfShape);
            this.Controls.Add(this.btnShape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShapeWeight.ResumeLayout(false);
            this.ShapeWeight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.Label lblTypeOfShape;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox ShapeWeight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox Square;
        private System.Windows.Forms.CheckBox Rectangle;
        private System.Windows.Forms.CheckBox RightTriangle;
        private System.Windows.Forms.CheckBox Quadrilateral;
        private System.Windows.Forms.CheckBox Triangle;
    }
}

