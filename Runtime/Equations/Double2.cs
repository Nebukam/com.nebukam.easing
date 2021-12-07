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
    public static class Double2
    {

        #region None

        internal static Easing.Ease<double2> none = None;
        public static Easing.EaseVariants<double2> NoEase = new Easing.EaseVariants<double2>() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double2 None(double2 a, double2 b, float t, float d){ return b; }

        #endregion

        #region BASE

        #region Linear

        internal static Easing.Ease<double2> linear = Linear;
        public static Easing.EaseVariants<double2> LinearEase = new Easing.EaseVariants<double2>() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double2 Linear(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        internal static Easing.Ease<double2> expoEaseOut = ExpoEaseOut;
        internal static Easing.Ease<double2> expoEaseIn = ExpoEaseIn;
        internal static Easing.Ease<double2> expoEaseInOut = ExpoEaseInOut;
        internal static Easing.Ease<double2> expoEaseOutIn = ExpoEaseOutIn;

        public static Easing.EaseVariants<double2> ExpoEase = new Easing.EaseVariants<double2>() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

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
        internal static double2 ExpoEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseOut(t, d)); }

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
        internal static double2 ExpoEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseIn(t, d)); }

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
        internal static double2 ExpoEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseInOut(t, d)); }


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
        internal static double2 ExpoEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        internal static Easing.Ease<double2> circEaseOut = CircEaseOut;
        internal static Easing.Ease<double2> circEaseIn = CircEaseIn;
        internal static Easing.Ease<double2> circEaseInOut = CircEaseInOut;
        internal static Easing.Ease<double2> circEaseOutIn = CircEaseOutIn;

        public static Easing.EaseVariants<double2> Circ = new Easing.EaseVariants<double2>() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

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
        internal static double2 CircEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CircEaseOut(t, d)); }

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
        internal static double2 CircEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CircEaseIn(t, d)); }

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
        internal static double2 CircEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CircEaseInOut(t, d)); }


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
        internal static double2 CircEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        internal static Easing.Ease<double2> quadEaseOut = QuadEaseOut;
        internal static Easing.Ease<double2> quadEaseIn = QuadEaseIn;
        internal static Easing.Ease<double2> quadEaseInOut = QuadEaseInOut;
        internal static Easing.Ease<double2> quadEaseOutIn = QuadEaseOutIn;

        public static Easing.EaseVariants<double2> Quad = new Easing.EaseVariants<double2>() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

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
        internal static double2 QuadEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseOut(t, d)); }

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
        internal static double2 QuadEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseIn(t, d)); }

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
        internal static double2 QuadEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseInOut(t, d)); }


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
        internal static double2 QuadEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        internal static Easing.Ease<double2> sineEaseOut = SineEaseOut;
        internal static Easing.Ease<double2> sineEaseIn = SineEaseIn;
        internal static Easing.Ease<double2> sineEaseInOut = SineEaseInOut;
        internal static Easing.Ease<double2> sineEaseOutIn = SineEaseOutIn;

        public static Easing.EaseVariants<double2> Sine = new Easing.EaseVariants<double2>() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

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
        internal static double2 SineEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.SineEaseOut(t, d)); }

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
        internal static double2 SineEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.SineEaseIn(t, d)); }

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
        internal static double2 SineEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.SineEaseInOut(t, d)); }

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
        internal static double2 SineEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        internal static Easing.Ease<double2> cubicEaseOut = CubicEaseOut;
        internal static Easing.Ease<double2> cubicEaseIn = CubicEaseIn;
        internal static Easing.Ease<double2> cubicEaseInOut = CubicEaseInOut;
        internal static Easing.Ease<double2> cubicEaseOutIn = CubicEaseOutIn;

        public static Easing.EaseVariants<double2> Cubic = new Easing.EaseVariants<double2>() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

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
        internal static double2 CubicEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseOut(t, d)); }

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
        internal static double2 CubicEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseIn(t, d)); }

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
        internal static double2 CubicEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseInOut(t, d)); }

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
        internal static double2 CubicEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        internal static Easing.Ease<double2> quartEaseOut = QuartEaseOut;
        internal static Easing.Ease<double2> quartEaseIn = QuartEaseIn;
        internal static Easing.Ease<double2> quartEaseInOut = QuartEaseInOut;
        internal static Easing.Ease<double2> quartEaseOutIn = QuartEaseOutIn;

        public static Easing.EaseVariants<double2> Quart = new Easing.EaseVariants<double2>() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

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
        internal static double2 QuartEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseOut(t, d)); }

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
        internal static double2 QuartEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseIn(t, d)); }

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
        internal static double2 QuartEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseInOut(t, d)); }

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
        internal static double2 QuartEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        internal static Easing.Ease<double2> quintEaseOut = QuintEaseOut;
        internal static Easing.Ease<double2> quintEaseIn = QuintEaseIn;
        internal static Easing.Ease<double2> quintEaseInOut = QuintEaseInOut;
        internal static Easing.Ease<double2> quintEaseOutIn = QuintEaseOutIn;

        public static Easing.EaseVariants<double2> Quint = new Easing.EaseVariants<double2>() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

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
        internal static double2 QuintEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseOut(t, d)); }

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
        internal static double2 QuintEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseIn(t, d)); }

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
        internal static double2 QuintEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseInOut(t, d)); }

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
        internal static double2 QuintEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        internal static Easing.Ease<double2> elasticEaseOut = ElasticEaseOut;
        internal static Easing.Ease<double2> elasticEaseIn = ElasticEaseIn;
        internal static Easing.Ease<double2> elasticEaseInOut = ElasticEaseInOut;
        internal static Easing.Ease<double2> elasticEaseOutIn = ElasticEaseOutIn;

        public static Easing.EaseVariants<double2> Elastic = new Easing.EaseVariants<double2>() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

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
        internal static double2 ElasticEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseOut(t, d)); }

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
        internal static double2 ElasticEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseIn(t, d)); }

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
        internal static double2 ElasticEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseInOut(t, d)); }


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
        internal static double2 ElasticEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        internal static Easing.Ease<double2> bounceEaseOut = BounceEaseOut;
        internal static Easing.Ease<double2> bounceEaseIn = BounceEaseIn;
        internal static Easing.Ease<double2> bounceEaseInOut = BounceEaseInOut;
        internal static Easing.Ease<double2> bounceEaseOutIn = BounceEaseOutIn;

        public static Easing.EaseVariants<double2> Bounce = new Easing.EaseVariants<double2>() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

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
        internal static double2 BounceEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseOut(t, d)); }

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
        internal static double2 BounceEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseIn(t, d)); }

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
        internal static double2 BounceEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseInOut(t, d)); }

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
        internal static double2 BounceEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        internal static Easing.Ease<double2> backEaseOut = BackEaseOut;
        internal static Easing.Ease<double2> backEaseIn = BackEaseIn;
        internal static Easing.Ease<double2> backEaseInOut = BackEaseInOut;
        internal static Easing.Ease<double2> backEaseOutIn = BackEaseOutIn;

        public static Easing.EaseVariants<double2> Back = new Easing.EaseVariants<double2>() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

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
        internal static double2 BackEaseOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BackEaseOut(t, d)); }

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
        internal static double2 BackEaseIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BackEaseIn(t, d)); }

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
        internal static double2 BackEaseInOut(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BackEaseInOut(t, d)); }

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
        internal static double2 BackEaseOutIn(double2 a, double2 b, float t, float d) { return lerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

    }

}
