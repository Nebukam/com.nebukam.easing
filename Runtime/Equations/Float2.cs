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
using Unity.Mathematics;
using static Unity.Mathematics.math;
using UnityEngine;

namespace Nebukam.Easing
{


    /// <summary>
    /// Robert Penner's easing functions for float.
    /// Cached delegates start with a lowercase.
    /// </summary>
    public static class Float2
    {

        #region None

        public static Easing.Ease<float2> none = None;
        public static Easing.EaseVariants<float2> NoEase = new Easing.EaseVariants<float2>() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 None(float2 a, float2 b, float t, float d){ return b; }

        #endregion

        #region BASE

        #region Linear

        public static Easing.Ease<float2> linear = Linear;
        public static Easing.EaseVariants<float2> LinearEase = new Easing.EaseVariants<float2>() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Linear(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        public static Easing.Ease<float2> expoEaseOut = ExpoEaseOut;
        public static Easing.Ease<float2> expoEaseIn = ExpoEaseIn;
        public static Easing.Ease<float2> expoEaseInOut = ExpoEaseInOut;
        public static Easing.Ease<float2> expoEaseOutIn = ExpoEaseOutIn;

        public static Easing.EaseVariants<float2> ExpoEase = new Easing.EaseVariants<float2>() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ExpoEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ExpoEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for an exponential (2^t) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ExpoEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseInOut(t, d)); }


        /// <summary>
        /// Easing equation function for an exponential (2^t) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ExpoEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        public static Easing.Ease<float2> circEaseOut = CircEaseOut;
        public static Easing.Ease<float2> circEaseIn = CircEaseIn;
        public static Easing.Ease<float2> circEaseInOut = CircEaseInOut;
        public static Easing.Ease<float2> circEaseOutIn = CircEaseOutIn;

        public static Easing.EaseVariants<float2> Circ = new Easing.EaseVariants<float2>() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CircEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CircEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CircEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CircEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CircEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CircEaseInOut(t, d)); }


        /// <summary>
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CircEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        public static Easing.Ease<float2> quadEaseOut = QuadEaseOut;
        public static Easing.Ease<float2> quadEaseIn = QuadEaseIn;
        public static Easing.Ease<float2> quadEaseInOut = QuadEaseInOut;
        public static Easing.Ease<float2> quadEaseOutIn = QuadEaseOutIn;

        public static Easing.EaseVariants<float2> Quad = new Easing.EaseVariants<float2>() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuadEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuadEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuadEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseInOut(t, d)); }


        /// <summary>
        /// Easing equation function for a quadratic (t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuadEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        public static Easing.Ease<float2> sineEaseOut = SineEaseOut;
        public static Easing.Ease<float2> sineEaseIn = SineEaseIn;
        public static Easing.Ease<float2> sineEaseInOut = SineEaseInOut;
        public static Easing.Ease<float2> sineEaseOutIn = SineEaseOutIn;

        public static Easing.EaseVariants<float2> Sine = new Easing.EaseVariants<float2>() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SineEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.SineEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SineEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.SineEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SineEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.SineEaseInOut(t, d)); }

        /// <summary>
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 SineEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        public static Easing.Ease<float2> cubicEaseOut = CubicEaseOut;
        public static Easing.Ease<float2> cubicEaseIn = CubicEaseIn;
        public static Easing.Ease<float2> cubicEaseInOut = CubicEaseInOut;
        public static Easing.Ease<float2> cubicEaseOutIn = CubicEaseOutIn;

        public static Easing.EaseVariants<float2> Cubic = new Easing.EaseVariants<float2>() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CubicEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CubicEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CubicEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseInOut(t, d)); }

        /// <summary>
        /// Easing equation function for a cubic (t^3) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 CubicEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        public static Easing.Ease<float2> quartEaseOut = QuartEaseOut;
        public static Easing.Ease<float2> quartEaseIn = QuartEaseIn;
        public static Easing.Ease<float2> quartEaseInOut = QuartEaseInOut;
        public static Easing.Ease<float2> quartEaseOutIn = QuartEaseOutIn;

        public static Easing.EaseVariants<float2> Quart = new Easing.EaseVariants<float2>() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuartEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuartEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuartEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseInOut(t, d)); }

        /// <summary>
        /// Easing equation function for a quartic (t^4) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuartEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        public static Easing.Ease<float2> quintEaseOut = QuintEaseOut;
        public static Easing.Ease<float2> quintEaseIn = QuintEaseIn;
        public static Easing.Ease<float2> quintEaseInOut = QuintEaseInOut;
        public static Easing.Ease<float2> quintEaseOutIn = QuintEaseOutIn;

        public static Easing.EaseVariants<float2> Quint = new Easing.EaseVariants<float2>() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuintEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuintEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuintEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseInOut(t, d)); }

        /// <summary>
        /// Easing equation function for a quintic (t^5) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 QuintEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        public static Easing.Ease<float2> elasticEaseOut = ElasticEaseOut;
        public static Easing.Ease<float2> elasticEaseIn = ElasticEaseIn;
        public static Easing.Ease<float2> elasticEaseInOut = ElasticEaseInOut;
        public static Easing.Ease<float2> elasticEaseOutIn = ElasticEaseOutIn;

        public static Easing.EaseVariants<float2> Elastic = new Easing.EaseVariants<float2>() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ElasticEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ElasticEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ElasticEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseInOut(t, d)); }


        /// <summary>
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 ElasticEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        public static Easing.Ease<float2> bounceEaseOut = BounceEaseOut;
        public static Easing.Ease<float2> bounceEaseIn = BounceEaseIn;
        public static Easing.Ease<float2> bounceEaseInOut = BounceEaseInOut;
        public static Easing.Ease<float2> bounceEaseOutIn = BounceEaseOutIn;

        public static Easing.EaseVariants<float2> Bounce = new Easing.EaseVariants<float2>() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BounceEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BounceEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BounceEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseInOut(t, d)); }

        /// <summary>
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BounceEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        public static Easing.Ease<float2> backEaseOut = BackEaseOut;
        public static Easing.Ease<float2> backEaseIn = BackEaseIn;
        public static Easing.Ease<float2> backEaseInOut = BackEaseInOut;
        public static Easing.Ease<float2> backEaseOutIn = BackEaseOutIn;

        public static Easing.EaseVariants<float2> Back = new Easing.EaseVariants<float2>() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: 
        /// decelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BackEaseOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BackEaseOut(t, d)); }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: 
        /// accelerating from zero velocity.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BackEaseIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BackEaseIn(t, d)); }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: 
        /// acceleration until halfway, then deceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BackEaseInOut(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BackEaseInOut(t, d)); }

        /// <summary>
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: 
        /// deceleration until halfway, then acceleration.
        /// </summary>
        /// <param name="a">Starting value</param>
        /// <param name="b">End value.</param>
        /// <param name="t">Current time.</param>
        /// <param name="d">Duration of animation.</param>
        /// <returns>The correct value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 BackEaseOutIn(float2 a, float2 b, float t, float d) { return lerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

    }

}
