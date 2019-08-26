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
    public struct EaseFloat2
    {
        public float time, duration;
        public float2 from, diff, value;

        public float progress { get { return time / duration; } }

        public static implicit operator float2(EaseFloat2 e) { return e.value; }
    }

    public static class EaseFloat2Extensions
    {

        public static EaseFloat2 Reset(this ref EaseFloat2 @this)
        {
            @this.time = 0f;
            @this.value = @this.from;
            return @this;
        }

        #region Linear

        public static float2 Linear(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.Linear(t, @this.from, @this.diff, d);
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
        public static float2 ExpoEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ExpoEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 ExpoEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ExpoEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 ExpoEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ExpoEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 ExpoEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ExpoEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 CircEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CircEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 CircEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CircEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 CircEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CircEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 CircEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CircEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 QuadEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuadEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 QuadEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuadEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 QuadEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuadEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 QuadEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuadEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 SineEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.SineEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 SineEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.SineEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 SineEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.SineEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 SineEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.SineEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 CubicEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CubicEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 CubicEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CubicEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 CubicEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CubicEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 CubicEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.CubicEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 QuartEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuartEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 QuartEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuartEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 QuartEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuartEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 QuartEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuartEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 QuintEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuintEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 QuintEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuintEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 QuintEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuintEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 QuintEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.QuintEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 ElasticEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ElasticEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 ElasticEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ElasticEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 ElasticEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ElasticEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 ElasticEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.ElasticEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 BounceEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BounceEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 BounceEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BounceEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 BounceEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BounceEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 BounceEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BounceEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float2 BackEaseOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BackEaseOut(t, @this.from, @this.diff, d);
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
        public static float2 BackEaseIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BackEaseIn(t, @this.from, @this.diff, d);
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
        public static float2 BackEaseInOut(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BackEaseInOut(t, @this.from, @this.diff, d);
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
        public static float2 BackEaseOutIn(this ref EaseFloat2 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float2 v = Easing2.BackEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

    }

}
