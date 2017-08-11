namespace TMathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timelabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusequalto = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minussignlabel = new System.Windows.Forms.Label();
            this.differences = new System.Windows.Forms.NumericUpDown();
            this.egualtosignforminus = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.timesSign = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.egualtosignfortimes = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.divideRightlabel = new System.Windows.Forms.Label();
            this.dividedEgualtosign = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(272, 9);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(200, 30);
            this.timelabel.TabIndex = 0;
            this.timelabel.BackColorChanged += new System.EventHandler(this.colour_change);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(144, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 70);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(185, 70);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusequalto
            // 
            this.plusequalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusequalto.Location = new System.Drawing.Point(251, 70);
            this.plusequalto.Name = "plusequalto";
            this.plusequalto.Size = new System.Drawing.Size(60, 50);
            this.plusequalto.TabIndex = 5;
            this.plusequalto.Text = "=";
            this.plusequalto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 120);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(185, 120);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 8;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(317, 79);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.sum_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minussignlabel
            // 
            this.minussignlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minussignlabel.Location = new System.Drawing.Point(119, 120);
            this.minussignlabel.Name = "minussignlabel";
            this.minussignlabel.Size = new System.Drawing.Size(60, 50);
            this.minussignlabel.TabIndex = 10;
            this.minussignlabel.Text = "-";
            this.minussignlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // differences
            // 
            this.differences.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differences.Location = new System.Drawing.Point(317, 129);
            this.differences.Name = "differences";
            this.differences.Size = new System.Drawing.Size(100, 35);
            this.differences.TabIndex = 3;
            this.differences.ValueChanged += new System.EventHandler(this.differences_ValueChanged);
            this.differences.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // egualtosignforminus
            // 
            this.egualtosignforminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egualtosignforminus.Location = new System.Drawing.Point(251, 120);
            this.egualtosignforminus.Name = "egualtosignforminus";
            this.egualtosignforminus.Size = new System.Drawing.Size(60, 50);
            this.egualtosignforminus.TabIndex = 12;
            this.egualtosignforminus.Text = "=";
            this.egualtosignforminus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 170);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 13;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timesLeftLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // timesSign
            // 
            this.timesSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesSign.Location = new System.Drawing.Point(119, 170);
            this.timesSign.Name = "timesSign";
            this.timesSign.Size = new System.Drawing.Size(60, 50);
            this.timesSign.TabIndex = 14;
            this.timesSign.Text = "×";
            this.timesSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(185, 170);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 15;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // egualtosignfortimes
            // 
            this.egualtosignfortimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.egualtosignfortimes.Location = new System.Drawing.Point(251, 161);
            this.egualtosignfortimes.Name = "egualtosignfortimes";
            this.egualtosignfortimes.Size = new System.Drawing.Size(60, 50);
            this.egualtosignfortimes.TabIndex = 16;
            this.egualtosignfortimes.Text = "=";
            this.egualtosignfortimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(317, 176);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 4;
            this.product.ValueChanged += new System.EventHandler(this.product_ValueChanged);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 220);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 18;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideRightlabel
            // 
            this.divideRightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRightlabel.Location = new System.Drawing.Point(185, 220);
            this.divideRightlabel.Name = "divideRightlabel";
            this.divideRightlabel.Size = new System.Drawing.Size(60, 50);
            this.divideRightlabel.TabIndex = 19;
            this.divideRightlabel.Text = "?";
            this.divideRightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedEgualtosign
            // 
            this.dividedEgualtosign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedEgualtosign.Location = new System.Drawing.Point(119, 214);
            this.dividedEgualtosign.Name = "dividedEgualtosign";
            this.dividedEgualtosign.Size = new System.Drawing.Size(60, 50);
            this.dividedEgualtosign.TabIndex = 20;
            this.dividedEgualtosign.Text = " ÷";
            this.dividedEgualtosign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 21;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(317, 232);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 5;
            this.quotient.ValueChanged += new System.EventHandler(this.quotient_ValueChanged);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(181, 326);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(84, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dividedEgualtosign);
            this.Controls.Add(this.divideRightlabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.egualtosignfortimes);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesSign);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.egualtosignforminus);
            this.Controls.Add(this.differences);
            this.Controls.Add(this.minussignlabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusequalto);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.timelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ToluMath Quiz App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusequalto;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minussignlabel;
        private System.Windows.Forms.NumericUpDown differences;
        private System.Windows.Forms.Label egualtosignforminus;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label timesSign;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label egualtosignfortimes;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label divideRightlabel;
        private System.Windows.Forms.Label dividedEgualtosign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

