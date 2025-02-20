namespace Calculadora2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operando 2:";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(275, 109);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(31, 29);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 300);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(341, 39);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOper1
            // 
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.Location = new System.Drawing.Point(195, 40);
            this.numOper1.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(120, 35);
            this.numOper1.TabIndex = 5;
            // 
            // numOper2
            // 
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.Location = new System.Drawing.Point(195, 154);
            this.numOper2.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(120, 35);
            this.numOper2.TabIndex = 6;
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(67, 102);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(46, 43);
            this.btSoma.TabIndex = 7;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(119, 102);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(46, 43);
            this.btSub.TabIndex = 8;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(171, 102);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(46, 43);
            this.btMult.TabIndex = 9;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(223, 102);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(46, 43);
            this.btDiv.TabIndex = 10;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(91, 212);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(178, 44);
            this.btIgual.TabIndex = 11;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 348);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btIgual;
    }
}

