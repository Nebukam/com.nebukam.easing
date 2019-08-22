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
    public struct EaseFloat
    {
        public float time, duration;
        public float from, diff, value;

        public float progress { get { return time / duration; } }

        public static implicit operator float(EaseFloat e) { return e.value; }

    }

    public static class EaseFloatExtensions
    {

        public static EaseFloat Reset(this ref EaseFloat @this)
        {
            @this.time = 0f;
            @this.value = @this.from;
            return @this;
        }
        
        #region Linear

        public static float Linear(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.Linear(t, @this.from, @this.diff, d);
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
        public static float ExpoEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ExpoEaseOut(t, @this.from, @this.diff, d);
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
        public static float ExpoEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ExpoEaseIn(t, @this.from, @this.diff, d);
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
        public static float ExpoEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ExpoEaseInOut(t, @this.from, @this.diff, d);
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
        public static float ExpoEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ExpoEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float CircEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CircEaseOut(t, @this.from, @this.diff, d);
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
        public static float CircEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CircEaseIn(t, @this.from, @this.diff, d);
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
        public static float CircEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CircEaseInOut(t, @this.from, @this.diff, d);
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
        public static float CircEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CircEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float QuadEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuadEaseOut(t, @this.from, @this.diff, d);
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
        public static float QuadEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuadEaseIn(t, @this.from, @this.diff, d);
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
        public static float QuadEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuadEaseInOut(t, @this.from, @this.diff, d);
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
        public static float QuadEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuadEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float SineEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.SineEaseOut(t, @this.from, @this.diff, d);
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
        public static float SineEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.SineEaseIn(t, @this.from, @this.diff, d);
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
        public static float SineEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.SineEaseInOut(t, @this.from, @this.diff, d);
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
        public static float SineEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.SineEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float CubicEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CubicEaseOut(t, @this.from, @this.diff, d);
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
        public static float CubicEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CubicEaseIn(t, @this.from, @this.diff, d);
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
        public static float CubicEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CubicEaseInOut(t, @this.from, @this.diff, d);
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
        public static float CubicEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.CubicEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float QuartEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuartEaseOut(t, @this.from, @this.diff, d);
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
        public static float QuartEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuartEaseIn(t, @this.from, @this.diff, d);
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
        public static float QuartEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuartEaseInOut(t, @this.from, @this.diff, d);
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
        public static float QuartEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuartEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float QuintEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuintEaseOut(t, @this.from, @this.diff, d);
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
        public static float QuintEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuintEaseIn(t, @this.from, @this.diff, d);
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
        public static float QuintEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuintEaseInOut(t, @this.from, @this.diff, d);
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
        public static float QuintEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.QuintEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float ElasticEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ElasticEaseOut(t, @this.from, @this.diff, d);
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
        public static float ElasticEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ElasticEaseIn(t, @this.from, @this.diff, d);
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
        public static float ElasticEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ElasticEaseInOut(t, @this.from, @this.diff, d);
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
        public static float ElasticEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.ElasticEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float BounceEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BounceEaseOut(t, @this.from, @this.diff, d);
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
        public static float BounceEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BounceEaseIn(t, @this.from, @this.diff, d);
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
        public static float BounceEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BounceEaseInOut(t, @this.from, @this.diff, d);
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
        public static float BounceEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BounceEaseOutIn(t, @this.from, @this.diff, d);
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
        public static float BackEaseOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BackEaseOut(t, @this.from, @this.diff, d);
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
        public static float BackEaseIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BackEaseIn(t, @this.from, @this.diff, d);
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
        public static float BackEaseInOut(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BackEaseInOut(t, @this.from, @this.diff, d);
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
        public static float BackEaseOutIn(this ref EaseFloat @this, float delta)
        {
            float d = @this.duration, t = clamp(@this.time + delta, 0f, d), v = Easing.BackEaseOutIn(t, @this.from, @this.diff, d);
            @this.time = t;
            @this.value = v;
            return v;
        }

        #endregion

    }

}
