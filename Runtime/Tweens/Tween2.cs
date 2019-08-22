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
using static Unity.Mathematics.math;

namespace Nebukam.Easing
{
    public struct Tween2
    {
        public Easing2.Ease ease;
        public float time, duration;
        public float2 from, diff;
        public float2 value;

        public float progress {
            get { return time / duration; }
            set {
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
        public Tween2(Easing2.Ease ease, float2 from, float2 to, float duration)
        {
            this.ease = ease;
            time = 0f;
            this.from = from;
            this.duration = duration;
            diff = to - from;
            value = from;
        }

        /// <summary>
        /// Return a copy of the Tween2, with value interpolated at a given time t.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public Tween2 At(float t)
        {
            float2 val = ease(t, from, diff, duration);
            Tween2 advanced = this;
            advanced.time = t;
            advanced.value = val;
            return advanced;
        }

        /// <summary>
        /// Return a copy of the Tween2, advanced by delta.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public Tween2 Advanced(float delta)
        {
            float t = time + delta;
            float2 val = ease(t, from, diff, duration);
            Tween2 advanced = this;
            advanced.time = t;
            advanced.value = val;
            return advanced;
        }

        /// <summary>
        /// Return a copy of the Tween2, advanced by delta, with duration clamped.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public Tween2 Clamped(float delta)
        {
            float t = clamp(time + delta, 0f, duration);
            float2 val = ease(t, from, diff, duration);
            Tween2 advanced = this;
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
        public static Tween2 operator +(Tween2 tween, float delta) { return tween.Advanced(delta); }

        /// <summary>
        /// Advance (unclamped) by negative delta.
        /// </summary>
        /// <param name="tween"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static Tween2 operator -(Tween2 tween, float delta) { return tween.Advanced(-delta); }

        public static implicit operator float2(Tween2 e) { return e.value; }

    }
}
