// Copyright (c) 2021 Timothé Lapetite - nebukam@gmail.com.
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

using UnityEngine;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Nebukam.Easing
{
    public class TweenCurve : Tween<float>, ITweenCurve
    {

        protected AnimationCurve m_curve = null;
        public AnimationCurve curve
        {
            get { return m_curve; }
            set { m_curve = value; }
        }

        public TweenCurve(AnimationCurve c, Easing.Ease<float> e, float d, float dlay = 0f, float ts = 1f) 
            : base(e, 0f, 1f, d, dlay, ts)
        {
            m_curve = c;
            m_val = InternalComputeValue(0f);

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override float InternalComputeValue(float t)
        {
            return m_curve != null ? m_curve.Evaluate(m_ease(m_from, m_to, t, m_duration)) : 0f;
        }

    }
}
