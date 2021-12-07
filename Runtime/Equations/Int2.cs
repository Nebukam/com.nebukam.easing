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
    public static class Int2
    {

        #region None

        public static Easing.Ease<int2> none = None;
        public static Easing.EaseVariants<int2> NoEase = new Easing.EaseVariants<int2>() { Out = none, In = none, InOut = none, OutIn = none };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 None(int2 a, int2 b, float t, float d) { return b; }

        #endregion

        #region BASE

        #region Linear

        public static Easing.Ease<int2> linear = Linear;
        public static Easing.EaseVariants<int2> LinearEase = new Easing.EaseVariants<int2>() { Out = linear, In = linear, InOut = linear, OutIn = linear };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 Linear(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.Linear(t, d)); }

        #endregion

        #region Expo

        public static Easing.Ease<int2> expoEaseOut = ExpoEaseOut;
        public static Easing.Ease<int2> expoEaseIn = ExpoEaseIn;
        public static Easing.Ease<int2> expoEaseInOut = ExpoEaseInOut;
        public static Easing.Ease<int2> expoEaseOutIn = ExpoEaseOutIn;

        public static Easing.EaseVariants<int2> ExpoEase = new Easing.EaseVariants<int2>() { Out = expoEaseOut, In = expoEaseIn, InOut = expoEaseInOut, OutIn = expoEaseOutIn };

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
        public static int2 ExpoEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ExpoEaseOut(t, d)); }

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
        public static int2 ExpoEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ExpoEaseIn(t, d)); }

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
        public static int2 ExpoEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ExpoEaseInOut(t, d)); }


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
        public static int2 ExpoEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ExpoEaseOutIn(t, d)); }

        #endregion

        #region Circular

        public static Easing.Ease<int2> circEaseOut = CircEaseOut;
        public static Easing.Ease<int2> circEaseIn = CircEaseIn;
        public static Easing.Ease<int2> circEaseInOut = CircEaseInOut;
        public static Easing.Ease<int2> circEaseOutIn = CircEaseOutIn;

        public static Easing.EaseVariants<int2> Circ = new Easing.EaseVariants<int2>() { Out = circEaseOut, In = circEaseIn, InOut = circEaseInOut, OutIn = circEaseOutIn };

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
        public static int2 CircEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CircEaseOut(t, d)); }

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
        public static int2 CircEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CircEaseIn(t, d)); }

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
        public static int2 CircEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CircEaseInOut(t, d)); }


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
        public static int2 CircEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CircEaseOutIn(t, d)); }

        #endregion

        #region Quad


        public static Easing.Ease<int2> quadEaseOut = QuadEaseOut;
        public static Easing.Ease<int2> quadEaseIn = QuadEaseIn;
        public static Easing.Ease<int2> quadEaseInOut = QuadEaseInOut;
        public static Easing.Ease<int2> quadEaseOutIn = QuadEaseOutIn;

        public static Easing.EaseVariants<int2> Quad = new Easing.EaseVariants<int2>() { Out = quadEaseOut, In = quadEaseIn, InOut = quadEaseInOut, OutIn = quadEaseOutIn };

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
        public static int2 QuadEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuadEaseOut(t, d)); }

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
        public static int2 QuadEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuadEaseIn(t, d)); }

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
        public static int2 QuadEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuadEaseInOut(t, d)); }


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
        public static int2 QuadEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuadEaseOutIn(t, d)); }

        #endregion

        #region Sine

        public static Easing.Ease<int2> sineEaseOut = SineEaseOut;
        public static Easing.Ease<int2> sineEaseIn = SineEaseIn;
        public static Easing.Ease<int2> sineEaseInOut = SineEaseInOut;
        public static Easing.Ease<int2> sineEaseOutIn = SineEaseOutIn;

        public static Easing.EaseVariants<int2> Sine = new Easing.EaseVariants<int2>() { Out = sineEaseOut, In = sineEaseIn, InOut = sineEaseInOut, OutIn = sineEaseOutIn };

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
        public static int2 SineEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.SineEaseOut(t, d)); }

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
        public static int2 SineEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.SineEaseIn(t, d)); }

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
        public static int2 SineEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.SineEaseInOut(t, d)); }

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
        public static int2 SineEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.SineEaseOutIn(t, d)); }

        #endregion

        #region Cubic

        public static Easing.Ease<int2> cubicEaseOut = CubicEaseOut;
        public static Easing.Ease<int2> cubicEaseIn = CubicEaseIn;
        public static Easing.Ease<int2> cubicEaseInOut = CubicEaseInOut;
        public static Easing.Ease<int2> cubicEaseOutIn = CubicEaseOutIn;

        public static Easing.EaseVariants<int2> Cubic = new Easing.EaseVariants<int2>() { Out = cubicEaseOut, In = cubicEaseIn, InOut = cubicEaseInOut, OutIn = cubicEaseOutIn };

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
        public static int2 CubicEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CubicEaseOut(t, d)); }

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
        public static int2 CubicEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CubicEaseIn(t, d)); }

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
        public static int2 CubicEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CubicEaseInOut(t, d)); }

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
        public static int2 CubicEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.CubicEaseOutIn(t, d)); }

        #endregion

        #region Quartic

        public static Easing.Ease<int2> quartEaseOut = QuartEaseOut;
        public static Easing.Ease<int2> quartEaseIn = QuartEaseIn;
        public static Easing.Ease<int2> quartEaseInOut = QuartEaseInOut;
        public static Easing.Ease<int2> quartEaseOutIn = QuartEaseOutIn;

        public static Easing.EaseVariants<int2> Quart = new Easing.EaseVariants<int2>() { Out = quartEaseOut, In = quartEaseIn, InOut = quartEaseInOut, OutIn = quartEaseOutIn };

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
        public static int2 QuartEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuartEaseOut(t, d)); }

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
        public static int2 QuartEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuartEaseIn(t, d)); }

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
        public static int2 QuartEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuartEaseInOut(t, d)); }

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
        public static int2 QuartEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuartEaseOutIn(t, d)); }

        #endregion

        #region Quintic

        public static Easing.Ease<int2> quintEaseOut = QuintEaseOut;
        public static Easing.Ease<int2> quintEaseIn = QuintEaseIn;
        public static Easing.Ease<int2> quintEaseInOut = QuintEaseInOut;
        public static Easing.Ease<int2> quintEaseOutIn = QuintEaseOutIn;

        public static Easing.EaseVariants<int2> Quint = new Easing.EaseVariants<int2>() { Out = quintEaseOut, In = quintEaseIn, InOut = quintEaseInOut, OutIn = quintEaseOutIn };

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
        public static int2 QuintEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuintEaseOut(t, d)); }

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
        public static int2 QuintEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuintEaseIn(t, d)); }

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
        public static int2 QuintEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuintEaseInOut(t, d)); }

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
        public static int2 QuintEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.QuintEaseOutIn(t, d)); }

        #endregion

        #region Elastic

        public static Easing.Ease<int2> elasticEaseOut = ElasticEaseOut;
        public static Easing.Ease<int2> elasticEaseIn = ElasticEaseIn;
        public static Easing.Ease<int2> elasticEaseInOut = ElasticEaseInOut;
        public static Easing.Ease<int2> elasticEaseOutIn = ElasticEaseOutIn;

        public static Easing.EaseVariants<int2> Elastic = new Easing.EaseVariants<int2>() { Out = elasticEaseOut, In = elasticEaseIn, InOut = elasticEaseInOut, OutIn = elasticEaseOutIn };

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
        public static int2 ElasticEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ElasticEaseOut(t, d)); }

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
        public static int2 ElasticEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ElasticEaseIn(t, d)); }

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
        public static int2 ElasticEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ElasticEaseInOut(t, d)); }


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
        public static int2 ElasticEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.ElasticEaseOutIn(t, d)); }

        #endregion

        #region Bounce

        public static Easing.Ease<int2> bounceEaseOut = BounceEaseOut;
        public static Easing.Ease<int2> bounceEaseIn = BounceEaseIn;
        public static Easing.Ease<int2> bounceEaseInOut = BounceEaseInOut;
        public static Easing.Ease<int2> bounceEaseOutIn = BounceEaseOutIn;

        public static Easing.EaseVariants<int2> Bounce = new Easing.EaseVariants<int2>() { Out = bounceEaseOut, In = bounceEaseIn, InOut = bounceEaseInOut, OutIn = bounceEaseOutIn };

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
        public static int2 BounceEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BounceEaseOut(t, d)); }

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
        public static int2 BounceEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BounceEaseIn(t, d)); }

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
        public static int2 BounceEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BounceEaseInOut(t, d)); }

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
        public static int2 BounceEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BounceEaseOutIn(t, d)); }

        #endregion

        #region Back

        public static Easing.Ease<int2> backEaseOut = BackEaseOut;
        public static Easing.Ease<int2> backEaseIn = BackEaseIn;
        public static Easing.Ease<int2> backEaseInOut = BackEaseInOut;
        public static Easing.Ease<int2> backEaseOutIn = BackEaseOutIn;

        public static Easing.EaseVariants<int2> Back = new Easing.EaseVariants<int2>() { Out = backEaseOut, In = backEaseIn, InOut = backEaseInOut, OutIn = backEaseOutIn };

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
        public static int2 BackEaseOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BackEaseOut(t, d)); }

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
        public static int2 BackEaseIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BackEaseIn(t, d)); }

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
        public static int2 BackEaseInOut(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BackEaseInOut(t, d)); }

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
        public static int2 BackEaseOutIn(int2 a, int2 b, float t, float d) { return (int2)lerp(a, b, Easing.BackEaseOutIn(t, d)); }

        #endregion

        #endregion

    }

}
