namespace GeometricFigures_3
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.lblStartPoint = new System.Windows.Forms.Label();
            this.lblStartPointX = new System.Windows.Forms.Label();
            this.lblStartPointY = new System.Windows.Forms.Label();
            this.txtBoxStartPointX = new System.Windows.Forms.TextBox();
            this.txtBoxStartPointY = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartPoint
            // 
            this.lblStartPoint.AutoSize = true;
            this.lblStartPoint.Location = new System.Drawing.Point(38, 9);
            this.lblStartPoint.Name = "lblStartPoint";
            this.lblStartPoint.Size = new System.Drawing.Size(101, 15);
            this.lblStartPoint.TabIndex = 1;
            this.lblStartPoint.Text = "Начальная точка";
            // 
            // lblStartPointX
            // 
            this.lblStartPointX.AutoSize = true;
            this.lblStartPointX.Location = new System.Drawing.Point(23, 37);
            this.lblStartPointX.Name = "lblStartPointX";
            this.lblStartPointX.Size = new System.Drawing.Size(14, 15);
            this.lblStartPointX.TabIndex = 2;
            this.lblStartPointX.Text = "X";
            // 
            // lblStartPointY
            // 
            this.lblStartPointY.AutoSize = true;
            this.lblStartPointY.Location = new System.Drawing.Point(89, 37);
            this.lblStartPointY.Name = "lblStartPointY";
            this.lblStartPointY.Size = new System.Drawing.Size(14, 15);
            this.lblStartPointY.TabIndex = 2;
            this.lblStartPointY.Text = "Y";
            // 
            // txtBoxStartPointX
            // 
            this.txtBoxStartPointX.Location = new System.Drawing.Point(43, 34);
            this.txtBoxStartPointX.Name = "txtBoxStartPointX";
            this.txtBoxStartPointX.Size = new System.Drawing.Size(38, 23);
            this.txtBoxStartPointX.TabIndex = 3;
            // 
            // txtBoxStartPointY
            // 
            this.txtBoxStartPointY.Location = new System.Drawing.Point(110, 34);
            this.txtBoxStartPointY.Name = "txtBoxStartPointY";
            this.txtBoxStartPointY.Size = new System.Drawing.Size(38, 23);
            this.txtBoxStartPointY.TabIndex = 3;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(107, 201);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "ОК";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 236);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtBoxStartPointY);
            this.Controls.Add(this.txtBoxStartPointX);
            this.Controls.Add(this.lblStartPointY);
            this.Controls.Add(this.lblStartPointX);
            this.Controls.Add(this.lblStartPoint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню фигуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartPoint;
        private System.Windows.Forms.Label lblStartPointX;
        private System.Windows.Forms.Label lblStartPointY;
        private System.Windows.Forms.TextBox txtBoxStartPointX;
        private System.Windows.Forms.TextBox txtBoxStartPointY;
        private System.Windows.Forms.Button btnDraw;
        public System.Drawing.Point btnDrawLocation
        {
            get { return btnDraw.Location; }
            set { btnDraw.Location = value; }
        }
    }
}