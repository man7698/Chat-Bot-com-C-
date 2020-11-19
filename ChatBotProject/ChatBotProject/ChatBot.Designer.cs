namespace ChatBotProject
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
            this.txtTyping = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InputTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.bubble1 = new ChatBotProject.bubble();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTyping
            // 
            this.txtTyping.AutoSize = true;
            this.txtTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyping.Location = new System.Drawing.Point(14, 121);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(225, 20);
            this.txtTyping.TabIndex = 3;
            this.txtTyping.Text = "O ChatBot Esta Pensando ..... ";
            this.txtTyping.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 40);
            this.panel1.TabIndex = 4;
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(605, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 16);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ChatBot Profissões";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InputTxt
            // 
            this.InputTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputTxt.HintForeColor = System.Drawing.Color.Empty;
            this.InputTxt.HintText = "";
            this.InputTxt.isPassword = false;
            this.InputTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineIdleColor = System.Drawing.Color.Black;
            this.InputTxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineThickness = 4;
            this.InputTxt.Location = new System.Drawing.Point(7, 47);
            this.InputTxt.Margin = new System.Windows.Forms.Padding(4);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(546, 44);
            this.InputTxt.TabIndex = 5;
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageActive = null;
            this.button1.Location = new System.Drawing.Point(583, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 56);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.Zoom = 10;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Controls.Add(this.bubble1);
            this.panel2.Location = new System.Drawing.Point(7, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 396);
            this.panel2.TabIndex = 7;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(395, 111);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(114, 30);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar Chat";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // bubble1
            // 
            this.bubble1.AutoScroll = true;
            this.bubble1.AutoSize = true;
            this.bubble1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bubble1.BackColor = System.Drawing.Color.Brown;
            this.bubble1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubble1.Location = new System.Drawing.Point(16, 19);
            this.bubble1.Margin = new System.Windows.Forms.Padding(4);
            this.bubble1.Name = "bubble1";
            this.bubble1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bubble1.Size = new System.Drawing.Size(305, 39);
            this.bubble1.TabIndex = 3;
            this.bubble1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(645, 555);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTyping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTyping;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTxt;
        private Bunifu.Framework.UI.BunifuImageButton button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private bubble bubble1;
        private System.Windows.Forms.Button btnlimpar;
    }
}

