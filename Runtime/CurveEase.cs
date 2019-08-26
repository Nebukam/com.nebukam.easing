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

using Unity.Mathematics;
using UnityEngine;

namespace Nebukam.Easing
{
    public class CurveEase
    {

        protected AnimationCurve m_curve = null;
        protected readonly Easing.Ease m_ease;
        protected readonly Easing2.Ease m_ease2;
        protected readonly Easing3.Ease m_ease3;
        protected readonly Easing4.Ease m_ease4;

        public AnimationCurve curve
        {
            get { return m_curve; }
            set { m_curve = value; }
        }
        public Easing.Ease ease { get { return m_ease; } }
        public Easing2.Ease ease2 { get { return m_ease2; } }
        public Easing3.Ease ease3 { get { return m_ease3; } }
        public Easing4.Ease ease4 { get { return m_ease4; } }

        public CurveEase()
        {
            m_ease = Ease;
            m_ease2 = Ease;
            m_ease3 = Ease;
            m_ease4 = Ease;
        }

        #region Float

        /// <summary>
        /// Interpolate b to c given a t and d
        /// </summary>
        /// <param name="t">Current ratio.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Change between Starting and Final value.</param>
        /// <param name="d">Maximum ratio.</param>
        /// <returns>The correct value.</returns>
        protected float Ease(float t, float b, float c, float d) { return b + m_curve.Evaluate(t / d) * c; }

        /// <summary>
        /// Interpolate between from & to, at t
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="t">normalized</param>
        /// <returns></returns>
        public float Ease(float from, float to, float t) { return from + m_curve.Evaluate(t) * (to - from); }

        #endregion

        #region Float2

        /// <summary>
        /// Interpolate b to c given a t and d
        /// </summary>
        /// <param name="t">Current ratio.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Change between Starting and Final value.</param>
        /// <param name="d">Maximum ratio.</param>
        /// <returns>The correct value.</returns>
        protected float2 Ease(float t, float2 b, float2 c, float d) { return b + m_curve.Evaluate(t / d) * c; }

        /// <summary>
        /// Interpolate between from & to, at t
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="t">normalized</param>
        /// <returns></returns>
        public float2 Ease(float2 from, float2 to, float t) { return from + m_curve.Evaluate(t) * (to - from); }

        #endregion

        #region Float3

        /// <summary>
        /// Interpolate b to c given a t and d
        /// </summary>
        /// <param name="t">Current ratio.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Change between Starting and Final value.</param>
        /// <param name="d">Maximum ratio.</param>
        /// <returns>The correct value.</returns>
        protected float3 Ease(float t, float3 b, float3 c, float d) { return b + m_curve.Evaluate(t / d) * c; }

        /// <summary>
        /// Interpolate between from & to, at t
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="t">normalized</param>
        /// <returns></returns>
        public float3 Ease(float3 from, float3 to, float t) { return from + m_curve.Evaluate(t) * (to - from); }

        #endregion

        #region Float4

        /// <summary>
        /// Interpolate b to c given a t and d
        /// </summary>
        /// <param name="t">Current ratio.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Change between Starting and Final value.</param>
        /// <param name="d">Maximum ratio.</param>
        /// <returns>The correct value.</returns>
        protected float4 Ease(float t, float4 b, float4 c, float d) { return b + m_curve.Evaluate(t / d) * c; }

        /// <summary>
        /// Interpolate between from & to, at t
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="t">normalized</param>
        /// <returns></returns>
        public float4 Ease(float4 from, float4 to, float t) { return from + m_curve.Evaluate(t) * (to - from); }

        #endregion

    }
}
