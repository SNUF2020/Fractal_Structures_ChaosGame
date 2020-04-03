namespace Fractal_Structures
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Description = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.radioButton_Sirpinski_3rand = new System.Windows.Forms.RadioButton();
            this.groupBox_Fractal = new System.Windows.Forms.GroupBox();
            this.radioButton_noRes_23 = new System.Windows.Forms.RadioButton();
            this.radioButton_CenterPoint_23 = new System.Windows.Forms.RadioButton();
            this.radioButton_CenterPoint_13 = new System.Windows.Forms.RadioButton();
            this.radioButton_SquareRest1 = new System.Windows.Forms.RadioButton();
            this.radioButton_SquarNoice = new System.Windows.Forms.RadioButton();
            this.radioButton_non = new System.Windows.Forms.RadioButton();
            this.radioButton_Last = new System.Windows.Forms.RadioButton();
            this.radioButton_secLast = new System.Windows.Forms.RadioButton();
            this.groupBox_Color = new System.Windows.Forms.GroupBox();
            this.radioButton_3rdLast = new System.Windows.Forms.RadioButton();
            this.radioButton_SquareRest2 = new System.Windows.Forms.RadioButton();
            this.radioButton_SquareRest3 = new System.Windows.Forms.RadioButton();
            this.groupBox_Fractal.SuspendLayout();
            this.groupBox_Color.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(60, 20);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(555, 29);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "Fractal Structures by Random Jump (Chaos Game)";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(50, 77);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(140, 70);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(50, 195);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(140, 70);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // radioButton_Sirpinski_3rand
            // 
            this.radioButton_Sirpinski_3rand.AutoSize = true;
            this.radioButton_Sirpinski_3rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Sirpinski_3rand.Location = new System.Drawing.Point(20, 132);
            this.radioButton_Sirpinski_3rand.Name = "radioButton_Sirpinski_3rand";
            this.radioButton_Sirpinski_3rand.Size = new System.Drawing.Size(427, 28);
            this.radioButton_Sirpinski_3rand.TabIndex = 3;
            this.radioButton_Sirpinski_3rand.Text = "Restriction: w/o one corner (Jump-Length = 1/2)";
            this.radioButton_Sirpinski_3rand.UseVisualStyleBackColor = true;
            // 
            // groupBox_Fractal
            // 
            this.groupBox_Fractal.Controls.Add(this.radioButton_SquareRest3);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SquareRest2);
            this.groupBox_Fractal.Controls.Add(this.radioButton_noRes_23);
            this.groupBox_Fractal.Controls.Add(this.radioButton_CenterPoint_23);
            this.groupBox_Fractal.Controls.Add(this.radioButton_CenterPoint_13);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SquareRest1);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SquarNoice);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Sirpinski_3rand);
            this.groupBox_Fractal.Location = new System.Drawing.Point(535, 77);
            this.groupBox_Fractal.Name = "groupBox_Fractal";
            this.groupBox_Fractal.Size = new System.Drawing.Size(576, 477);
            this.groupBox_Fractal.TabIndex = 4;
            this.groupBox_Fractal.TabStop = false;
            this.groupBox_Fractal.Text = "Options";
            // 
            // radioButton_noRes_23
            // 
            this.radioButton_noRes_23.AutoSize = true;
            this.radioButton_noRes_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_noRes_23.Location = new System.Drawing.Point(20, 82);
            this.radioButton_noRes_23.Name = "radioButton_noRes_23";
            this.radioButton_noRes_23.Size = new System.Drawing.Size(324, 28);
            this.radioButton_noRes_23.TabIndex = 8;
            this.radioButton_noRes_23.Text = "w/o Restriction (Jump-Length = 2/3)";
            this.radioButton_noRes_23.UseVisualStyleBackColor = true;
            // 
            // radioButton_CenterPoint_23
            // 
            this.radioButton_CenterPoint_23.AutoSize = true;
            this.radioButton_CenterPoint_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CenterPoint_23.Location = new System.Drawing.Point(20, 412);
            this.radioButton_CenterPoint_23.Name = "radioButton_CenterPoint_23";
            this.radioButton_CenterPoint_23.Size = new System.Drawing.Size(490, 28);
            this.radioButton_CenterPoint_23.TabIndex = 7;
            this.radioButton_CenterPoint_23.Text = "w/o Restriction: With Middle-Points (Jump-Length = 2/3)";
            this.radioButton_CenterPoint_23.UseVisualStyleBackColor = true;
            // 
            // radioButton_CenterPoint_13
            // 
            this.radioButton_CenterPoint_13.AutoSize = true;
            this.radioButton_CenterPoint_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CenterPoint_13.Location = new System.Drawing.Point(20, 353);
            this.radioButton_CenterPoint_13.Name = "radioButton_CenterPoint_13";
            this.radioButton_CenterPoint_13.Size = new System.Drawing.Size(474, 28);
            this.radioButton_CenterPoint_13.TabIndex = 6;
            this.radioButton_CenterPoint_13.Text = "w/o Restriction: With CenterPoint (Jump-Length = 2/3)";
            this.radioButton_CenterPoint_13.UseVisualStyleBackColor = true;
            // 
            // radioButton_SquareRest1
            // 
            this.radioButton_SquareRest1.AutoSize = true;
            this.radioButton_SquareRest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SquareRest1.Location = new System.Drawing.Point(20, 189);
            this.radioButton_SquareRest1.Name = "radioButton_SquareRest1";
            this.radioButton_SquareRest1.Size = new System.Drawing.Size(505, 28);
            this.radioButton_SquareRest1.TabIndex = 5;
            this.radioButton_SquareRest1.Text = "Restriction: last corner is not allowed (Jump-Length = 1/2)";
            this.radioButton_SquareRest1.UseVisualStyleBackColor = true;
            // 
            // radioButton_SquarNoice
            // 
            this.radioButton_SquarNoice.AutoSize = true;
            this.radioButton_SquarNoice.Checked = true;
            this.radioButton_SquarNoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SquarNoice.Location = new System.Drawing.Point(20, 33);
            this.radioButton_SquarNoice.Name = "radioButton_SquarNoice";
            this.radioButton_SquarNoice.Size = new System.Drawing.Size(324, 28);
            this.radioButton_SquarNoice.TabIndex = 4;
            this.radioButton_SquarNoice.TabStop = true;
            this.radioButton_SquarNoice.Text = "w/o Restriction (Jump-Length = 1/2)";
            this.radioButton_SquarNoice.UseVisualStyleBackColor = true;
            // 
            // radioButton_non
            // 
            this.radioButton_non.AutoSize = true;
            this.radioButton_non.Checked = true;
            this.radioButton_non.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_non.Location = new System.Drawing.Point(11, 28);
            this.radioButton_non.Name = "radioButton_non";
            this.radioButton_non.Size = new System.Drawing.Size(108, 28);
            this.radioButton_non.TabIndex = 5;
            this.radioButton_non.TabStop = true;
            this.radioButton_non.Text = "w/o Color";
            this.radioButton_non.UseVisualStyleBackColor = true;
            // 
            // radioButton_Last
            // 
            this.radioButton_Last.AutoSize = true;
            this.radioButton_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Last.Location = new System.Drawing.Point(11, 83);
            this.radioButton_Last.Name = "radioButton_Last";
            this.radioButton_Last.Size = new System.Drawing.Size(188, 28);
            this.radioButton_Last.TabIndex = 6;
            this.radioButton_Last.Text = "w/ Color (last jump)";
            this.radioButton_Last.UseVisualStyleBackColor = true;
            // 
            // radioButton_secLast
            // 
            this.radioButton_secLast.AutoSize = true;
            this.radioButton_secLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_secLast.Location = new System.Drawing.Point(11, 140);
            this.radioButton_secLast.Name = "radioButton_secLast";
            this.radioButton_secLast.Size = new System.Drawing.Size(225, 28);
            this.radioButton_secLast.TabIndex = 7;
            this.radioButton_secLast.Text = "w/ Color (2nd last jump)";
            this.radioButton_secLast.UseVisualStyleBackColor = true;
            // 
            // groupBox_Color
            // 
            this.groupBox_Color.Controls.Add(this.radioButton_3rdLast);
            this.groupBox_Color.Controls.Add(this.radioButton_secLast);
            this.groupBox_Color.Controls.Add(this.radioButton_Last);
            this.groupBox_Color.Controls.Add(this.radioButton_non);
            this.groupBox_Color.Location = new System.Drawing.Point(224, 82);
            this.groupBox_Color.Name = "groupBox_Color";
            this.groupBox_Color.Size = new System.Drawing.Size(280, 251);
            this.groupBox_Color.TabIndex = 8;
            this.groupBox_Color.TabStop = false;
            this.groupBox_Color.Text = "Color";
            // 
            // radioButton_3rdLast
            // 
            this.radioButton_3rdLast.AutoSize = true;
            this.radioButton_3rdLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_3rdLast.Location = new System.Drawing.Point(11, 196);
            this.radioButton_3rdLast.Name = "radioButton_3rdLast";
            this.radioButton_3rdLast.Size = new System.Drawing.Size(220, 28);
            this.radioButton_3rdLast.TabIndex = 8;
            this.radioButton_3rdLast.Text = "w/ Color (3rd last jump)";
            this.radioButton_3rdLast.UseVisualStyleBackColor = true;
            // 
            // radioButton_SquareRest2
            // 
            this.radioButton_SquareRest2.AutoSize = true;
            this.radioButton_SquareRest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SquareRest2.Location = new System.Drawing.Point(20, 246);
            this.radioButton_SquareRest2.Name = "radioButton_SquareRest2";
            this.radioButton_SquareRest2.Size = new System.Drawing.Size(550, 28);
            this.radioButton_SquareRest2.TabIndex = 9;
            this.radioButton_SquareRest2.Text = "Restriction: opposite corner is not allowed (Jump-Length = 1/2)";
            this.radioButton_SquareRest2.UseVisualStyleBackColor = true;
            // 
            // radioButton_SquareRest3
            // 
            this.radioButton_SquareRest3.AutoSize = true;
            this.radioButton_SquareRest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SquareRest3.Location = new System.Drawing.Point(20, 298);
            this.radioButton_SquareRest3.Name = "radioButton_SquareRest3";
            this.radioButton_SquareRest3.Size = new System.Drawing.Size(501, 28);
            this.radioButton_SquareRest3.TabIndex = 10;
            this.radioButton_SquareRest3.Text = "Restriction: left corner is not allowed (Jump-Length = 1/2)";
            this.radioButton_SquareRest3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 566);
            this.Controls.Add(this.groupBox_Color);
            this.Controls.Add(this.groupBox_Fractal);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Description);
            this.Name = "Form1";
            this.Text = "S.NUF.2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Fractal.ResumeLayout(false);
            this.groupBox_Fractal.PerformLayout();
            this.groupBox_Color.ResumeLayout(false);
            this.groupBox_Color.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.RadioButton radioButton_Sirpinski_3rand;
        private System.Windows.Forms.GroupBox groupBox_Fractal;
        private System.Windows.Forms.RadioButton radioButton_SquareRest1;
        private System.Windows.Forms.RadioButton radioButton_SquarNoice;
        private System.Windows.Forms.RadioButton radioButton_CenterPoint_13;
        private System.Windows.Forms.RadioButton radioButton_CenterPoint_23;
        private System.Windows.Forms.RadioButton radioButton_non;
        private System.Windows.Forms.RadioButton radioButton_Last;
        private System.Windows.Forms.RadioButton radioButton_secLast;
        private System.Windows.Forms.GroupBox groupBox_Color;
        private System.Windows.Forms.RadioButton radioButton_3rdLast;
        private System.Windows.Forms.RadioButton radioButton_noRes_23;
        private System.Windows.Forms.RadioButton radioButton_SquareRest3;
        private System.Windows.Forms.RadioButton radioButton_SquareRest2;
    }
}

