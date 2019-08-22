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
    public struct EaseFloat3
    {
        public float time, duration;
        public float3 from, diff, value;

        public float progress { get { return time / duration; } }

        public static implicit operator float3(EaseFloat3 e) { return e.value; }
    }

    public static class EaseFloat3Extensions
    {

        public static EaseFloat3 Reset(this ref EaseFloat3 @this)
        {
            @this.time = 0f;
            @this.value = @this.from;
            return @this;
        }

        #region Linear

        public static float3 Linear(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.Linear(t, @this.from, @this.diff, d);
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
        public static float3 ExpoEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ExpoEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 ExpoEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ExpoEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 ExpoEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ExpoEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 ExpoEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ExpoEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 CircEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CircEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 CircEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CircEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 CircEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CircEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 CircEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CircEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 QuadEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuadEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 QuadEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuadEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 QuadEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuadEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 QuadEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuadEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 SineEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.SineEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 SineEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.SineEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 SineEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.SineEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 SineEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.SineEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 CubicEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CubicEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 CubicEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CubicEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 CubicEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CubicEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 CubicEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.CubicEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 QuartEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuartEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 QuartEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuartEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 QuartEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuartEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 QuartEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuartEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 QuintEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuintEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 QuintEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuintEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 QuintEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuintEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 QuintEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.QuintEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 ElasticEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ElasticEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 ElasticEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ElasticEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 ElasticEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ElasticEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 ElasticEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.ElasticEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 BounceEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BounceEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 BounceEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BounceEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 BounceEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BounceEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 BounceEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BounceEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float3 BackEaseOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BackEaseOut(t, @this.from, @this.diff, d);
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
        public static float3 BackEaseIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BackEaseIn(t, @this.from, @this.diff, d);
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
        public static float3 BackEaseInOut(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BackEaseInOut(t, @this.from, @this.diff, d);
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
        public static float3 BackEaseOutIn(this ref EaseFloat3 @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d);
            float3 v = Easing3.BackEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

    }

}
