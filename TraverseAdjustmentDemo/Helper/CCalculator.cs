using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraverseAdjustmentDemo.Helper
{
    internal class CCalculator
    {
        /// <summary>
        /// 角度化弧度函数
        /// </summary>
        /// <param name="ang"></param>
        /// <returns></returns>
        public static double DEG(double ang)
        {
            int fuhao = (int) (ang/Math.Abs(ang));
            ang = Math.Abs(ang);
            int d = (int) ang;
            int m = ((int) (ang*100)) - d*100;
            double s = ang*10000 - m*100 - d*10000;
            return ((d + m/60.0 + s/3600.0)*fuhao)/180.0*Math.PI;
        }

        /// <summary>
        /// 弧度化角度函数
        /// </summary>
        /// <param name="ang"></param>
        /// <returns></returns>
        private static double DMS(double ang)
        {
            ang += 1.0E-15; //加上一个小量，以保证进位 
            int fuhao = (int) (ang/Math.Abs(ang));
            ang = Math.Abs(ang)*180.0/Math.PI;
            int d = (int) ang;
            ang = (ang - d)*60.0;
            int m = (int) ang;
            double s = (ang - m)*60.0;
            return (d + m/100.0 + s/10000.0)*fuhao;
        }

        /// <summary>
        /// 两个度分秒数求和
        /// </summary>
        /// <param name="ang1"></param>
        /// <param name="ang2"></param>
        /// <returns></returns>
        public static string SumAngle(string ang1, string ang2)
        {
            int du,fen,miao;
            int k = 0;
            if (int.Parse(ang1.Substring(ang1.Length - 2, 2)) + int.Parse(ang2.Substring(ang2.Length - 2, 2))>=60)
            {
                miao = int.Parse(ang1.Substring(ang1.Length - 2, 2)) + int.Parse(ang2.Substring(ang2.Length - 2, 2)) - 60;
                k = 1;
            }
            else
            {
                miao = int.Parse(ang1.Substring(ang1.Length - 2, 2)) +int.Parse(ang2.Substring(ang2.Length - 2, 2));
            }

            if (int.Parse(ang1.Substring(ang1.Length - 5, 2)) + int.Parse(ang2.Substring(ang2.Length - 5, 2))+k >= 60)
            {
                fen = int.Parse(ang1.Substring(ang1.Length - 5, 2)) + int.Parse(ang2.Substring(ang2.Length - 5, 2)) + k - 60;
                k = 1;
            }
            else
            {
                fen = int.Parse(ang1.Substring(ang1.Length - 5, 2)) + int.Parse(ang2.Substring(ang2.Length - 5, 2)) + k ;
                k = 0;
            }
            du = int.Parse(ang1.Substring(0, ang1.Length - 5)) + int.Parse(ang2.Substring(0, ang2.Length - 5))+k;
            return FomatAngle(du + " " + fen + " " + miao);
        }

        /// <summary>
        /// 两个度分秒数求差
        /// </summary>
        /// <param name="endAng">减数</param>
        /// <param name="startAng">被减数</param>
        /// <returns></returns>
        public static string SubAngle(string endAng, string startAng)
        {
            int du, fen, miao;
            int k = 0;
            if (int.Parse(endAng.Substring(endAng.Length - 2, 2)) - int.Parse(startAng.Substring(startAng.Length - 2, 2)) < 0)
            {
                miao = int.Parse(endAng.Substring(endAng.Length - 2, 2)) - int.Parse(startAng.Substring(startAng.Length - 2, 2)) + 60;
                k = -1;
            }
            else
            {
                miao = int.Parse(endAng.Substring(endAng.Length - 2, 2)) - int.Parse(startAng.Substring(startAng.Length - 2, 2));
                k = 0;
            }

            if (int.Parse(endAng.Substring(endAng.Length - 5, 2)) - int.Parse(startAng.Substring(startAng.Length - 5, 2)) + k < 0)
            {
                fen = int.Parse(endAng.Substring(endAng.Length - 5, 2)) - int.Parse(startAng.Substring(startAng.Length - 5, 2)) + k + 60;
                k = -1;
            }
            else
            {
                fen = int.Parse(endAng.Substring(endAng.Length - 5, 2)) - int.Parse(startAng.Substring(startAng.Length - 5, 2)) + k;
                k = 0;
            }
            du = int.Parse(endAng.Substring(0, endAng.Length - 5)) - int.Parse(startAng.Substring(0, startAng.Length - 5)) + k;
          
            return FomatAngle(du + " " + fen + " " + miao);
        }

        /// <summary>
        /// 理论上坐标方位角之和
        /// </summary>
        /// <param name="startAng"></param>
        /// <param name="endAng"></param>
        /// <param name="pointNums"></param>
        /// <returns></returns>
        public static string SumTheoDirAngle(string startAng, string endAng, int pointNums)
        {
            return FomatAngle(SumAngle(SubAngle(endAng, startAng), (pointNums + 2) * 180 + " 00 00"));
        }

        /// <summary>
        /// 实际上坐标方位角之和
        /// </summary>
        /// <param name="ang"></param>
        /// <returns></returns>
        public static string SumFactDirAngle(string[] ang)
        {
            string angle="00 00 00";
            for (int i = 0; i < ang.Length; i++)
            {
                angle = SumAngle(angle, ang[i]);
            }
            return FomatAngle(angle);
        }

        /// <summary>
        /// 获取观测角单位改正数
        /// </summary>
        /// <param name="theoDirAngle"></param>
        /// <param name="factDirAngle"></param>
        /// <param name="pointNums"></param>
        /// <returns></returns>
        public static string CorrectDirAngle(string theoDirAngle, string factDirAngle, int pointNums)
        {
            int du, fen, miao;
            string ang = SubAngle(factDirAngle, theoDirAngle);
            du = int.Parse(ang.Split(' ')[0]);
            fen = int.Parse(ang.Split(' ')[1]);
            miao = int.Parse(ang.Split(' ')[2]);
            miao = (du*3600 + fen*60 + miao)/(pointNums+2);
            return "00 00 "+miao;

        }


        public static void GetXY(string ang, double l, ref double dx, ref double dy)
        {
            double a = (Double.Parse(ang.Split(' ')[0]) + Double.Parse(ang.Split(' ')[1])/60 +
                        Double.Parse(ang.Split(' ')[2])/3600);
            dy = Double.Parse((Math.Sin(DEG(a))*l).ToString("0.00"));
            dx = Double.Parse((Math.Cos(DEG(a))*l).ToString("0.00"));

        }

        /// <summary>
        /// 度分秒的格式化如（00 00 00）
        /// </summary>
        /// <param name="ang"></param>
        /// <returns></returns>
        private static string FomatAngle(string ang)
        {
            if (ang.Split(' ').Length==3)
            {
                string du = ang.Split(' ')[0];
                string fen = ang.Split(' ')[1];
                string miao = ang.Split(' ')[2];
                if (!du.Contains("-") && du.Length == 0)
                {
                    du = "00";
                }
                else if (!du.Contains("-") && du.Length == 1)
                {
                    du = "0" + du;
                }
                if (fen.Length == 0)
                {
                    fen = "00";
                }
                else if (fen.Length == 1)
                {
                    fen = "0" + fen;
                }
                if (miao.Contains("-") && miao.Length != 2)
                {
                    miao = miao.Replace("-", "-0");
                }
                else if (!miao.Contains("-") && miao.Length != 2)
                {
                    miao = "0" + miao;
                }
                return du + " " + fen + " " + miao;
            }
            else
            {
                return ang;
            }
        }
    }
}
