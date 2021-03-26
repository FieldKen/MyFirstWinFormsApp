
namespace MyFirstWinFormsApp
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
            this.btnButton = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.cbCheckbox = new System.Windows.Forms.CheckBox();
            this.rbButton = new System.Windows.Forms.RadioButton();
            this.rbButton2 = new System.Windows.Forms.RadioButton();
            this.cbCheckbox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbBar = new System.Windows.Forms.ProgressBar();
            this.lbList = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.clbMijnLijst = new System.Windows.Forms.CheckedListBox();
            this.txtClb = new System.Windows.Forms.TextBox();
            this.txtClbAll = new System.Windows.Forms.TextBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnButton.Location = new System.Drawing.Point(12, 11);
            this.btnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(400, 24);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Klik mij!";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            this.btnButton.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtInput.Location = new System.Drawing.Point(12, 41);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(402, 32);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "Ken";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(12, 75);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(0, 13);
            this.lblLabel.TabIndex = 6;
            // 
            // cbCheckbox
            // 
            this.cbCheckbox.AutoSize = true;
            this.cbCheckbox.Location = new System.Drawing.Point(12, 172);
            this.cbCheckbox.Name = "cbCheckbox";
            this.cbCheckbox.Size = new System.Drawing.Size(80, 17);
            this.cbCheckbox.TabIndex = 7;
            this.cbCheckbox.Text = "checkBox1";
            this.cbCheckbox.UseVisualStyleBackColor = true;
            // 
            // rbButton
            // 
            this.rbButton.AutoSize = true;
            this.rbButton.Checked = true;
            this.rbButton.Location = new System.Drawing.Point(6, 19);
            this.rbButton.Name = "rbButton";
            this.rbButton.Size = new System.Drawing.Size(75, 17);
            this.rbButton.TabIndex = 8;
            this.rbButton.TabStop = true;
            this.rbButton.Text = "minderjarig";
            this.rbButton.UseVisualStyleBackColor = true;
            // 
            // rbButton2
            // 
            this.rbButton2.AutoSize = true;
            this.rbButton2.Location = new System.Drawing.Point(6, 42);
            this.rbButton2.Name = "rbButton2";
            this.rbButton2.Size = new System.Drawing.Size(75, 17);
            this.rbButton2.TabIndex = 9;
            this.rbButton2.Text = "volwassen";
            this.rbButton2.UseVisualStyleBackColor = true;
            // 
            // cbCheckbox2
            // 
            this.cbCheckbox2.AutoSize = true;
            this.cbCheckbox2.Location = new System.Drawing.Point(12, 195);
            this.cbCheckbox2.Name = "cbCheckbox2";
            this.cbCheckbox2.Size = new System.Drawing.Size(80, 17);
            this.cbCheckbox2.TabIndex = 10;
            this.cbCheckbox2.Text = "checkBox1";
            this.cbCheckbox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "man";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "vrouw";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbButton);
            this.groupBox1.Controls.Add(this.rbButton2);
            this.groupBox1.Location = new System.Drawing.Point(450, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 66);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(566, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 71);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pbBar
            // 
            this.pbBar.Location = new System.Drawing.Point(12, 327);
            this.pbBar.Name = "pbBar";
            this.pbBar.Size = new System.Drawing.Size(760, 23);
            this.pbBar.TabIndex = 15;
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(450, 94);
            this.lbList.Name = "lbList";
            this.lbList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbList.Size = new System.Drawing.Size(120, 212);
            this.lbList.TabIndex = 16;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(576, 94);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(196, 212);
            this.webBrowser1.TabIndex = 17;
            this.webBrowser1.Url = new System.Uri("http://www.google.be/", System.UriKind.Absolute);
            // 
            // clbMijnLijst
            // 
            this.clbMijnLijst.CheckOnClick = true;
            this.clbMijnLijst.FormattingEnabled = true;
            this.clbMijnLijst.Location = new System.Drawing.Point(256, 172);
            this.clbMijnLijst.Name = "clbMijnLijst";
            this.clbMijnLijst.Size = new System.Drawing.Size(120, 139);
            this.clbMijnLijst.TabIndex = 18;
            this.clbMijnLijst.SelectedIndexChanged += new System.EventHandler(this.clbMijnLijst_SelectedIndexChanged);
            // 
            // txtClb
            // 
            this.txtClb.Enabled = false;
            this.txtClb.Location = new System.Drawing.Point(12, 291);
            this.txtClb.Name = "txtClb";
            this.txtClb.Size = new System.Drawing.Size(238, 20);
            this.txtClb.TabIndex = 19;
            // 
            // txtClbAll
            // 
            this.txtClbAll.Enabled = false;
            this.txtClbAll.Location = new System.Drawing.Point(12, 265);
            this.txtClbAll.Name = "txtClbAll";
            this.txtClbAll.Size = new System.Drawing.Size(238, 20);
            this.txtClbAll.TabIndex = 20;
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(323, 94);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 21;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.txtClbAll);
            this.Controls.Add(this.txtClb);
            this.Controls.Add(this.clbMijnLijst);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.pbBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCheckbox2);
            this.Controls.Add(this.cbCheckbox);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 501);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Mijn Eerste App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.CheckBox cbCheckbox;
        private System.Windows.Forms.RadioButton rbButton;
        private System.Windows.Forms.RadioButton rbButton2;
        private System.Windows.Forms.CheckBox cbCheckbox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pbBar;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.CheckedListBox clbMijnLijst;
        private System.Windows.Forms.TextBox txtClb;
        private System.Windows.Forms.TextBox txtClbAll;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

