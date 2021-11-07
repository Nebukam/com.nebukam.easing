// Copyright (c) 2019 Timothé Lapetite - nebukam@gmail.com.
// Based on Robert Penner's easing equations : http://robertpenner.com/easing/
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


    /// <summary>
    /// Robert Penner's easing functions for float.
    /// Cached delegates start with a lowercase.
    /// </summary>
    public class Easing
    {

        /// <summary>
        /// Interpolate a value from a to b according to a current time & duration
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        public delegate T Ease<T>(T a, T b, float t, float d);

        public class EaseVariants<T> { public Ease<T> Out, In, InOut, OutIn; }

        #region EQUATIONS

        internal const float
            HalfPI = PI * 0.5f,
            TAU = PI * 2f;


        #region None

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float None(float t, float d, float b = 0f, float c = 1f)
        {
            return c;
        }

        #endregion

        #region Linear

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Linear(float t, float d, float b = 0f, float c = 1f)
        {
            return c * t / d + b;
        }

        #endregion

        #region Expo

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ExpoEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return (t == d) ? b + c : c * (-pow(2.0f, -10.0f * t / d) + 1.0f) + b;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ExpoEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return (t == 0) ? b : c * pow(2.0f, 10.0f * (t / d - 1.0f)) + b;
        }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ExpoEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if (t == 0)
                return b;

            if (t == d)
                return b + c;

            if ((t /= d * 0.5f) < 1.0f)
                return c * 0.5f * pow(2.0f, 10.0f * (t - 1.0f)) + b;

            return c * 0.5f * (-pow(2.0f, -10.0f * --t) + 2.0f) + b;
        }


        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ExpoEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return ExpoEaseOut(t * 2.0f, b, c * 0.5f, d);

            return ExpoEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Circular

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CircEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return c * sqrt(1.0f - (t = t / d - 1.0f) * t) + b;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CircEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return -c * (sqrt(1.0f - (t /= d) * t) - 1.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CircEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) < 1.0f)
                return -c * 0.5f * (sqrt(1.0f - t * t) - 1.0f) + b;

            return c * 0.5f * (sqrt(1.0f - (t -= 2.0f) * t) + 1.0f) + b;
        }


        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CircEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return CircEaseOut(t * 2.0f, b, c * 0.5f, d);

            return CircEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Quad

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuadEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return -c * (t /= d) * (t - 2.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuadEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return c * (t /= d) * t + b;
        }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuadEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) < 1.0f)
                return c * 0.5f * t * t + b;

            return -c * 0.5f * ((--t) * (t - 2.0f) - 1.0f) + b;
        }


        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuadEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return QuadEaseOut(t * 2.0f, b, c * 0.5f, d);

            return QuadEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Sine

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SineEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return c * sin(t / d * HalfPI) + b;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SineEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return -c * cos(t / d * HalfPI) + c + b;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SineEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) < 1)
                return c * 0.5f * (sin(PI * t * 0.5f)) + b;

            return -c * 0.5f * (cos(PI * --t * 0.5f) - 2.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SineEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return SineEaseOut(t * 2.0f, b, c * 0.5f, d);

            return SineEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Cubic

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CubicEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return c * ((t = t / d - 1.0f) * t * t + 1.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CubicEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return c * (t /= d) * t * t + b;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CubicEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) < 1.0f)
                return c * 0.5f * t * t * t + b;

            return c * 0.5f * ((t -= 2.0f) * t * t + 2.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float CubicEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return CubicEaseOut(t * 2.0f, b, c * 0.5f, d);

            return CubicEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Quartic

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuartEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return -c * ((t = t / d - 1.0f) * t * t * t - 1.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuartEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return c * (t /= d) * t * t * t + b;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuartEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) < 1.0f)
                return c * 0.5f * t * t * t * t + b;

            return -c * 0.5f * ((t -= 2.0f) * t * t * t - 2.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuartEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return QuartEaseOut(t * 2.0f, b, c * 0.5f, d);

            return QuartEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Quintic

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuintEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return c * ((t = t / d - 1.0f) * t * t * t * t + 1.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuintEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return c * (t /= d) * t * t * t * t + b;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuintEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) < 1.0f)
                return c * 0.5f * t * t * t * t * t + b;
            return c * 0.5f * ((t -= 2.0f) * t * t * t * t + 2.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float QuintEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return QuintEaseOut(t * 2.0f, b, c * 0.5f, d);
            return QuintEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Elastic

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ElasticEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d) == 1)
                return b + c;

            float p = d * .3f;
            float s = p / 4.0f;

            return (c * pow(2.0f, -10.0f * t) * sin((t * d - s) * TAU / p) + c + b);
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ElasticEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d) == 1.0f)
                return b + c;

            float p = d * .3f;
            float s = p / 4.0f;

            return -(c * pow(2.0f, 10.0f * (t -= 1.0f)) * sin((t * d - s) * TAU / p)) + b;
        }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ElasticEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d * 0.5f) == 2.0f)
                return b + c;

            float p = d * (.3f * 1.5f);
            float s = p / 4.0f;

            if (t < 1)
                return -.5f * (c * pow(2.0f, 10.0f * (t -= 1.0f)) * sin((t * d - s) * TAU / p)) + b;
            return c * pow(2.0f, -10.0f * (t -= 1)) * sin((t * d - s) * TAU / p) * .5f + c + b;
        }


        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ElasticEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d / 2)
                return ElasticEaseOut(t * 2, b, c / 2, d);
            return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Bounce

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BounceEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            if ((t /= d) < (1 / 2.75))
                return c * (7.5625f * t * t) + b;
            else if (t < (2.0f / 2.75f))
                return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + .75f) + b;
            else if (t < (2.5f / 2.75f))
                return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + .9375f) + b;
            else
                return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + .984375f) + b;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BounceEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return c - BounceEaseOut(d - t, 0, c, d) + b;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BounceEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d / 2)
                return BounceEaseIn(t * 2.0f, 0, c, d) * .5f + b;
            else
                return BounceEaseOut(t * 2.0f - d, 0.0f, c, d) * .5f + c * .5f + b;
        }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BounceEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d / 2)
                return BounceEaseOut(t * 2.0f, b, c * 0.5f, d);
            return BounceEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Back

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BackEaseOut(float t, float d, float b = 0f, float c = 1f)
        {
            return c * ((t = t / d - 1.0f) * t * ((1.70158f + 1.0f) * t + 1.70158f) + 1.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BackEaseIn(float t, float d, float b = 0f, float c = 1f)
        {
            return c * (t /= d) * t * ((1.70158f + 1.0f) * t - 1.70158f) + b;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BackEaseInOut(float t, float d, float b = 0f, float c = 1f)
        {
            float s = 1.70158f;
            if ((t /= d * 0.5f) < 1)
                return c * 0.5f * (t * t * (((s *= (1.525f)) + 1.0f) * t - s)) + b;
            return c * 0.5f * ((t -= 2.0f) * t * (((s *= (1.525f)) + 1.0f) * t + s) + 2.0f) + b;
        }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="t">Current time in seconds.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Final value.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float BackEaseOutIn(float t, float d, float b = 0f, float c = 1f)
        {
            if (t < d * 0.5f)
                return BackEaseOut(t * 2.0f, b, c * 0.5f, d);
            return BackEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #endregion

    }

}
