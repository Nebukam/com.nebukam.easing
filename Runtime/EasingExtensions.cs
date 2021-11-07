using Unity.Mathematics;

namespace Nebukam.Easing
{
    public static class EasingExtensions
    {

        #region float

        public static float linear(this float @this, float b, float t) { return Float.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float expoEaseOut(this float @this, float b, float t) { return Float.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float expoEaseIn(this float @this, float b, float t) { return Float.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float expoEaseInOut(this float @this, float b, float t) { return Float.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float expoEaseOutIn(this float @this, float b, float t) { return Float.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float circEaseOut(this float @this, float b, float t) { return Float.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float circEaseIn(this float @this, float b, float t) { return Float.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float circEaseInOut(this float @this, float b, float t) { return Float.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float circEaseOutIn(this float @this, float b, float t) { return Float.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float quadEaseOut(this float @this, float b, float t) { return Float.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float quadEaseIn(this float @this, float b, float t) { return Float.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quadEaseInOut(this float @this, float b, float t) { return Float.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float quadEaseOutIn(this float @this, float b, float t) { return Float.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float sineEaseOut(this float @this, float b, float t) { return Float.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float sineEaseIn(this float @this, float b, float t) { return Float.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float sineEaseInOut(this float @this, float b, float t) { return Float.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float sineEaseOutIn(this float @this, float b, float t) { return Float.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float cubicEaseOut(this float @this, float b, float t) { return Float.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float cubicEaseIn(this float @this, float b, float t) { return Float.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float cubicEaseInOut(this float @this, float b, float t) { return Float.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float cubicEaseOutIn(this float @this, float b, float t) { return Float.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float quartEaseOut(this float @this, float b, float t) { return Float.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float quartEaseIn(this float @this, float b, float t) { return Float.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quartEaseInOut(this float @this, float b, float t) { return Float.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float quartEaseOutIn(this float @this, float b, float t) { return Float.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float quintEaseOut(this float @this, float b, float t) { return Float.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float quintEaseIn(this float @this, float b, float t) { return Float.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float quintEaseInOut(this float @this, float b, float t) { return Float.QuintEaseInOut(@this, b, t, 1.0f); }

        public static float quintEaseOutIn(this float @this, float b, float t) { return Float.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float elasticEaseOut(this float @this, float b, float t) { return Float.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float elasticEaseIn(this float @this, float b, float t) { return Float.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float elasticEaseInOut(this float @this, float b, float t) { return Float.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float elasticEaseOutIn(this float @this, float b, float t) { return Float.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float bounceEaseOut(this float @this, float b, float t) { return Float.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float bounceEaseIn(this float @this, float b, float t) { return Float.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float bounceEaseInOut(this float @this, float b, float t) { return Float.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float bounceEaseOutIn(this float @this, float b, float t) { return Float.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float backEaseOut(this float @this, float b, float t) { return Float.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float backEaseIn(this float @this, float b, float t) { return Float.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float backEaseInOut(this float @this, float b, float t) { return Float.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float backEaseOutIn(this float @this, float b, float t) { return Float.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region float2

        public static float2 linear(this float2 @this, float2 b, float t) { return Float2.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float2 expoEaseOut(this float2 @this, float2 b, float t) { return Float2.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float2 expoEaseIn(this float2 @this, float2 b, float t) { return Float2.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 expoEaseInOut(this float2 @this, float2 b, float t) { return Float2.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 expoEaseOutIn(this float2 @this, float2 b, float t) { return Float2.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float2 circEaseOut(this float2 @this, float2 b, float t) { return Float2.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float2 circEaseIn(this float2 @this, float2 b, float t) { return Float2.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 circEaseInOut(this float2 @this, float2 b, float t) { return Float2.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 circEaseOutIn(this float2 @this, float2 b, float t) { return Float2.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float2 quadEaseOut(this float2 @this, float2 b, float t) { return Float2.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float2 quadEaseIn(this float2 @this, float2 b, float t) { return Float2.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quadEaseInOut(this float2 @this, float2 b, float t) { return Float2.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 quadEaseOutIn(this float2 @this, float2 b, float t) { return Float2.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float2 sineEaseOut(this float2 @this, float2 b, float t) { return Float2.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float2 sineEaseIn(this float2 @this, float2 b, float t) { return Float2.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 sineEaseInOut(this float2 @this, float2 b, float t) { return Float2.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float2 sineEaseOutIn(this float2 @this, float2 b, float t) { return Float2.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float2 cubicEaseOut(this float2 @this, float2 b, float t) { return Float2.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float2 cubicEaseIn(this float2 @this, float2 b, float t) { return Float2.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 cubicEaseInOut(this float2 @this, float2 b, float t) { return Float2.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 cubicEaseOutIn(this float2 @this, float2 b, float t) { return Float2.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float2 quartEaseOut(this float2 @this, float2 b, float t) { return Float2.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float2 quartEaseIn(this float2 @this, float2 b, float t) { return Float2.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quartEaseInOut(this float2 @this, float2 b, float t) { return Float2.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 quartEaseOutIn(this float2 @this, float2 b, float t) { return Float2.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float2 quintEaseOut(this float2 @this, float2 b, float t) { return Float2.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float2 quintEaseIn(this float2 @this, float2 b, float t) { return Float2.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 quintEaseInOut(this float2 @this, float2 b, float t) { return Float2.QuintEaseInOut(@this, b, t, 1.0f); }

        public static float2 quintEaseOutIn(this float2 @this, float2 b, float t) { return Float2.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float2 elasticEaseOut(this float2 @this, float2 b, float t) { return Float2.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float2 elasticEaseIn(this float2 @this, float2 b, float t) { return Float2.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 elasticEaseInOut(this float2 @this, float2 b, float t) { return Float2.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 elasticEaseOutIn(this float2 @this, float2 b, float t) { return Float2.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float2 bounceEaseOut(this float2 @this, float2 b, float t) { return Float2.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float2 bounceEaseIn(this float2 @this, float2 b, float t) { return Float2.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 bounceEaseInOut(this float2 @this, float2 b, float t) { return Float2.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 bounceEaseOutIn(this float2 @this, float2 b, float t) { return Float2.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float2 backEaseOut(this float2 @this, float2 b, float t) { return Float2.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float2 backEaseIn(this float2 @this, float2 b, float t) { return Float2.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float2 backEaseInOut(this float2 @this, float2 b, float t) { return Float2.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float2 backEaseOutIn(this float2 @this, float2 b, float t) { return Float2.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region float3

        public static float3 linear(this float3 @this, float3 b, float t) { return Float3.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float3 expoEaseOut(this float3 @this, float3 b, float t) { return Float3.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float3 expoEaseIn(this float3 @this, float3 b, float t) { return Float3.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 expoEaseInOut(this float3 @this, float3 b, float t) { return Float3.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 expoEaseOutIn(this float3 @this, float3 b, float t) { return Float3.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float3 circEaseOut(this float3 @this, float3 b, float t) { return Float3.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float3 circEaseIn(this float3 @this, float3 b, float t) { return Float3.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseInOut(this float3 @this, float3 b, float t) { return Float3.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseOutIn(this float3 @this, float3 b, float t) { return Float3.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 quadEaseOut(this float3 @this, float3 b, float t) { return Float3.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 quadEaseIn(this float3 @this, float3 b, float t) { return Float3.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quadEaseInOut(this float3 @this, float3 b, float t) { return Float3.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quadEaseOutIn(this float3 @this, float3 b, float t) { return Float3.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float3 sineEaseOut(this float3 @this, float3 b, float t) { return Float3.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float3 sineEaseIn(this float3 @this, float3 b, float t) { return Float3.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 sineEaseInOut(this float3 @this, float3 b, float t) { return Float3.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float3 sineEaseOutIn(this float3 @this, float3 b, float t) { return Float3.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float3 cubicEaseOut(this float3 @this, float3 b, float t) { return Float3.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float3 cubicEaseIn(this float3 @this, float3 b, float t) { return Float3.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 cubicEaseInOut(this float3 @this, float3 b, float t) { return Float3.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 cubicEaseOutIn(this float3 @this, float3 b, float t) { return Float3.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float3 quartEaseOut(this float3 @this, float3 b, float t) { return Float3.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float3 quartEaseIn(this float3 @this, float3 b, float t) { return Float3.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quartEaseInOut(this float3 @this, float3 b, float t) { return Float3.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quartEaseOutIn(this float3 @this, float3 b, float t) { return Float3.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float3 quintEaseOut(this float3 @this, float3 b, float t) { return Float3.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float3 quintEaseIn(this float3 @this, float3 b, float t) { return Float3.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quintEaseInOut(this float3 @this, float3 b, float t) { return Float3.QuintEaseInOut(@this, b, t, 1.0f); }

        public static float3 quintEaseOutIn(this float3 @this, float3 b, float t) { return Float3.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float3 elasticEaseOut(this float3 @this, float3 b, float t) { return Float3.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float3 elasticEaseIn(this float3 @this, float3 b, float t) { return Float3.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 elasticEaseInOut(this float3 @this, float3 b, float t) { return Float3.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 elasticEaseOutIn(this float3 @this, float3 b, float t) { return Float3.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float3 bounceEaseOut(this float3 @this, float3 b, float t) { return Float3.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float3 bounceEaseIn(this float3 @this, float3 b, float t) { return Float3.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 bounceEaseInOut(this float3 @this, float3 b, float t) { return Float3.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 bounceEaseOutIn(this float3 @this, float3 b, float t) { return Float3.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 backEaseOut(this float3 @this, float3 b, float t) { return Float3.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 backEaseIn(this float3 @this, float3 b, float t) { return Float3.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 backEaseInOut(this float3 @this, float3 b, float t) { return Float3.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 backEaseOutIn(this float3 @this, float3 b, float t) { return Float3.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region float3 slerp

        public static float3 linearSlerp(this float3 @this, float3 b, float t) { return Float3.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float3 expoEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float3 expoEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 expoEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 expoEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float3 circEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float3 circEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 circEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 quadEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 quadEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quadEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quadEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float3 sineEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float3 sineEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 sineEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float3 sineEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float3 cubicEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float3 cubicEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 cubicEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 cubicEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float3 quartEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float3 quartEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quartEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 quartEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float3 quintEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float3 quintEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 quintEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.QuintEaseInOut(@this, b, t, 1.0f); }

        public static float3 quintEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float3 elasticEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float3 elasticEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 elasticEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 elasticEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float3 bounceEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float3 bounceEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 bounceEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 bounceEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float3 backEaseOutSlerp(this float3 @this, float3 b, float t) { return Float3.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float3 backEaseInSlerp(this float3 @this, float3 b, float t) { return Float3.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float3 backEaseInOutSlerp(this float3 @this, float3 b, float t) { return Float3.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float3 backEaseOutInSlerp(this float3 @this, float3 b, float t) { return Float3.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region float4

        public static float4 linear(this float4 @this, float4 b, float t) { return Float4.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static float4 expoEaseOut(this float4 @this, float4 b, float t) { return Float4.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static float4 expoEaseIn(this float4 @this, float4 b, float t) { return Float4.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 expoEaseInOut(this float4 @this, float4 b, float t) { return Float4.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 expoEaseOutIn(this float4 @this, float4 b, float t) { return Float4.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static float4 circEaseOut(this float4 @this, float4 b, float t) { return Float4.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static float4 circEaseIn(this float4 @this, float4 b, float t) { return Float4.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 circEaseInOut(this float4 @this, float4 b, float t) { return Float4.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 circEaseOutIn(this float4 @this, float4 b, float t) { return Float4.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static float4 quadEaseOut(this float4 @this, float4 b, float t) { return Float4.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static float4 quadEaseIn(this float4 @this, float4 b, float t) { return Float4.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quadEaseInOut(this float4 @this, float4 b, float t) { return Float4.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 quadEaseOutIn(this float4 @this, float4 b, float t) { return Float4.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static float4 sineEaseOut(this float4 @this, float4 b, float t) { return Float4.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static float4 sineEaseIn(this float4 @this, float4 b, float t) { return Float4.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 sineEaseInOut(this float4 @this, float4 b, float t) { return Float4.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static float4 sineEaseOutIn(this float4 @this, float4 b, float t) { return Float4.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static float4 cubicEaseOut(this float4 @this, float4 b, float t) { return Float4.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static float4 cubicEaseIn(this float4 @this, float4 b, float t) { return Float4.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 cubicEaseInOut(this float4 @this, float4 b, float t) { return Float4.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 cubicEaseOutIn(this float4 @this, float4 b, float t) { return Float4.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static float4 quartEaseOut(this float4 @this, float4 b, float t) { return Float4.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static float4 quartEaseIn(this float4 @this, float4 b, float t) { return Float4.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quartEaseInOut(this float4 @this, float4 b, float t) { return Float4.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 quartEaseOutIn(this float4 @this, float4 b, float t) { return Float4.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static float4 quintEaseOut(this float4 @this, float4 b, float t) { return Float4.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static float4 quintEaseIn(this float4 @this, float4 b, float t) { return Float4.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 quintEaseInOut(this float4 @this, float4 b, float t) { return Float4.QuintEaseInOut(@this, b, t, 1.0f); }

        public static float4 quintEaseOutIn(this float4 @this, float4 b, float t) { return Float4.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static float4 elasticEaseOut(this float4 @this, float4 b, float t) { return Float4.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static float4 elasticEaseIn(this float4 @this, float4 b, float t) { return Float4.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 elasticEaseInOut(this float4 @this, float4 b, float t) { return Float4.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 elasticEaseOutIn(this float4 @this, float4 b, float t) { return Float4.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static float4 bounceEaseOut(this float4 @this, float4 b, float t) { return Float4.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static float4 bounceEaseIn(this float4 @this, float4 b, float t) { return Float4.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 bounceEaseInOut(this float4 @this, float4 b, float t) { return Float4.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 bounceEaseOutIn(this float4 @this, float4 b, float t) { return Float4.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static float4 backEaseOut(this float4 @this, float4 b, float t) { return Float4.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static float4 backEaseIn(this float4 @this, float4 b, float t) { return Float4.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static float4 backEaseInOut(this float4 @this, float4 b, float t) { return Float4.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static float4 backEaseOutIn(this float4 @this, float4 b, float t) { return Float4.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region quaternion

        public static quaternion linear(this quaternion @this, quaternion b, float t) { return Quaternion.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static quaternion expoEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static quaternion expoEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion expoEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion expoEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static quaternion circEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static quaternion circEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion circEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion circEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static quaternion quadEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static quaternion quadEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion quadEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion quadEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static quaternion sineEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static quaternion sineEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion sineEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static quaternion sineEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static quaternion cubicEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static quaternion cubicEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion cubicEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion cubicEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static quaternion quartEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static quaternion quartEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion quartEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion quartEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static quaternion quintEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static quaternion quintEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion quintEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.QuintEaseInOut(@this, b, t, 1.0f); }

        public static quaternion quintEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static quaternion elasticEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static quaternion elasticEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion elasticEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion elasticEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static quaternion bounceEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static quaternion bounceEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion bounceEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion bounceEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static quaternion backEaseOut(this quaternion @this, quaternion b, float t) { return Quaternion.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static quaternion backEaseIn(this quaternion @this, quaternion b, float t) { return Quaternion.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static quaternion backEaseInOut(this quaternion @this, quaternion b, float t) { return Quaternion.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static quaternion backEaseOutIn(this quaternion @this, quaternion b, float t) { return Quaternion.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

    }
}
