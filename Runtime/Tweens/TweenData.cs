using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nebukam.Easing
{

    public interface ITweenData<T>
    {
        T from { get; set; }
        T to { get; set; }
        T val { get; set; }

        float timescale { get; set; }
        float time { get; set; }
        float duration { get; set; }
        float delay { get; set; }

    }

    public struct TweenData<T> : ITweenData<T>
    {

        public T m_from;
        public T m_to;
        public T m_val;

        public float m_timescale;
        public float m_time;
        public float m_duration;
        public float m_delay;


        public T from { get { return m_from; } set { m_from = value; } }
        public T to { get { return m_to; } set { m_to = value; } }
        public T val { get { return m_val; } set { m_val = value; } }

        public float timescale { get { return m_timescale; } set { m_timescale = value; } }
        public float time { get { return m_time; } set { m_time = value; } }
        public float duration { get { return m_duration; } set { m_duration = value; } }
        public float delay { get { return m_delay; } set { m_delay = value; } }

        public TweenData(TweenData<T> a)
        {

            m_from = a.m_from;
            m_to = a.m_to;
            m_val = a.m_val;

            m_timescale = a.m_timescale;
            m_time = a.m_time;
            m_duration = a.m_duration;
            m_delay = a.m_delay;

        }

        public TweenData(T a, T b, T v, float t, float d, float dlay = 0f, float ts = 1f)
        {

            m_from = a;
            m_to = b;
            m_val = v;

            m_timescale = ts;
            m_time = t;
            m_duration = d;
            m_delay = dlay;

        }

    }

}
