namespace Crud
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonExitElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonMaxElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buttonMinElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolTipView = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMax = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.userControlAdd1 = new Crud.UserControlAdd();
            this.userControlView1 = new Crud.UserControlView();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 36);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Simple CRUD";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1053, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(19, 19);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1078, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 19);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1103, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 19);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(12, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 10);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desing By: Maxwell Tavares";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1140, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 554);
            this.panel4.TabIndex = 3;
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 25;
            this.FormElipse.TargetControl = this;
            // 
            // buttonExitElipse
            // 
            this.buttonExitElipse.ElipseRadius = 40;
            this.buttonExitElipse.TargetControl = this.button1;
            // 
            // buttonMaxElipse
            // 
            this.buttonMaxElipse.ElipseRadius = 40;
            this.buttonMaxElipse.TargetControl = this.button2;
            // 
            // buttonMinElipse
            // 
            this.buttonMinElipse.ElipseRadius = 40;
            this.buttonMinElipse.TargetControl = this.button3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.bunifuImageButton2);
            this.panel5.Controls.Add(this.bunifuImageButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(12, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(81, 554);
            this.panel5.TabIndex = 1;
            // 
            // toolTipView
            // 
            this.toolTipView.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipView.ToolTipTitle = "Aqui podras visualizar";
            // 
            // toolTipAdd
            // 
            this.toolTipAdd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAdd.ToolTipTitle = "Aqui podras añadir un nuevo doc.";
            // 
            // toolTipExit
            // 
            this.toolTipExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipExit.ToolTipTitle = "Salir.";
            // 
            // toolTipMax
            // 
            this.toolTipMax.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMax.ToolTipTitle = "Maximizar";
            // 
            // toolTipMin
            // 
            this.toolTipMin.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMin.ToolTipTitle = "Minimizar";
            // 
            // toolTipDelete
            // 
            this.toolTipDelete.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDelete.ToolTipTitle = "Aqui podras eliminar docs.";
            // 
            // toolTipUpdate
            // 
            this.toolTipUpdate.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUpdate.ToolTipTitle = "Aqui podras actualizar docs.";
            // 
            // userControlAdd1
            // 
            this.userControlAdd1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdd1.Location = new System.Drawing.Point(0, 0);
            this.userControlAdd1.Name = "userControlAdd1";
            this.userControlAdd1.Size = new System.Drawing.Size(1150, 600);
            this.userControlAdd1.TabIndex = 5;
            // 
            // userControlView1
            // 
            this.userControlView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlView1.Location = new System.Drawing.Point(0, 0);
            this.userControlView1.Name = "userControlView1";
            this.userControlView1.Size = new System.Drawing.Size(1150, 600);
            this.userControlView1.TabIndex = 4;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuImageButton2.Image = global::Crud.Properties.Resources.icons8_document_100px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(0, 101);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(81, 71);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            this.bunifuImageButton2.MouseEnter += new System.EventHandler(this.bunifuImageButton2_MouseEnter);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuImageButton1.Image = global::Crud.Properties.Resources.Eye;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 24);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(81, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.bunifuImageButton1.MouseEnter += new System.EventHandler(this.bunifuImageButton1_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlView1);
            this.Controls.Add(this.userControlAdd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Bunifu.Framework.UI.BunifuElipse buttonExitElipse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuElipse buttonMaxElipse;
        private Bunifu.Framework.UI.BunifuElipse buttonMinElipse;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolTip toolTipView;
        private System.Windows.Forms.ToolTip toolTipAdd;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipMax;
        private System.Windows.Forms.ToolTip toolTipMin;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.ToolTip toolTipUpdate;
        private UserControlView userControlView1;
        private UserControlAdd userControlAdd1;
    }
}

