namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTela = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnResto = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnVirg = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTela
            // 
            this.txtTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTela.Location = new System.Drawing.Point(12, 12);
            this.txtTela.Name = "txtTela";
            this.txtTela.ReadOnly = true;
            this.txtTela.Size = new System.Drawing.Size(432, 116);
            this.txtTela.TabIndex = 0;
            this.txtTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(373, 274);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(71, 165);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(373, 206);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(71, 62);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(373, 138);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(71, 62);
            this.btnMult.TabIndex = 4;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnResto
            // 
            this.btnResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResto.Location = new System.Drawing.Point(12, 138);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(173, 62);
            this.btnResto.TabIndex = 5;
            this.btnResto.Text = "%";
            this.btnResto.UseVisualStyleBackColor = true;
            this.btnResto.Click += new System.EventHandler(this.btnResto_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(191, 138);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(176, 62);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(89, 206);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(96, 79);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(191, 206);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(71, 79);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(268, 206);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(99, 79);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(89, 291);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(96, 62);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(191, 291);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(71, 62);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(268, 291);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(99, 62);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(268, 359);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(99, 80);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(191, 359);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 80);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(89, 359);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(96, 80);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 324);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(71, 115);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(12, 206);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(71, 112);
            this.btnLimpa.TabIndex = 17;
            this.btnLimpa.Text = "C";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(12, 445);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(148, 62);
            this.btnPonto.TabIndex = 18;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnVirg
            // 
            this.btnVirg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirg.Location = new System.Drawing.Point(89, 445);
            this.btnVirg.Name = "btnVirg";
            this.btnVirg.Size = new System.Drawing.Size(71, 62);
            this.btnVirg.TabIndex = 19;
            this.btnVirg.Text = ",";
            this.btnVirg.UseVisualStyleBackColor = true;
            this.btnVirg.Click += new System.EventHandler(this.btnVirg_Click);
            // 
            // btnRes
            // 
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.Location = new System.Drawing.Point(166, 445);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(278, 62);
            this.btnRes.TabIndex = 20;
            this.btnRes.Text = "=";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 519);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnResto);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.btnVirg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnVirg;
        private System.Windows.Forms.Button btnRes;
    }
}

