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

using Unity.Mathematics;

namespace Nebukam.Easing
{

    /// <summary>
    /// Robert Penner's easing functions for float.
    /// Partial class, normalized methods (t is expected to be in 0-1 range).
    /// All easing methods are formatted as like a Lerp would be : from, to, t.
    /// </summary>
    public static partial class ease
    {

        #region Direct

        #region Linear

        public static float linear(float from, float to, float t) { return Easing.Linear(t, from, to - from, 1.0f); }
        public static float2 linear(float2 from, float2 to, float t) { return Easing2.Linear(t, from, to - from, 1.0f); }
        public static float3 linear(float3 from, float3 to, float t) { return Easing3.Linear(t, from, to - from, 1.0f); }
        public static float4 linear(float4 from, float4 to, float t) { return Easing4.Linear(t, from, to - from, 1.0f); }

        #endregion

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float expoEaseOut(float from, float to, float t){ return Easing.ExpoEaseOut(t, from, to - from, 1.0f); }
        
        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float2 expoEaseOut(float2 from, float2 to, float t) { return Easing2.ExpoEaseOut(t, from, to - from, 1.0f); }
        
        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float3 expoEaseOut(float3 from, float3 to, float t) { return Easing3.ExpoEaseOut(t, from, to - from, 1.0f); }
        
        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float4 expoEaseOut(float4 from, float4 to, float t) { return Easing4.ExpoEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float expoEaseIn(float from, float to, float t) { return Easing.ExpoEaseIn(t, from, to - from, 1.0f); }
        
        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float2 expoEaseIn(float2 from, float2 to, float t) { return Easing2.ExpoEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float3 expoEaseIn(float3 from, float3 to, float t) { return Easing3.ExpoEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float4 expoEaseIn(float4 from, float4 to, float t) { return Easing4.ExpoEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float expoEaseInOut(float from, float to, float t) { return Easing.ExpoEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 expoEaseInOut(float2 from, float2 to, float t) { return Easing2.ExpoEaseInOut(t, from, to - from, 1.0f); }
        
        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 expoEaseInOut(float3 from, float3 to, float t) { return Easing3.ExpoEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 expoEaseInOut(float4 from, float4 to, float t) { return Easing4.ExpoEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float expoEaseOutIn(float from, float to, float t) { return Easing.ExpoEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 expoEaseOutIn(float2 from, float2 to, float t) { return Easing2.ExpoEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 expoEaseOutIn(float3 from, float3 to, float t) { return Easing3.ExpoEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 expoEaseOutIn(float4 from, float4 to, float t) { return Easing4.ExpoEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float circEaseOut(float from, float to, float t) { return Easing.CircEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float2 circEaseOut(float2 from, float2 to, float t) { return Easing2.CircEaseOut(t, from, to - from, 1.0f); }
        
        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float3 circEaseOut(float3 from, float3 to, float t) { return Easing3.CircEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float4 circEaseOut(float4 from, float4 to, float t) { return Easing4.CircEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float circEaseIn(float from, float to, float t) { return Easing.CircEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float2 circEaseIn(float2 from, float2 to, float t) { return Easing2.CircEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float3 circEaseIn(float3 from, float3 to, float t) { return Easing3.CircEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float4 circEaseIn(float4 from, float4 to, float t) { return Easing4.CircEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float circEaseInOut(float from, float to, float t) { return Easing.CircEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 circEaseInOut(float2 from, float2 to, float t) { return Easing2.CircEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseInOut(float3 from, float3 to, float t) { return Easing3.CircEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 circEaseInOut(float4 from, float4 to, float t) { return Easing4.CircEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float circEaseOutIn(float from, float to, float t) { return Easing.CircEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 circEaseOutIn(float2 from, float2 to, float t) { return Easing2.CircEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseOutIn(float3 from, float3 to, float t) { return Easing3.CircEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 circEaseOutIn(float4 from, float4 to, float t) { return Easing4.CircEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float quadEaseOut(float from, float to, float t) { return Easing.QuadEaseOut(t, from, to - from, 1.0f); }

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float2 quadEaseOut(float2 from, float2 to, float t) { return Easing2.QuadEaseOut(t, from, to - from, 1.0f); }

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 quadEaseOut(float3 from, float3 to, float t) { return Easing3.QuadEaseOut(t, from, to - from, 1.0f); }

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float4 quadEaseOut(float4 from, float4 to, float t) { return Easing4.QuadEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float quadEaseIn(float from, float to, float t) { return Easing.QuadEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float2 quadEaseIn(float2 from, float2 to, float t) { return Easing2.QuadEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 quadEaseIn(float3 from, float3 to, float t) { return Easing3.QuadEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float4 quadEaseIn(float4 from, float4 to, float t) { return Easing4.QuadEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quadEaseInOut(float from, float to, float t) { return Easing.QuadEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quadEaseInOut(float2 from, float2 to, float t) { return Easing2.QuadEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quadEaseInOut(float3 from, float3 to, float t) { return Easing3.QuadEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quadEaseInOut(float4 from, float4 to, float t) { return Easing4.QuadEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float quadEaseOutIn(float from, float to, float t) { return Easing.QuadEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 quadEaseOutIn(float2 from, float2 to, float t) { return Easing2.QuadEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quadEaseOutIn(float3 from, float3 to, float t) { return Easing3.QuadEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 quadEaseOutIn(float4 from, float4 to, float t) { return Easing4.QuadEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float sineEaseOut(float from, float to, float t) { return Easing.SineEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float2 sineEaseOut(float2 from, float2 to, float t) { return Easing2.SineEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float3 sineEaseOut(float3 from, float3 to, float t) { return Easing3.SineEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float4 sineEaseOut(float4 from, float4 to, float t) { return Easing4.SineEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float sineEaseIn(float from, float to, float t) { return Easing.SineEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float2 sineEaseIn(float2 from, float2 to, float t) { return Easing2.SineEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float3 sineEaseIn(float3 from, float3 to, float t) { return Easing3.SineEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float4 sineEaseIn(float4 from, float4 to, float t) { return Easing4.SineEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float sineEaseInOut(float from, float to, float t) { return Easing.SineEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 sineEaseInOut(float2 from, float2 to, float t) { return Easing2.SineEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 sineEaseInOut(float3 from, float3 to, float t) { return Easing3.SineEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 sineEaseInOut(float4 from, float4 to, float t) { return Easing4.SineEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float sineEaseOutIn(float from, float to, float t) { return Easing.SineEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float2 sineEaseOutIn(float2 from, float2 to, float t) { return Easing2.SineEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float3 sineEaseOutIn(float3 from, float3 to, float t) { return Easing3.SineEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float4 sineEaseOutIn(float4 from, float4 to, float t) { return Easing4.SineEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float cubicEaseOut(float from, float to, float t) { return Easing.CubicEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float2 cubicEaseOut(float2 from, float2 to, float t) { return Easing2.CubicEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float3 cubicEaseOut(float3 from, float3 to, float t) { return Easing3.CubicEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float4 cubicEaseOut(float4 from, float4 to, float t) { return Easing4.CubicEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float cubicEaseIn(float from, float to, float t) { return Easing.CubicEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float2 cubicEaseIn(float2 from, float2 to, float t) { return Easing2.CubicEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float3 cubicEaseIn(float3 from, float3 to, float t) { return Easing3.CubicEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float4 cubicEaseIn(float4 from, float4 to, float t) { return Easing4.CubicEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float cubicEaseInOut(float from, float to, float t) { return Easing.CubicEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 cubicEaseInOut(float2 from, float2 to, float t) { return Easing2.CubicEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 cubicEaseInOut(float3 from, float3 to, float t) { return Easing3.CubicEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 cubicEaseInOut(float4 from, float4 to, float t) { return Easing4.CubicEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float cubicEaseOutIn(float from, float to, float t) { return Easing.CubicEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 cubicEaseOutIn(float2 from, float2 to, float t) { return Easing2.CubicEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 cubicEaseOutIn(float3 from, float3 to, float t) { return Easing3.CubicEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 cubicEaseOutIn(float4 from, float4 to, float t) { return Easing4.CubicEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float quartEaseOut(float from, float to, float t) { return Easing.QuartEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float2 quartEaseOut(float2 from, float2 to, float t) { return Easing2.QuartEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float3 quartEaseOut(float3 from, float3 to, float t) { return Easing3.QuartEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float4 quartEaseOut(float4 from, float4 to, float t) { return Easing4.QuartEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float quartEaseIn(float from, float to, float t) { return Easing.QuartEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float2 quartEaseIn(float2 from, float2 to, float t) { return Easing2.QuartEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float3 quartEaseIn(float3 from, float3 to, float t) { return Easing3.QuartEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float4 quartEaseIn(float4 from, float4 to, float t) { return Easing4.QuartEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quartEaseInOut(float from, float to, float t) { return Easing.QuartEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quartEaseInOut(float2 from, float2 to, float t) { return Easing2.QuartEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quartEaseInOut(float3 from, float3 to, float t) { return Easing3.QuartEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quartEaseInOut(float4 from, float4 to, float t) { return Easing4.QuartEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float quartEaseOutIn(float from, float to, float t) { return Easing.QuartEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 quartEaseOutIn(float2 from, float2 to, float t) { return Easing2.QuartEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quartEaseOutIn(float from, float3 to, float t) { return Easing3.QuartEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 quartEaseOutIn(float from, float4 to, float t) { return Easing4.QuartEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float quintEaseOut(float from, float to, float t) { return Easing.QuintEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float2 quintEaseOut(float2 from, float2 to, float t) { return Easing2.QuintEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float3 quintEaseOut(float3 from, float3 to, float t) { return Easing3.QuintEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float4 quintEaseOut(float4 from, float4 to, float t) { return Easing4.QuintEaseOut(t, from, to - from, 1.0f); }
        

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float quintEaseIn(float from, float to, float t) { return Easing.QuintEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float2 quintEaseIn(float2 from, float2 to, float t) { return Easing2.QuintEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float3 quintEaseIn(float3 from, float3 to, float t) { return Easing3.QuintEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float4 quintEaseIn(float4 from, float4 to, float t) { return Easing4.QuintEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quintEaseInOut(float from, float to, float t) { return Easing.QuintEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quintEaseInOut(float2 from, float2 to, float t) { return Easing2.QuintEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quintEaseInOut(float3 from, float3 to, float t) { return Easing3.QuintEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quintEaseInOut(float4 from, float4 to, float t) { return Easing4.QuintEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quintEaseOutIn(float from, float to, float t) { return Easing.QuintEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quintEaseOutIn(float2 from, float2 to, float t) { return Easing2.QuintEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quintEaseOutIn(float3 from, float3 to, float t) { return Easing3.QuintEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quintEaseOutIn(float4 from, float4 to, float t) { return Easing4.QuintEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float elasticEaseOut(float from, float to, float t) { return Easing.ElasticEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float2 elasticEaseOut(float2 from, float2 to, float t) { return Easing2.ElasticEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float3 elasticEaseOut(float3 from, float3 to, float t) { return Easing3.ElasticEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float4 elasticEaseOut(float4 from, float4 to, float t) { return Easing4.ElasticEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float elasticEaseIn(float from, float to, float t) { return Easing.ElasticEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float2 elasticEaseIn(float2 from, float2 to, float t) { return Easing2.ElasticEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float3 elasticEaseIn(float3 from, float3 to, float t) { return Easing3.ElasticEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float4 elasticEaseIn(float4 from, float4 to, float t) { return Easing4.ElasticEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float elasticEaseInOut(float from, float to, float t) { return Easing.ElasticEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 elasticEaseInOut(float2 from, float2 to, float t) { return Easing2.ElasticEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 elasticEaseInOut(float3 from, float3 to, float t) { return Easing3.ElasticEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 elasticEaseInOut(float4 from, float4 to, float t) { return Easing4.ElasticEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float elasticEaseOutIn(float from, float to, float t) { return Easing.ElasticEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 elasticEaseOutIn(float2 from, float2 to, float t) { return Easing2.ElasticEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 elasticEaseOutIn(float3 from, float3 to, float t) { return Easing3.ElasticEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 elasticEaseOutIn(float4 from, float4 to, float t) { return Easing4.ElasticEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float bounceEaseOut(float from, float to, float t) { return Easing.BounceEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float2 bounceEaseOut(float2 from, float2 to, float t) { return Easing2.BounceEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float3 bounceEaseOut(float3 from, float3 to, float t) { return Easing3.BounceEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float4 bounceEaseOut(float4 from, float4 to, float t) { return Easing4.BounceEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float bounceEaseIn(float from, float to, float t) { return Easing.BounceEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float2 bounceEaseIn(float2 from, float2 to, float t) { return Easing2.BounceEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float3 bounceEaseIn(float3 from, float3 to, float t) { return Easing3.BounceEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float4 bounceEaseIn(float4 from, float4 to, float t) { return Easing4.BounceEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float bounceEaseInOut(float from, float to, float t) { return Easing.BounceEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 bounceEaseInOut(float2 from, float2 to, float t) { return Easing2.BounceEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 bounceEaseInOut(float3 from, float3 to, float t) { return Easing3.BounceEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 bounceEaseInOut(float4 from, float4 to, float t) { return Easing4.BounceEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float bounceEaseOutIn(float from, float to, float t) { return Easing.BounceEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 bounceEaseOutIn(float2 from, float2 to, float t) { return Easing2.BounceEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 bounceEaseOutIn(float3 from, float3 to, float t) { return Easing3.BounceEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 bounceEaseOutIn(float4 from, float4 to, float t) { return Easing4.BounceEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float backEaseOut(float from, float to, float t) { return Easing.BackEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float2 backEaseOut(float2 from, float2 to, float t) { return Easing2.BackEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 backEaseOut(float3 from, float3 to, float t) { return Easing3.BackEaseOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float4 backEaseOut(float4 from, float4 to, float t) { return Easing4.BackEaseOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float backEaseIn(float from, float to, float t) { return Easing.BackEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float2 backEaseIn(float2 from, float2 to, float t) { return Easing2.BackEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 backEaseIn(float3 from, float3 to, float t) { return Easing3.BackEaseIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float4 backEaseIn(float4 from, float4 to, float t) { return Easing4.BackEaseIn(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float backEaseInOut(float from, float to, float t) { return Easing.BackEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 backEaseInOut(float2 from, float2 to, float t) { return Easing2.BackEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 backEaseInOut(float3 from, float3 to, float t) { return Easing3.BackEaseInOut(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 backEaseInOut(float4 from, float4 to, float t) { return Easing4.BackEaseInOut(t, from, to - from, 1.0f); }


        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float backEaseOutIn(float from, float to, float t) { return Easing.BackEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 backEaseOutIn(float2 from, float2 to, float t) { return Easing2.BackEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 backEaseOutIn(float3 from, float3 to, float t) { return Easing3.BackEaseOutIn(t, from, to - from, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 backEaseOutIn(float4 from, float4 to, float t) { return Easing4.BackEaseOutIn(t, from, to - from, 1.0f); }

        #endregion

        #endregion

        #region Ease Object

        #region Linear

        public static float linear(EaseFloat e, float t) { return Easing.Linear(t, e.from, e.diff, 1.0f); }
        public static float2 linear(EaseFloat2 e, float t) { return Easing2.Linear(t, e.from, e.diff, 1.0f); }
        public static float3 linear(EaseFloat3 e, float t) { return Easing3.Linear(t, e.from, e.diff, 1.0f); }
        public static float4 linear(EaseFloat4 e, float t) { return Easing4.Linear(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float expoEaseOut(EaseFloat e, float t) { return Easing.ExpoEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float2 expoEaseOut(EaseFloat2 e, float t) { return Easing2.ExpoEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float3 expoEaseOut(EaseFloat3 e, float t) { return Easing3.ExpoEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float4 expoEaseOut(EaseFloat4 e, float t) { return Easing4.ExpoEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float expoEaseIn(EaseFloat e, float t) { return Easing.ExpoEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float2 expoEaseIn(EaseFloat2 e, float t) { return Easing2.ExpoEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float3 expoEaseIn(EaseFloat3 e, float t) { return Easing3.ExpoEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float4 expoEaseIn(EaseFloat4 e, float t) { return Easing4.ExpoEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float expoEaseInOut(EaseFloat e, float t) { return Easing.ExpoEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 expoEaseInOut(EaseFloat2 e, float t) { return Easing2.ExpoEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 expoEaseInOut(EaseFloat3 e, float t) { return Easing3.ExpoEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 expoEaseInOut(EaseFloat4 e, float t) { return Easing4.ExpoEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float expoEaseOutIn(EaseFloat e, float t) { return Easing.ExpoEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 expoEaseOutIn(EaseFloat2 e, float t) { return Easing2.ExpoEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 expoEaseOutIn(EaseFloat3 e, float t) { return Easing3.ExpoEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 expoEaseOutIn(EaseFloat4 e, float t) { return Easing4.ExpoEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Circular

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float circEaseOut(EaseFloat e, float t) { return Easing.CircEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float2 circEaseOut(EaseFloat2 e, float t) { return Easing2.CircEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float3 circEaseOut(EaseFloat3 e, float t) { return Easing3.CircEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float4 circEaseOut(EaseFloat4 e, float t) { return Easing4.CircEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float circEaseIn(EaseFloat e, float t) { return Easing.CircEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float2 circEaseIn(EaseFloat2 e, float t) { return Easing2.CircEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float3 circEaseIn(EaseFloat3 e, float t) { return Easing3.CircEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float4 circEaseIn(EaseFloat4 e, float t) { return Easing4.CircEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float circEaseInOut(EaseFloat e, float t) { return Easing.CircEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 circEaseInOut(EaseFloat2 e, float t) { return Easing2.CircEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseInOut(EaseFloat3 e, float t) { return Easing3.CircEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 circEaseInOut(EaseFloat4 e, float t) { return Easing4.CircEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float circEaseOutIn(EaseFloat e, float t) { return Easing.CircEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 circEaseOutIn(EaseFloat2 e, float t) { return Easing2.CircEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseOutIn(EaseFloat3 e, float t) { return Easing3.CircEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 circEaseOutIn(EaseFloat4 e, float t) { return Easing4.CircEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float quadEaseOut(EaseFloat e, float t) { return Easing.QuadEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float2 quadEaseOut(EaseFloat2 e, float t) { return Easing2.QuadEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 quadEaseOut(EaseFloat3 e, float t) { return Easing3.QuadEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float4 quadEaseOut(EaseFloat4 e, float t) { return Easing4.QuadEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float quadEaseIn(EaseFloat e, float t) { return Easing.QuadEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float2 quadEaseIn(EaseFloat2 e, float t) { return Easing2.QuadEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 quadEaseIn(EaseFloat3 e, float t) { return Easing3.QuadEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float4 quadEaseIn(EaseFloat4 e, float t) { return Easing4.QuadEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quadEaseInOut(EaseFloat e, float t) { return Easing.QuadEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quadEaseInOut(EaseFloat2 e, float t) { return Easing2.QuadEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quadEaseInOut(EaseFloat3 e, float t) { return Easing3.QuadEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quadEaseInOut(EaseFloat4 e, float t) { return Easing4.QuadEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float quadEaseOutIn(EaseFloat e, float t) { return Easing.QuadEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 quadEaseOutIn(EaseFloat2 e, float t) { return Easing2.QuadEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quadEaseOutIn(EaseFloat3 e, float t) { return Easing3.QuadEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 quadEaseOutIn(EaseFloat4 e, float t) { return Easing4.QuadEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float sineEaseOut(EaseFloat e, float t) { return Easing.SineEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float2 sineEaseOut(EaseFloat2 e, float t) { return Easing2.SineEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float3 sineEaseOut(EaseFloat3 e, float t) { return Easing3.SineEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float4 sineEaseOut(EaseFloat4 e, float t) { return Easing4.SineEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float sineEaseIn(EaseFloat e, float t) { return Easing.SineEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float2 sineEaseIn(EaseFloat2 e, float t) { return Easing2.SineEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float3 sineEaseIn(EaseFloat3 e, float t) { return Easing3.SineEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float4 sineEaseIn(EaseFloat4 e, float t) { return Easing4.SineEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float sineEaseInOut(EaseFloat e, float t) { return Easing.SineEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 sineEaseInOut(EaseFloat2 e, float t) { return Easing2.SineEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 sineEaseInOut(EaseFloat3 e, float t) { return Easing3.SineEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 sineEaseInOut(EaseFloat4 e, float t) { return Easing4.SineEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float sineEaseOutIn(EaseFloat e, float t) { return Easing.SineEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float2 sineEaseOutIn(EaseFloat2 e, float t) { return Easing2.SineEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float3 sineEaseOutIn(EaseFloat3 e, float t) { return Easing3.SineEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float4 sineEaseOutIn(EaseFloat4 e, float t) { return Easing4.SineEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float cubicEaseOut(EaseFloat e, float t) { return Easing.CubicEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float2 cubicEaseOut(EaseFloat2 e, float t) { return Easing2.CubicEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float3 cubicEaseOut(EaseFloat3 e, float t) { return Easing3.CubicEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float4 cubicEaseOut(EaseFloat4 e, float t) { return Easing4.CubicEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float cubicEaseIn(EaseFloat e, float t) { return Easing.CubicEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float2 cubicEaseIn(EaseFloat2 e, float t) { return Easing2.CubicEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float3 cubicEaseIn(EaseFloat3 e, float t) { return Easing3.CubicEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float4 cubicEaseIn(EaseFloat4 e, float t) { return Easing4.CubicEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float cubicEaseInOut(EaseFloat e, float t) { return Easing.CubicEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 cubicEaseInOut(EaseFloat2 e, float t) { return Easing2.CubicEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 cubicEaseInOut(EaseFloat3 e, float t) { return Easing3.CubicEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 cubicEaseInOut(EaseFloat4 e, float t) { return Easing4.CubicEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float cubicEaseOutIn(EaseFloat e, float t) { return Easing.CubicEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 cubicEaseOutIn(EaseFloat2 e, float t) { return Easing2.CubicEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 cubicEaseOutIn(EaseFloat3 e, float t) { return Easing3.CubicEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 cubicEaseOutIn(EaseFloat4 e, float t) { return Easing4.CubicEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float quartEaseOut(EaseFloat e, float t) { return Easing.QuartEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float2 quartEaseOut(EaseFloat2 e, float t) { return Easing2.QuartEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float3 quartEaseOut(EaseFloat3 e, float t) { return Easing3.QuartEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float4 quartEaseOut(EaseFloat4 e, float t) { return Easing4.QuartEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float quartEaseIn(EaseFloat e, float t) { return Easing.QuartEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float2 quartEaseIn(EaseFloat2 e, float t) { return Easing2.QuartEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float3 quartEaseIn(EaseFloat3 e, float t) { return Easing3.QuartEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float4 quartEaseIn(EaseFloat4 e, float t) { return Easing4.QuartEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quartEaseInOut(EaseFloat e, float t) { return Easing.QuartEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quartEaseInOut(EaseFloat2 e, float t) { return Easing2.QuartEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quartEaseInOut(EaseFloat3 e, float t) { return Easing3.QuartEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quartEaseInOut(EaseFloat4 e, float t) { return Easing4.QuartEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float quartEaseOutIn(EaseFloat e, float t) { return Easing.QuartEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 quartEaseOutIn(EaseFloat2 e, float t) { return Easing2.QuartEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quartEaseOutIn(EaseFloat3 e, float t) { return Easing3.QuartEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 quartEaseOutIn(EaseFloat4 e, float t) { return Easing4.QuartEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float quintEaseOut(EaseFloat e, float t) { return Easing.QuintEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float2 quintEaseOut(EaseFloat2 e, float t) { return Easing2.QuintEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float3 quintEaseOut(EaseFloat3 e, float t) { return Easing3.QuintEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float4 quintEaseOut(EaseFloat4 e, float t) { return Easing4.QuintEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float quintEaseIn(EaseFloat e, float t) { return Easing.QuintEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float2 quintEaseIn(EaseFloat2 e, float t) { return Easing2.QuintEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float3 quintEaseIn(EaseFloat3 e, float t) { return Easing3.QuintEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float4 quintEaseIn(EaseFloat4 e, float t) { return Easing4.QuintEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quintEaseInOut(EaseFloat e, float t) { return Easing.QuintEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quintEaseInOut(EaseFloat2 e, float t) { return Easing2.QuintEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quintEaseInOut(EaseFloat3 e, float t) { return Easing3.QuintEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quintEaseInOut(EaseFloat4 e, float t) { return Easing4.QuintEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quintEaseOutIn(EaseFloat e, float t) { return Easing.QuintEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quintEaseOutIn(EaseFloat2 e, float t) { return Easing2.QuintEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quintEaseOutIn(EaseFloat3 e, float t) { return Easing3.QuintEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quintEaseOutIn(EaseFloat4 e, float t) { return Easing4.QuintEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float elasticEaseOut(EaseFloat e, float t) { return Easing.ElasticEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float2 elasticEaseOut(EaseFloat2 e, float t) { return Easing2.ElasticEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float3 elasticEaseOut(EaseFloat3 e, float t) { return Easing3.ElasticEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float4 elasticEaseOut(EaseFloat4 e, float t) { return Easing4.ElasticEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float elasticEaseIn(EaseFloat e, float t) { return Easing.ElasticEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float2 elasticEaseIn(EaseFloat2 e, float t) { return Easing2.ElasticEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float3 elasticEaseIn(EaseFloat3 e, float t) { return Easing3.ElasticEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float4 elasticEaseIn(EaseFloat4 e, float t) { return Easing4.ElasticEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float elasticEaseInOut(EaseFloat e, float t) { return Easing.ElasticEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 elasticEaseInOut(EaseFloat2 e, float t) { return Easing2.ElasticEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 elasticEaseInOut(EaseFloat3 e, float t) { return Easing3.ElasticEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 elasticEaseInOut(EaseFloat4 e, float t) { return Easing4.ElasticEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float elasticEaseOutIn(EaseFloat e, float t) { return Easing.ElasticEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 elasticEaseOutIn(EaseFloat2 e, float t) { return Easing2.ElasticEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 elasticEaseOutIn(EaseFloat3 e, float t) { return Easing3.ElasticEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 elasticEaseOutIn(EaseFloat4 e, float t) { return Easing4.ElasticEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float bounceEaseOut(EaseFloat e, float t) { return Easing.BounceEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float2 bounceEaseOut(EaseFloat2 e, float t) { return Easing2.BounceEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float3 bounceEaseOut(EaseFloat3 e, float t) { return Easing3.BounceEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float4 bounceEaseOut(EaseFloat4 e, float t) { return Easing4.BounceEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float bounceEaseIn(EaseFloat e, float t) { return Easing.BounceEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float2 bounceEaseIn(EaseFloat2 e, float t) { return Easing2.BounceEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float3 bounceEaseIn(EaseFloat3 e, float t) { return Easing3.BounceEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float4 bounceEaseIn(EaseFloat4 e, float t) { return Easing4.BounceEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float bounceEaseInOut(EaseFloat e, float t) { return Easing.BounceEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 bounceEaseInOut(EaseFloat2 e, float t) { return Easing2.BounceEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 bounceEaseInOut(EaseFloat3 e, float t) { return Easing3.BounceEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 bounceEaseInOut(EaseFloat4 e, float t) { return Easing4.BounceEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float bounceEaseOutIn(EaseFloat e, float t) { return Easing.BounceEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 bounceEaseOutIn(EaseFloat2 e, float t) { return Easing2.BounceEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 bounceEaseOutIn(EaseFloat3 e, float t) { return Easing3.BounceEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 bounceEaseOutIn(EaseFloat4 e, float t) { return Easing4.BounceEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float backEaseOut(EaseFloat e, float t) { return Easing.BackEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float2 backEaseOut(EaseFloat2 e, float t) { return Easing2.BackEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 backEaseOut(EaseFloat3 e, float t) { return Easing3.BackEaseOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float4 backEaseOut(EaseFloat4 e, float t) { return Easing4.BackEaseOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float backEaseIn(EaseFloat e, float t) { return Easing.BackEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float2 backEaseIn(EaseFloat2 e, float t) { return Easing2.BackEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 backEaseIn(EaseFloat3 e, float t) { return Easing3.BackEaseIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float4 backEaseIn(EaseFloat4 e, float t) { return Easing4.BackEaseIn(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float backEaseInOut(EaseFloat e, float t) { return Easing.BackEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 backEaseInOut(EaseFloat2 e, float t) { return Easing2.BackEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 backEaseInOut(EaseFloat3 e, float t) { return Easing3.BackEaseInOut(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 backEaseInOut(EaseFloat4 e, float t) { return Easing4.BackEaseInOut(t, e.from, e.diff, 1.0f); }


        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float backEaseOutIn(EaseFloat e, float t) { return Easing.BackEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 backEaseOutIn(EaseFloat2 e, float t) { return Easing2.BackEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 backEaseOutIn(EaseFloat3 e, float t) { return Easing3.BackEaseOutIn(t, e.from, e.diff, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 backEaseOutIn(EaseFloat4 e, float t) { return Easing4.BackEaseOutIn(t, e.from, e.diff, 1.0f); }

        #endregion

        #endregion


    }

}
