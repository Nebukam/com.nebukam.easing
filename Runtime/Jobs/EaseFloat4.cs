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
    /// <summary>
    /// Job-friendly tween data format
    /// </summary>
    public struct EaseFloat4
    {
        public float time, duration;
        public float4 from, diff, value;

        public float progress { get { return time / duration; } }

        public static implicit operator float4(EaseFloat4 e) { return e.value; }
    }

    public static class EaseFloat4Extensions
    {

        public static EaseFloat4 Reset(this ref EaseFloat4 @this)
        {
            @this.time = 0f;
            @this.value = @this.from;
            return @this;
        }

        #region Linear

        public static float4 Linear(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.Linear(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Expo

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ExpoEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ExpoEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ExpoEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ExpoEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ExpoEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ExpoEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ExpoEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ExpoEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Circular

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CircEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CircEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CircEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CircEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CircEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CircEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }


        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out/in: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CircEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CircEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Quad

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuadEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuadEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuadEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuadEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in/out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuadEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuadEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }


        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out/in: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuadEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuadEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Sine

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 SineEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.SineEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 SineEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.SineEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 SineEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.SineEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing out/in: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 SineEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.SineEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Cubic

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CubicEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CubicEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CubicEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CubicEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CubicEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CubicEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 CubicEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.CubicEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Quartic

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuartEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuartEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuartEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuartEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuartEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuartEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuartEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuartEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Quintic

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuintEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuintEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuintEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuintEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuintEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuintEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 QuintEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.QuintEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Elastic

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ElasticEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ElasticEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ElasticEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ElasticEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ElasticEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ElasticEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 ElasticEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.ElasticEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Bounce

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BounceEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BounceEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BounceEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BounceEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BounceEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BounceEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BounceEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BounceEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

        #region Back

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BackEaseOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BackEaseOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BackEaseIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BackEaseIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BackEaseInOut(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BackEaseInOut(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float4 BackEaseOutIn(this ref EaseFloat4 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float4 v = Easing4.BackEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

    }

}
