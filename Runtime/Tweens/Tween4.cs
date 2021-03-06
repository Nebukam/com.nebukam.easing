﻿// Copyright (c) 2019 Timothé Lapetite - nebukam@gmail.com.
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
using static Unity.Mathematics.math;

namespace Nebukam.Easing
{
    public struct Tween4
    {
        public Easing4.Ease ease;
        public float time, duration;
        public float4 from, diff;
        public float4 value;

        public float progress
        {
            get { return time / duration; }
            set
            {
                time = duration * value;
                this.value = ease(time, from, diff, duration);
            }
        }

        /// <summary>
        /// Create a self-contained tween using a given easing equation.
        /// </summary>
        /// <param name="ease">Easing equation</param>
        /// <param name="from">Starting value</param>
        /// <param name="to">End value</param>
        /// <param name="duration"></param>
        public Tween4(Easing4.Ease ease, float4 from, float4 to, float duration)
        {
            this.ease = ease;
            time = 0f;
            this.from = from;
            this.duration = duration;
            diff = to - from;
            value = from;
        }

        /// <summary>
        /// Return a copy of the Tween4, with value interpolated at a given time t.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public Tween4 At(float t)
        {
            float4 val = ease(t, from, diff, duration);
            Tween4 advanced = this;
            advanced.time = t;
            advanced.value = val;
            return advanced;
        }

        /// <summary>
        /// Return a copy of the Tween4, advanced by delta.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public Tween4 Advanced(float delta)
        {
            float t = time + delta;
            float4 val = ease(t, from, diff, duration);
            Tween4 advanced = this;
            advanced.time = t;
            advanced.value = val;
            return advanced;
        }

        /// <summary>
        /// Return a copy of the Tween4, advanced by delta, with duration clamped.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public Tween4 Clamped(float delta)
        {
            float t = clamp(time + delta, 0f, duration);
            float4 val = ease(t, from, diff, duration);
            Tween4 advanced = this;
            advanced.time = t;
            advanced.value = val;
            return advanced;
        }

        /// <summary>
        /// Advance this struct internally.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public void Advance(float delta)
        {
            time += delta;
            value = ease(time, from, diff, duration);
        }

        /// <summary>
        /// Advance this struct internally.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public void Clamp(float delta)
        {
            time = clamp(time + delta, 0f, duration);
            value = ease(time, from, diff, duration);
        }

        /// <summary>
        /// Advance (unclamped).
        /// </summary>
        /// <param name="tween"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static Tween4 operator +(Tween4 tween, float delta) { return tween.Advanced(delta); }

        /// <summary>
        /// Advance (unclamped) by negative delta.
        /// </summary>
        /// <param name="tween"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static Tween4 operator -(Tween4 tween, float delta) { return tween.Advanced(-delta); }

        public static implicit operator float4(Tween4 e) { return e.value; }

    }
}
