// Copyright (c) 2021 Timothé Lapetite - nebukam@gmail.com.
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
    public static class Int4
    {

        #region None

        internal static Easing.Ease<int4> none = None;
        public static Easing.EaseVariants<int4> NoEase = new Easing.EaseVariants<int4>() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int4 None(int4 a, int4 b, float t, float d) { return b; }

        #endregion

        #region BASE

        #region Linear

        internal static Easing.Ease<int4> linear = Linear;
        public static Easing.EaseVariants<int4> LinearEase = new Easing.EaseVariants<int4>() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int4 Linear(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        internal static Easing.Ease<int4> expoEaseOut = ExpoEaseOut;
        internal static Easing.Ease<int4> expoEaseIn = ExpoEaseIn;
        internal static Easing.Ease<int4> expoEaseInOut = ExpoEaseInOut;
        internal static Easing.Ease<int4> expoEaseOutIn = ExpoEaseOutIn;

        public static Easing.EaseVariants<int4> ExpoEase = new Easing.EaseVariants<int4>() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

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
        internal static int4 ExpoEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ExpoEaseOut(t, d)); }

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
        internal static int4 ExpoEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ExpoEaseIn(t, d)); }

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
        internal static int4 ExpoEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ExpoEaseInOut(t, d)); }


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
        internal static int4 ExpoEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        internal static Easing.Ease<int4> circEaseOut = CircEaseOut;
        internal static Easing.Ease<int4> circEaseIn = CircEaseIn;
        internal static Easing.Ease<int4> circEaseInOut = CircEaseInOut;
        internal static Easing.Ease<int4> circEaseOutIn = CircEaseOutIn;

        public static Easing.EaseVariants<int4> Circ = new Easing.EaseVariants<int4>() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

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
        internal static int4 CircEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CircEaseOut(t, d)); }

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
        internal static int4 CircEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CircEaseIn(t, d)); }

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
        internal static int4 CircEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CircEaseInOut(t, d)); }


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
        internal static int4 CircEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        internal static Easing.Ease<int4> quadEaseOut = QuadEaseOut;
        internal static Easing.Ease<int4> quadEaseIn = QuadEaseIn;
        internal static Easing.Ease<int4> quadEaseInOut = QuadEaseInOut;
        internal static Easing.Ease<int4> quadEaseOutIn = QuadEaseOutIn;

        public static Easing.EaseVariants<int4> Quad = new Easing.EaseVariants<int4>() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

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
        internal static int4 QuadEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuadEaseOut(t, d)); }

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
        internal static int4 QuadEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuadEaseIn(t, d)); }

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
        internal static int4 QuadEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuadEaseInOut(t, d)); }


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
        internal static int4 QuadEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        internal static Easing.Ease<int4> sineEaseOut = SineEaseOut;
        internal static Easing.Ease<int4> sineEaseIn = SineEaseIn;
        internal static Easing.Ease<int4> sineEaseInOut = SineEaseInOut;
        internal static Easing.Ease<int4> sineEaseOutIn = SineEaseOutIn;

        public static Easing.EaseVariants<int4> Sine = new Easing.EaseVariants<int4>() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

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
        internal static int4 SineEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.SineEaseOut(t, d)); }

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
        internal static int4 SineEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.SineEaseIn(t, d)); }

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
        internal static int4 SineEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.SineEaseInOut(t, d)); }

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
        internal static int4 SineEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        internal static Easing.Ease<int4> cubicEaseOut = CubicEaseOut;
        internal static Easing.Ease<int4> cubicEaseIn = CubicEaseIn;
        internal static Easing.Ease<int4> cubicEaseInOut = CubicEaseInOut;
        internal static Easing.Ease<int4> cubicEaseOutIn = CubicEaseOutIn;

        public static Easing.EaseVariants<int4> Cubic = new Easing.EaseVariants<int4>() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

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
        internal static int4 CubicEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CubicEaseOut(t, d)); }

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
        internal static int4 CubicEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CubicEaseIn(t, d)); }

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
        internal static int4 CubicEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CubicEaseInOut(t, d)); }

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
        internal static int4 CubicEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        internal static Easing.Ease<int4> quartEaseOut = QuartEaseOut;
        internal static Easing.Ease<int4> quartEaseIn = QuartEaseIn;
        internal static Easing.Ease<int4> quartEaseInOut = QuartEaseInOut;
        internal static Easing.Ease<int4> quartEaseOutIn = QuartEaseOutIn;

        public static Easing.EaseVariants<int4> Quart = new Easing.EaseVariants<int4>() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

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
        internal static int4 QuartEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuartEaseOut(t, d)); }

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
        internal static int4 QuartEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuartEaseIn(t, d)); }

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
        internal static int4 QuartEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuartEaseInOut(t, d)); }

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
        internal static int4 QuartEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        internal static Easing.Ease<int4> quintEaseOut = QuintEaseOut;
        internal static Easing.Ease<int4> quintEaseIn = QuintEaseIn;
        internal static Easing.Ease<int4> quintEaseInOut = QuintEaseInOut;
        internal static Easing.Ease<int4> quintEaseOutIn = QuintEaseOutIn;

        public static Easing.EaseVariants<int4> Quint = new Easing.EaseVariants<int4>() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

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
        internal static int4 QuintEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuintEaseOut(t, d)); }

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
        internal static int4 QuintEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuintEaseIn(t, d)); }

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
        internal static int4 QuintEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuintEaseInOut(t, d)); }

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
        internal static int4 QuintEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        internal static Easing.Ease<int4> elasticEaseOut = ElasticEaseOut;
        internal static Easing.Ease<int4> elasticEaseIn = ElasticEaseIn;
        internal static Easing.Ease<int4> elasticEaseInOut = ElasticEaseInOut;
        internal static Easing.Ease<int4> elasticEaseOutIn = ElasticEaseOutIn;

        public static Easing.EaseVariants<int4> Elastic = new Easing.EaseVariants<int4>() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

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
        internal static int4 ElasticEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ElasticEaseOut(t, d)); }

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
        internal static int4 ElasticEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ElasticEaseIn(t, d)); }

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
        internal static int4 ElasticEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ElasticEaseInOut(t, d)); }


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
        internal static int4 ElasticEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        internal static Easing.Ease<int4> bounceEaseOut = BounceEaseOut;
        internal static Easing.Ease<int4> bounceEaseIn = BounceEaseIn;
        internal static Easing.Ease<int4> bounceEaseInOut = BounceEaseInOut;
        internal static Easing.Ease<int4> bounceEaseOutIn = BounceEaseOutIn;

        public static Easing.EaseVariants<int4> Bounce = new Easing.EaseVariants<int4>() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

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
        internal static int4 BounceEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BounceEaseOut(t, d)); }

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
        internal static int4 BounceEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BounceEaseIn(t, d)); }

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
        internal static int4 BounceEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BounceEaseInOut(t, d)); }

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
        internal static int4 BounceEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        internal static Easing.Ease<int4> backEaseOut = BackEaseOut;
        internal static Easing.Ease<int4> backEaseIn = BackEaseIn;
        internal static Easing.Ease<int4> backEaseInOut = BackEaseInOut;
        internal static Easing.Ease<int4> backEaseOutIn = BackEaseOutIn;

        public static Easing.EaseVariants<int4> Back = new Easing.EaseVariants<int4>() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

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
        internal static int4 BackEaseOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BackEaseOut(t, d)); }

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
        internal static int4 BackEaseIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BackEaseIn(t, d)); }

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
        internal static int4 BackEaseInOut(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BackEaseInOut(t, d)); }

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
        internal static int4 BackEaseOutIn(int4 a, int4 b, float t, float d) { return (int4)lerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

    }

}
