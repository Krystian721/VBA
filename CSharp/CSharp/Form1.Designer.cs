namespace CSharp
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
            this.lSensor1 = new System.Windows.Forms.Label();
            this.lSensor2 = new System.Windows.Forms.Label();
            this.tbSensor1 = new System.Windows.Forms.TextBox();
            this.tbSensor2 = new System.Windows.Forms.TextBox();
            this.bStartPomiar = new System.Windows.Forms.Button();
            this.bStartZapis = new System.Windows.Forms.Button();
            this.bStopPomiar = new System.Windows.Forms.Button();
            this.bStopZapis = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // lSensor1
            // 
            this.lSensor1.AutoSize = true;
            this.lSensor1.Location = new System.Drawing.Point(9, 9);
            this.lSensor1.Name = "lSensor1";
            this.lSensor1.Size = new System.Drawing.Size(65, 17);
            this.lSensor1.TabIndex = 0;
            this.lSensor1.Text = "Sensor 1";
            // 
            // lSensor2
            // 
            this.lSensor2.AutoSize = true;
            this.lSensor2.Location = new System.Drawing.Point(98, 9);
            this.lSensor2.Name = "lSensor2";
            this.lSensor2.Size = new System.Drawing.Size(65, 17);
            this.lSensor2.TabIndex = 1;
            this.lSensor2.Text = "Sensor 2";
            // 
            // tbSensor1
            // 
            this.tbSensor1.Location = new System.Drawing.Point(12, 29);
            this.tbSensor1.Name = "tbSensor1";
            this.tbSensor1.Size = new System.Drawing.Size(83, 22);
            this.tbSensor1.TabIndex = 2;
            // 
            // tbSensor2
            // 
            this.tbSensor2.Location = new System.Drawing.Point(101, 29);
            this.tbSensor2.Name = "tbSensor2";
            this.tbSensor2.Size = new System.Drawing.Size(83, 22);
            this.tbSensor2.TabIndex = 3;
            // 
            // bStartPomiar
            // 
            this.bStartPomiar.Location = new System.Drawing.Point(12, 57);
            this.bStartPomiar.Name = "bStartPomiar";
            this.bStartPomiar.Size = new System.Drawing.Size(83, 47);
            this.bStartPomiar.TabIndex = 4;
            this.bStartPomiar.Text = "POMIAR START";
            this.bStartPomiar.UseVisualStyleBackColor = true;
            this.bStartPomiar.Click += new System.EventHandler(this.bStartPomiar_Click);
            // 
            // bStartZapis
            // 
            this.bStartZapis.Location = new System.Drawing.Point(12, 113);
            this.bStartZapis.Name = "bStartZapis";
            this.bStartZapis.Size = new System.Drawing.Size(83, 47);
            this.bStartZapis.TabIndex = 5;
            this.bStartZapis.Text = "ZAPIS START";
            this.bStartZapis.UseVisualStyleBackColor = true;
            this.bStartZapis.Click += new System.EventHandler(this.bStartZapis_Click);
            // 
            // bStopPomiar
            // 
            this.bStopPomiar.Location = new System.Drawing.Point(101, 57);
            this.bStopPomiar.Name = "bStopPomiar";
            this.bStopPomiar.Size = new System.Drawing.Size(83, 47);
            this.bStopPomiar.TabIndex = 6;
            this.bStopPomiar.Text = "POMIAR STOP";
            this.bStopPomiar.UseVisualStyleBackColor = true;
            this.bStopPomiar.Click += new System.EventHandler(this.bStopPomiar_Click);
            // 
            // bStopZapis
            // 
            this.bStopZapis.Location = new System.Drawing.Point(101, 113);
            this.bStopZapis.Name = "bStopZapis";
            this.bStopZapis.Size = new System.Drawing.Size(83, 47);
            this.bStopZapis.TabIndex = 7;
            this.bStopZapis.Text = "ZAPIS STOP";
            this.bStopZapis.UseVisualStyleBackColor = true;
            this.bStopZapis.Click += new System.EventHandler(this.bStopZapis_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 172);
            this.Controls.Add(this.bStopZapis);
            this.Controls.Add(this.bStopPomiar);
            this.Controls.Add(this.bStartZapis);
            this.Controls.Add(this.bStartPomiar);
            this.Controls.Add(this.tbSensor2);
            this.Controls.Add(this.tbSensor1);
            this.Controls.Add(this.lSensor2);
            this.Controls.Add(this.lSensor1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSensor1;
        private System.Windows.Forms.Label lSensor2;
        private System.Windows.Forms.TextBox tbSensor1;
        private System.Windows.Forms.TextBox tbSensor2;
        private System.Windows.Forms.Button bStartPomiar;
        private System.Windows.Forms.Button bStartZapis;
        private System.Windows.Forms.Button bStopPomiar;
        private System.Windows.Forms.Button bStopZapis;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

