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

        #region double

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double linear(double a, double b, float t) { return Double.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double expoEaseOut(double a, double b, float t) { return Double.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double expoEaseIn(double a, double b, float t) { return Double.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double expoEaseInOut(double a, double b, float t) { return Double.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double expoEaseOutIn(double a, double b, float t) { return Double.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double circEaseOut(double a, double b, float t) { return Double.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double circEaseIn(double a, double b, float t) { return Double.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double circEaseInOut(double a, double b, float t) { return Double.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double circEaseOutIn(double a, double b, float t) { return Double.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quadEaseOut(double a, double b, float t) { return Double.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quadEaseIn(double a, double b, float t) { return Double.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quadEaseInOut(double a, double b, float t) { return Double.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quadEaseOutIn(double a, double b, float t) { return Double.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sineEaseOut(double a, double b, float t) { return Double.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sineEaseIn(double a, double b, float t) { return Double.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sineEaseInOut(double a, double b, float t) { return Double.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double sineEaseOutIn(double a, double b, float t) { return Double.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cubicEaseOut(double a, double b, float t) { return Double.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cubicEaseIn(double a, double b, float t) { return Double.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cubicEaseInOut(double a, double b, float t) { return Double.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cubicEaseOutIn(double a, double b, float t) { return Double.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quartEaseOut(double a, double b, float t) { return Double.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quartEaseIn(double a, double b, float t) { return Double.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quartEaseInOut(double a, double b, float t) { return Double.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quartEaseOutIn(double a, double b, float t) { return Double.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quintEaseOut(double a, double b, float t) { return Double.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quintEaseIn(double a, double b, float t) { return Double.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quintEaseInOut(double a, double b, float t) { return Double.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double quintEaseOutIn(double a, double b, float t) { return Double.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double elasticEaseOut(double a, double b, float t) { return Double.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double elasticEaseIn(double a, double b, float t) { return Double.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double elasticEaseInOut(double a, double b, float t) { return Double.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double elasticEaseOutIn(double a, double b, float t) { return Double.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double bounceEaseOut(double a, double b, float t) { return Double.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double bounceEaseIn(double a, double b, float t) { return Double.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double bounceEaseInOut(double a, double b, float t) { return Double.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double bounceEaseOutIn(double a, double b, float t) { return Double.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double backEaseOut(double a, double b, float t) { return Double.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double backEaseIn(double a, double b, float t) { return Double.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double backEaseInOut(double a, double b, float t) { return Double.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double backEaseOutIn(double a, double b, float t) { return Double.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region double2

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 linear(double2 a, double2 b, float t) { return Double2.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 expoEaseOut(double2 a, double2 b, float t) { return Double2.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 expoEaseIn(double2 a, double2 b, float t) { return Double2.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 expoEaseInOut(double2 a, double2 b, float t) { return Double2.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 expoEaseOutIn(double2 a, double2 b, float t) { return Double2.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 circEaseOut(double2 a, double2 b, float t) { return Double2.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 circEaseIn(double2 a, double2 b, float t) { return Double2.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 circEaseInOut(double2 a, double2 b, float t) { return Double2.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 circEaseOutIn(double2 a, double2 b, float t) { return Double2.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quadEaseOut(double2 a, double2 b, float t) { return Double2.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quadEaseIn(double2 a, double2 b, float t) { return Double2.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quadEaseInOut(double2 a, double2 b, float t) { return Double2.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quadEaseOutIn(double2 a, double2 b, float t) { return Double2.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 sineEaseOut(double2 a, double2 b, float t) { return Double2.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 sineEaseIn(double2 a, double2 b, float t) { return Double2.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 sineEaseInOut(double2 a, double2 b, float t) { return Double2.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 sineEaseOutIn(double2 a, double2 b, float t) { return Double2.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 cubicEaseOut(double2 a, double2 b, float t) { return Double2.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 cubicEaseIn(double2 a, double2 b, float t) { return Double2.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 cubicEaseInOut(double2 a, double2 b, float t) { return Double2.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 cubicEaseOutIn(double2 a, double2 b, float t) { return Double2.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quartEaseOut(double2 a, double2 b, float t) { return Double2.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quartEaseIn(double2 a, double2 b, float t) { return Double2.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quartEaseInOut(double2 a, double2 b, float t) { return Double2.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quartEaseOutIn(double2 a, double2 b, float t) { return Double2.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quintEaseOut(double2 a, double2 b, float t) { return Double2.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quintEaseIn(double2 a, double2 b, float t) { return Double2.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quintEaseInOut(double2 a, double2 b, float t) { return Double2.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 quintEaseOutIn(double2 a, double2 b, float t) { return Double2.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 elasticEaseOut(double2 a, double2 b, float t) { return Double2.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 elasticEaseIn(double2 a, double2 b, float t) { return Double2.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 elasticEaseInOut(double2 a, double2 b, float t) { return Double2.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 elasticEaseOutIn(double2 a, double2 b, float t) { return Double2.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 bounceEaseOut(double2 a, double2 b, float t) { return Double2.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 bounceEaseIn(double2 a, double2 b, float t) { return Double2.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 bounceEaseInOut(double2 a, double2 b, float t) { return Double2.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 bounceEaseOutIn(double2 a, double2 b, float t) { return Double2.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 backEaseOut(double2 a, double2 b, float t) { return Double2.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 backEaseIn(double2 a, double2 b, float t) { return Double2.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 backEaseInOut(double2 a, double2 b, float t) { return Double2.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 backEaseOutIn(double2 a, double2 b, float t) { return Double2.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region double3

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 linear(double3 a, double3 b, float t) { return Double3.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 expoEaseOut(double3 a, double3 b, float t) { return Double3.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 expoEaseIn(double3 a, double3 b, float t) { return Double3.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 expoEaseInOut(double3 a, double3 b, float t) { return Double3.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 expoEaseOutIn(double3 a, double3 b, float t) { return Double3.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 circEaseOut(double3 a, double3 b, float t) { return Double3.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 circEaseIn(double3 a, double3 b, float t) { return Double3.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 circEaseInOut(double3 a, double3 b, float t) { return Double3.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 circEaseOutIn(double3 a, double3 b, float t) { return Double3.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quadEaseOut(double3 a, double3 b, float t) { return Double3.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quadEaseIn(double3 a, double3 b, float t) { return Double3.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quadEaseInOut(double3 a, double3 b, float t) { return Double3.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quadEaseOutIn(double3 a, double3 b, float t) { return Double3.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 sineEaseOut(double3 a, double3 b, float t) { return Double3.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 sineEaseIn(double3 a, double3 b, float t) { return Double3.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 sineEaseInOut(double3 a, double3 b, float t) { return Double3.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 sineEaseOutIn(double3 a, double3 b, float t) { return Double3.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 cubicEaseOut(double3 a, double3 b, float t) { return Double3.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 cubicEaseIn(double3 a, double3 b, float t) { return Double3.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 cubicEaseInOut(double3 a, double3 b, float t) { return Double3.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 cubicEaseOutIn(double3 a, double3 b, float t) { return Double3.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quartEaseOut(double3 a, double3 b, float t) { return Double3.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quartEaseIn(double3 a, double3 b, float t) { return Double3.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quartEaseInOut(double3 a, double3 b, float t) { return Double3.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quartEaseOutIn(double3 a, double3 b, float t) { return Double3.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quintEaseOut(double3 a, double3 b, float t) { return Double3.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quintEaseIn(double3 a, double3 b, float t) { return Double3.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quintEaseInOut(double3 a, double3 b, float t) { return Double3.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 quintEaseOutIn(double3 a, double3 b, float t) { return Double3.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 elasticEaseOut(double3 a, double3 b, float t) { return Double3.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 elasticEaseIn(double3 a, double3 b, float t) { return Double3.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 elasticEaseInOut(double3 a, double3 b, float t) { return Double3.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 elasticEaseOutIn(double3 a, double3 b, float t) { return Double3.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 bounceEaseOut(double3 a, double3 b, float t) { return Double3.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 bounceEaseIn(double3 a, double3 b, float t) { return Double3.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 bounceEaseInOut(double3 a, double3 b, float t) { return Double3.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 bounceEaseOutIn(double3 a, double3 b, float t) { return Double3.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 backEaseOut(double3 a, double3 b, float t) { return Double3.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 backEaseIn(double3 a, double3 b, float t) { return Double3.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 backEaseInOut(double3 a, double3 b, float t) { return Double3.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 backEaseOutIn(double3 a, double3 b, float t) { return Double3.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region double4

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 linear(double4 a, double4 b, float t) { return Double4.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 expoEaseOut(double4 a, double4 b, float t) { return Double4.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 expoEaseIn(double4 a, double4 b, float t) { return Double4.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 expoEaseInOut(double4 a, double4 b, float t) { return Double4.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 expoEaseOutIn(double4 a, double4 b, float t) { return Double4.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 circEaseOut(double4 a, double4 b, float t) { return Double4.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 circEaseIn(double4 a, double4 b, float t) { return Double4.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 circEaseInOut(double4 a, double4 b, float t) { return Double4.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 circEaseOutIn(double4 a, double4 b, float t) { return Double4.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quadEaseOut(double4 a, double4 b, float t) { return Double4.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quadEaseIn(double4 a, double4 b, float t) { return Double4.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quadEaseInOut(double4 a, double4 b, float t) { return Double4.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quadEaseOutIn(double4 a, double4 b, float t) { return Double4.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 sineEaseOut(double4 a, double4 b, float t) { return Double4.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 sineEaseIn(double4 a, double4 b, float t) { return Double4.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 sineEaseInOut(double4 a, double4 b, float t) { return Double4.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 sineEaseOutIn(double4 a, double4 b, float t) { return Double4.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 cubicEaseOut(double4 a, double4 b, float t) { return Double4.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 cubicEaseIn(double4 a, double4 b, float t) { return Double4.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 cubicEaseInOut(double4 a, double4 b, float t) { return Double4.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 cubicEaseOutIn(double4 a, double4 b, float t) { return Double4.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quartEaseOut(double4 a, double4 b, float t) { return Double4.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quartEaseIn(double4 a, double4 b, float t) { return Double4.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quartEaseInOut(double4 a, double4 b, float t) { return Double4.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quartEaseOutIn(double4 a, double4 b, float t) { return Double4.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quintEaseOut(double4 a, double4 b, float t) { return Double4.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quintEaseIn(double4 a, double4 b, float t) { return Double4.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quintEaseInOut(double4 a, double4 b, float t) { return Double4.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 quintEaseOutIn(double4 a, double4 b, float t) { return Double4.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 elasticEaseOut(double4 a, double4 b, float t) { return Double4.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 elasticEaseIn(double4 a, double4 b, float t) { return Double4.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 elasticEaseInOut(double4 a, double4 b, float t) { return Double4.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 elasticEaseOutIn(double4 a, double4 b, float t) { return Double4.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 bounceEaseOut(double4 a, double4 b, float t) { return Double4.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 bounceEaseIn(double4 a, double4 b, float t) { return Double4.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 bounceEaseInOut(double4 a, double4 b, float t) { return Double4.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 bounceEaseOutIn(double4 a, double4 b, float t) { return Double4.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 backEaseOut(double4 a, double4 b, float t) { return Double4.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 backEaseIn(double4 a, double4 b, float t) { return Double4.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 backEaseInOut(double4 a, double4 b, float t) { return Double4.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 backEaseOutIn(double4 a, double4 b, float t) { return Double4.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion


        #region int

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int linear(int a, int b, float t) { return Int.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int expoEaseOut(int a, int b, float t) { return Int.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int expoEaseIn(int a, int b, float t) { return Int.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int expoEaseInOut(int a, int b, float t) { return Int.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int expoEaseOutIn(int a, int b, float t) { return Int.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int circEaseOut(int a, int b, float t) { return Int.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int circEaseIn(int a, int b, float t) { return Int.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int circEaseInOut(int a, int b, float t) { return Int.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int circEaseOutIn(int a, int b, float t) { return Int.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quadEaseOut(int a, int b, float t) { return Int.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quadEaseIn(int a, int b, float t) { return Int.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quadEaseInOut(int a, int b, float t) { return Int.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quadEaseOutIn(int a, int b, float t) { return Int.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sineEaseOut(int a, int b, float t) { return Int.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sineEaseIn(int a, int b, float t) { return Int.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sineEaseInOut(int a, int b, float t) { return Int.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int sineEaseOutIn(int a, int b, float t) { return Int.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cubicEaseOut(int a, int b, float t) { return Int.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cubicEaseIn(int a, int b, float t) { return Int.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cubicEaseInOut(int a, int b, float t) { return Int.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cubicEaseOutIn(int a, int b, float t) { return Int.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quartEaseOut(int a, int b, float t) { return Int.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quartEaseIn(int a, int b, float t) { return Int.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quartEaseInOut(int a, int b, float t) { return Int.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quartEaseOutIn(int a, int b, float t) { return Int.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quintEaseOut(int a, int b, float t) { return Int.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quintEaseIn(int a, int b, float t) { return Int.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quintEaseInOut(int a, int b, float t) { return Int.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int quintEaseOutIn(int a, int b, float t) { return Int.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int elasticEaseOut(int a, int b, float t) { return Int.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int elasticEaseIn(int a, int b, float t) { return Int.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int elasticEaseInOut(int a, int b, float t) { return Int.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int elasticEaseOutIn(int a, int b, float t) { return Int.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int bounceEaseOut(int a, int b, float t) { return Int.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int bounceEaseIn(int a, int b, float t) { return Int.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int bounceEaseInOut(int a, int b, float t) { return Int.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int bounceEaseOutIn(int a, int b, float t) { return Int.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int backEaseOut(int a, int b, float t) { return Int.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int backEaseIn(int a, int b, float t) { return Int.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int backEaseInOut(int a, int b, float t) { return Int.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int backEaseOutIn(int a, int b, float t) { return Int.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region int2

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 linear(int2 a, int2 b, float t) { return Int2.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 expoEaseOut(int2 a, int2 b, float t) { return Int2.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 expoEaseIn(int2 a, int2 b, float t) { return Int2.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 expoEaseInOut(int2 a, int2 b, float t) { return Int2.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 expoEaseOutIn(int2 a, int2 b, float t) { return Int2.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 circEaseOut(int2 a, int2 b, float t) { return Int2.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 circEaseIn(int2 a, int2 b, float t) { return Int2.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 circEaseInOut(int2 a, int2 b, float t) { return Int2.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 circEaseOutIn(int2 a, int2 b, float t) { return Int2.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quadEaseOut(int2 a, int2 b, float t) { return Int2.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quadEaseIn(int2 a, int2 b, float t) { return Int2.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quadEaseInOut(int2 a, int2 b, float t) { return Int2.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quadEaseOutIn(int2 a, int2 b, float t) { return Int2.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 sineEaseOut(int2 a, int2 b, float t) { return Int2.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 sineEaseIn(int2 a, int2 b, float t) { return Int2.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 sineEaseInOut(int2 a, int2 b, float t) { return Int2.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 sineEaseOutIn(int2 a, int2 b, float t) { return Int2.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 cubicEaseOut(int2 a, int2 b, float t) { return Int2.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 cubicEaseIn(int2 a, int2 b, float t) { return Int2.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 cubicEaseInOut(int2 a, int2 b, float t) { return Int2.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 cubicEaseOutIn(int2 a, int2 b, float t) { return Int2.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quartEaseOut(int2 a, int2 b, float t) { return Int2.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quartEaseIn(int2 a, int2 b, float t) { return Int2.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quartEaseInOut(int2 a, int2 b, float t) { return Int2.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quartEaseOutIn(int2 a, int2 b, float t) { return Int2.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quintEaseOut(int2 a, int2 b, float t) { return Int2.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quintEaseIn(int2 a, int2 b, float t) { return Int2.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quintEaseInOut(int2 a, int2 b, float t) { return Int2.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 quintEaseOutIn(int2 a, int2 b, float t) { return Int2.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 elasticEaseOut(int2 a, int2 b, float t) { return Int2.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 elasticEaseIn(int2 a, int2 b, float t) { return Int2.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 elasticEaseInOut(int2 a, int2 b, float t) { return Int2.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 elasticEaseOutIn(int2 a, int2 b, float t) { return Int2.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 bounceEaseOut(int2 a, int2 b, float t) { return Int2.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 bounceEaseIn(int2 a, int2 b, float t) { return Int2.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 bounceEaseInOut(int2 a, int2 b, float t) { return Int2.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 bounceEaseOutIn(int2 a, int2 b, float t) { return Int2.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 backEaseOut(int2 a, int2 b, float t) { return Int2.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 backEaseIn(int2 a, int2 b, float t) { return Int2.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 backEaseInOut(int2 a, int2 b, float t) { return Int2.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 backEaseOutIn(int2 a, int2 b, float t) { return Int2.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region int3

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 linear(int3 a, int3 b, float t) { return Int3.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 expoEaseOut(int3 a, int3 b, float t) { return Int3.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 expoEaseIn(int3 a, int3 b, float t) { return Int3.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 expoEaseInOut(int3 a, int3 b, float t) { return Int3.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 expoEaseOutIn(int3 a, int3 b, float t) { return Int3.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 circEaseOut(int3 a, int3 b, float t) { return Int3.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 circEaseIn(int3 a, int3 b, float t) { return Int3.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 circEaseInOut(int3 a, int3 b, float t) { return Int3.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 circEaseOutIn(int3 a, int3 b, float t) { return Int3.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quadEaseOut(int3 a, int3 b, float t) { return Int3.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quadEaseIn(int3 a, int3 b, float t) { return Int3.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quadEaseInOut(int3 a, int3 b, float t) { return Int3.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quadEaseOutIn(int3 a, int3 b, float t) { return Int3.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 sineEaseOut(int3 a, int3 b, float t) { return Int3.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 sineEaseIn(int3 a, int3 b, float t) { return Int3.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 sineEaseInOut(int3 a, int3 b, float t) { return Int3.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 sineEaseOutIn(int3 a, int3 b, float t) { return Int3.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 cubicEaseOut(int3 a, int3 b, float t) { return Int3.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 cubicEaseIn(int3 a, int3 b, float t) { return Int3.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 cubicEaseInOut(int3 a, int3 b, float t) { return Int3.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 cubicEaseOutIn(int3 a, int3 b, float t) { return Int3.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quartEaseOut(int3 a, int3 b, float t) { return Int3.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quartEaseIn(int3 a, int3 b, float t) { return Int3.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quartEaseInOut(int3 a, int3 b, float t) { return Int3.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quartEaseOutIn(int3 a, int3 b, float t) { return Int3.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quintEaseOut(int3 a, int3 b, float t) { return Int3.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quintEaseIn(int3 a, int3 b, float t) { return Int3.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quintEaseInOut(int3 a, int3 b, float t) { return Int3.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 quintEaseOutIn(int3 a, int3 b, float t) { return Int3.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 elasticEaseOut(int3 a, int3 b, float t) { return Int3.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 elasticEaseIn(int3 a, int3 b, float t) { return Int3.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 elasticEaseInOut(int3 a, int3 b, float t) { return Int3.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 elasticEaseOutIn(int3 a, int3 b, float t) { return Int3.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 bounceEaseOut(int3 a, int3 b, float t) { return Int3.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 bounceEaseIn(int3 a, int3 b, float t) { return Int3.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 bounceEaseInOut(int3 a, int3 b, float t) { return Int3.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 bounceEaseOutIn(int3 a, int3 b, float t) { return Int3.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 backEaseOut(int3 a, int3 b, float t) { return Int3.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 backEaseIn(int3 a, int3 b, float t) { return Int3.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 backEaseInOut(int3 a, int3 b, float t) { return Int3.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 backEaseOutIn(int3 a, int3 b, float t) { return Int3.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion

        #region int4

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 linear(int4 a, int4 b, float t) { return Int4.Linear(a, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 expoEaseOut(int4 a, int4 b, float t) { return Int4.ExpoEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 expoEaseIn(int4 a, int4 b, float t) { return Int4.ExpoEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 expoEaseInOut(int4 a, int4 b, float t) { return Int4.ExpoEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 expoEaseOutIn(int4 a, int4 b, float t) { return Int4.ExpoEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 circEaseOut(int4 a, int4 b, float t) { return Int4.CircEaseOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 circEaseIn(int4 a, int4 b, float t) { return Int4.CircEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 circEaseInOut(int4 a, int4 b, float t) { return Int4.CircEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 circEaseOutIn(int4 a, int4 b, float t) { return Int4.CircEaseOutIn(a, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quadEaseOut(int4 a, int4 b, float t) { return Int4.QuadEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quadEaseIn(int4 a, int4 b, float t) { return Int4.QuadEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quadEaseInOut(int4 a, int4 b, float t) { return Int4.QuadEaseInOut(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quadEaseOutIn(int4 a, int4 b, float t) { return Int4.QuadEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 sineEaseOut(int4 a, int4 b, float t) { return Int4.SineEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 sineEaseIn(int4 a, int4 b, float t) { return Int4.SineEaseIn(a, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 sineEaseInOut(int4 a, int4 b, float t) { return Int4.SineEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 sineEaseOutIn(int4 a, int4 b, float t) { return Int4.SineEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 cubicEaseOut(int4 a, int4 b, float t) { return Int4.CubicEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 cubicEaseIn(int4 a, int4 b, float t) { return Int4.CubicEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 cubicEaseInOut(int4 a, int4 b, float t) { return Int4.CubicEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 cubicEaseOutIn(int4 a, int4 b, float t) { return Int4.CubicEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quartEaseOut(int4 a, int4 b, float t) { return Int4.QuartEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quartEaseIn(int4 a, int4 b, float t) { return Int4.QuartEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quartEaseInOut(int4 a, int4 b, float t) { return Int4.QuartEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quartEaseOutIn(int4 a, int4 b, float t) { return Int4.QuartEaseOutIn(a, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quintEaseOut(int4 a, int4 b, float t) { return Int4.QuintEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quintEaseIn(int4 a, int4 b, float t) { return Int4.QuintEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quintEaseInOut(int4 a, int4 b, float t) { return Int4.QuintEaseInOut(a, b, t, 1.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 quintEaseOutIn(int4 a, int4 b, float t) { return Int4.QuintEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 elasticEaseOut(int4 a, int4 b, float t) { return Int4.ElasticEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 elasticEaseIn(int4 a, int4 b, float t) { return Int4.ElasticEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 elasticEaseInOut(int4 a, int4 b, float t) { return Int4.ElasticEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 elasticEaseOutIn(int4 a, int4 b, float t) { return Int4.ElasticEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 bounceEaseOut(int4 a, int4 b, float t) { return Int4.BounceEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 bounceEaseIn(int4 a, int4 b, float t) { return Int4.BounceEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 bounceEaseInOut(int4 a, int4 b, float t) { return Int4.BounceEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 bounceEaseOutIn(int4 a, int4 b, float t) { return Int4.BounceEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 backEaseOut(int4 a, int4 b, float t) { return Int4.BackEaseOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 backEaseIn(int4 a, int4 b, float t) { return Int4.BackEaseIn(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 backEaseInOut(int4 a, int4 b, float t) { return Int4.BackEaseInOut(a, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 backEaseOutIn(int4 a, int4 b, float t) { return Int4.BackEaseOutIn(a, b, t, 1.0f); }

        #endregion

        #endregion


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
