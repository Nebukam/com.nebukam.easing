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
    /// Robert Penner's easing functions for float3.
    /// Cached delegates start with a lowercase.
    /// </summary>
    public static class Float3
    {
                
        #region None

        public static Easing.Ease<float3> none = None;
        public static Easing.EaseVariants<float3> NoEase = new Easing.EaseVariants<float3>() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 None(float3 a, float3 b, float t, float d){ return b; }

        #endregion

        #region BASE

        #region Linear

        public static Easing.Ease<float3> linear = Linear;
        public static Easing.EaseVariants<float3> LinearEase = new Easing.EaseVariants<float3>() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Linear(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        public static Easing.Ease<float3> expoEaseOut = ExpoEaseOut;
        public static Easing.Ease<float3> expoEaseIn = ExpoEaseIn;
        public static Easing.Ease<float3> expoEaseInOut = ExpoEaseInOut;
        public static Easing.Ease<float3> expoEaseOutIn = ExpoEaseOutIn;

        public static Easing.EaseVariants<float3> ExpoEase = new Easing.EaseVariants<float3>() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

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
        public static float3 ExpoEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseOut(t, d)); }

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
        public static float3 ExpoEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseIn(t, d)); }

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
        public static float3 ExpoEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseInOut(t, d)); }


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
        public static float3 ExpoEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        public static Easing.Ease<float3> circEaseOut = CircEaseOut;
        public static Easing.Ease<float3> circEaseIn = CircEaseIn;
        public static Easing.Ease<float3> circEaseInOut = CircEaseInOut;
        public static Easing.Ease<float3> circEaseOutIn = CircEaseOutIn;

        public static Easing.EaseVariants<float3> Circ = new Easing.EaseVariants<float3>() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

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
        public static float3 CircEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CircEaseOut(t, d)); }

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
        public static float3 CircEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CircEaseIn(t, d)); }

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
        public static float3 CircEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CircEaseInOut(t, d)); }


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
        public static float3 CircEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        public static Easing.Ease<float3> quadEaseOut = QuadEaseOut;
        public static Easing.Ease<float3> quadEaseIn = QuadEaseIn;
        public static Easing.Ease<float3> quadEaseInOut = QuadEaseInOut;
        public static Easing.Ease<float3> quadEaseOutIn = QuadEaseOutIn;

        public static Easing.EaseVariants<float3> Quad = new Easing.EaseVariants<float3>() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

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
        public static float3 QuadEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuadEaseOut(t, d)); }

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
        public static float3 QuadEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuadEaseIn(t, d)); }

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
        public static float3 QuadEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuadEaseInOut(t, d)); }


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
        public static float3 QuadEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        public static Easing.Ease<float3> sineEaseOut = SineEaseOut;
        public static Easing.Ease<float3> sineEaseIn = SineEaseIn;
        public static Easing.Ease<float3> sineEaseInOut = SineEaseInOut;
        public static Easing.Ease<float3> sineEaseOutIn = SineEaseOutIn;

        public static Easing.EaseVariants<float3> Sine = new Easing.EaseVariants<float3>() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

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
        public static float3 SineEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.SineEaseOut(t, d)); }

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
        public static float3 SineEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.SineEaseIn(t, d)); }

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
        public static float3 SineEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.SineEaseInOut(t, d)); }

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
        public static float3 SineEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        public static Easing.Ease<float3> cubicEaseOut = CubicEaseOut;
        public static Easing.Ease<float3> cubicEaseIn = CubicEaseIn;
        public static Easing.Ease<float3> cubicEaseInOut = CubicEaseInOut;
        public static Easing.Ease<float3> cubicEaseOutIn = CubicEaseOutIn;

        public static Easing.EaseVariants<float3> Cubic = new Easing.EaseVariants<float3>() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

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
        public static float3 CubicEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CubicEaseOut(t, d)); }

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
        public static float3 CubicEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CubicEaseIn(t, d)); }

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
        public static float3 CubicEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CubicEaseInOut(t, d)); }

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
        public static float3 CubicEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        public static Easing.Ease<float3> quartEaseOut = QuartEaseOut;
        public static Easing.Ease<float3> quartEaseIn = QuartEaseIn;
        public static Easing.Ease<float3> quartEaseInOut = QuartEaseInOut;
        public static Easing.Ease<float3> quartEaseOutIn = QuartEaseOutIn;

        public static Easing.EaseVariants<float3> Quart = new Easing.EaseVariants<float3>() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

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
        public static float3 QuartEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuartEaseOut(t, d)); }

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
        public static float3 QuartEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuartEaseIn(t, d)); }

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
        public static float3 QuartEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuartEaseInOut(t, d)); }

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
        public static float3 QuartEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        public static Easing.Ease<float3> quintEaseOut = QuintEaseOut;
        public static Easing.Ease<float3> quintEaseIn = QuintEaseIn;
        public static Easing.Ease<float3> quintEaseInOut = QuintEaseInOut;
        public static Easing.Ease<float3> quintEaseOutIn = QuintEaseOutIn;

        public static Easing.EaseVariants<float3> Quint = new Easing.EaseVariants<float3>() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

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
        public static float3 QuintEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuintEaseOut(t, d)); }

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
        public static float3 QuintEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuintEaseIn(t, d)); }

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
        public static float3 QuintEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuintEaseInOut(t, d)); }

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
        public static float3 QuintEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        public static Easing.Ease<float3> elasticEaseOut = ElasticEaseOut;
        public static Easing.Ease<float3> elasticEaseIn = ElasticEaseIn;
        public static Easing.Ease<float3> elasticEaseInOut = ElasticEaseInOut;
        public static Easing.Ease<float3> elasticEaseOutIn = ElasticEaseOutIn;

        public static Easing.EaseVariants<float3> Elastic = new Easing.EaseVariants<float3>() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

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
        public static float3 ElasticEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseOut(t, d)); }

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
        public static float3 ElasticEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseIn(t, d)); }

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
        public static float3 ElasticEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseInOut(t, d)); }


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
        public static float3 ElasticEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        public static Easing.Ease<float3> bounceEaseOut = BounceEaseOut;
        public static Easing.Ease<float3> bounceEaseIn = BounceEaseIn;
        public static Easing.Ease<float3> bounceEaseInOut = BounceEaseInOut;
        public static Easing.Ease<float3> bounceEaseOutIn = BounceEaseOutIn;

        public static Easing.EaseVariants<float3> Bounce = new Easing.EaseVariants<float3>() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

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
        public static float3 BounceEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BounceEaseOut(t, d)); }

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
        public static float3 BounceEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BounceEaseIn(t, d)); }

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
        public static float3 BounceEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BounceEaseInOut(t, d)); }

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
        public static float3 BounceEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        public static Easing.Ease<float3> backEaseOut = BackEaseOut;
        public static Easing.Ease<float3> backEaseIn = BackEaseIn;
        public static Easing.Ease<float3> backEaseInOut = BackEaseInOut;
        public static Easing.Ease<float3> backEaseOutIn = BackEaseOutIn;

        public static Easing.EaseVariants<float3> Back = new Easing.EaseVariants<float3>() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

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
        public static float3 BackEaseOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BackEaseOut(t, d)); }

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
        public static float3 BackEaseIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BackEaseIn(t, d)); }

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
        public static float3 BackEaseInOut(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BackEaseInOut(t, d)); }

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
        public static float3 BackEaseOutIn(float3 a, float3 b, float t, float d) { return lerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

        #region SLERP

        #region Linear

        public static Easing.Ease<float3> linearSlerp = LinearSlerp;
        public static Easing.EaseVariants<float3> LinearSlerpEase = new Easing.EaseVariants<float3>() { Out = linearSlerp, In = linearSlerp, InOut = linearSlerp, OutIn = linearSlerp };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 LinearSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        public static Easing.Ease<float3> expoEaseOutSlerp = ExpoEaseOutSlerp;
        public static Easing.Ease<float3> expoEaseInSlerp = ExpoEaseInSlerp;
        public static Easing.Ease<float3> expoEaseInOutSlerp = ExpoEaseInOutSlerp;
        public static Easing.Ease<float3> expoEaseOutInSlerp = ExpoEaseOutInSlerp;

        public static Easing.EaseVariants<float3> ExpoEaseSlerp = new Easing.EaseVariants<float3>() { Out = expoEaseOutSlerp, In = expoEaseInSlerp, InOut = expoEaseInOutSlerp, OutIn = expoEaseOutInSlerp };

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
        public static float3 ExpoEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ExpoEaseOut(t, d)); }

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
        public static float3 ExpoEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ExpoEaseIn(t, d)); }

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
        public static float3 ExpoEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ExpoEaseIn(t, d)); }


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
        public static float3 ExpoEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        public static Easing.Ease<float3> circEaseOutSlerp = CircEaseOutSlerp;
        public static Easing.Ease<float3> circEaseInSlerp = CircEaseInSlerp;
        public static Easing.Ease<float3> circEaseInOutSlerp = CircEaseInOutSlerp;
        public static Easing.Ease<float3> circEaseOutInSlerp = CircEaseOutInSlerp;

        public static Easing.EaseVariants<float3> CircSlerp = new Easing.EaseVariants<float3>() { Out = circEaseOutSlerp, In = circEaseInSlerp, InOut = circEaseInOutSlerp, OutIn = circEaseOutInSlerp };

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
        public static float3 CircEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CircEaseOut(t, d)); }

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
        public static float3 CircEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CircEaseIn(t, d)); }

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
        public static float3 CircEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CircEaseInOut(t, d)); }


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
        public static float3 CircEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        public static Easing.Ease<float3> quadEaseOutSlerp = QuadEaseOutSlerp;
        public static Easing.Ease<float3> quadEaseInSlerp = QuadEaseInSlerp;
        public static Easing.Ease<float3> quadEaseInOutSlerp = QuadEaseInOutSlerp;
        public static Easing.Ease<float3> quadEaseOutInSlerp = QuadEaseOutInSlerp;

        public static Easing.EaseVariants<float3> QuadSlerp = new Easing.EaseVariants<float3>() { Out = quadEaseOutSlerp, In = quadEaseInSlerp, InOut = quadEaseInOutSlerp, OutIn = quadEaseOutInSlerp };

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
        public static float3 QuadEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuadEaseOut(t, d)); }

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
        public static float3 QuadEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuadEaseQuadEaseInOut(t, d)); }

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
        public static float3 QuadEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuadEaseInOut(t, d)); }


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
        public static float3 QuadEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        public static Easing.Ease<float3> sineEaseOutSlerp = SineEaseOutSlerp;
        public static Easing.Ease<float3> sineEaseInSlerp = SineEaseInSlerp;
        public static Easing.Ease<float3> sineEaseInOutSlerp = SineEaseInOutSlerp;
        public static Easing.Ease<float3> sineEaseOutInSlerp = SineEaseOutInSlerp;

        public static Easing.EaseVariants<float3> SineSlerp = new Easing.EaseVariants<float3>() { Out = sineEaseOutSlerp, In = sineEaseInSlerp, InOut = sineEaseInOutSlerp, OutIn = sineEaseOutInSlerp };

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
        public static float3 SineEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.SineEaseOut(t, d)); }

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
        public static float3 SineEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.SineEaseIn(t, d)); }

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
        public static float3 SineEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.SineEaseInOut(t, d)); }

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
        public static float3 SineEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        public static Easing.Ease<float3> cubicEaseOutSlerp = CubicEaseOutSlerp;
        public static Easing.Ease<float3> cubicEaseInSlerp = CubicEaseInSlerp;
        public static Easing.Ease<float3> cubicEaseInOutSlerp = CubicEaseInOutSlerp;
        public static Easing.Ease<float3> cubicEaseOutInSlerp = CubicEaseOutInSlerp;

        public static Easing.EaseVariants<float3> CubicSlerp = new Easing.EaseVariants<float3>() { Out = cubicEaseOutSlerp, In = cubicEaseInSlerp, InOut = cubicEaseInOutSlerp, OutIn = cubicEaseOutInSlerp };

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
        public static float3 CubicEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CubicEaseOut(t, d)); }

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
        public static float3 CubicEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CubicEaseIn(t, d)); }

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
        public static float3 CubicEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CubicEaseInOut(t, d)); }

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
        public static float3 CubicEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        public static Easing.Ease<float3> quartEaseOutSlerp = QuartEaseOutSlerp;
        public static Easing.Ease<float3> quartEaseInSlerp = QuartEaseInSlerp;
        public static Easing.Ease<float3> quartEaseInOutSlerp = QuartEaseInOutSlerp;
        public static Easing.Ease<float3> quartEaseOutInSlerp = QuartEaseOutInSlerp;

        public static Easing.EaseVariants<float3> QuartSlerp = new Easing.EaseVariants<float3>() { Out = quartEaseOutSlerp, In = quartEaseInSlerp, InOut = quartEaseInOutSlerp, OutIn = quartEaseOutInSlerp };

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
        public static float3 QuartEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuartEaseOut(t, d)); }

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
        public static float3 QuartEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuartEaseIn(t, d)); }

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
        public static float3 QuartEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuartEaseInOut(t, d)); }

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
        public static float3 QuartEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        public static Easing.Ease<float3> quintEaseOutSlerp = QuintEaseOutSlerp;
        public static Easing.Ease<float3> quintEaseInSlerp = QuintEaseInSlerp;
        public static Easing.Ease<float3> quintEaseInOutSlerp = QuintEaseInOutSlerp;
        public static Easing.Ease<float3> quintEaseOutInSlerp = QuintEaseOutInSlerp;

        public static Easing.EaseVariants<float3> QuintSlerp = new Easing.EaseVariants<float3>() { Out = quintEaseOutSlerp, In = quintEaseInSlerp, InOut = quintEaseInOutSlerp, OutIn = quintEaseOutInSlerp };

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
        public static float3 QuintEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuintEaseOut(t, d)); }

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
        public static float3 QuintEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuintEaseIn(t, d)); }

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
        public static float3 QuintEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuintEaseInOut(t, d)); }

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
        public static float3 QuintEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        public static Easing.Ease<float3> elasticEaseOutSlerp = ElasticEaseOutSlerp;
        public static Easing.Ease<float3> elasticEaseInSlerp = ElasticEaseInSlerp;
        public static Easing.Ease<float3> elasticEaseInOutSlerp = ElasticEaseInOutSlerp;
        public static Easing.Ease<float3> elasticEaseOutInSlerp = ElasticEaseOutInSlerp;

        public static Easing.EaseVariants<float3> ElasticSlerp = new Easing.EaseVariants<float3>() { Out = elasticEaseOutSlerp, In = elasticEaseInSlerp, InOut = elasticEaseInOutSlerp, OutIn = elasticEaseOutInSlerp };

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
        public static float3 ElasticEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ElasticEaseOut(t, d)); }

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
        public static float3 ElasticEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ElasticEaseIn(t, d)); }

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
        public static float3 ElasticEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ElasticEaseInOut(t, d)); }


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
        public static float3 ElasticEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        public static Easing.Ease<float3> bounceEaseOutSlerp = BounceEaseOutSlerp;
        public static Easing.Ease<float3> bounceEaseInSlerp = BounceEaseInSlerp;
        public static Easing.Ease<float3> bounceEaseInOutSlerp = BounceEaseInOutSlerp;
        public static Easing.Ease<float3> bounceEaseOutInSlerp = BounceEaseOutInSlerp;

        public static Easing.EaseVariants<float3> BounceSlerp = new Easing.EaseVariants<float3>() { Out = bounceEaseOutSlerp, In = bounceEaseInSlerp, InOut = bounceEaseInOutSlerp, OutIn = bounceEaseOutInSlerp };

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
        public static float3 BounceEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BounceEaseOut(t, d)); }

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
        public static float3 BounceEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BounceEaseIn(t, d)); }

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
        public static float3 BounceEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BounceEaseInOut(t, d)); }

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
        public static float3 BounceEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        public static Easing.Ease<float3> backEaseOutSlerp = BackEaseOutSlerp;
        public static Easing.Ease<float3> backEaseInSlerp = BackEaseInSlerp;
        public static Easing.Ease<float3> backEaseInOutSlerp = BackEaseInOutSlerp;
        public static Easing.Ease<float3> backEaseOutInSlerp = BackEaseOutInSlerp;

        public static Easing.EaseVariants<float3> BackSlerp = new Easing.EaseVariants<float3>() { Out = backEaseOutSlerp, In = backEaseInSlerp, InOut = backEaseInOutSlerp, OutIn = backEaseOutInSlerp };

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
        public static float3 BackEaseOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BackEaseOut(t, d)); }

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
        public static float3 BackEaseInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BackEaseIn(t, d)); }

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
        public static float3 BackEaseInOutSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BackEaseInOut(t, d)); }

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
        public static float3 BackEaseOutInSlerp(float3 a, float3 b, float t, float d) { return Vector3.Slerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

    }
}
