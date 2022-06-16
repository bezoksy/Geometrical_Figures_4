namespace GeometricFigures_3
{
    partial class mainForm
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
            System.Windows.Forms.Button btnTriangle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.gBoxMainMenu = new System.Windows.Forms.GroupBox();
            this.tBarThickness = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.labelThickness = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            btnTriangle = new System.Windows.Forms.Button();
            this.gBoxMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTriangle
            // 
            btnTriangle.BackgroundImage = global::GeometricFigures_3.Properties.Resources.triangle;
            btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnTriangle.Location = new System.Drawing.Point(29, 147);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new System.Drawing.Size(84, 82);
            btnTriangle.TabIndex = 0;
            btnTriangle.UseVisualStyleBackColor = true;
            btnTriangle.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // gBoxMainMenu
            // 
            this.gBoxMainMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gBoxMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gBoxMainMenu.Controls.Add(this.tBarThickness);
            this.gBoxMainMenu.Controls.Add(this.btnColor);
            this.gBoxMainMenu.Controls.Add(this.labelThickness);
            this.gBoxMainMenu.Controls.Add(this.labelColor);
            this.gBoxMainMenu.Controls.Add(this.btnClear);
            this.gBoxMainMenu.Controls.Add(this.btnLoad);
            this.gBoxMainMenu.Controls.Add(this.btnSave);
            this.gBoxMainMenu.Controls.Add(this.btnLine);
            this.gBoxMainMenu.Controls.Add(btnTriangle);
            this.gBoxMainMenu.Controls.Add(this.btnRectangle);
            this.gBoxMainMenu.Controls.Add(this.btnCircle);
            this.gBoxMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gBoxMainMenu.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBoxMainMenu.Location = new System.Drawing.Point(0, 0);
            this.gBoxMainMenu.Name = "gBoxMainMenu";
            this.gBoxMainMenu.Size = new System.Drawing.Size(300, 677);
            this.gBoxMainMenu.TabIndex = 0;
            this.gBoxMainMenu.TabStop = false;
            this.gBoxMainMenu.Text = "Главное меню";
            // 
            // tBarThickness
            // 
            this.tBarThickness.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tBarThickness.Location = new System.Drawing.Point(149, 295);
            this.tBarThickness.Name = "tBarThickness";
            this.tBarThickness.Size = new System.Drawing.Size(104, 45);
            this.tBarThickness.TabIndex = 4;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(196, 254);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 30);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelThickness.Location = new System.Drawing.Point(29, 305);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(99, 24);
            this.labelThickness.TabIndex = 2;
            this.labelThickness.Text = "Толщина:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColor.Location = new System.Drawing.Point(29, 257);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(143, 24);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Цвет фигуры:";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(29, 638);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(224, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(29, 592);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(224, 40);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(29, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = global::GeometricFigures_3.Properties.Resources.line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLine.Location = new System.Drawing.Point(169, 42);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(84, 82);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::GeometricFigures_3.Properties.Resources.rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Location = new System.Drawing.Point(169, 147);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(84, 82);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = global::GeometricFigures_3.Properties.Resources.Circle;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCircle.Location = new System.Drawing.Point(29, 42);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(84, 82);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // panelBoard
            // 
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(300, 0);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(693, 677);
            this.panelBoard.TabIndex = 1;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(993, 677);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.gBoxMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Геометрические фигуры";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gBoxMainMenu.ResumeLayout(false);
            this.gBoxMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMainMenu;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelThickness;
        public System.Windows.Forms.Button btnColor;
        public System.Windows.Forms.TrackBar tBarThickness;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
