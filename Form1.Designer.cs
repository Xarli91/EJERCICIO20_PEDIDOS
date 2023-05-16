using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO20_PEDIDOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquetes";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(308, 116);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 29);
            this.button6.TabIndex = 9;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(271, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(271, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 29);
            this.button5.TabIndex = 6;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 157);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(129, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Otras opciones";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(184, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ensalada, Yogur y Agua";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(199, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pizza, Nuggets y Refresco";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(240, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hamburguesa, Papas y Refresco";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(308, 28);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(43, 27);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 27);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 27);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cambio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total a Pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Postal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IVA 16%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub Total";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.button22);
            this.groupBox3.Controls.Add(this.button23);
            this.groupBox3.Controls.Add(this.button20);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.button18);
            this.groupBox3.Controls.Add(this.button19);
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 310);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedidos";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(126, 269);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(31, 29);
            this.button22.TabIndex = 39;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(89, 269);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(31, 29);
            this.button23.TabIndex = 38;
            this.button23.Text = "+";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(126, 234);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(31, 29);
            this.button20.TabIndex = 37;
            this.button20.Text = "-";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(89, 234);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(31, 29);
            this.button21.TabIndex = 36;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(126, 202);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(31, 29);
            this.button18.TabIndex = 35;
            this.button18.Text = "-";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(89, 202);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(31, 29);
            this.button19.TabIndex = 34;
            this.button19.Text = "+";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(126, 170);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(31, 29);
            this.button16.TabIndex = 33;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(89, 170);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(31, 29);
            this.button17.TabIndex = 32;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(126, 135);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(31, 29);
            this.button14.TabIndex = 31;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(89, 135);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(31, 29);
            this.button15.TabIndex = 30;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(126, 101);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(31, 29);
            this.button12.TabIndex = 29;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(89, 101);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(31, 29);
            this.button13.TabIndex = 28;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(126, 66);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(31, 29);
            this.button10.TabIndex = 27;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(89, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(31, 29);
            this.button11.TabIndex = 26;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(126, 31);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 29);
            this.button8.TabIndex = 25;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(89, 31);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 29);
            this.button9.TabIndex = 24;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(21, 204);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(51, 27);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "0";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(21, 271);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(51, 27);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "0";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(21, 238);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(51, 27);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "0";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(21, 171);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(51, 27);
            this.textBox11.TabIndex = 20;
            this.textBox11.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(21, 137);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(51, 27);
            this.textBox10.TabIndex = 19;
            this.textBox10.Text = "0";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(21, 103);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(51, 27);
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "0";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(21, 68);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(51, 27);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(21, 31);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(51, 27);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(289, 273);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 20);
            this.label22.TabIndex = 15;
            this.label22.Text = "$12.00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(289, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 20);
            this.label21.TabIndex = 14;
            this.label21.Text = "$15.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(289, 207);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 20);
            this.label20.TabIndex = 13;
            this.label20.Text = "$30.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(289, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 20);
            this.label19.TabIndex = 12;
            this.label19.Text = "$25.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(289, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 20);
            this.label18.TabIndex = 11;
            this.label18.Text = "$70.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(289, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "$12.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(289, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "$15.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(289, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "$35.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Agua";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Yogur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ensalada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nugget";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pizza";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Refresco";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Papas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hamburguesa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button25);
            this.groupBox4.Controls.Add(this.button24);
            this.groupBox4.Location = new System.Drawing.Point(429, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(368, 125);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(224, 27);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(117, 83);
            this.button25.TabIndex = 1;
            this.button25.Text = "SALIR";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(21, 27);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(119, 83);
            this.button24.TabIndex = 0;
            this.button24.Text = "Nueva Operacion";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(809, 478);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button22;
        private Button button23;
        private Button button20;
        private Button button21;
        private Button button18;
        private Button button19;
        private Button button16;
        private Button button17;
        private Button button14;
        private Button button15;
        private Button button12;
        private Button button13;
        private Button button10;
        private Button button11;
        private Button button8;
        private Button button9;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox4;
        private Button button25;
        private Button button24;
        private MaskedTextBox maskedTextBox1;
    }
}