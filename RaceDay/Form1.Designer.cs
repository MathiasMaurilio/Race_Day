namespace RaceDay
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
            this.SpeedWay = new System.Windows.Forms.Panel();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCorram = new System.Windows.Forms.Button();
            this.lblAlfredo = new System.Windows.Forms.Label();
            this.lblBeto = new System.Windows.Forms.Label();
            this.lblJoao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDog = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAposta = new System.Windows.Forms.Button();
            this.lblApostador = new System.Windows.Forms.Label();
            this.rbtnAlfredo = new System.Windows.Forms.RadioButton();
            this.rbtnBeto = new System.Windows.Forms.RadioButton();
            this.rbtnJoao = new System.Windows.Forms.RadioButton();
            this.lblApostaMinima = new System.Windows.Forms.Label();
            this.SpeedWay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // SpeedWay
            // 
            this.SpeedWay.BackgroundImage = global::RaceDay.Properties.Resources.racetrack;
            this.SpeedWay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SpeedWay.Controls.Add(this.Dog4);
            this.SpeedWay.Controls.Add(this.Dog3);
            this.SpeedWay.Controls.Add(this.Dog2);
            this.SpeedWay.Controls.Add(this.Dog1);
            this.SpeedWay.Location = new System.Drawing.Point(11, 12);
            this.SpeedWay.Name = "SpeedWay";
            this.SpeedWay.Size = new System.Drawing.Size(600, 202);
            this.SpeedWay.TabIndex = 0;
            // 
            // Dog4
            // 
            this.Dog4.BackgroundImage = global::RaceDay.Properties.Resources.dog;
            this.Dog4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dog4.Location = new System.Drawing.Point(16, 159);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(73, 26);
            this.Dog4.TabIndex = 3;
            this.Dog4.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.BackgroundImage = global::RaceDay.Properties.Resources.dog;
            this.Dog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dog3.Location = new System.Drawing.Point(16, 110);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(73, 26);
            this.Dog3.TabIndex = 2;
            this.Dog3.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.BackgroundImage = global::RaceDay.Properties.Resources.dog;
            this.Dog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dog2.Location = new System.Drawing.Point(16, 65);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(73, 26);
            this.Dog2.TabIndex = 1;
            this.Dog2.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.BackgroundImage = global::RaceDay.Properties.Resources.dog;
            this.Dog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dog1.InitialImage = global::RaceDay.Properties.Resources.dog;
            this.Dog1.Location = new System.Drawing.Point(16, 12);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(73, 26);
            this.Dog1.TabIndex = 0;
            this.Dog1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCorram);
            this.groupBox1.Controls.Add(this.lblAlfredo);
            this.groupBox1.Controls.Add(this.lblBeto);
            this.groupBox1.Controls.Add(this.lblJoao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudDog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudAmount);
            this.groupBox1.Controls.Add(this.btnAposta);
            this.groupBox1.Controls.Add(this.lblApostador);
            this.groupBox1.Controls.Add(this.rbtnAlfredo);
            this.groupBox1.Controls.Add(this.rbtnBeto);
            this.groupBox1.Controls.Add(this.rbtnJoao);
            this.groupBox1.Controls.Add(this.lblApostaMinima);
            this.groupBox1.Location = new System.Drawing.Point(13, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balcão de Apostas";
            // 
            // btnCorram
            // 
            this.btnCorram.Location = new System.Drawing.Point(486, 124);
            this.btnCorram.Name = "btnCorram";
            this.btnCorram.Size = new System.Drawing.Size(107, 37);
            this.btnCorram.TabIndex = 13;
            this.btnCorram.Text = "Corram!";
            this.btnCorram.UseVisualStyleBackColor = true;
            this.btnCorram.Click += new System.EventHandler(this.BtnCorram_Click);
            // 
            // lblAlfredo
            // 
            this.lblAlfredo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlfredo.Location = new System.Drawing.Point(307, 99);
            this.lblAlfredo.Name = "lblAlfredo";
            this.lblAlfredo.Size = new System.Drawing.Size(286, 17);
            this.lblAlfredo.TabIndex = 12;
            this.lblAlfredo.Text = "Aposta do Alfredo";
            // 
            // lblBeto
            // 
            this.lblBeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBeto.Location = new System.Drawing.Point(307, 77);
            this.lblBeto.Name = "lblBeto";
            this.lblBeto.Size = new System.Drawing.Size(286, 17);
            this.lblBeto.TabIndex = 11;
            this.lblBeto.Text = "Aposta do Beto";
            // 
            // lblJoao
            // 
            this.lblJoao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoao.Location = new System.Drawing.Point(307, 54);
            this.lblJoao.Name = "lblJoao";
            this.lblJoao.Size = new System.Drawing.Size(286, 17);
            this.lblJoao.TabIndex = 10;
            this.lblJoao.Text = "Aposta do João";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apostas";
            // 
            // nudDog
            // 
            this.nudDog.Location = new System.Drawing.Point(310, 141);
            this.nudDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDog.Name = "nudDog";
            this.nudDog.Size = new System.Drawing.Size(57, 20);
            this.nudDog.TabIndex = 8;
            this.nudDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reais no Cão Número";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(128, 141);
            this.nudAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(59, 20);
            this.nudAmount.TabIndex = 6;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAposta
            // 
            this.btnAposta.Location = new System.Drawing.Point(47, 138);
            this.btnAposta.Name = "btnAposta";
            this.btnAposta.Size = new System.Drawing.Size(75, 23);
            this.btnAposta.TabIndex = 5;
            this.btnAposta.Text = "Aposta";
            this.btnAposta.UseVisualStyleBackColor = true;
            this.btnAposta.Click += new System.EventHandler(this.BtnAposta_Click);
            // 
            // lblApostador
            // 
            this.lblApostador.AutoSize = true;
            this.lblApostador.Location = new System.Drawing.Point(6, 143);
            this.lblApostador.Name = "lblApostador";
            this.lblApostador.Size = new System.Drawing.Size(30, 13);
            this.lblApostador.TabIndex = 4;
            this.lblApostador.Text = "João";
            // 
            // rbtnAlfredo
            // 
            this.rbtnAlfredo.AutoSize = true;
            this.rbtnAlfredo.Location = new System.Drawing.Point(14, 99);
            this.rbtnAlfredo.Name = "rbtnAlfredo";
            this.rbtnAlfredo.Size = new System.Drawing.Size(58, 17);
            this.rbtnAlfredo.TabIndex = 3;
            this.rbtnAlfredo.TabStop = true;
            this.rbtnAlfredo.Text = "Alfredo";
            this.rbtnAlfredo.UseVisualStyleBackColor = true;
            this.rbtnAlfredo.CheckedChanged += new System.EventHandler(this.RbtnAlfredo_CheckedChanged);
            // 
            // rbtnBeto
            // 
            this.rbtnBeto.AutoSize = true;
            this.rbtnBeto.Location = new System.Drawing.Point(14, 77);
            this.rbtnBeto.Name = "rbtnBeto";
            this.rbtnBeto.Size = new System.Drawing.Size(47, 17);
            this.rbtnBeto.TabIndex = 2;
            this.rbtnBeto.TabStop = true;
            this.rbtnBeto.Text = "Beto";
            this.rbtnBeto.UseVisualStyleBackColor = true;
            this.rbtnBeto.CheckedChanged += new System.EventHandler(this.RbtnBeto_CheckedChanged);
            // 
            // rbtnJoao
            // 
            this.rbtnJoao.AutoSize = true;
            this.rbtnJoao.Location = new System.Drawing.Point(14, 54);
            this.rbtnJoao.Name = "rbtnJoao";
            this.rbtnJoao.Size = new System.Drawing.Size(48, 17);
            this.rbtnJoao.TabIndex = 1;
            this.rbtnJoao.TabStop = true;
            this.rbtnJoao.Text = "João";
            this.rbtnJoao.UseVisualStyleBackColor = true;
            this.rbtnJoao.CheckedChanged += new System.EventHandler(this.RbtnJoao_CheckedChanged);
            // 
            // lblApostaMinima
            // 
            this.lblApostaMinima.AutoSize = true;
            this.lblApostaMinima.Location = new System.Drawing.Point(11, 29);
            this.lblApostaMinima.Name = "lblApostaMinima";
            this.lblApostaMinima.Size = new System.Drawing.Size(76, 13);
            this.lblApostaMinima.TabIndex = 0;
            this.lblApostaMinima.Text = "Aposta Minima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpeedWay);
            this.Name = "Form1";
            this.Text = "Um Dia de Corrida";
            this.SpeedWay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SpeedWay;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblApostador;
        private System.Windows.Forms.RadioButton rbtnAlfredo;
        private System.Windows.Forms.RadioButton rbtnBeto;
        private System.Windows.Forms.RadioButton rbtnJoao;
        private System.Windows.Forms.Label lblApostaMinima;
        private System.Windows.Forms.NumericUpDown nudDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnAposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlfredo;
        private System.Windows.Forms.Label lblBeto;
        private System.Windows.Forms.Label lblJoao;
        private System.Windows.Forms.Button btnCorram;
    }
}

