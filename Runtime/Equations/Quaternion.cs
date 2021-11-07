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
    /// Robert Penner's easing functions for quaternion.
    /// Cached delegates start with a lowercase.
    /// </summary>
    public static class Quaternion
    {

        #region None

        internal static Easing.Ease<quaternion> none = None;
        public static Easing.EaseVariants<quaternion> NoEase = new Easing.EaseVariants<quaternion>() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static quaternion None(quaternion a, quaternion b, float t, float d) { return b; }

        #endregion

        #region BASE

        #region Linear

        internal static Easing.Ease<quaternion> linear = Linear;
        public static Easing.EaseVariants<quaternion> LinearEase = new Easing.EaseVariants<quaternion>() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static quaternion Linear(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        internal static Easing.Ease<quaternion> expoEaseOut = ExpoEaseOut;
        internal static Easing.Ease<quaternion> expoEaseIn = ExpoEaseIn;
        internal static Easing.Ease<quaternion> expoEaseInOut = ExpoEaseInOut;
        internal static Easing.Ease<quaternion> expoEaseOutIn = ExpoEaseOutIn;

        public static Easing.EaseVariants<quaternion> ExpoEase = new Easing.EaseVariants<quaternion>() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

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
        internal static quaternion ExpoEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ExpoEaseOut(t, d)); }

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
        internal static quaternion ExpoEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ExpoEaseIn(t, d)); }

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
        internal static quaternion ExpoEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ExpoEaseInOut(t, d)); }


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
        internal static quaternion ExpoEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        internal static Easing.Ease<quaternion> circEaseOut = CircEaseOut;
        internal static Easing.Ease<quaternion> circEaseIn = CircEaseIn;
        internal static Easing.Ease<quaternion> circEaseInOut = CircEaseInOut;
        internal static Easing.Ease<quaternion> circEaseOutIn = CircEaseOutIn;

        public static Easing.EaseVariants<quaternion> Circ = new Easing.EaseVariants<quaternion>() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

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
        internal static quaternion CircEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CircEaseOut(t, d)); }

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
        internal static quaternion CircEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CircEaseIn(t, d)); }

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
        internal static quaternion CircEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CircEaseInOut(t, d)); }


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
        internal static quaternion CircEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        internal static Easing.Ease<quaternion> quadEaseOut = QuadEaseOut;
        internal static Easing.Ease<quaternion> quadEaseIn = QuadEaseIn;
        internal static Easing.Ease<quaternion> quadEaseInOut = QuadEaseInOut;
        internal static Easing.Ease<quaternion> quadEaseOutIn = QuadEaseOutIn;

        public static Easing.EaseVariants<quaternion> Quad = new Easing.EaseVariants<quaternion>() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

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
        internal static quaternion QuadEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuadEaseOut(t, d)); }

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
        internal static quaternion QuadEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuadEaseIn(t, d)); }

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
        internal static quaternion QuadEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuadEaseInOut(t, d)); }


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
        internal static quaternion QuadEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        internal static Easing.Ease<quaternion> sineEaseOut = SineEaseOut;
        internal static Easing.Ease<quaternion> sineEaseIn = SineEaseIn;
        internal static Easing.Ease<quaternion> sineEaseInOut = SineEaseInOut;
        internal static Easing.Ease<quaternion> sineEaseOutIn = SineEaseOutIn;

        public static Easing.EaseVariants<quaternion> Sine = new Easing.EaseVariants<quaternion>() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

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
        internal static quaternion SineEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.SineEaseOut(t, d)); }

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
        internal static quaternion SineEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.SineEaseIn(t, d)); }

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
        internal static quaternion SineEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.SineEaseInOut(t, d)); }

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
        internal static quaternion SineEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        internal static Easing.Ease<quaternion> cubicEaseOut = CubicEaseOut;
        internal static Easing.Ease<quaternion> cubicEaseIn = CubicEaseIn;
        internal static Easing.Ease<quaternion> cubicEaseInOut = CubicEaseInOut;
        internal static Easing.Ease<quaternion> cubicEaseOutIn = CubicEaseOutIn;

        public static Easing.EaseVariants<quaternion> Cubic = new Easing.EaseVariants<quaternion>() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

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
        internal static quaternion CubicEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CubicEaseOut(t, d)); }

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
        internal static quaternion CubicEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CubicEaseIn(t, d)); }

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
        internal static quaternion CubicEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CubicEaseInOut(t, d)); }

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
        internal static quaternion CubicEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        internal static Easing.Ease<quaternion> quartEaseOut = QuartEaseOut;
        internal static Easing.Ease<quaternion> quartEaseIn = QuartEaseIn;
        internal static Easing.Ease<quaternion> quartEaseInOut = QuartEaseInOut;
        internal static Easing.Ease<quaternion> quartEaseOutIn = QuartEaseOutIn;

        public static Easing.EaseVariants<quaternion> Quart = new Easing.EaseVariants<quaternion>() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

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
        internal static quaternion QuartEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuartEaseOut(t, d)); }

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
        internal static quaternion QuartEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuartEaseIn(t, d)); }

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
        internal static quaternion QuartEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuartEaseInOut(t, d)); }

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
        internal static quaternion QuartEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        internal static Easing.Ease<quaternion> quintEaseOut = QuintEaseOut;
        internal static Easing.Ease<quaternion> quintEaseIn = QuintEaseIn;
        internal static Easing.Ease<quaternion> quintEaseInOut = QuintEaseInOut;
        internal static Easing.Ease<quaternion> quintEaseOutIn = QuintEaseOutIn;

        public static Easing.EaseVariants<quaternion> Quint = new Easing.EaseVariants<quaternion>() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

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
        internal static quaternion QuintEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuintEaseOut(t, d)); }

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
        internal static quaternion QuintEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuintEaseIn(t, d)); }

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
        internal static quaternion QuintEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuintEaseInOut(t, d)); }

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
        internal static quaternion QuintEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        internal static Easing.Ease<quaternion> elasticEaseOut = ElasticEaseOut;
        internal static Easing.Ease<quaternion> elasticEaseIn = ElasticEaseIn;
        internal static Easing.Ease<quaternion> elasticEaseInOut = ElasticEaseInOut;
        internal static Easing.Ease<quaternion> elasticEaseOutIn = ElasticEaseOutIn;

        public static Easing.EaseVariants<quaternion> Elastic = new Easing.EaseVariants<quaternion>() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

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
        internal static quaternion ElasticEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ElasticEaseOut(t, d)); }

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
        internal static quaternion ElasticEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ElasticEaseIn(t, d)); }

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
        internal static quaternion ElasticEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ElasticEaseInOut(t, d)); }


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
        internal static quaternion ElasticEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        internal static Easing.Ease<quaternion> bounceEaseOut = BounceEaseOut;
        internal static Easing.Ease<quaternion> bounceEaseIn = BounceEaseIn;
        internal static Easing.Ease<quaternion> bounceEaseInOut = BounceEaseInOut;
        internal static Easing.Ease<quaternion> bounceEaseOutIn = BounceEaseOutIn;

        public static Easing.EaseVariants<quaternion> Bounce = new Easing.EaseVariants<quaternion>() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

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
        internal static quaternion BounceEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BounceEaseOut(t, d)); }

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
        internal static quaternion BounceEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BounceEaseIn(t, d)); }

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
        internal static quaternion BounceEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BounceEaseInOut(t, d)); }

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
        internal static quaternion BounceEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        internal static Easing.Ease<quaternion> backEaseOut = BackEaseOut;
        internal static Easing.Ease<quaternion> backEaseIn = BackEaseIn;
        internal static Easing.Ease<quaternion> backEaseInOut = BackEaseInOut;
        internal static Easing.Ease<quaternion> backEaseOutIn = BackEaseOutIn;

        public static Easing.EaseVariants<quaternion> Back = new Easing.EaseVariants<quaternion>() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

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
        internal static quaternion BackEaseOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BackEaseOut(t, d)); }

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
        internal static quaternion BackEaseIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BackEaseIn(t, d)); }

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
        internal static quaternion BackEaseInOut(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BackEaseInOut(t, d)); }

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
        internal static quaternion BackEaseOutIn(quaternion a, quaternion b, float t, float d) { return slerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

    }
}
