
namespace CityTime
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
            this.dragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.titleBar = new Guna.UI.WinForms.GunaPanel();
            this.cityText = new Guna.UI.WinForms.GunaLabel();
            this.titleIcon = new Guna.UI.WinForms.GunaPictureBox();
            this.minBox = new Guna.UI.WinForms.GunaControlBox();
            this.closeBox = new Guna.UI.WinForms.GunaControlBox();
            this.btnLondon = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBaku = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.timerBaku = new System.Windows.Forms.Timer(this.components);
            this.timerLondon = new System.Windows.Forms.Timer(this.components);
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.titleBar;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.SlateGray;
            this.titleBar.Controls.Add(this.cityText);
            this.titleBar.Controls.Add(this.titleIcon);
            this.titleBar.Controls.Add(this.minBox);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(550, 30);
            this.titleBar.TabIndex = 1;
            // 
            // cityText
            // 
            this.cityText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cityText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityText.ForeColor = System.Drawing.Color.White;
            this.cityText.Location = new System.Drawing.Point(36, 0);
            this.cityText.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(66, 30);
            this.cityText.TabIndex = 3;
            this.cityText.Text = "Baku";
            this.cityText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleIcon
            // 
            this.titleIcon.BackColor = System.Drawing.Color.Transparent;
            this.titleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titleIcon.BaseColor = System.Drawing.Color.White;
            this.titleIcon.Image = global::CityTime.Properties.Resources.icons8_azerbaijan_64;
            this.titleIcon.Location = new System.Drawing.Point(0, 0);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(30, 30);
            this.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleIcon.TabIndex = 2;
            this.titleIcon.TabStop = false;
            // 
            // minBox
            // 
            this.minBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBox.AnimationHoverSpeed = 0.07F;
            this.minBox.AnimationSpeed = 0.03F;
            this.minBox.BackColor = System.Drawing.Color.Transparent;
            this.minBox.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.minBox.IconColor = System.Drawing.Color.White;
            this.minBox.IconSize = 15F;
            this.minBox.Location = new System.Drawing.Point(460, 0);
            this.minBox.Name = "minBox";
            this.minBox.OnHoverBackColor = System.Drawing.SystemColors.ControlDark;
            this.minBox.OnHoverIconColor = System.Drawing.Color.White;
            this.minBox.OnPressedColor = System.Drawing.Color.Black;
            this.minBox.Size = new System.Drawing.Size(45, 30);
            this.minBox.TabIndex = 1;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.AnimationHoverSpeed = 0.07F;
            this.closeBox.AnimationSpeed = 0.03F;
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.IconSize = 15F;
            this.closeBox.Location = new System.Drawing.Point(505, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.OnHoverBackColor = System.Drawing.Color.Red;
            this.closeBox.OnHoverIconColor = System.Drawing.Color.White;
            this.closeBox.OnPressedColor = System.Drawing.Color.Black;
            this.closeBox.Size = new System.Drawing.Size(45, 30);
            this.closeBox.TabIndex = 0;
            // 
            // btnLondon
            // 
            this.btnLondon.Animated = true;
            this.btnLondon.AnimationHoverSpeed = 0.07F;
            this.btnLondon.AnimationSpeed = 0.03F;
            this.btnLondon.BackColor = System.Drawing.Color.Transparent;
            this.btnLondon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnLondon.BorderColor = System.Drawing.Color.Black;
            this.btnLondon.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLondon.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLondon.CheckedForeColor = System.Drawing.Color.White;
            this.btnLondon.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnLondon.CheckedImage")));
            this.btnLondon.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLondon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLondon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLondon.FocusedColor = System.Drawing.Color.Empty;
            this.btnLondon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLondon.ForeColor = System.Drawing.Color.Black;
            this.btnLondon.Image = global::CityTime.Properties.Resources.great_britain_96px;
            this.btnLondon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLondon.LineColor = System.Drawing.Color.Transparent;
            this.btnLondon.Location = new System.Drawing.Point(310, 340);
            this.btnLondon.Name = "btnLondon";
            this.btnLondon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnLondon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLondon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLondon.OnHoverImage = null;
            this.btnLondon.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLondon.OnPressedColor = System.Drawing.Color.Black;
            this.btnLondon.Radius = 10;
            this.btnLondon.Size = new System.Drawing.Size(80, 40);
            this.btnLondon.TabIndex = 0;
            this.btnLondon.Tag = "london";
            this.btnLondon.Text = "London";
            this.btnLondon.TextOffsetX = -7;
            this.btnLondon.Click += new System.EventHandler(this.btnLondon_Click);
            // 
            // btnBaku
            // 
            this.btnBaku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaku.Animated = true;
            this.btnBaku.AnimationHoverSpeed = 0.07F;
            this.btnBaku.AnimationSpeed = 0.03F;
            this.btnBaku.BackColor = System.Drawing.Color.Transparent;
            this.btnBaku.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.btnBaku.BorderColor = System.Drawing.Color.Black;
            this.btnBaku.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBaku.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBaku.CheckedForeColor = System.Drawing.Color.White;
            this.btnBaku.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBaku.CheckedImage")));
            this.btnBaku.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBaku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaku.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaku.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaku.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBaku.ForeColor = System.Drawing.Color.Black;
            this.btnBaku.Image = global::CityTime.Properties.Resources.azerbaijan_96px;
            this.btnBaku.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBaku.LineColor = System.Drawing.Color.Transparent;
            this.btnBaku.Location = new System.Drawing.Point(130, 340);
            this.btnBaku.Name = "btnBaku";
            this.btnBaku.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.btnBaku.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBaku.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBaku.OnHoverImage = null;
            this.btnBaku.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnBaku.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaku.Radius = 10;
            this.btnBaku.Size = new System.Drawing.Size(80, 40);
            this.btnBaku.TabIndex = 0;
            this.btnBaku.Tag = "baku";
            this.btnBaku.Text = "Baku";
            this.btnBaku.UseTransfarantBackground = true;
            this.btnBaku.Click += new System.EventHandler(this.btnBaku_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 90);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(526, 50);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "lblTime";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBaku
            // 
            this.timerBaku.Enabled = true;
            this.timerBaku.Interval = 1000;
            this.timerBaku.Tick += new System.EventHandler(this.timerBaku_Tick);
            // 
            // timerLondon
            // 
            this.timerLondon.Enabled = true;
            this.timerLondon.Interval = 1000;
            this.timerLondon.Tick += new System.EventHandler(this.timerLondon_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CityTime.Properties.Resources.baku_small;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.btnLondon);
            this.Controls.Add(this.btnBaku);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaControlBox closeBox;
        private Guna.UI.WinForms.GunaDragControl dragControl;
        private Guna.UI.WinForms.GunaControlBox minBox;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaku;
        private Guna.UI.WinForms.GunaAdvenceButton btnLondon;
        private Guna.UI.WinForms.GunaPanel titleBar;
        private Guna.UI.WinForms.GunaPictureBox titleIcon;
        private Guna.UI.WinForms.GunaLabel cityText;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private System.Windows.Forms.Timer timerBaku;
        private System.Windows.Forms.Timer timerLondon;
    }
}

