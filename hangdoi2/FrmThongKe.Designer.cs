namespace hangdoi2
{
    partial class FrmThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DgvTopDV = new Sunny.UI.UIDataGridView();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtStarDate = new System.Windows.Forms.DateTimePicker();
            this.Chart1 = new Sunny.UI.UIBarChart();
            this.btnCustomDate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiDoughnutChart1 = new Sunny.UI.UIDoughnutChart();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTopDV)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvTopDV
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DgvTopDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvTopDV.BackgroundColor = System.Drawing.Color.White;
            this.DgvTopDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTopDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvTopDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTopDV.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvTopDV.EnableHeadersVisualStyles = false;
            this.DgvTopDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvTopDV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DgvTopDV.Location = new System.Drawing.Point(12, 19);
            this.DgvTopDV.Name = "DgvTopDV";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTopDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvTopDV.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvTopDV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvTopDV.RowTemplate.Height = 24;
            this.DgvTopDV.SelectedIndex = -1;
            this.DgvTopDV.Size = new System.Drawing.Size(240, 150);
            this.DgvTopDV.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.DgvTopDV.TabIndex = 175;
            this.DgvTopDV.UseWaitCursor = true;
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.Location = new System.Drawing.Point(602, 5);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(35, 35);
            this.btnOkCustomDate.TabIndex = 173;
            this.btnOkCustomDate.Text = "Ok";
            this.btnOkCustomDate.UseVisualStyleBackColor = true;
            this.btnOkCustomDate.UseWaitCursor = true;
            this.btnOkCustomDate.Visible = false;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(718, 5);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(130, 35);
            this.btnToday.TabIndex = 172;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.UseWaitCursor = true;
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.Location = new System.Drawing.Point(849, 5);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast7Days.TabIndex = 171;
            this.btnLast7Days.Text = "Lasta 7 days";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.UseWaitCursor = true;
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.Location = new System.Drawing.Point(980, 5);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(130, 35);
            this.btnLast30Days.TabIndex = 170;
            this.btnLast30Days.Text = "Last 30 days";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.UseWaitCursor = true;
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(1111, 5);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(130, 35);
            this.btnThisMonth.TabIndex = 169;
            this.btnThisMonth.Text = "This month";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.UseWaitCursor = true;
            // 
            // txtEndDate
            // 
            this.txtEndDate.CustomFormat = "MMM dd, yyyy";
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtEndDate.Location = new System.Drawing.Point(468, 13);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(122, 23);
            this.txtEndDate.TabIndex = 168;
            this.txtEndDate.UseWaitCursor = true;
            // 
            // txtStarDate
            // 
            this.txtStarDate.CustomFormat = "MMM dd, yyyy";
            this.txtStarDate.Enabled = false;
            this.txtStarDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStarDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStarDate.Location = new System.Drawing.Point(322, 13);
            this.txtStarDate.Name = "txtStarDate";
            this.txtStarDate.Size = new System.Drawing.Size(122, 23);
            this.txtStarDate.TabIndex = 167;
            this.txtStarDate.UseWaitCursor = true;
            // 
            // Chart1
            // 
            this.Chart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Chart1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Chart1.Location = new System.Drawing.Point(306, 156);
            this.Chart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(400, 300);
            this.Chart1.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Chart1.TabIndex = 165;
            this.Chart1.Text = "Theo Tuần";
            this.Chart1.UseWaitCursor = true;
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.AllowAnimations = true;
            this.btnCustomDate.AllowMouseEffects = true;
            this.btnCustomDate.AllowToggling = false;
            this.btnCustomDate.AnimationSpeed = 200;
            this.btnCustomDate.AutoGenerateColors = false;
            this.btnCustomDate.AutoRoundBorders = false;
            this.btnCustomDate.AutoSizeLeftIcon = true;
            this.btnCustomDate.AutoSizeRightIcon = true;
            this.btnCustomDate.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomDate.BackColor1 = System.Drawing.Color.Transparent;
            this.btnCustomDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomDate.BackgroundImage")));
            this.btnCustomDate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomDate.ButtonText = "Custom";
            this.btnCustomDate.ButtonTextMarginLeft = 0;
            this.btnCustomDate.ColorContrastOnClick = 45;
            this.btnCustomDate.ColorContrastOnHover = 45;
            this.btnCustomDate.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCustomDate.CustomizableEdges = borderEdges2;
            this.btnCustomDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomDate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomDate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomDate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomDate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCustomDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomDate.ForeColor = System.Drawing.Color.Black;
            this.btnCustomDate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomDate.IconLeftCursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCustomDate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCustomDate.IconMarginLeft = 11;
            this.btnCustomDate.IconPadding = 10;
            this.btnCustomDate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomDate.IconRightCursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCustomDate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCustomDate.IconSize = 25;
            this.btnCustomDate.IdleBorderColor = System.Drawing.Color.Black;
            this.btnCustomDate.IdleBorderRadius = 5;
            this.btnCustomDate.IdleBorderThickness = 1;
            this.btnCustomDate.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCustomDate.IdleIconLeftImage = null;
            this.btnCustomDate.IdleIconRightImage = null;
            this.btnCustomDate.IndicateFocus = false;
            this.btnCustomDate.Location = new System.Drawing.Point(209, 12);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomDate.OnDisabledState.BorderRadius = 5;
            this.btnCustomDate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomDate.OnDisabledState.BorderThickness = 1;
            this.btnCustomDate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomDate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomDate.OnDisabledState.IconLeftImage = null;
            this.btnCustomDate.OnDisabledState.IconRightImage = null;
            this.btnCustomDate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCustomDate.onHoverState.BorderRadius = 5;
            this.btnCustomDate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomDate.onHoverState.BorderThickness = 1;
            this.btnCustomDate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCustomDate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCustomDate.onHoverState.IconLeftImage = null;
            this.btnCustomDate.onHoverState.IconRightImage = null;
            this.btnCustomDate.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnCustomDate.OnIdleState.BorderRadius = 5;
            this.btnCustomDate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomDate.OnIdleState.BorderThickness = 1;
            this.btnCustomDate.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomDate.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomDate.OnIdleState.IconLeftImage = null;
            this.btnCustomDate.OnIdleState.IconRightImage = null;
            this.btnCustomDate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCustomDate.OnPressedState.BorderRadius = 5;
            this.btnCustomDate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomDate.OnPressedState.BorderThickness = 1;
            this.btnCustomDate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCustomDate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCustomDate.OnPressedState.IconLeftImage = null;
            this.btnCustomDate.OnPressedState.IconRightImage = null;
            this.btnCustomDate.Size = new System.Drawing.Size(107, 24);
            this.btnCustomDate.TabIndex = 174;
            this.btnCustomDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustomDate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCustomDate.TextMarginLeft = 0;
            this.btnCustomDate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCustomDate.UseDefaultRadiusAndThickness = true;
            this.btnCustomDate.UseWaitCursor = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.DgvTopDV);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 462);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1340, 337);
            this.bunifuPanel1.TabIndex = 176;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(23, 14);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Radius = 8;
            this.uiComboBox1.RectColor = System.Drawing.Color.DimGray;
            this.uiComboBox1.Size = new System.Drawing.Size(150, 27);
            this.uiComboBox1.TabIndex = 177;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiDoughnutChart1
            // 
            this.uiDoughnutChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDoughnutChart1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiDoughnutChart1.Location = new System.Drawing.Point(810, 136);
            this.uiDoughnutChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDoughnutChart1.Name = "uiDoughnutChart1";
            this.uiDoughnutChart1.Size = new System.Drawing.Size(400, 300);
            this.uiDoughnutChart1.SubFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiDoughnutChart1.TabIndex = 178;
            this.uiDoughnutChart1.Text = "uiDoughnutChart1";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 799);
            this.Controls.Add(this.uiDoughnutChart1);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStarDate);
            this.Controls.Add(this.btnCustomDate);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTopDV)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView DgvTopDV;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.DateTimePicker txtStarDate;
        private Sunny.UI.UIBarChart Chart1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCustomDate;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIDoughnutChart uiDoughnutChart1;
    }
}