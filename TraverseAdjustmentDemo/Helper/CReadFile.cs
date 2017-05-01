using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraverseAdjustmentDemo.Common;

namespace TraverseAdjustmentDemo.Helper
{
    class CReadFile
    {
        /// <summary>
        /// 读取txt中信息
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="type"></param>
        /// <param name="pointlist"></param>
        /// <param name="linelist"></param>
        /// <param name="m_PointNum"></param>
        public static bool GetDataFromFile(string fileName, int type, ref List<CPoint> pointlist,
            ref List<CLine> linelist, ref int m_PointNum)
        {
            if (type == 1)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default); //Encoding.Default读取时 防止乱码
                string content = sr.ReadLine();
                if (!content.Contains("符合导线数据："))
                {
                    MessageBox.Show("请检查打开的文件是否为符合导线数据！");
                    return false;
                }
                int pnums = 0;
                string[] sViewAngle = null;
                string[] sDirAngle = null;
                string[] sViewLong = null;
                string[] sStartP = null;
                string[] sEndP = null;
                while (!string.IsNullOrEmpty(content))
                {
                    try
                    {
                        if (content.Contains("点数："))
                        {
                            pnums = Int32.Parse(content.Substring(content.IndexOf("点数：") + 3));
                            m_PointNum = pnums;
                        }
                        if (content.Contains("观测角值："))
                        {
                            string str = content.Substring(content.IndexOf("观测角值：") + 5);
                            sViewAngle = str.Split('；');
                        }
                        if (content.Contains("方向角："))
                        {
                            string str = content.Substring(4);
                            sDirAngle = str.Split('；');
                        }
                        if (content.Contains("观测边长："))
                        {
                            string str = content.Substring(5);
                            sViewLong = str.Split('；');
                        }
                        if (content.Contains("起点坐标："))
                        {
                            string str = content.Substring(5);
                            sStartP = str.Split('，');
                        }
                        if (content.Contains("终点坐标："))
                        {
                            string str = content.Substring(5);
                            sEndP = str.Split('，');
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        content = sr.ReadLine();
                    }
                }

                CPoint p = null;
                CLine l = null;
                for (int i = 0; i < pnums + 2; i++)
                {
                    p = new CPoint();
                    p.PointNum = i;
                    p.Angel = sViewAngle[i];
                    if (i == 0)
                    {
                        p.PointName = "起点";
                        p.CorX = Double.Parse(sStartP[0]);
                        p.CorY = Double.Parse(sStartP[1]);
                    }
                    else if (i == pnums + 1)
                    {
                        p.PointName = "终点";
                        p.CorX = Double.Parse(sEndP[0]);
                        p.CorY = Double.Parse(sEndP[1]);
                    }
                    else
                    {
                        p.PointName = "未知点" + i;
                    }
                    pointlist.Add(p);
                }
                for (int i = 0; i < pnums + 3; i++)
                {
                    l = new CLine();
                    l.LineNum = i;
                    if (i == 0)
                    {
                        l.Angel = sDirAngle[0];
                    }
                    else if (i == pnums + 2)
                    {
                        l.Angel = sDirAngle[1];
                    }
                    else
                    {
                        l.StartPoint = pointlist[i - 1];
                        l.EndPoint = pointlist[i];
                        l.Distance = double.Parse(sViewLong[i - 1]);
                    }
                    linelist.Add(l);
                }
                fs.Close();
                sr.Close();
            }
            else if (type == 2)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default); //Encoding.Default读取时 防止乱码
                string content = sr.ReadLine();
                if (!content.Contains("闭合导线数据："))
                {
                    MessageBox.Show("请检查打开的文件是否为闭合导线数据！");
                    return false;
                }
                int pnums = 0;
                string[] sViewAngle = null;
                string sDirAngle = null;
                string[] sViewLong = null;
                //string[] sDirP = null;
                string[] sStartP = null;
                while (!string.IsNullOrEmpty(content))
                {
                    try
                    {
                        if (content.Contains("点数："))
                        {
                            pnums = Int32.Parse(content.Substring(content.IndexOf("点数：") + 3));
                            m_PointNum = pnums;
                        }
                        if (content.Contains("观测角值："))
                        {
                            string str = content.Substring(content.IndexOf("观测角值：") + 5);
                            sViewAngle = str.Split('；');
                        }
                        if (content.Contains("观测边长："))
                        {
                            string str = content.Substring(5);
                            sViewLong = str.Split('；');
                        }
                        if (content.Contains("起点坐标："))
                        {
                            string str = content.Substring(5);
                            sStartP = str.Split('，');
                        }
                        //if (content.Contains("方向点坐标："))
                        //{
                        //    string str = content.Substring(6);
                        //    sDirP = str.Split('，');
                        //}
                        if (content.Contains("方向角："))
                        {
                            string str = content.Substring(4);
                            sDirAngle = str.Trim();
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        content = sr.ReadLine();
                    }
                }

                CPoint p = null;
                CLine l = null;
                for (int i = 0; i < pnums + 2; i++)
                {
                    p = new CPoint();
                    p.PointNum = i;
                    //if (i == -1)
                    //{
                    //    p.PointName = "方向点";
                    //   //p.Angel = sDirAngle;
                    //   // p.CorX = Double.Parse(sDirP[0]);
                    //   //  p.CorY = Double.Parse(sDirP[1]);
                    //}
                     if (i == 0)
                    {
                        p.PointName = "起点";
                        p.CorX = Double.Parse(sStartP[0]);
                        p.CorY = Double.Parse(sStartP[1]);
                       // p.Angel = sViewAngle[i];
                    }
                    else if (i == pnums+1)
                    {
                        p.PointName = "起点";
                        p.CorX = Double.Parse(sStartP[0]);
                        p.CorY = Double.Parse(sStartP[1]);
                        p.Angel = sViewAngle[i-1];
                    }
                    else
                    {
                        p.PointName = "未知点" + i;
                        p.Angel = sViewAngle[i-1];
                    }
                    pointlist.Add(p);
                }
                //线的列表
                for (int i = 0; i < pnums + 1; i++)
                {
                    l = new CLine();
                    l.LineNum = i;
                    
                     if (i == pnums)
                    {
                        l.StartPoint = pointlist[pointlist.Count - 1];
                        l.EndPoint = pointlist[1];
                        l.Distance = double.Parse(sViewLong[sViewLong.Count()-1]);
                    }
                    else 
                    {
                        l.StartPoint = pointlist[i ];
                        l.EndPoint = pointlist[i+1];
                        l.Distance = double.Parse(sViewLong[i]);
                        if (i == 0)
                            l.Angel = sDirAngle;
                    }
                    linelist.Add(l);
                }
                fs.Close();
                sr.Close();
            }
            return true;
        }


    }
}
