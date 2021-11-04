﻿// Copyright (c) 2019 Timothé Lapetite - nebukam@gmail.com.
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
using Unity.Mathematics;
using UnityEngine;
using static Unity.Mathematics.math;

namespace Nebukam.Easing
{

    /// <summary>
    /// Robert Penner's easing functions for float3.
    /// Cached delegates start with a lowercase.
    /// </summary>
    public static class Easing3
    {

        /// <summary>
        /// Interpolate b to c given a t and d
        /// </summary>
        /// <param name="t">Current ratio.</param>
        /// <param name="b">Starting value.</param>
        /// <param name="c">Change between Starting and Final value.</param>
        /// <param name="d">Maximum ratio.</param>
        /// <returns>The correct value.</returns>
        public delegate float3 Ease(float t, float3 b, float3 c, float d);

        internal const float HalfPI = PI * 0.5f;
        internal const float TAU = PI * 2f;

        public struct Float3Ease { public Ease Out, In, InOut, OutIn; }

        #region None

        public static Ease none = None;
        public static Float3Ease NoEase = new Float3Ease() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 None(float t, float3 b, float3 c, float d)
        {
            return c;
        }

        #endregion

        #region Linear

        public static Ease linear = Linear;
        public static Float3Ease LinearEase = new Float3Ease() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Linear(float t, float3 b, float3 c, float d)
        {
            return c * t / d + b;
        }

        #endregion

        #region Expo

        public static Ease expoEaseOut = ExpoEaseOut;
        public static Ease expoEaseIn = ExpoEaseIn;
        public static Ease expoEaseInOut = ExpoEaseInOut;
        public static Ease expoEaseOutIn = ExpoEaseOutIn;

        public static Float3Ease ExpoEase = new Float3Ease() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

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
        public static float3 ExpoEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 ExpoEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 ExpoEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 ExpoEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return ExpoEaseOut(t * 2.0f, b, c * 0.5f, d);

            return ExpoEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Circular

        public static Ease circEaseOut = CircEaseOut;
        public static Ease circEaseIn = CircEaseIn;
        public static Ease circEaseInOut = CircEaseInOut;
        public static Ease circEaseOutIn = CircEaseOutIn;

        public static Float3Ease Circ = new Float3Ease() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

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
        public static float3 CircEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 CircEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 CircEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 CircEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return CircEaseOut(t * 2.0f, b, c * 0.5f, d);

            return CircEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Quad


        public static Ease quadEaseOut = QuadEaseOut;
        public static Ease quadEaseIn = QuadEaseIn;
        public static Ease quadEaseInOut = QuadEaseInOut;
        public static Ease quadEaseOutIn = QuadEaseOutIn;

        public static Float3Ease Quad = new Float3Ease() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

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
        public static float3 QuadEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 QuadEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 QuadEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 QuadEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return QuadEaseOut(t * 2.0f, b, c * 0.5f, d);

            return QuadEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Sine

        public static Ease sineEaseOut = SineEaseOut;
        public static Ease sineEaseIn = SineEaseIn;
        public static Ease sineEaseInOut = SineEaseInOut;
        public static Ease sineEaseOutIn = SineEaseOutIn;

        public static Float3Ease Sine = new Float3Ease() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

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
        public static float3 SineEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 SineEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 SineEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 SineEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return SineEaseOut(t * 2.0f, b, c * 0.5f, d);

            return SineEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Cubic

        public static Ease cubicEaseOut = CubicEaseOut;
        public static Ease cubicEaseIn = CubicEaseIn;
        public static Ease cubicEaseInOut = CubicEaseInOut;
        public static Ease cubicEaseOutIn = CubicEaseOutIn;

        public static Float3Ease Cubic = new Float3Ease() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

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
        public static float3 CubicEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 CubicEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 CubicEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 CubicEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return CubicEaseOut(t * 2.0f, b, c * 0.5f, d);

            return CubicEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Quartic

        public static Ease quartEaseOut = QuartEaseOut;
        public static Ease quartEaseIn = QuartEaseIn;
        public static Ease quartEaseInOut = QuartEaseInOut;
        public static Ease quartEaseOutIn = QuartEaseOutIn;

        public static Float3Ease Quart = new Float3Ease() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

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
        public static float3 QuartEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 QuartEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 QuartEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 QuartEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return QuartEaseOut(t * 2.0f, b, c * 0.5f, d);

            return QuartEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Quintic

        public static Ease quintEaseOut = QuintEaseOut;
        public static Ease quintEaseIn = QuintEaseIn;
        public static Ease quintEaseInOut = QuintEaseInOut;
        public static Ease quintEaseOutIn = QuintEaseOutIn;

        public static Float3Ease Quint = new Float3Ease() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

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
        public static float3 QuintEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 QuintEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 QuintEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 QuintEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return QuintEaseOut(t * 2.0f, b, c * 0.5f, d);
            return QuintEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Elastic

        public static Ease elasticEaseOut = ElasticEaseOut;
        public static Ease elasticEaseIn = ElasticEaseIn;
        public static Ease elasticEaseInOut = ElasticEaseInOut;
        public static Ease elasticEaseOutIn = ElasticEaseOutIn;

        public static Float3Ease Elastic = new Float3Ease() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

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
        public static float3 ElasticEaseOut(float t, float3 b, float3 c, float d)
        {
            if ((t /= d) == 1)
                return b + c;

            float3 p = d * .3f;
            float3 s = p / 4.0f;

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
        public static float3 ElasticEaseIn(float t, float3 b, float3 c, float d)
        {
            if ((t /= d) == 1.0f)
                return b + c;

            float3 p = d * .3f;
            float3 s = p / 4.0f;

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
        public static float3 ElasticEaseInOut(float t, float3 b, float3 c, float d)
        {
            if ((t /= d * 0.5f) == 2.0f)
                return b + c;

            float3 p = d * (.3f * 1.5f);
            float3 s = p / 4.0f;

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
        public static float3 ElasticEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d / 2)
                return ElasticEaseOut(t * 2, b, c / 2, d);
            return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Bounce

        public static Ease bounceEaseOut = BounceEaseOut;
        public static Ease bounceEaseIn = BounceEaseIn;
        public static Ease bounceEaseInOut = BounceEaseInOut;
        public static Ease bounceEaseOutIn = BounceEaseOutIn;

        public static Float3Ease Bounce = new Float3Ease() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

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
        public static float3 BounceEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 BounceEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 BounceEaseInOut(float t, float3 b, float3 c, float d)
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
        public static float3 BounceEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d / 2)
                return BounceEaseOut(t * 2.0f, b, c * 0.5f, d);
            return BounceEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Back

        public static Ease backEaseOut = BackEaseOut;
        public static Ease backEaseIn = BackEaseIn;
        public static Ease backEaseInOut = BackEaseInOut;
        public static Ease backEaseOutIn = BackEaseOutIn;

        public static Float3Ease Back = new Float3Ease() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

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
        public static float3 BackEaseOut(float t, float3 b, float3 c, float d)
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
        public static float3 BackEaseIn(float t, float3 b, float3 c, float d)
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
        public static float3 BackEaseInOut(float t, float3 b, float3 c, float d)
        {
            float3 s = 1.70158f;
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
        public static float3 BackEaseOutIn(float t, float3 b, float3 c, float d)
        {
            if (t < d * 0.5f)
                return BackEaseOut(t * 2.0f, b, c * 0.5f, d);
            return BackEaseIn((t * 2.0f) - d, b + c * 0.5f, c * 0.5f, d);
        }

        #endregion

        #region Slerp

        public static Ease slerp = SlerpEase;

        public static Float3Ease Slerp = new Float3Ease() { Out = slerp, In = slerp, InOut = slerp, OutIn = slerp };

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
        public static float3 SlerpEase(float t, float3 b, float3 c, float d)
        {
            return Vector3.Slerp(b, b+c, t/f);
        }


        #endregion

    }
}
