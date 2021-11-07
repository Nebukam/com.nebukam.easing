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
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Nebukam.Easing
{

    /// <summary>
    /// Robert Penner's easing.
    /// Partial class, normalized methods (t is expected to be in 0-1 range).
    /// All easing methods are formatted as like a Lerp would be : from, to, t.
    /// </summary>
    public static partial class ease
    {

        #region float
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float linear(float a, float b, float t) { return Float.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float expoEaseOut(float a, float b, float t) { return Float.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float expoEaseIn(float a, float b, float t) { return Float.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float expoEaseInOut(float a, float b, float t) { return Float.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float expoEaseOutIn(float a, float b, float t) { return Float.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float circEaseOut(float a, float b, float t) { return Float.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float circEaseIn(float a, float b, float t) { return Float.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float circEaseInOut(float a, float b, float t) { return Float.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float circEaseOutIn(float a, float b, float t) { return Float.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quadEaseOut(float a, float b, float t) { return Float.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quadEaseIn(float a, float b, float t) { return Float.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quadEaseInOut(float a, float b, float t) { return Float.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quadEaseOutIn(float a, float b, float t) { return Float.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sineEaseOut(float a, float b, float t) { return Float.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sineEaseIn(float a, float b, float t) { return Float.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sineEaseInOut(float a, float b, float t) { return Float.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float sineEaseOutIn(float a, float b, float t) { return Float.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cubicEaseOut(float a, float b, float t) { return Float.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cubicEaseIn(float a, float b, float t) { return Float.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cubicEaseInOut(float a, float b, float t) { return Float.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cubicEaseOutIn(float a, float b, float t) { return Float.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quartEaseOut(float a, float b, float t) { return Float.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quartEaseIn(float a, float b, float t) { return Float.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quartEaseInOut(float a, float b, float t) { return Float.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quartEaseOutIn(float a, float b, float t) { return Float.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quintEaseOut(float a, float b, float t) { return Float.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quintEaseIn(float a, float b, float t) { return Float.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quintEaseInOut(float a, float b, float t) { return Float.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float quintEaseOutIn(float a, float b, float t) { return Float.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float elasticEaseOut(float a, float b, float t) { return Float.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float elasticEaseIn(float a, float b, float t) { return Float.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float elasticEaseInOut(float a, float b, float t) { return Float.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float elasticEaseOutIn(float a, float b, float t) { return Float.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float bounceEaseOut(float a, float b, float t) { return Float.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float bounceEaseIn(float a, float b, float t) { return Float.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float bounceEaseInOut(float a, float b, float t) { return Float.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float bounceEaseOutIn(float a, float b, float t) { return Float.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float backEaseOut(float a, float b, float t) { return Float.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float backEaseIn(float a, float b, float t) { return Float.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float backEaseInOut(float a, float b, float t) { return Float.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float backEaseOutIn(float a, float b, float t) { return Float.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region float2

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 linear(float2 a, float2 b, float t) { return Float2.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 expoEaseOut(float2 a, float2 b, float t) { return Float2.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 expoEaseIn(float2 a, float2 b, float t) { return Float2.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 expoEaseInOut(float2 a, float2 b, float t) { return Float2.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 expoEaseOutIn(float2 a, float2 b, float t) { return Float2.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 circEaseOut(float2 a, float2 b, float t) { return Float2.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 circEaseIn(float2 a, float2 b, float t) { return Float2.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 circEaseInOut(float2 a, float2 b, float t) { return Float2.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 circEaseOutIn(float2 a, float2 b, float t) { return Float2.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quadEaseOut(float2 a, float2 b, float t) { return Float2.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quadEaseIn(float2 a, float2 b, float t) { return Float2.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quadEaseInOut(float2 a, float2 b, float t) { return Float2.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quadEaseOutIn(float2 a, float2 b, float t) { return Float2.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 sineEaseOut(float2 a, float2 b, float t) { return Float2.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 sineEaseIn(float2 a, float2 b, float t) { return Float2.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 sineEaseInOut(float2 a, float2 b, float t) { return Float2.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 sineEaseOutIn(float2 a, float2 b, float t) { return Float2.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 cubicEaseOut(float2 a, float2 b, float t) { return Float2.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 cubicEaseIn(float2 a, float2 b, float t) { return Float2.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 cubicEaseInOut(float2 a, float2 b, float t) { return Float2.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 cubicEaseOutIn(float2 a, float2 b, float t) { return Float2.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quartEaseOut(float2 a, float2 b, float t) { return Float2.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quartEaseIn(float2 a, float2 b, float t) { return Float2.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quartEaseInOut(float2 a, float2 b, float t) { return Float2.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quartEaseOutIn(float2 a, float2 b, float t) { return Float2.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quintEaseOut(float2 a, float2 b, float t) { return Float2.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quintEaseIn(float2 a, float2 b, float t) { return Float2.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quintEaseInOut(float2 a, float2 b, float t) { return Float2.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 quintEaseOutIn(float2 a, float2 b, float t) { return Float2.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 elasticEaseOut(float2 a, float2 b, float t) { return Float2.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 elasticEaseIn(float2 a, float2 b, float t) { return Float2.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 elasticEaseInOut(float2 a, float2 b, float t) { return Float2.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 elasticEaseOutIn(float2 a, float2 b, float t) { return Float2.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 bounceEaseOut(float2 a, float2 b, float t) { return Float2.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 bounceEaseIn(float2 a, float2 b, float t) { return Float2.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 bounceEaseInOut(float2 a, float2 b, float t) { return Float2.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 bounceEaseOutIn(float2 a, float2 b, float t) { return Float2.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 backEaseOut(float2 a, float2 b, float t) { return Float2.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 backEaseIn(float2 a, float2 b, float t) { return Float2.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 backEaseInOut(float2 a, float2 b, float t) { return Float2.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 backEaseOutIn(float2 a, float2 b, float t) { return Float2.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region float3

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 linear(float3 a, float3 b, float t) { return Float3.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseOut(float3 a, float3 b, float t) { return Float3.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseIn(float3 a, float3 b, float t) { return Float3.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseInOut(float3 a, float3 b, float t) { return Float3.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseOutIn(float3 a, float3 b, float t) { return Float3.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseOut(float3 a, float3 b, float t) { return Float3.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseIn(float3 a, float3 b, float t) { return Float3.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseInOut(float3 a, float3 b, float t) { return Float3.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseOutIn(float3 a, float3 b, float t) { return Float3.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseOut(float3 a, float3 b, float t) { return Float3.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseIn(float3 a, float3 b, float t) { return Float3.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseInOut(float3 a, float3 b, float t) { return Float3.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseOutIn(float3 a, float3 b, float t) { return Float3.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseOut(float3 a, float3 b, float t) { return Float3.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseIn(float3 a, float3 b, float t) { return Float3.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseInOut(float3 a, float3 b, float t) { return Float3.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseOutIn(float3 a, float3 b, float t) { return Float3.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseOut(float3 a, float3 b, float t) { return Float3.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseIn(float3 a, float3 b, float t) { return Float3.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseInOut(float3 a, float3 b, float t) { return Float3.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseOutIn(float3 a, float3 b, float t) { return Float3.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseOut(float3 a, float3 b, float t) { return Float3.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseIn(float3 a, float3 b, float t) { return Float3.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseInOut(float3 a, float3 b, float t) { return Float3.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseOutIn(float3 a, float3 b, float t) { return Float3.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseOut(float3 a, float3 b, float t) { return Float3.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseIn(float3 a, float3 b, float t) { return Float3.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseInOut(float3 a, float3 b, float t) { return Float3.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseOutIn(float3 a, float3 b, float t) { return Float3.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseOut(float3 a, float3 b, float t) { return Float3.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseIn(float3 a, float3 b, float t) { return Float3.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseInOut(float3 a, float3 b, float t) { return Float3.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseOutIn(float3 a, float3 b, float t) { return Float3.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseOut(float3 a, float3 b, float t) { return Float3.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseIn(float3 a, float3 b, float t) { return Float3.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseInOut(float3 a, float3 b, float t) { return Float3.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseOutIn(float3 a, float3 b, float t) { return Float3.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseOut(float3 a, float3 b, float t) { return Float3.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseIn(float3 a, float3 b, float t) { return Float3.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseInOut(float3 a, float3 b, float t) { return Float3.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseOutIn(float3 a, float3 b, float t) { return Float3.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region float3 slerp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 linearSlerp(float3 a, float3 b, float t) { return Float3.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseOutSlerp(float3 a, float3 b, float t) { return Float3.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseInSlerp(float3 a, float3 b, float t) { return Float3.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 expoEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseOutSlerp(float3 a, float3 b, float t) { return Float3.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseInSlerp(float3 a, float3 b, float t) { return Float3.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 circEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseOutSlerp(float3 a, float3 b, float t) { return Float3.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseInSlerp(float3 a, float3 b, float t) { return Float3.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quadEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseOutSlerp(float3 a, float3 b, float t) { return Float3.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseInSlerp(float3 a, float3 b, float t) { return Float3.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 sineEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseOutSlerp(float3 a, float3 b, float t) { return Float3.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseInSlerp(float3 a, float3 b, float t) { return Float3.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 cubicEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseOutSlerp(float3 a, float3 b, float t) { return Float3.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseInSlerp(float3 a, float3 b, float t) { return Float3.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quartEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseOutSlerp(float3 a, float3 b, float t) { return Float3.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseInSlerp(float3 a, float3 b, float t) { return Float3.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 quintEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseOutSlerp(float3 a, float3 b, float t) { return Float3.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseInSlerp(float3 a, float3 b, float t) { return Float3.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 elasticEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseOutSlerp(float3 a, float3 b, float t) { return Float3.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseInSlerp(float3 a, float3 b, float t) { return Float3.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 bounceEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseOutSlerp(float3 a, float3 b, float t) { return Float3.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseInSlerp(float3 a, float3 b, float t) { return Float3.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseInOutSlerp(float3 a, float3 b, float t) { return Float3.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 backEaseOutInSlerp(float3 a, float3 b, float t) { return Float3.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region float4

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 linear(float4 a, float4 b, float t) { return Float4.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 expoEaseOut(float4 a, float4 b, float t) { return Float4.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 expoEaseIn(float4 a, float4 b, float t) { return Float4.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 expoEaseInOut(float4 a, float4 b, float t) { return Float4.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 expoEaseOutIn(float4 a, float4 b, float t) { return Float4.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 circEaseOut(float4 a, float4 b, float t) { return Float4.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 circEaseIn(float4 a, float4 b, float t) { return Float4.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 circEaseInOut(float4 a, float4 b, float t) { return Float4.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 circEaseOutIn(float4 a, float4 b, float t) { return Float4.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quadEaseOut(float4 a, float4 b, float t) { return Float4.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quadEaseIn(float4 a, float4 b, float t) { return Float4.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quadEaseInOut(float4 a, float4 b, float t) { return Float4.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quadEaseOutIn(float4 a, float4 b, float t) { return Float4.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 sineEaseOut(float4 a, float4 b, float t) { return Float4.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 sineEaseIn(float4 a, float4 b, float t) { return Float4.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 sineEaseInOut(float4 a, float4 b, float t) { return Float4.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 sineEaseOutIn(float4 a, float4 b, float t) { return Float4.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 cubicEaseOut(float4 a, float4 b, float t) { return Float4.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 cubicEaseIn(float4 a, float4 b, float t) { return Float4.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 cubicEaseInOut(float4 a, float4 b, float t) { return Float4.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 cubicEaseOutIn(float4 a, float4 b, float t) { return Float4.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quartEaseOut(float4 a, float4 b, float t) { return Float4.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quartEaseIn(float4 a, float4 b, float t) { return Float4.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quartEaseInOut(float4 a, float4 b, float t) { return Float4.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quartEaseOutIn(float4 a, float4 b, float t) { return Float4.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quintEaseOut(float4 a, float4 b, float t) { return Float4.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quintEaseIn(float4 a, float4 b, float t) { return Float4.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quintEaseInOut(float4 a, float4 b, float t) { return Float4.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 quintEaseOutIn(float4 a, float4 b, float t) { return Float4.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 elasticEaseOut(float4 a, float4 b, float t) { return Float4.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 elasticEaseIn(float4 a, float4 b, float t) { return Float4.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 elasticEaseInOut(float4 a, float4 b, float t) { return Float4.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 elasticEaseOutIn(float4 a, float4 b, float t) { return Float4.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 bounceEaseOut(float4 a, float4 b, float t) { return Float4.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 bounceEaseIn(float4 a, float4 b, float t) { return Float4.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 bounceEaseInOut(float4 a, float4 b, float t) { return Float4.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 bounceEaseOutIn(float4 a, float4 b, float t) { return Float4.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 backEaseOut(float4 a, float4 b, float t) { return Float4.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 backEaseIn(float4 a, float4 b, float t) { return Float4.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 backEaseInOut(float4 a, float4 b, float t) { return Float4.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 backEaseOutIn(float4 a, float4 b, float t) { return Float4.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region quaternion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion linear(quaternion a, quaternion b, float t) { return Quaternion.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion expoEaseOut(quaternion a, quaternion b, float t) { return Quaternion.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion expoEaseIn(quaternion a, quaternion b, float t) { return Quaternion.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion expoEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion expoEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion circEaseOut(quaternion a, quaternion b, float t) { return Quaternion.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion circEaseIn(quaternion a, quaternion b, float t) { return Quaternion.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion circEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion circEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quadEaseOut(quaternion a, quaternion b, float t) { return Quaternion.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quadEaseIn(quaternion a, quaternion b, float t) { return Quaternion.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quadEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quadEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion sineEaseOut(quaternion a, quaternion b, float t) { return Quaternion.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion sineEaseIn(quaternion a, quaternion b, float t) { return Quaternion.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion sineEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion sineEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion cubicEaseOut(quaternion a, quaternion b, float t) { return Quaternion.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion cubicEaseIn(quaternion a, quaternion b, float t) { return Quaternion.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion cubicEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion cubicEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quartEaseOut(quaternion a, quaternion b, float t) { return Quaternion.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quartEaseIn(quaternion a, quaternion b, float t) { return Quaternion.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quartEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quartEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quintEaseOut(quaternion a, quaternion b, float t) { return Quaternion.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quintEaseIn(quaternion a, quaternion b, float t) { return Quaternion.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quintEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quintEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion elasticEaseOut(quaternion a, quaternion b, float t) { return Quaternion.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion elasticEaseIn(quaternion a, quaternion b, float t) { return Quaternion.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion elasticEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion elasticEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion bounceEaseOut(quaternion a, quaternion b, float t) { return Quaternion.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion bounceEaseIn(quaternion a, quaternion b, float t) { return Quaternion.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion bounceEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion bounceEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion backEaseOut(quaternion a, quaternion b, float t) { return Quaternion.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion backEaseIn(quaternion a, quaternion b, float t) { return Quaternion.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion backEaseInOut(quaternion a, quaternion b, float t) { return Quaternion.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion backEaseOutIn(quaternion a, quaternion b, float t) { return Quaternion.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

    }

}
