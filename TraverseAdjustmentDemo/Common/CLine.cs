using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseAdjustmentDemo.Common
{
    class CLine
    {
        private int m_lineNum;//边编号
        private CPoint m_startPoint;//起始点号
        private CPoint m_endPoint;//终止点号
        private double m_distance;//距离
        private string m_angel;//坐标方位角

        private double m_dx;//X坐标增量
        private double m_dy;//Y坐标增量
        private double m_cordx;//X坐标增量
        private double m_cordy;//Y坐标增量
        public int LineNum
        {
            get { return m_lineNum; }
            set { m_lineNum = value; }
        }
        public CPoint StartPoint
        {
            get { return m_startPoint; }
            set { m_startPoint = value; }
        }
        public CPoint EndPoint
        {
            get { return m_endPoint; }
            set { m_endPoint = value; }
        }
        public double Distance
        {
            get { return m_distance; }
            set { m_distance = value; }
        }

        public string Angel
        {
            get { return m_angel; }
            set { m_angel = value; }
        }
        public double Dx
        {
            get { return m_dx; }
            set { m_dx = value; }
        }
        public double Dy
        {
            get { return m_dy; }
            set { m_dy = value; }
        }
        public double CorDx
        {
            get { return m_cordx; }
            set { m_cordx = value; }
        }
        public double CorDy
        {
            get { return m_cordy; }
            set { m_cordy = value; }
        }
    }
}
