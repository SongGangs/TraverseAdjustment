using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraverseAdjustmentDemo.Common;
using TraverseAdjustmentDemo.Helper;

namespace TraverseAdjustmentDemo
{
    public partial class MainForm : Form
    {
        private int m_PointNum = 0;
        private List<CPoint> Plist = null;
        private List<CLine> Llist = null;

        private int m_Type = 1; //1表示附和导线计算 2表示闭合导线计算

        
        public int Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }

        //基本画图
        private Bitmap bitmap ;
        private Graphics graphics;

        private Pen pen;
        private Font font;
        private Brush brush;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算内容点击事件 添加点数
        /// 出现此页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_PointNum_Click(object sender, EventArgs e)
        {
            if (!panel_PointNum.Visible)
            {
                panel_ViewImg.Visible = panel_PointNum.Visible;
                panel_ResultData.Visible = panel_PointNum.Visible;
                panel_Img.Visible = panel_PointNum.Visible;
                panel_ViewData.Visible = panel_PointNum.Visible;
                panel_PointNum.Visible = !panel_PointNum.Visible;
            }
            this.textBox_PointNum.Text = m_PointNum.ToString();
        }

        /// <summary>
        /// 观测数据点击事件 添加观测数据
        /// 出现此页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_ViewData_Click(object sender, EventArgs e)
        {
            if (!panel_ViewData.Visible)
            {
                panel_Img.Visible = panel_ViewData.Visible;
                panel_PointNum.Visible = panel_ViewData.Visible;
                panel_ViewImg.Visible = panel_ViewData.Visible;
                panel_ResultData.Visible = panel_ViewData.Visible;
                panel_ViewData.Visible = !panel_ViewData.Visible;
            }
        }

        /// <summary>
        /// 向观测数据中的Datagridview导入文件中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Link_AddData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Llist=new List<CLine>();Plist=new List<CPoint>();
                if (CReadFile.GetDataFromFile(fileDialog.FileName.Trim(), m_Type, ref Plist, ref Llist, ref m_PointNum))
                {
                    if (Plist != null && Llist != null)
                    {
                        if (m_Type == 1)
                        {
                            dataGridView_ViewData.Rows.Clear();
                            dataGridView_ViewData.Rows.Add((m_PointNum + 4)*2 - 1);
                            dataGridView_ViewData.Rows[0].Cells["View_PointName"].Value = "方向点";
                            dataGridView_ViewData.Rows[dataGridView_ViewData.RowCount - 1].Cells["View_PointName"].Value
                                =
                                "方向点";
                            dataGridView_ViewData.Rows[1].Cells["View_DirectionAngle"].Value = Llist[0].Angel;
                            dataGridView_ViewData.Rows[dataGridView_ViewData.RowCount - 2].Cells["View_DirectionAngle"]
                                .Value =
                                Llist[Llist.Count - 1].Angel;

                            for (int i = 0; i < Plist.Count; i++)
                            {
                                dataGridView_ViewData.Rows[(i + 1)*2].Cells["View_PointName"].Value = Plist[i].PointName;
                                dataGridView_ViewData.Rows[(i + 1)*2].Cells["View_ViewAngle"].Value = Plist[i].Angel;
                                if (i == 0 || i == Plist.Count - 1)
                                {
                                    dataGridView_ViewData.Rows[(i + 1)*2].Cells["View_Coordinate_X"].Value =
                                        Plist[i].CorX;
                                    dataGridView_ViewData.Rows[(i + 1)*2].Cells["View_Coordinate_Y"].Value =
                                        Plist[i].CorY;
                                }
                            }
                            for (int i = 1; i < Llist.Count - 1; i++)
                            {
                                dataGridView_ViewData.Rows[2*i+1].Cells["View_ViewLineLong"].Value = Llist[i].Distance;
                            }


                            foreach (DataGridViewRow VARIABLE in this.dataGridView_ViewData.Rows)
                            {
                                for (int i = 0; i < this.dataGridView_ViewData.ColumnCount; i++)
                                {
                                    if (VARIABLE.Cells[i].Value == null)
                                    {
                                        VARIABLE.Cells[i].Style.BackColor = Color.Gray;
                                    }
                                }
                            }
                        }
                        else if (m_Type == 2)
                        {
                            dataGridView_ViewData.Rows.Clear();
                            dataGridView_ViewData.Rows.Add((m_PointNum + 3)*2 - 1);
                            dataGridView_ViewData.Rows[1].Cells["View_DirectionAngle"].Value = Llist[0].Angel;
                            

                            for (int i = 0; i < Plist.Count; i++)
                            {
                                dataGridView_ViewData.Rows[i*2].Cells["View_PointName"].Value = Plist[i].PointName;
                                dataGridView_ViewData.Rows[i*2].Cells["View_ViewAngle"].Value = Plist[i].Angel;
                                if (i == 0 || i == Plist.Count - 1)
                                {
                                    dataGridView_ViewData.Rows[i*2].Cells["View_Coordinate_X"].Value = Plist[i].CorX;
                                    dataGridView_ViewData.Rows[i*2].Cells["View_Coordinate_Y"].Value = Plist[i].CorY;
                                }
                            }
                            for (int i = 1; i < Llist.Count; i++)
                            {
                                dataGridView_ViewData.Rows[2*i + 1].Cells["View_ViewLineLong"].Value = Llist[i].Distance;
                            }


                            dataGridView_ViewData.Rows[dataGridView_ViewData.RowCount - 1].Cells["View_PointName"].Value
                                =
                                Plist[2].PointName;

                            foreach (DataGridViewRow VARIABLE in this.dataGridView_ViewData.Rows)
                            {
                                for (int i = 0; i < this.dataGridView_ViewData.ColumnCount; i++)
                                {
                                    if (VARIABLE.Cells[i].Value == null)
                                    {
                                        VARIABLE.Cells[i].Style.BackColor = Color.Gray;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /*
        private void Link_AddData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView_ViewData.Rows.Clear();

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[0].Cells["PointName"].Value = "方向点";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[1].Cells["DirectionAngle"].Value = "237°59′30″";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[2].Cells["PointName"].Value = "起点";
            dataGridView_ViewData.Rows[2].Cells["ViewAngle"].Value = "99°01′00″";
            dataGridView_ViewData.Rows[2].Cells["Coordinate_X"].Value = "2507.690";
            dataGridView_ViewData.Rows[2].Cells["Coordinate_Y"].Value = "1215.630";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[3].Cells["ViewLineLong"].Value = "225.850";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[4].Cells["PointName"].Value = "未知点1";
            dataGridView_ViewData.Rows[4].Cells["ViewAngle"].Value = "167°45′36″";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[5].Cells["ViewLineLong"].Value = "139.030";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[6].Cells["PointName"].Value = "未知点2";
            dataGridView_ViewData.Rows[6].Cells["ViewAngle"].Value = "123°11′24″";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[7].Cells["ViewLineLong"].Value = "172.570";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[8].Cells["PointName"].Value = "未知点3";
            dataGridView_ViewData.Rows[8].Cells["ViewAngle"].Value = "189°20′36″";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[9].Cells["ViewLineLong"].Value = "100.070";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[10].Cells["PointName"].Value = "未知点4";
            dataGridView_ViewData.Rows[10].Cells["ViewAngle"].Value = "179°59′18″";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[11].Cells["ViewLineLong"].Value = "102.480";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[12].Cells["PointName"].Value = "终点";
            dataGridView_ViewData.Rows[12].Cells["ViewAngle"].Value = "129°27′24″";
            dataGridView_ViewData.Rows[12].Cells["Coordinate_X"].Value = "2166.720";
            dataGridView_ViewData.Rows[12].Cells["Coordinate_Y"].Value = "1757.290";

            dataGridView_ViewData.Rows.Add();
            dataGridView_ViewData.Rows[13].Cells["ViewLineLong"].Value = "46°45′30″";

            foreach (DataGridViewRow VARIABLE in this.dataGridView_ViewData.Rows)
            {
                for (int i = 0; i < this.dataGridView_ViewData.ColumnCount; i++)
                {
                    if (VARIABLE.Cells[i].Value == null)
                    {
                        VARIABLE.Cells[i].Style.BackColor = Color.Gray;
                    }
                }
            }
        }
        */

        /// <summary>
        /// 点数的确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_Point_Submit_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(this.textBox_PointNum.Text.Trim()) > 0 &&
                Int32.Parse(this.textBox_PointNum.Text.Trim()) < 10000)
            {
                m_PointNum = Int32.Parse(this.textBox_PointNum.Text.Trim());
            }
            else
            {
                MessageBox.Show("请检查输入的点数是否为正整数！");
            }
        }

        /// <summary>
        /// 暂时测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_ToExcel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 计算坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_CalcultorXY_Click(object sender, EventArgs e)
        {
            try
            {
                if (Plist != null && Llist != null)
                {
                    if (m_Type==1)
                    {
                        string[] ang = new string[Plist.Count];
                        for (int i = 0; i < Plist.Count; i++)
                        {
                            ang[i] = Plist[i].Angel;

                        }
                        //观测角的改正值
                        string everyAng = CCalculator.CorrectDirAngle(
                            CCalculator.SumTheoDirAngle(Llist[0].Angel, Llist[Llist.Count - 1].Angel, m_PointNum),
                            CCalculator.SumFactDirAngle(ang), m_PointNum);
                        //观测角的改正后的值
                        for (int i = 0; i < Plist.Count; i++)
                        {
                            Plist[i].CorAngel = CCalculator.SubAngle(Plist[i].Angel, everyAng);
                        }
                        //坐标方位角=上一个坐标方位角+这个点的观测角改正值-180°；
                        for (int i = 0; i < Plist.Count; i++)
                        {
                            Llist[i + 1].Angel =
                                CCalculator.SubAngle(CCalculator.SumAngle(Llist[i].Angel, Plist[i].CorAngel),
                                    "180 00 00");
                        }
                        //坐标增量 未改正前
                        double dx = 0, dy = 0;
                        for (int i = 1; i < Llist.Count - 1; i++)
                        {
                            double x = 0, y = 0;
                            CCalculator.GetXY(Llist[i].Angel, Llist[i].Distance, ref x, ref y);
                            Llist[i].Dx = x;
                            Llist[i].Dy = y;
                            dx += x;
                            dy += y;
                        }
                        double allDx = dx - (Plist[Plist.Count - 1].CorX - Plist[0].CorX);
                        double allDy = dy - (Plist[Plist.Count - 1].CorY - Plist[0].CorY);

                        //坐标改正 
                        for (int i = 1; i < Llist.Count - 1; i++)
                        {
                            Llist[i].CorDx = Double.Parse((Llist[i].Dx + Llist[i].Dx * allDx / dx).ToString("0.00"));
                            Llist[i].CorDy = Double.Parse((Llist[i].Dy + Llist[i].Dy * allDy / dy).ToString("0.00"));
                            Plist[i].CorX = Plist[i - 1].CorX + Llist[i].CorDx;
                            Plist[i].CorY = Plist[i - 1].CorY + Llist[i].CorDy;
                        } 
                    }else if (m_Type==2)
                    {
                        string[] ang = new string[Plist.Count-1];
                        for (int i = 0; i < Plist.Count-1; i++)
                        {
                            ang[i] = Plist[i+1].Angel;

                        }
                        //观测角的改正值  闭合导线理论值(n-2)*180°
                        string everyAng = CCalculator.CorrectDirAngle(
                            CCalculator.SumTheoDirAngle("00 00 00", "00 00 00", m_PointNum-3),
                            CCalculator.SumFactDirAngle(ang), m_PointNum-1);
                        //观测角的改正后的值
                        for (int i = 1; i < Plist.Count; i++)
                        {
                            Plist[i].CorAngel = CCalculator.SubAngle(Plist[i].Angel, everyAng);
                        }
                        //坐标方位角=上一个坐标方位角-这个点的观测角改正值+180°；
                        for (int i = 1; i < Plist.Count-1; i++)
                        {
                            Llist[i ].Angel =
                                CCalculator.SumAngle(CCalculator.SubAngle(Llist[i - 1].Angel, Plist[i].CorAngel),
                                    "180 00 00");
                        }

                        //坐标增量 未改正前
                        double dx = 0, dy = 0;
                        for (int i = 0; i < Llist.Count ; i++)
                        {
                            double x = 0, y = 0;
                            CCalculator.GetXY(Llist[i].Angel, Llist[i].Distance, ref x, ref y);
                            Llist[i].Dx = Double.Parse(x.ToString("0.00"));
                            Llist[i].Dy = Double.Parse(y.ToString("0.00"));
                            dx += x;
                            dy += y;
                        }
                        double allDx = dx - (Plist[Plist.Count - 1].CorX - Plist[0].CorX);
                        double allDy = dy - (Plist[Plist.Count - 1].CorY - Plist[0].CorY);

                        //坐标改正 
                        for (int i = 0; i < Llist.Count ; i++)
                        {
                            Llist[i].CorDx = Double.Parse((Llist[i].Dx + Llist[i].Dx * allDx / dx).ToString("0.00"));
                            Llist[i].CorDy = Double.Parse((Llist[i].Dy + Llist[i].Dy * allDy / dy).ToString("0.00"));
                            Plist[i + 1].CorX = Double.Parse((Plist[i].CorX + Llist[i].CorDx).ToString("0.00"));
                            Plist[i + 1].CorY = Double.Parse((Plist[i].CorY + Llist[i].CorDy).ToString("0.00"));
                        } 
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// 导线计算表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_CalcultorLine_Click(object sender, EventArgs e)
        {
            if (!panel_ResultData.Visible)
            {
                panel_Img.Visible = panel_ResultData.Visible;
                panel_ViewData.Visible = panel_ResultData.Visible;
                panel_PointNum.Visible = panel_ResultData.Visible;
                panel_ViewImg.Visible = panel_ResultData.Visible;
                panel_ResultData.Visible = !panel_ResultData.Visible;
            }
            try
            {
                if (Plist != null && Llist != null)
                {
                    if (m_Type == 1)
                    {

                        dataGridView_ResultData.Rows.Clear();
                        dataGridView_ResultData.Rows.Add((m_PointNum + 4)*2);
                        dataGridView_ResultData.Rows[0].Cells["Result_PointName"].Value = "方向点";
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 2].Cells["Result_PointName"]
                            .Value = "方向点";
                        dataGridView_ResultData.Rows[1].Cells["Result_DirectionAngle"].Value = Llist[0].Angel;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 3].Cells["Result_DirectionAngle"
                            ].Value =
                            Llist[Llist.Count - 1].Angel;

                        string allviewAng = "00 00 00", allCorviewAng = "00 00 00", allViewAngNo = "00 00 00";
                        double allLine = 0, allDx = 0, allDy = 0, allCorDx = 0, allCorDy = 0;
                        for (int i = 0; i < Plist.Count; i++)
                        {
                            dataGridView_ResultData.Rows[(i + 1)*2].Cells["Result_PointName"].Value = Plist[i].PointName;
                            dataGridView_ResultData.Rows[(i + 1)*2].Cells["Result_ViewAngle"].Value = Plist[i].Angel;
                            dataGridView_ResultData.Rows[(i + 1)*2].Cells["Result_CorViewAngle"].Value =
                                Plist[i].CorAngel;
                            dataGridView_ResultData.Rows[(i + 1)*2].Cells["Result_ViewAngleNo"].Value =
                                CCalculator.SubAngle(Plist[i].CorAngel, Plist[i].Angel);
                            dataGridView_ResultData.Rows[(i + 1)*2].Cells["Result_Coordinate_X"].Value = Plist[i].CorX;
                            dataGridView_ResultData.Rows[(i + 1)*2].Cells["Result_Coordinate_Y"].Value = Plist[i].CorY;
                            allviewAng = CCalculator.SumAngle(allviewAng, Plist[i].Angel);
                            allCorviewAng = CCalculator.SumAngle(allCorviewAng, Plist[i].CorAngel);
                            allViewAngNo = CCalculator.SumAngle(allViewAngNo,
                                CCalculator.SubAngle(Plist[i].CorAngel, Plist[i].Angel));
                        }
                        for (int i = 1; i < Llist.Count-1; i++)
                        {
                            dataGridView_ResultData.Rows[2 * i + 1].Cells["Result_DirectionAngle"].Value = Llist[i].Angel;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_ViewLineLong"].Value = Llist[i].Distance;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_DxNo"].Value = Llist[i].Dx;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_DyNo"].Value = Llist[i].Dy;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_CorDx"].Value = Llist[i].CorDx;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_CorDy"].Value = Llist[i].CorDy;
                            allLine = Double.Parse((allLine + Llist[i].Distance).ToString("0.00"));
                            allDx = Double.Parse((allDx + Llist[i].Dx).ToString("0.00"));
                            allDy = Double.Parse((allDy + Llist[i].Dy).ToString("0.00"));
                            allCorDx = Double.Parse((allCorDx + Llist[i].CorDx).ToString("0.00"));
                            allCorDy = Double.Parse((allCorDy + Llist[i].CorDy).ToString("0.00"));

                        }

                        //最后一行
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_PointName"]
                            .Value = "∑";
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_ViewAngle"]
                            .Value = allviewAng;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_CorViewAngle"]
                            .Value = allCorviewAng;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_ViewAngleNo"]
                            .Value = allViewAngNo;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_ViewLineLong"]
                            .Value = allLine;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_DxNo"].Value =
                            allDx;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_DyNo"].Value =
                            allDy;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_CorDx"].Value =
                            allCorDx;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_CorDy"].Value =
                            allCorDy;

                        foreach (DataGridViewRow VARIABLE in this.dataGridView_ResultData.Rows)
                        {
                            for (int i = 0; i < this.dataGridView_ResultData.ColumnCount; i++)
                            {
                                if (VARIABLE.Cells[i].Value == null)
                                {
                                    VARIABLE.Cells[i].Style.BackColor = Color.Gray;
                                }
                            }
                        }

                    }
                    else if (m_Type == 2)
                    {
                          dataGridView_ResultData.Rows.Clear();
                          dataGridView_ResultData.Rows.Add((m_PointNum + 3) * 2);
                          dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 2].Cells["Result_PointName"].Value = Plist[1].PointName;

                        string allviewAng = "00 00 00", allCorviewAng = "00 00 00", allViewAngNo = "00 00 00";
                        double allLine = 0, allDx = 0, allDy = 0, allCorDx = 0, allCorDy = 0;

                        
                        for (int i = 0; i < Plist.Count; i++)
                        {
                            dataGridView_ResultData.Rows[i * 2].Cells["Result_PointName"].Value = Plist[i].PointName;
                            dataGridView_ResultData.Rows[i * 2].Cells["Result_Coordinate_X"].Value = Plist[i].CorX;
                            dataGridView_ResultData.Rows[i * 2].Cells["Result_Coordinate_Y"].Value = Plist[i].CorY;
                            if (i == 0)
                                continue;
                            dataGridView_ResultData.Rows[i*2].Cells["Result_ViewAngle"].Value = Plist[i].Angel;
                            dataGridView_ResultData.Rows[i*2].Cells["Result_CorViewAngle"].Value =
                                Plist[i].CorAngel;
                            dataGridView_ResultData.Rows[i*2].Cells["Result_ViewAngleNo"].Value =
                                CCalculator.SubAngle(Plist[i].CorAngel, Plist[i].Angel);
                            
                            allviewAng = CCalculator.SumAngle(allviewAng, Plist[i].Angel);
                            allCorviewAng = CCalculator.SumAngle(allCorviewAng, Plist[i].CorAngel);
                            allViewAngNo = CCalculator.SumAngle(allViewAngNo,
                                CCalculator.SubAngle(Plist[i].CorAngel, Plist[i].Angel));
                        }
                        for (int i = 0; i <=Llist.Count; i++)
                        {
                            if (i == Llist.Count)
                            {
                                dataGridView_ResultData.Rows[2 * i + 1].Cells["Result_DirectionAngle"].Value = Llist[0].Angel;
                            break;
                            }
                            dataGridView_ResultData.Rows[2 * i + 1].Cells["Result_DirectionAngle"].Value = Llist[i].Angel;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_ViewLineLong"].Value = Llist[i].Distance;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_DxNo"].Value = Llist[i].Dx;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_DyNo"].Value = Llist[i].Dy;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_CorDx"].Value = Llist[i].CorDx;
                            dataGridView_ResultData.Rows[2*i + 1].Cells["Result_CorDy"].Value = Llist[i].CorDy;
                            allLine = Double.Parse((allLine + Llist[i].Distance).ToString("0.00"));
                            allDx = Double.Parse((allDx + Llist[i].Dx).ToString("0.00"));
                            allDy = Double.Parse((allDy + Llist[i].Dy).ToString("0.00"));
                            allCorDx = Double.Parse((allCorDx+ Llist[i].CorDx).ToString("0.00"));
                            allCorDy = Double.Parse((allCorDy + Llist[i].CorDy).ToString("0.00"));
                        }
                        //最后一行
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_PointName"]
                            .Value = "∑";
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_ViewAngle"]
                            .Value = allviewAng;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_CorViewAngle"]
                            .Value = allCorviewAng;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_ViewAngleNo"]
                            .Value = allViewAngNo;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_ViewLineLong"]
                            .Value = allLine;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_DxNo"].Value =
                            allDx;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_DyNo"].Value =
                            allDy;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_CorDx"].Value =
                            allCorDx;
                        dataGridView_ResultData.Rows[dataGridView_ResultData.RowCount - 1].Cells["Result_CorDy"].Value =
                            allCorDy;

                        foreach (DataGridViewRow VARIABLE in this.dataGridView_ResultData.Rows)
                        {
                            for (int i = 0; i < this.dataGridView_ResultData.ColumnCount; i++)
                            {
                                if (VARIABLE.Cells[i].Value == null)
                                {
                                    VARIABLE.Cells[i].Style.BackColor = Color.Gray;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请先计算坐标！");
            }
        }

        /// <summary>
        /// 平面图形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btu_FloatView_Click(object sender, EventArgs e)
        {
            if (!panel_ViewImg.Visible)
            {
                panel_Img.Visible = panel_ViewImg.Visible;
                panel_ViewData.Visible = panel_ViewImg.Visible;
                panel_PointNum.Visible = panel_ViewImg.Visible;
                panel_ResultData.Visible = panel_ViewImg.Visible;
                panel_ViewImg.Visible = !panel_ViewImg.Visible;
            }
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            font = new Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular);
            brush = new SolidBrush(Color.Blue);

            //绘制坐标原点
            DrawPoint(50, this.pictureBox1.Height - 50, new Pen(Color.Black, 5), "0");
            //绘制X轴
            DrawLine(new PointF(50, this.pictureBox1.Height - 50), new PointF(50, 50));
            graphics.DrawString("↑", font, new SolidBrush(Color.Black), 45, 40);
            graphics.DrawString("Y", font, new SolidBrush(Color.Black), 35, 45);
            //绘制Y轴
            DrawLine(new PointF(50, this.pictureBox1.Height - 50),
                new PointF(this.pictureBox1.Width - 50, this.pictureBox1.Height - 50));
            graphics.DrawString(">", font, new SolidBrush(Color.Black), this.pictureBox1.Width - 55,
                this.pictureBox1.Height - 61);
            graphics.DrawString("X", font, new SolidBrush(Color.Black), this.pictureBox1.Width - 55,
                this.pictureBox1.Height - 50);


            if (Plist != null && Llist != null)
            {
                //连线
                if (m_Type == 1)
                {
                    //绘制方向点及连线
                    double dx = 0, dy = 0;
                    CCalculator.GetXY(Llist[0].Angel, 100, ref dx, ref dy);
                    PointF pp1 = new PointF((float)(1.5 * Plist[0].CorX - dx), (float)(0.9 * (Plist[0].CorY - 300) - dy));
                    CCalculator.GetXY(Llist[Llist.Count - 1].Angel, 100, ref dx, ref dy);
                    PointF pp2 = new PointF((float)(1.5 * Plist[Plist.Count - 1].CorX + dx),
                        (float)(0.9 * (Plist[Plist.Count - 1].CorY - 300) + dy));
                    DrawPoint(50 + pp1.Y, this.pictureBox1.Height - 50 - pp1.X, new Pen(Color.Red, 2), "方向点");
                    DrawPoint(50 + pp2.Y, this.pictureBox1.Height - 50 - pp2.X, new Pen(Color.Red, 2), "方向点");

                    for (int i = 0; i < Plist.Count; i++)
                    {
                        PointF p = new PointF((float)(1.5 * Plist[i].CorX), (float)(0.9 * (Plist[i].CorY - 300)));
                        DrawPoint(50 + p.Y, this.pictureBox1.Height - 50 - p.X, new Pen(Color.Red, 2), Plist[i].PointName);
                        if (i == 0)
                        {
                            DrawLine(new PointF(50 + pp1.Y, this.pictureBox1.Height - 50 - pp1.X),
                                new PointF((float)(0.9 * (Plist[i].CorY - 300)) + 50,
                                    this.pictureBox1.Height - 50 - (float)(1.5 * Plist[i].CorX)));

                        }
                        if (i > 0)
                        {
                            PointF p1 = new PointF((float)(0.9 * (Plist[i - 1].CorY - 300)) + 50,
                                this.pictureBox1.Height - 50 - (float)(1.5 * Plist[i - 1].CorX));

                            DrawLine(p1, new PointF(50 + p.Y, this.pictureBox1.Height - 50 - p.X));
                        }

                    }
                    DrawLine(
                        new PointF(50 + (float)(0.9 * (Plist[Plist.Count - 1].CorY - 300)),
                            this.pictureBox1.Height - 50 - (float)(1.5 * Plist[Plist.Count - 1].CorX)),
                        new PointF(50 + pp2.Y, this.pictureBox1.Height - 50 - pp2.X));

                }
                else if (m_Type == 2)
                {
                    for (int i = 0; i < Plist.Count; i++)
                    {
                        PointF p1 = new PointF((float)(0.9 * (Plist[i].CorY - 300)) + 50,
                            this.pictureBox1.Height - 50 - (float)(1.1 * (Plist[i].CorX - 100)));

                        DrawPoint(p1.X, p1.Y, new Pen(Color.Red, 2), Plist[i].PointName);


                        if (i == Plist.Count - 1)
                        {
                            DrawLine(p1,
                                new PointF((float)(0.9 * (Plist[0].CorY - 300)) + 50,
                                    this.pictureBox1.Height - 50 - (float)(1.1 * (Plist[0].CorX - 100))));
                            continue;
                        }
                        PointF p2 = new PointF((float)(0.9 * (Plist[i + 1].CorY - 300)) + 50,
                            this.pictureBox1.Height - 50 - (float)(1.1 * (Plist[i + 1].CorX - 100)));
                        DrawLine(p1, p2);
                    }
                } 
            }
        }

        private void DrawPoint(float x,float y,Pen pen ,string str)
        {
            graphics.DrawEllipse(pen, x, y, 1.5f, 1.5f);
            graphics.DrawString(str, font, brush, x,y);
            this.pictureBox1.Image = bitmap;
        }
        private void DrawLine(PointF p1, PointF p2)
        {
            pen = new Pen(Color.Black, 1);
            float x1 = (float)p1.X;
            float y1 = (float) p1.Y;

            float x2 = (float)p2.X;
            float y2 = (float) p2.Y;
            graphics.DrawLine(pen, x1, y1, x2, y2);
            this.pictureBox1.Image = bitmap;
        }
    }
}
