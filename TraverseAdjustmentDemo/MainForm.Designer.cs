namespace TraverseAdjustmentDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Link_AddData = new System.Windows.Forms.LinkLabel();
            this.Btu_Exit = new System.Windows.Forms.Button();
            this.Btu_ToExcel = new System.Windows.Forms.Button();
            this.Btu_FloatView = new System.Windows.Forms.Button();
            this.Btu_FloatXY = new System.Windows.Forms.Button();
            this.Btu_CalcultorLine = new System.Windows.Forms.Button();
            this.Btu_CalcultorXY = new System.Windows.Forms.Button();
            this.Btu_ViewData = new System.Windows.Forms.Button();
            this.Btu_PointNum = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_PointNum = new System.Windows.Forms.Panel();
            this.Btu_Point_Submit = new System.Windows.Forms.Button();
            this.textBox_PointNum = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel_Img = new System.Windows.Forms.Panel();
            this.panel_ViewImg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ResultData = new System.Windows.Forms.Panel();
            this.dataGridView_ResultData = new System.Windows.Forms.DataGridView();
            this.Result_PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_ViewAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_ViewAngleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_CorViewAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_DirectionAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_ViewLineLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_DxNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_DyNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_CorDx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_CorDy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_Coordinate_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_Coordinate_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ViewData = new System.Windows.Forms.Panel();
            this.dataGridView_ViewData = new System.Windows.Forms.DataGridView();
            this.View_PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_ViewAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_DirectionAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_ViewLineLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_Coordinate_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_Coordinate_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_PointNum.SuspendLayout();
            this.panel_ViewImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ResultData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultData)).BeginInit();
            this.panel_ViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Link_AddData);
            this.panel1.Controls.Add(this.Btu_Exit);
            this.panel1.Controls.Add(this.Btu_ToExcel);
            this.panel1.Controls.Add(this.Btu_FloatView);
            this.panel1.Controls.Add(this.Btu_FloatXY);
            this.panel1.Controls.Add(this.Btu_CalcultorLine);
            this.panel1.Controls.Add(this.Btu_CalcultorXY);
            this.panel1.Controls.Add(this.Btu_ViewData);
            this.panel1.Controls.Add(this.Btu_PointNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.panel1.Size = new System.Drawing.Size(1290, 59);
            this.panel1.TabIndex = 0;
            // 
            // Link_AddData
            // 
            this.Link_AddData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Link_AddData.Dock = System.Windows.Forms.DockStyle.Right;
            this.Link_AddData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Link_AddData.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Link_AddData.Location = new System.Drawing.Point(1150, 5);
            this.Link_AddData.Name = "Link_AddData";
            this.Link_AddData.Size = new System.Drawing.Size(110, 49);
            this.Link_AddData.TabIndex = 8;
            this.Link_AddData.TabStop = true;
            this.Link_AddData.Text = "导入数据";
            this.Link_AddData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Link_AddData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_AddData_LinkClicked);
            // 
            // Btu_Exit
            // 
            this.Btu_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_Exit.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btu_Exit.Location = new System.Drawing.Point(923, 5);
            this.Btu_Exit.Name = "Btu_Exit";
            this.Btu_Exit.Size = new System.Drawing.Size(129, 49);
            this.Btu_Exit.TabIndex = 7;
            this.Btu_Exit.TabStop = false;
            this.Btu_Exit.Text = "退出程序";
            this.Btu_Exit.UseVisualStyleBackColor = true;
            // 
            // Btu_ToExcel
            // 
            this.Btu_ToExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_ToExcel.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_ToExcel.Location = new System.Drawing.Point(794, 5);
            this.Btu_ToExcel.Name = "Btu_ToExcel";
            this.Btu_ToExcel.Size = new System.Drawing.Size(129, 49);
            this.Btu_ToExcel.TabIndex = 6;
            this.Btu_ToExcel.TabStop = false;
            this.Btu_ToExcel.Text = "导出Excel";
            this.Btu_ToExcel.UseVisualStyleBackColor = true;
            this.Btu_ToExcel.Click += new System.EventHandler(this.Btu_ToExcel_Click);
            // 
            // Btu_FloatView
            // 
            this.Btu_FloatView.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_FloatView.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_FloatView.Location = new System.Drawing.Point(665, 5);
            this.Btu_FloatView.Name = "Btu_FloatView";
            this.Btu_FloatView.Size = new System.Drawing.Size(129, 49);
            this.Btu_FloatView.TabIndex = 5;
            this.Btu_FloatView.TabStop = false;
            this.Btu_FloatView.Text = "平面图形";
            this.Btu_FloatView.UseVisualStyleBackColor = true;
            this.Btu_FloatView.Click += new System.EventHandler(this.Btu_FloatView_Click);
            // 
            // Btu_FloatXY
            // 
            this.Btu_FloatXY.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_FloatXY.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_FloatXY.Location = new System.Drawing.Point(536, 5);
            this.Btu_FloatXY.Name = "Btu_FloatXY";
            this.Btu_FloatXY.Size = new System.Drawing.Size(129, 49);
            this.Btu_FloatXY.TabIndex = 4;
            this.Btu_FloatXY.TabStop = false;
            this.Btu_FloatXY.Text = "平面坐标系";
            this.Btu_FloatXY.UseVisualStyleBackColor = true;
            // 
            // Btu_CalcultorLine
            // 
            this.Btu_CalcultorLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_CalcultorLine.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_CalcultorLine.Location = new System.Drawing.Point(407, 5);
            this.Btu_CalcultorLine.Name = "Btu_CalcultorLine";
            this.Btu_CalcultorLine.Size = new System.Drawing.Size(129, 49);
            this.Btu_CalcultorLine.TabIndex = 3;
            this.Btu_CalcultorLine.TabStop = false;
            this.Btu_CalcultorLine.Text = "导线计算表";
            this.Btu_CalcultorLine.UseVisualStyleBackColor = true;
            this.Btu_CalcultorLine.Click += new System.EventHandler(this.Btu_CalcultorLine_Click);
            // 
            // Btu_CalcultorXY
            // 
            this.Btu_CalcultorXY.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_CalcultorXY.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_CalcultorXY.Location = new System.Drawing.Point(278, 5);
            this.Btu_CalcultorXY.Name = "Btu_CalcultorXY";
            this.Btu_CalcultorXY.Size = new System.Drawing.Size(129, 49);
            this.Btu_CalcultorXY.TabIndex = 2;
            this.Btu_CalcultorXY.TabStop = false;
            this.Btu_CalcultorXY.Text = "计算坐标";
            this.Btu_CalcultorXY.UseVisualStyleBackColor = true;
            this.Btu_CalcultorXY.Click += new System.EventHandler(this.Btu_CalcultorXY_Click);
            // 
            // Btu_ViewData
            // 
            this.Btu_ViewData.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_ViewData.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_ViewData.Location = new System.Drawing.Point(149, 5);
            this.Btu_ViewData.Name = "Btu_ViewData";
            this.Btu_ViewData.Size = new System.Drawing.Size(129, 49);
            this.Btu_ViewData.TabIndex = 1;
            this.Btu_ViewData.TabStop = false;
            this.Btu_ViewData.Text = "观测数据";
            this.Btu_ViewData.UseVisualStyleBackColor = true;
            this.Btu_ViewData.Click += new System.EventHandler(this.Btu_ViewData_Click);
            // 
            // Btu_PointNum
            // 
            this.Btu_PointNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btu_PointNum.Enabled = false;
            this.Btu_PointNum.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_PointNum.Location = new System.Drawing.Point(20, 5);
            this.Btu_PointNum.Name = "Btu_PointNum";
            this.Btu_PointNum.Size = new System.Drawing.Size(129, 49);
            this.Btu_PointNum.TabIndex = 0;
            this.Btu_PointNum.TabStop = false;
            this.Btu_PointNum.Text = "计算内容";
            this.Btu_PointNum.UseVisualStyleBackColor = true;
            this.Btu_PointNum.Click += new System.EventHandler(this.Btu_PointNum_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_PointNum);
            this.panel2.Controls.Add(this.panel_Img);
            this.panel2.Controls.Add(this.panel_ViewImg);
            this.panel2.Controls.Add(this.panel_ViewData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 630);
            this.panel2.TabIndex = 1;
            // 
            // panel_PointNum
            // 
            this.panel_PointNum.Controls.Add(this.Btu_Point_Submit);
            this.panel_PointNum.Controls.Add(this.textBox_PointNum);
            this.panel_PointNum.Controls.Add(this.label);
            this.panel_PointNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_PointNum.Location = new System.Drawing.Point(0, 0);
            this.panel_PointNum.Name = "panel_PointNum";
            this.panel_PointNum.Size = new System.Drawing.Size(1290, 630);
            this.panel_PointNum.TabIndex = 4;
            this.panel_PointNum.Visible = false;
            // 
            // Btu_Point_Submit
            // 
            this.Btu_Point_Submit.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.Btu_Point_Submit.Location = new System.Drawing.Point(432, 118);
            this.Btu_Point_Submit.Name = "Btu_Point_Submit";
            this.Btu_Point_Submit.Size = new System.Drawing.Size(94, 31);
            this.Btu_Point_Submit.TabIndex = 2;
            this.Btu_Point_Submit.Text = "确 认";
            this.Btu_Point_Submit.UseVisualStyleBackColor = true;
            this.Btu_Point_Submit.Click += new System.EventHandler(this.Btu_Point_Submit_Click);
            // 
            // textBox_PointNum
            // 
            this.textBox_PointNum.Location = new System.Drawing.Point(221, 121);
            this.textBox_PointNum.Name = "textBox_PointNum";
            this.textBox_PointNum.Size = new System.Drawing.Size(171, 25);
            this.textBox_PointNum.TabIndex = 1;
            this.textBox_PointNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label.Location = new System.Drawing.Point(33, 118);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 31);
            this.label.TabIndex = 0;
            this.label.Text = "计算的点数：";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Img
            // 
            this.panel_Img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Img.BackgroundImage")));
            this.panel_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Img.Location = new System.Drawing.Point(0, 0);
            this.panel_Img.Name = "panel_Img";
            this.panel_Img.Size = new System.Drawing.Size(1290, 630);
            this.panel_Img.TabIndex = 0;
            // 
            // panel_ViewImg
            // 
            this.panel_ViewImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_ViewImg.BackgroundImage")));
            this.panel_ViewImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ViewImg.Controls.Add(this.pictureBox1);
            this.panel_ViewImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ViewImg.Location = new System.Drawing.Point(0, 0);
            this.panel_ViewImg.Name = "panel_ViewImg";
            this.panel_ViewImg.Size = new System.Drawing.Size(1290, 630);
            this.panel_ViewImg.TabIndex = 5;
            this.panel_ViewImg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1290, 630);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_ResultData
            // 
            this.panel_ResultData.Controls.Add(this.dataGridView_ResultData);
            this.panel_ResultData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ResultData.Location = new System.Drawing.Point(0, 87);
            this.panel_ResultData.Name = "panel_ResultData";
            this.panel_ResultData.Size = new System.Drawing.Size(1290, 630);
            this.panel_ResultData.TabIndex = 3;
            this.panel_ResultData.Visible = false;
            // 
            // dataGridView_ResultData
            // 
            this.dataGridView_ResultData.AllowUserToAddRows = false;
            this.dataGridView_ResultData.AllowUserToDeleteRows = false;
            this.dataGridView_ResultData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ResultData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Result_PointName,
            this.Result_ViewAngle,
            this.Result_ViewAngleNo,
            this.Result_CorViewAngle,
            this.Result_DirectionAngle,
            this.Result_ViewLineLong,
            this.Result_DxNo,
            this.Result_DyNo,
            this.Result_CorDx,
            this.Result_CorDy,
            this.Result_Coordinate_X,
            this.Result_Coordinate_Y});
            this.dataGridView_ResultData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ResultData.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ResultData.Name = "dataGridView_ResultData";
            this.dataGridView_ResultData.ReadOnly = true;
            this.dataGridView_ResultData.RowTemplate.Height = 27;
            this.dataGridView_ResultData.Size = new System.Drawing.Size(1290, 630);
            this.dataGridView_ResultData.TabIndex = 1;
            // 
            // Result_PointName
            // 
            this.Result_PointName.HeaderText = "点号";
            this.Result_PointName.Name = "Result_PointName";
            this.Result_PointName.ReadOnly = true;
            this.Result_PointName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_ViewAngle
            // 
            this.Result_ViewAngle.HeaderText = "观测角值";
            this.Result_ViewAngle.Name = "Result_ViewAngle";
            this.Result_ViewAngle.ReadOnly = true;
            this.Result_ViewAngle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_ViewAngleNo
            // 
            this.Result_ViewAngleNo.HeaderText = "观测角改正数";
            this.Result_ViewAngleNo.Name = "Result_ViewAngleNo";
            this.Result_ViewAngleNo.ReadOnly = true;
            this.Result_ViewAngleNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_CorViewAngle
            // 
            this.Result_CorViewAngle.HeaderText = "改正后的角值";
            this.Result_CorViewAngle.Name = "Result_CorViewAngle";
            this.Result_CorViewAngle.ReadOnly = true;
            this.Result_CorViewAngle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_DirectionAngle
            // 
            this.Result_DirectionAngle.HeaderText = "坐标方向角";
            this.Result_DirectionAngle.Name = "Result_DirectionAngle";
            this.Result_DirectionAngle.ReadOnly = true;
            this.Result_DirectionAngle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_ViewLineLong
            // 
            this.Result_ViewLineLong.HeaderText = "观测边长";
            this.Result_ViewLineLong.Name = "Result_ViewLineLong";
            this.Result_ViewLineLong.ReadOnly = true;
            this.Result_ViewLineLong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_DxNo
            // 
            this.Result_DxNo.HeaderText = "改正前△X值/m";
            this.Result_DxNo.Name = "Result_DxNo";
            this.Result_DxNo.ReadOnly = true;
            this.Result_DxNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_DyNo
            // 
            this.Result_DyNo.HeaderText = "改正前△Y值/m";
            this.Result_DyNo.Name = "Result_DyNo";
            this.Result_DyNo.ReadOnly = true;
            this.Result_DyNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_CorDx
            // 
            this.Result_CorDx.HeaderText = "改正后△X值/m";
            this.Result_CorDx.Name = "Result_CorDx";
            this.Result_CorDx.ReadOnly = true;
            this.Result_CorDx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_CorDy
            // 
            this.Result_CorDy.HeaderText = "改正后△Y值/m";
            this.Result_CorDy.Name = "Result_CorDy";
            this.Result_CorDy.ReadOnly = true;
            this.Result_CorDy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_Coordinate_X
            // 
            this.Result_Coordinate_X.HeaderText = "X(m)";
            this.Result_Coordinate_X.Name = "Result_Coordinate_X";
            this.Result_Coordinate_X.ReadOnly = true;
            this.Result_Coordinate_X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result_Coordinate_Y
            // 
            this.Result_Coordinate_Y.HeaderText = "Y(m)";
            this.Result_Coordinate_Y.Name = "Result_Coordinate_Y";
            this.Result_Coordinate_Y.ReadOnly = true;
            this.Result_Coordinate_Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel_ViewData
            // 
            this.panel_ViewData.Controls.Add(this.dataGridView_ViewData);
            this.panel_ViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ViewData.Location = new System.Drawing.Point(0, 0);
            this.panel_ViewData.Name = "panel_ViewData";
            this.panel_ViewData.Size = new System.Drawing.Size(1290, 630);
            this.panel_ViewData.TabIndex = 1;
            this.panel_ViewData.Visible = false;
            // 
            // dataGridView_ViewData
            // 
            this.dataGridView_ViewData.AllowUserToAddRows = false;
            this.dataGridView_ViewData.AllowUserToDeleteRows = false;
            this.dataGridView_ViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View_PointName,
            this.View_ViewAngle,
            this.View_DirectionAngle,
            this.View_ViewLineLong,
            this.View_Coordinate_X,
            this.View_Coordinate_Y});
            this.dataGridView_ViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ViewData.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ViewData.Name = "dataGridView_ViewData";
            this.dataGridView_ViewData.ReadOnly = true;
            this.dataGridView_ViewData.RowTemplate.Height = 27;
            this.dataGridView_ViewData.Size = new System.Drawing.Size(1290, 630);
            this.dataGridView_ViewData.TabIndex = 0;
            // 
            // View_PointName
            // 
            this.View_PointName.HeaderText = "点号";
            this.View_PointName.Name = "View_PointName";
            this.View_PointName.ReadOnly = true;
            this.View_PointName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // View_ViewAngle
            // 
            this.View_ViewAngle.HeaderText = "观测角值";
            this.View_ViewAngle.Name = "View_ViewAngle";
            this.View_ViewAngle.ReadOnly = true;
            this.View_ViewAngle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // View_DirectionAngle
            // 
            this.View_DirectionAngle.HeaderText = "方向角";
            this.View_DirectionAngle.Name = "View_DirectionAngle";
            this.View_DirectionAngle.ReadOnly = true;
            this.View_DirectionAngle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // View_ViewLineLong
            // 
            this.View_ViewLineLong.HeaderText = "观测边长";
            this.View_ViewLineLong.Name = "View_ViewLineLong";
            this.View_ViewLineLong.ReadOnly = true;
            this.View_ViewLineLong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // View_Coordinate_X
            // 
            this.View_Coordinate_X.HeaderText = "X(m)";
            this.View_Coordinate_X.Name = "View_Coordinate_X";
            this.View_Coordinate_X.ReadOnly = true;
            this.View_Coordinate_X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // View_Coordinate_Y
            // 
            this.View_Coordinate_Y.HeaderText = "Y(m)";
            this.View_Coordinate_Y.Name = "View_Coordinate_Y";
            this.View_Coordinate_Y.ReadOnly = true;
            this.View_Coordinate_Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.计算ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.图形ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.计算ToolStripMenuItem.Text = "计算";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 图形ToolStripMenuItem
            // 
            this.图形ToolStripMenuItem.Name = "图形ToolStripMenuItem";
            this.图形ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.图形ToolStripMenuItem.Text = "图形";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 717);
            this.Controls.Add(this.panel_ResultData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "导线平差";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_PointNum.ResumeLayout(false);
            this.panel_PointNum.PerformLayout();
            this.panel_ViewImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ResultData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ResultData)).EndInit();
            this.panel_ViewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViewData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btu_Exit;
        private System.Windows.Forms.Button Btu_ToExcel;
        private System.Windows.Forms.Button Btu_FloatView;
        private System.Windows.Forms.Button Btu_FloatXY;
        private System.Windows.Forms.Button Btu_CalcultorLine;
        private System.Windows.Forms.Button Btu_CalcultorXY;
        private System.Windows.Forms.Button Btu_ViewData;
        private System.Windows.Forms.Button Btu_PointNum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.LinkLabel Link_AddData;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Panel panel_ResultData;
        private System.Windows.Forms.Panel panel_ViewData;
        private System.Windows.Forms.DataGridView dataGridView_ViewData;
        private System.Windows.Forms.Panel panel_Img;
        private System.Windows.Forms.Panel panel_PointNum;
        private System.Windows.Forms.Button Btu_Point_Submit;
        private System.Windows.Forms.TextBox textBox_PointNum;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridViewTextBoxColumn View_PointName;
        private System.Windows.Forms.DataGridViewTextBoxColumn View_ViewAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn View_DirectionAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn View_ViewLineLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn View_Coordinate_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn View_Coordinate_Y;
        private System.Windows.Forms.DataGridView dataGridView_ResultData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_PointName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_ViewAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_ViewAngleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_CorViewAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_DirectionAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_ViewLineLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_DxNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_DyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_CorDx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_CorDy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_Coordinate_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result_Coordinate_Y;
        private System.Windows.Forms.Panel panel_ViewImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

