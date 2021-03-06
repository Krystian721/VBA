﻿namespace CSharp
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
            this.lSensor2.Location = new System.Drawing.Point(99, 9);
            this.lSensor2.Name = "lSensor2";
            this.lSensor2.Size = new System.Drawing.Size(65, 17);
            this.lSensor2.TabIndex = 1;
            this.lSensor2.Text = "Sensor 2";
            // 
            // tbSensor1
            // 
            this.tbSensor1.Enabled = false;
            this.tbSensor1.Location = new System.Drawing.Point(12, 30);
            this.tbSensor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSensor1.Name = "tbSensor1";
            this.tbSensor1.Size = new System.Drawing.Size(83, 22);
            this.tbSensor1.TabIndex = 2;
            this.tbSensor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSensor2
            // 
            this.tbSensor2.Enabled = false;
            this.tbSensor2.Location = new System.Drawing.Point(101, 30);
            this.tbSensor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSensor2.Name = "tbSensor2";
            this.tbSensor2.Size = new System.Drawing.Size(83, 22);
            this.tbSensor2.TabIndex = 3;
            this.tbSensor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bStartPomiar
            // 
            this.bStartPomiar.Location = new System.Drawing.Point(12, 57);
            this.bStartPomiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStartPomiar.Name = "bStartPomiar";
            this.bStartPomiar.Size = new System.Drawing.Size(83, 47);
            this.bStartPomiar.TabIndex = 4;
            this.bStartPomiar.Text = "POMIAR START";
            this.bStartPomiar.UseVisualStyleBackColor = true;
            this.bStartPomiar.Click += new System.EventHandler(this.bStartPomiar_Click);
            // 
            // bStartZapis
            // 
            this.bStartZapis.Enabled = false;
            this.bStartZapis.Location = new System.Drawing.Point(12, 113);
            this.bStartZapis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStartZapis.Name = "bStartZapis";
            this.bStartZapis.Size = new System.Drawing.Size(83, 47);
            this.bStartZapis.TabIndex = 5;
            this.bStartZapis.Text = "ZAPIS START";
            this.bStartZapis.UseVisualStyleBackColor = true;
            this.bStartZapis.Click += new System.EventHandler(this.bStartZapis_Click);
            // 
            // bStopPomiar
            // 
            this.bStopPomiar.Enabled = false;
            this.bStopPomiar.Location = new System.Drawing.Point(101, 57);
            this.bStopPomiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStopPomiar.Name = "bStopPomiar";
            this.bStopPomiar.Size = new System.Drawing.Size(83, 47);
            this.bStopPomiar.TabIndex = 6;
            this.bStopPomiar.Text = "POMIAR STOP";
            this.bStopPomiar.UseVisualStyleBackColor = true;
            this.bStopPomiar.Click += new System.EventHandler(this.bStopPomiar_Click);
            // 
            // bStopZapis
            // 
            this.bStopZapis.Enabled = false;
            this.bStopZapis.Location = new System.Drawing.Point(101, 113);
            this.bStopZapis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bStopZapis.Name = "bStopZapis";
            this.bStopZapis.Size = new System.Drawing.Size(83, 47);
            this.bStopZapis.TabIndex = 7;
            this.bStopZapis.Text = "ZAPIS STOP";
            this.bStopZapis.UseVisualStyleBackColor = true;
            this.bStopZapis.Click += new System.EventHandler(this.bStopZapis_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM4";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Czujniki";
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
        private System.IO.Ports.SerialPort serialPort2;
    }
}

