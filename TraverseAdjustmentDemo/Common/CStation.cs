using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseAdjustmentDemo.Common
{
    class CStation
    {
        private int m_stationNum;//测站编号
        private double m_distance;//距离
        private double m_angel;//观察角
        private double m_adjustAngel;//平差角
        public int StationNum
        {
            get { return m_stationNum; }
            set { m_stationNum = value; }
        }
        
        public double Distance
        {
            get { return m_distance; }
            set { m_distance = value; }
        }
        public double Angel
        {
            get { return m_angel; }
            set { m_angel = value; }
        }
        public double AdjustAngel
        {
            get { return m_adjustAngel; }
            set { m_adjustAngel = value; }
        }
    }
}
