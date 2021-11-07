// Copyright (c) 2019 Timothé Lapetite - nebukam@gmail.com.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Nebukam.Easing
{
    public class Tween<T> : ITween<T>
    {

        protected Easing.Ease<T> m_ease;

        protected float m_delay;
        protected float m_timeClamped;
        protected float m_time;
        protected float m_timescale;
        protected float m_duration;
        protected float m_progress;

        protected T m_from;
        protected T m_to;
        protected T m_val;

        protected ITween m_previous;

        /// <summary>
        /// Easing equation to be used by this tween
        /// </summary>
        public Easing.Ease<T> ease
        {
            get { return m_ease; }
            set { m_ease = value; m_val = InternalComputeValue(m_time); }
        }


        /// <summary>
        /// Current value according to start/end value, easing equation and progress
        /// </summary>
        public T val { get { return m_val; } }

        /// <summary>
        /// Current time
        /// </summary>
        public float delay
        {
            get { return m_delay; }
            set { Set(m_time); }
        }

        /// <summary>
        /// Current time
        /// </summary>
        public float time
        {
            get { return m_time; }
            set { Set(value); }
        }

        /// <summary>
        /// Current duration
        /// </summary>
        public float duration
        {
            get { return m_duration; }
            set { m_duration = value; Set(m_time); }
        }

        /// <summary>
        /// Current progress
        /// </summary>
        public float progress
        {
            get { return m_time / m_duration; }
            set { Set(value * m_duration); }
        }


        public float timescale
        {
            get { return m_timescale; }
            set { m_timescale = value; }
        }

        public T from
        {
            get { return m_from; }
            set { m_from = value; m_val = InternalComputeValue(m_time); }
        }

        public T to
        {
            get { return m_to; }
            set { m_to = value; m_val = InternalComputeValue(m_time); }
        }

        public bool done { get { return m_progress >= 1f; } }

        /// <summary>
        /// Creates a tween object that can easily be manipulated.
        /// </summary>
        /// <param name="e">Easing equation</param>
        /// <param name="a">Starting value</param>
        /// <param name="b">Final value</param>
        /// <param name="d">Duration</param>
        /// <param name="dlay">Delay</param>
        /// <param name="ts">Timescale</param>
        public Tween(Easing.Ease<T> e, T a, T b, float d, float dlay = 0f, float ts = 1f)
        {
            Init(e, a, b, d, dlay, ts);
        }

        /// <summary>
        /// Reset time
        /// </summary>
        public void ResetTime()
        {
            m_time = m_timeClamped = m_progress = 0;
            m_val = InternalComputeValue(0f);
        }

        /// <summary>
        /// Sets from & to values, resets time.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">Final value</param>
        public void Init(T a, T b)
        {
            m_from = a;
            m_to = b;
            ResetTime();
        }

        /// <summary>
        /// Init the base properties of the
        /// </summary>
        /// <param name="e">Easing equation</param>
        /// <param name="a">Starting value</param>
        /// <param name="b">Final value</param>
        /// <param name="d">Duration</param>
        /// <param name="dlay">Delay</param>
        /// <param name="ts">Timescale</param>
        public void Init(Easing.Ease<T> e, T a, T b, float d, float dlay = 0f, float ts = 1f)
        {
            m_ease = e;
            m_delay = dlay;
            m_duration = d;

            m_timescale = ts;
            Init(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual T InternalComputeValue(float t)
        {
            return m_ease(m_from, m_to, t, m_duration);
        }

        /// <summary>
        /// Sets the Tween current time and update protected values accordingly.
        /// Does not account for timescale.
        /// </summary>
        /// <param name="t">Time</param>
        /// <returns></returns>
        public virtual ITween Set(float t)
        {
            m_time = clamp(t, 0f, m_duration);
            m_timeClamped = clamp(m_time - m_delay, 0f, m_duration);
            m_progress = m_timeClamped / m_duration;
            m_val = InternalComputeValue(m_timeClamped);
            return this;
        }

        /// <summary>
        /// Returns the value of the Tween at a given time.
        /// Does not account for timescale.
        /// </summary>
        /// <param name="t">Time</param>
        /// <returns></returns>
        public virtual T At(float t)
        {
            return InternalComputeValue(clamp(t - m_delay, 0f, m_duration));
        }

        /// <summary>
        /// Advance the tween by a specified amount of time, and return its updated value.
        /// Affected by timescale.
        /// </summary>
        /// <param name="delta">Time delta</param>
        /// <returns>Current value</returns>
        public virtual ITween Advance(float delta)
        {
            if (m_previous != null && !m_previous.done)
            {
                m_time = 0f;
            }
            else
            {
                m_time += (delta * m_timescale);
                m_time = clamp(m_time, 0f, m_duration);
            }

            m_timeClamped = clamp(m_time - m_delay, 0f, m_duration);
            m_progress = m_timeClamped / m_duration;
            m_val = InternalComputeValue(m_timeClamped);
            return this;
        }

        public static implicit operator T(Tween<T> e) { return e.val; }

    }
}
