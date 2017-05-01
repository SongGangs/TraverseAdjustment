using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseAdjustmentDemo.Common
{
    class CPoint
    {
        private int m_pointNum;//点编号
        private string m_pointName;//点名
        private double m_corx;//改正后的X坐标
        private double m_cory;//改正后的Y坐标
        private string m_angel;//观察角
        private string m_corAngel;//改正的观测角

        public int PointNum
        {
            get { return m_pointNum; }
            set { m_pointNum = value; }
        }

        public string PointName
        {
            get { return m_pointName; }
            set { m_pointName = value; }
        }
      

        public double CorX
        {
            get { return m_corx; }
            set { m_corx = value; }
        }
        public double CorY
        {
            get { return m_cory; }
            set { m_cory = value; }
        }
        public string CorAngel
        {
            get { return m_corAngel; }
            set { m_corAngel = value; }
        }

        public string Angel
        {
            get { return m_angel; }
            set { m_angel = value; }
        }
    }
}
