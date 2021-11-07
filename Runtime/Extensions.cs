using Unity.Mathematics;

namespace Nebukam.Easing
{
    public static class Extensions
    {

        #region double

        public static double linear(this double @this, double b, float t) { return Double.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static double expoEaseOut(this double @this, double b, float t) { return Double.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static double expoEaseIn(this double @this, double b, float t) { return Double.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double expoEaseInOut(this double @this, double b, float t) { return Double.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double expoEaseOutIn(this double @this, double b, float t) { return Double.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static double circEaseOut(this double @this, double b, float t) { return Double.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static double circEaseIn(this double @this, double b, float t) { return Double.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double circEaseInOut(this double @this, double b, float t) { return Double.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double circEaseOutIn(this double @this, double b, float t) { return Double.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static double quadEaseOut(this double @this, double b, float t) { return Double.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static double quadEaseIn(this double @this, double b, float t) { return Double.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double quadEaseInOut(this double @this, double b, float t) { return Double.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double quadEaseOutIn(this double @this, double b, float t) { return Double.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static double sineEaseOut(this double @this, double b, float t) { return Double.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static double sineEaseIn(this double @this, double b, float t) { return Double.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double sineEaseInOut(this double @this, double b, float t) { return Double.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static double sineEaseOutIn(this double @this, double b, float t) { return Double.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static double cubicEaseOut(this double @this, double b, float t) { return Double.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static double cubicEaseIn(this double @this, double b, float t) { return Double.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double cubicEaseInOut(this double @this, double b, float t) { return Double.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double cubicEaseOutIn(this double @this, double b, float t) { return Double.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static double quartEaseOut(this double @this, double b, float t) { return Double.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static double quartEaseIn(this double @this, double b, float t) { return Double.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double quartEaseInOut(this double @this, double b, float t) { return Double.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double quartEaseOutIn(this double @this, double b, float t) { return Double.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static double quintEaseOut(this double @this, double b, float t) { return Double.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static double quintEaseIn(this double @this, double b, float t) { return Double.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double quintEaseInOut(this double @this, double b, float t) { return Double.QuintEaseInOut(@this, b, t, 1.0f); }

        public static double quintEaseOutIn(this double @this, double b, float t) { return Double.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static double elasticEaseOut(this double @this, double b, float t) { return Double.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static double elasticEaseIn(this double @this, double b, float t) { return Double.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double elasticEaseInOut(this double @this, double b, float t) { return Double.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double elasticEaseOutIn(this double @this, double b, float t) { return Double.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static double bounceEaseOut(this double @this, double b, float t) { return Double.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static double bounceEaseIn(this double @this, double b, float t) { return Double.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double bounceEaseInOut(this double @this, double b, float t) { return Double.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double bounceEaseOutIn(this double @this, double b, float t) { return Double.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static double backEaseOut(this double @this, double b, float t) { return Double.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static double backEaseIn(this double @this, double b, float t) { return Double.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double backEaseInOut(this double @this, double b, float t) { return Double.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double backEaseOutIn(this double @this, double b, float t) { return Double.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region double2

        public static double2 linear(this double2 @this, double2 b, float t) { return Double2.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static double2 expoEaseOut(this double2 @this, double2 b, float t) { return Double2.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static double2 expoEaseIn(this double2 @this, double2 b, float t) { return Double2.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 expoEaseInOut(this double2 @this, double2 b, float t) { return Double2.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 expoEaseOutIn(this double2 @this, double2 b, float t) { return Double2.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static double2 circEaseOut(this double2 @this, double2 b, float t) { return Double2.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static double2 circEaseIn(this double2 @this, double2 b, float t) { return Double2.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 circEaseInOut(this double2 @this, double2 b, float t) { return Double2.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 circEaseOutIn(this double2 @this, double2 b, float t) { return Double2.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static double2 quadEaseOut(this double2 @this, double2 b, float t) { return Double2.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static double2 quadEaseIn(this double2 @this, double2 b, float t) { return Double2.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 quadEaseInOut(this double2 @this, double2 b, float t) { return Double2.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 quadEaseOutIn(this double2 @this, double2 b, float t) { return Double2.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static double2 sineEaseOut(this double2 @this, double2 b, float t) { return Double2.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static double2 sineEaseIn(this double2 @this, double2 b, float t) { return Double2.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 sineEaseInOut(this double2 @this, double2 b, float t) { return Double2.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static double2 sineEaseOutIn(this double2 @this, double2 b, float t) { return Double2.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static double2 cubicEaseOut(this double2 @this, double2 b, float t) { return Double2.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static double2 cubicEaseIn(this double2 @this, double2 b, float t) { return Double2.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 cubicEaseInOut(this double2 @this, double2 b, float t) { return Double2.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 cubicEaseOutIn(this double2 @this, double2 b, float t) { return Double2.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static double2 quartEaseOut(this double2 @this, double2 b, float t) { return Double2.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static double2 quartEaseIn(this double2 @this, double2 b, float t) { return Double2.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 quartEaseInOut(this double2 @this, double2 b, float t) { return Double2.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 quartEaseOutIn(this double2 @this, double2 b, float t) { return Double2.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static double2 quintEaseOut(this double2 @this, double2 b, float t) { return Double2.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static double2 quintEaseIn(this double2 @this, double2 b, float t) { return Double2.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 quintEaseInOut(this double2 @this, double2 b, float t) { return Double2.QuintEaseInOut(@this, b, t, 1.0f); }

        public static double2 quintEaseOutIn(this double2 @this, double2 b, float t) { return Double2.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static double2 elasticEaseOut(this double2 @this, double2 b, float t) { return Double2.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static double2 elasticEaseIn(this double2 @this, double2 b, float t) { return Double2.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 elasticEaseInOut(this double2 @this, double2 b, float t) { return Double2.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 elasticEaseOutIn(this double2 @this, double2 b, float t) { return Double2.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static double2 bounceEaseOut(this double2 @this, double2 b, float t) { return Double2.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static double2 bounceEaseIn(this double2 @this, double2 b, float t) { return Double2.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 bounceEaseInOut(this double2 @this, double2 b, float t) { return Double2.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 bounceEaseOutIn(this double2 @this, double2 b, float t) { return Double2.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static double2 backEaseOut(this double2 @this, double2 b, float t) { return Double2.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static double2 backEaseIn(this double2 @this, double2 b, float t) { return Double2.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double2 backEaseInOut(this double2 @this, double2 b, float t) { return Double2.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double2 backEaseOutIn(this double2 @this, double2 b, float t) { return Double2.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region double3

        public static double3 linear(this double3 @this, double3 b, float t) { return Double3.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static double3 expoEaseOut(this double3 @this, double3 b, float t) { return Double3.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static double3 expoEaseIn(this double3 @this, double3 b, float t) { return Double3.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 expoEaseInOut(this double3 @this, double3 b, float t) { return Double3.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 expoEaseOutIn(this double3 @this, double3 b, float t) { return Double3.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static double3 circEaseOut(this double3 @this, double3 b, float t) { return Double3.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static double3 circEaseIn(this double3 @this, double3 b, float t) { return Double3.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 circEaseInOut(this double3 @this, double3 b, float t) { return Double3.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 circEaseOutIn(this double3 @this, double3 b, float t) { return Double3.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static double3 quadEaseOut(this double3 @this, double3 b, float t) { return Double3.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static double3 quadEaseIn(this double3 @this, double3 b, float t) { return Double3.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 quadEaseInOut(this double3 @this, double3 b, float t) { return Double3.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 quadEaseOutIn(this double3 @this, double3 b, float t) { return Double3.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static double3 sineEaseOut(this double3 @this, double3 b, float t) { return Double3.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static double3 sineEaseIn(this double3 @this, double3 b, float t) { return Double3.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 sineEaseInOut(this double3 @this, double3 b, float t) { return Double3.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static double3 sineEaseOutIn(this double3 @this, double3 b, float t) { return Double3.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static double3 cubicEaseOut(this double3 @this, double3 b, float t) { return Double3.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static double3 cubicEaseIn(this double3 @this, double3 b, float t) { return Double3.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 cubicEaseInOut(this double3 @this, double3 b, float t) { return Double3.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 cubicEaseOutIn(this double3 @this, double3 b, float t) { return Double3.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static double3 quartEaseOut(this double3 @this, double3 b, float t) { return Double3.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static double3 quartEaseIn(this double3 @this, double3 b, float t) { return Double3.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 quartEaseInOut(this double3 @this, double3 b, float t) { return Double3.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 quartEaseOutIn(this double3 @this, double3 b, float t) { return Double3.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static double3 quintEaseOut(this double3 @this, double3 b, float t) { return Double3.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static double3 quintEaseIn(this double3 @this, double3 b, float t) { return Double3.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 quintEaseInOut(this double3 @this, double3 b, float t) { return Double3.QuintEaseInOut(@this, b, t, 1.0f); }

        public static double3 quintEaseOutIn(this double3 @this, double3 b, float t) { return Double3.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static double3 elasticEaseOut(this double3 @this, double3 b, float t) { return Double3.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static double3 elasticEaseIn(this double3 @this, double3 b, float t) { return Double3.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 elasticEaseInOut(this double3 @this, double3 b, float t) { return Double3.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 elasticEaseOutIn(this double3 @this, double3 b, float t) { return Double3.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static double3 bounceEaseOut(this double3 @this, double3 b, float t) { return Double3.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static double3 bounceEaseIn(this double3 @this, double3 b, float t) { return Double3.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 bounceEaseInOut(this double3 @this, double3 b, float t) { return Double3.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 bounceEaseOutIn(this double3 @this, double3 b, float t) { return Double3.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static double3 backEaseOut(this double3 @this, double3 b, float t) { return Double3.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static double3 backEaseIn(this double3 @this, double3 b, float t) { return Double3.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double3 backEaseInOut(this double3 @this, double3 b, float t) { return Double3.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double3 backEaseOutIn(this double3 @this, double3 b, float t) { return Double3.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region double4

        public static double4 linear(this double4 @this, double4 b, float t) { return Double4.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static double4 expoEaseOut(this double4 @this, double4 b, float t) { return Double4.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static double4 expoEaseIn(this double4 @this, double4 b, float t) { return Double4.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 expoEaseInOut(this double4 @this, double4 b, float t) { return Double4.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 expoEaseOutIn(this double4 @this, double4 b, float t) { return Double4.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static double4 circEaseOut(this double4 @this, double4 b, float t) { return Double4.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static double4 circEaseIn(this double4 @this, double4 b, float t) { return Double4.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 circEaseInOut(this double4 @this, double4 b, float t) { return Double4.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 circEaseOutIn(this double4 @this, double4 b, float t) { return Double4.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static double4 quadEaseOut(this double4 @this, double4 b, float t) { return Double4.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static double4 quadEaseIn(this double4 @this, double4 b, float t) { return Double4.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 quadEaseInOut(this double4 @this, double4 b, float t) { return Double4.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 quadEaseOutIn(this double4 @this, double4 b, float t) { return Double4.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static double4 sineEaseOut(this double4 @this, double4 b, float t) { return Double4.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static double4 sineEaseIn(this double4 @this, double4 b, float t) { return Double4.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 sineEaseInOut(this double4 @this, double4 b, float t) { return Double4.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static double4 sineEaseOutIn(this double4 @this, double4 b, float t) { return Double4.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static double4 cubicEaseOut(this double4 @this, double4 b, float t) { return Double4.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static double4 cubicEaseIn(this double4 @this, double4 b, float t) { return Double4.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 cubicEaseInOut(this double4 @this, double4 b, float t) { return Double4.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 cubicEaseOutIn(this double4 @this, double4 b, float t) { return Double4.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static double4 quartEaseOut(this double4 @this, double4 b, float t) { return Double4.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static double4 quartEaseIn(this double4 @this, double4 b, float t) { return Double4.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 quartEaseInOut(this double4 @this, double4 b, float t) { return Double4.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 quartEaseOutIn(this double4 @this, double4 b, float t) { return Double4.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static double4 quintEaseOut(this double4 @this, double4 b, float t) { return Double4.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static double4 quintEaseIn(this double4 @this, double4 b, float t) { return Double4.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 quintEaseInOut(this double4 @this, double4 b, float t) { return Double4.QuintEaseInOut(@this, b, t, 1.0f); }

        public static double4 quintEaseOutIn(this double4 @this, double4 b, float t) { return Double4.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static double4 elasticEaseOut(this double4 @this, double4 b, float t) { return Double4.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static double4 elasticEaseIn(this double4 @this, double4 b, float t) { return Double4.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 elasticEaseInOut(this double4 @this, double4 b, float t) { return Double4.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 elasticEaseOutIn(this double4 @this, double4 b, float t) { return Double4.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static double4 bounceEaseOut(this double4 @this, double4 b, float t) { return Double4.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static double4 bounceEaseIn(this double4 @this, double4 b, float t) { return Double4.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 bounceEaseInOut(this double4 @this, double4 b, float t) { return Double4.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 bounceEaseOutIn(this double4 @this, double4 b, float t) { return Double4.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static double4 backEaseOut(this double4 @this, double4 b, float t) { return Double4.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static double4 backEaseIn(this double4 @this, double4 b, float t) { return Double4.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static double4 backEaseInOut(this double4 @this, double4 b, float t) { return Double4.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static double4 backEaseOutIn(this double4 @this, double4 b, float t) { return Double4.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion


        #region int

        public static int linear(this int @this, int b, float t) { return Int.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static int expoEaseOut(this int @this, int b, float t) { return Int.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static int expoEaseIn(this int @this, int b, float t) { return Int.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int expoEaseInOut(this int @this, int b, float t) { return Int.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int expoEaseOutIn(this int @this, int b, float t) { return Int.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static int circEaseOut(this int @this, int b, float t) { return Int.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static int circEaseIn(this int @this, int b, float t) { return Int.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int circEaseInOut(this int @this, int b, float t) { return Int.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int circEaseOutIn(this int @this, int b, float t) { return Int.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static int quadEaseOut(this int @this, int b, float t) { return Int.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static int quadEaseIn(this int @this, int b, float t) { return Int.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int quadEaseInOut(this int @this, int b, float t) { return Int.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int quadEaseOutIn(this int @this, int b, float t) { return Int.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static int sineEaseOut(this int @this, int b, float t) { return Int.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static int sineEaseIn(this int @this, int b, float t) { return Int.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int sineEaseInOut(this int @this, int b, float t) { return Int.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static int sineEaseOutIn(this int @this, int b, float t) { return Int.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static int cubicEaseOut(this int @this, int b, float t) { return Int.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static int cubicEaseIn(this int @this, int b, float t) { return Int.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int cubicEaseInOut(this int @this, int b, float t) { return Int.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int cubicEaseOutIn(this int @this, int b, float t) { return Int.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static int quartEaseOut(this int @this, int b, float t) { return Int.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static int quartEaseIn(this int @this, int b, float t) { return Int.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int quartEaseInOut(this int @this, int b, float t) { return Int.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int quartEaseOutIn(this int @this, int b, float t) { return Int.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static int quintEaseOut(this int @this, int b, float t) { return Int.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static int quintEaseIn(this int @this, int b, float t) { return Int.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int quintEaseInOut(this int @this, int b, float t) { return Int.QuintEaseInOut(@this, b, t, 1.0f); }

        public static int quintEaseOutIn(this int @this, int b, float t) { return Int.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static int elasticEaseOut(this int @this, int b, float t) { return Int.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static int elasticEaseIn(this int @this, int b, float t) { return Int.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int elasticEaseInOut(this int @this, int b, float t) { return Int.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int elasticEaseOutIn(this int @this, int b, float t) { return Int.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static int bounceEaseOut(this int @this, int b, float t) { return Int.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static int bounceEaseIn(this int @this, int b, float t) { return Int.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int bounceEaseInOut(this int @this, int b, float t) { return Int.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int bounceEaseOutIn(this int @this, int b, float t) { return Int.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static int backEaseOut(this int @this, int b, float t) { return Int.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static int backEaseIn(this int @this, int b, float t) { return Int.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int backEaseInOut(this int @this, int b, float t) { return Int.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int backEaseOutIn(this int @this, int b, float t) { return Int.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region int2

        public static int2 linear(this int2 @this, int2 b, float t) { return Int2.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static int2 expoEaseOut(this int2 @this, int2 b, float t) { return Int2.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static int2 expoEaseIn(this int2 @this, int2 b, float t) { return Int2.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 expoEaseInOut(this int2 @this, int2 b, float t) { return Int2.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 expoEaseOutIn(this int2 @this, int2 b, float t) { return Int2.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static int2 circEaseOut(this int2 @this, int2 b, float t) { return Int2.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static int2 circEaseIn(this int2 @this, int2 b, float t) { return Int2.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 circEaseInOut(this int2 @this, int2 b, float t) { return Int2.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 circEaseOutIn(this int2 @this, int2 b, float t) { return Int2.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static int2 quadEaseOut(this int2 @this, int2 b, float t) { return Int2.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static int2 quadEaseIn(this int2 @this, int2 b, float t) { return Int2.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 quadEaseInOut(this int2 @this, int2 b, float t) { return Int2.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 quadEaseOutIn(this int2 @this, int2 b, float t) { return Int2.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static int2 sineEaseOut(this int2 @this, int2 b, float t) { return Int2.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static int2 sineEaseIn(this int2 @this, int2 b, float t) { return Int2.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 sineEaseInOut(this int2 @this, int2 b, float t) { return Int2.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static int2 sineEaseOutIn(this int2 @this, int2 b, float t) { return Int2.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static int2 cubicEaseOut(this int2 @this, int2 b, float t) { return Int2.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static int2 cubicEaseIn(this int2 @this, int2 b, float t) { return Int2.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 cubicEaseInOut(this int2 @this, int2 b, float t) { return Int2.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 cubicEaseOutIn(this int2 @this, int2 b, float t) { return Int2.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static int2 quartEaseOut(this int2 @this, int2 b, float t) { return Int2.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static int2 quartEaseIn(this int2 @this, int2 b, float t) { return Int2.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 quartEaseInOut(this int2 @this, int2 b, float t) { return Int2.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 quartEaseOutIn(this int2 @this, int2 b, float t) { return Int2.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static int2 quintEaseOut(this int2 @this, int2 b, float t) { return Int2.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static int2 quintEaseIn(this int2 @this, int2 b, float t) { return Int2.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 quintEaseInOut(this int2 @this, int2 b, float t) { return Int2.QuintEaseInOut(@this, b, t, 1.0f); }

        public static int2 quintEaseOutIn(this int2 @this, int2 b, float t) { return Int2.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static int2 elasticEaseOut(this int2 @this, int2 b, float t) { return Int2.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static int2 elasticEaseIn(this int2 @this, int2 b, float t) { return Int2.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 elasticEaseInOut(this int2 @this, int2 b, float t) { return Int2.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 elasticEaseOutIn(this int2 @this, int2 b, float t) { return Int2.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static int2 bounceEaseOut(this int2 @this, int2 b, float t) { return Int2.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static int2 bounceEaseIn(this int2 @this, int2 b, float t) { return Int2.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 bounceEaseInOut(this int2 @this, int2 b, float t) { return Int2.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 bounceEaseOutIn(this int2 @this, int2 b, float t) { return Int2.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static int2 backEaseOut(this int2 @this, int2 b, float t) { return Int2.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static int2 backEaseIn(this int2 @this, int2 b, float t) { return Int2.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int2 backEaseInOut(this int2 @this, int2 b, float t) { return Int2.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int2 backEaseOutIn(this int2 @this, int2 b, float t) { return Int2.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region int3

        public static int3 linear(this int3 @this, int3 b, float t) { return Int3.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static int3 expoEaseOut(this int3 @this, int3 b, float t) { return Int3.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static int3 expoEaseIn(this int3 @this, int3 b, float t) { return Int3.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 expoEaseInOut(this int3 @this, int3 b, float t) { return Int3.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 expoEaseOutIn(this int3 @this, int3 b, float t) { return Int3.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static int3 circEaseOut(this int3 @this, int3 b, float t) { return Int3.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static int3 circEaseIn(this int3 @this, int3 b, float t) { return Int3.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 circEaseInOut(this int3 @this, int3 b, float t) { return Int3.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 circEaseOutIn(this int3 @this, int3 b, float t) { return Int3.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static int3 quadEaseOut(this int3 @this, int3 b, float t) { return Int3.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static int3 quadEaseIn(this int3 @this, int3 b, float t) { return Int3.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 quadEaseInOut(this int3 @this, int3 b, float t) { return Int3.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 quadEaseOutIn(this int3 @this, int3 b, float t) { return Int3.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static int3 sineEaseOut(this int3 @this, int3 b, float t) { return Int3.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static int3 sineEaseIn(this int3 @this, int3 b, float t) { return Int3.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 sineEaseInOut(this int3 @this, int3 b, float t) { return Int3.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static int3 sineEaseOutIn(this int3 @this, int3 b, float t) { return Int3.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static int3 cubicEaseOut(this int3 @this, int3 b, float t) { return Int3.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static int3 cubicEaseIn(this int3 @this, int3 b, float t) { return Int3.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 cubicEaseInOut(this int3 @this, int3 b, float t) { return Int3.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 cubicEaseOutIn(this int3 @this, int3 b, float t) { return Int3.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static int3 quartEaseOut(this int3 @this, int3 b, float t) { return Int3.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static int3 quartEaseIn(this int3 @this, int3 b, float t) { return Int3.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 quartEaseInOut(this int3 @this, int3 b, float t) { return Int3.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 quartEaseOutIn(this int3 @this, int3 b, float t) { return Int3.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static int3 quintEaseOut(this int3 @this, int3 b, float t) { return Int3.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static int3 quintEaseIn(this int3 @this, int3 b, float t) { return Int3.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 quintEaseInOut(this int3 @this, int3 b, float t) { return Int3.QuintEaseInOut(@this, b, t, 1.0f); }

        public static int3 quintEaseOutIn(this int3 @this, int3 b, float t) { return Int3.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static int3 elasticEaseOut(this int3 @this, int3 b, float t) { return Int3.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static int3 elasticEaseIn(this int3 @this, int3 b, float t) { return Int3.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 elasticEaseInOut(this int3 @this, int3 b, float t) { return Int3.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 elasticEaseOutIn(this int3 @this, int3 b, float t) { return Int3.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static int3 bounceEaseOut(this int3 @this, int3 b, float t) { return Int3.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static int3 bounceEaseIn(this int3 @this, int3 b, float t) { return Int3.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 bounceEaseInOut(this int3 @this, int3 b, float t) { return Int3.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 bounceEaseOutIn(this int3 @this, int3 b, float t) { return Int3.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static int3 backEaseOut(this int3 @this, int3 b, float t) { return Int3.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static int3 backEaseIn(this int3 @this, int3 b, float t) { return Int3.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int3 backEaseInOut(this int3 @this, int3 b, float t) { return Int3.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int3 backEaseOutIn(this int3 @this, int3 b, float t) { return Int3.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion

        #region int4

        public static int4 linear(this int4 @this, int4 b, float t) { return Int4.Linear(@this, b, t, 1.0f); }

        #region Expo

        /// <summary>Easing equation function for an exponential (2^t) easing out: decelerating from zero velocity.</summary>
        public static int4 expoEaseOut(this int4 @this, int4 b, float t) { return Int4.ExpoEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in: accelerating from zero velocity.</summary>
        public static int4 expoEaseIn(this int4 @this, int4 b, float t) { return Int4.ExpoEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 expoEaseInOut(this int4 @this, int4 b, float t) { return Int4.ExpoEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an exponential (2^t) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 expoEaseOutIn(this int4 @this, int4 b, float t) { return Int4.ExpoEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Circular


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing out: decelerating from zero velocity.</summary>
        public static int4 circEaseOut(this int4 @this, int4 b, float t) { return Int4.CircEaseOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in: accelerating from zero velocity.</summary>
        public static int4 circEaseIn(this int4 @this, int4 b, float t) { return Int4.CircEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 circEaseInOut(this int4 @this, int4 b, float t) { return Int4.CircEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a circular (sqrt(1-t^2)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 circEaseOutIn(this int4 @this, int4 b, float t) { return Int4.CircEaseOutIn(@this, b, t, 1.0f); }


        #endregion

        #region Quad

        /// <summary> Easing equation function for a quadratic (t^2) easing out: decelerating from zero velocity.</summary>
        public static int4 quadEaseOut(this int4 @this, int4 b, float t) { return Int4.QuadEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quadratic (t^2) easing in: accelerating from zero velocity.</summary>
        public static int4 quadEaseIn(this int4 @this, int4 b, float t) { return Int4.QuadEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 quadEaseInOut(this int4 @this, int4 b, float t) { return Int4.QuadEaseInOut(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a quadratic (t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 quadEaseOutIn(this int4 @this, int4 b, float t) { return Int4.QuadEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Sine

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing out: decelerating from zero velocity.</summary>
        public static int4 sineEaseOut(this int4 @this, int4 b, float t) { return Int4.SineEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in: accelerating from zero velocity.</summary>
        public static int4 sineEaseIn(this int4 @this, int4 b, float t) { return Int4.SineEaseIn(@this, b, t, 1.0f); }


        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 sineEaseInOut(this int4 @this, int4 b, float t) { return Int4.SineEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a sinusoidal (sin(t)) easing in/out: deceleration until halfway, then acceleration.</summary>
        public static int4 sineEaseOutIn(this int4 @this, int4 b, float t) { return Int4.SineEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Cubic

        /// <summary>Easing equation function for a cubic (t^3) easing out: decelerating from zero velocity.</summary>
        public static int4 cubicEaseOut(this int4 @this, int4 b, float t) { return Int4.CubicEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in: accelerating from zero velocity.</summary>
        public static int4 cubicEaseIn(this int4 @this, int4 b, float t) { return Int4.CubicEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 cubicEaseInOut(this int4 @this, int4 b, float t) { return Int4.CubicEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a cubic (t^3) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 cubicEaseOutIn(this int4 @this, int4 b, float t) { return Int4.CubicEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Quartic

        /// <summary>Easing equation function for a quartic (t^4) easing out: decelerating from zero velocity.</summary>
        public static int4 quartEaseOut(this int4 @this, int4 b, float t) { return Int4.QuartEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in: accelerating from zero velocity.</summary>
        public static int4 quartEaseIn(this int4 @this, int4 b, float t) { return Int4.QuartEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 quartEaseInOut(this int4 @this, int4 b, float t) { return Int4.QuartEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quartic (t^4) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 quartEaseOutIn(this int4 @this, int4 b, float t) { return Int4.QuartEaseOutIn(@this, b, t, 1.0f); }

        ///////////////////

        #endregion

        #region Quintic

        /// <summary>Easing equation function for a quintic (t^5) easing out: decelerating from zero velocity.</summary>
        public static int4 quintEaseOut(this int4 @this, int4 b, float t) { return Int4.QuintEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in: accelerating from zero velocity.</summary>
        public static int4 quintEaseIn(this int4 @this, int4 b, float t) { return Int4.QuintEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a quintic (t^5) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 quintEaseInOut(this int4 @this, int4 b, float t) { return Int4.QuintEaseInOut(@this, b, t, 1.0f); }

        public static int4 quintEaseOutIn(this int4 @this, int4 b, float t) { return Int4.QuintEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Elastic

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out: decelerating from zero velocity.</summary>
        public static int4 elasticEaseOut(this int4 @this, int4 b, float t) { return Int4.ElasticEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in: accelerating from zero velocity.</summary>
        public static int4 elasticEaseIn(this int4 @this, int4 b, float t) { return Int4.ElasticEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 elasticEaseInOut(this int4 @this, int4 b, float t) { return Int4.ElasticEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for an elastic (exponentially decaying sine wave) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 elasticEaseOutIn(this int4 @this, int4 b, float t) { return Int4.ElasticEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Bounce

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: decelerating from zero velocity.</summary>
        public static int4 bounceEaseOut(this int4 @this, int4 b, float t) { return Int4.BounceEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: accelerating from zero velocity.</summary>
        public static int4 bounceEaseIn(this int4 @this, int4 b, float t) { return Int4.BounceEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 bounceEaseInOut(this int4 @this, int4 b, float t) { return Int4.BounceEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 bounceEaseOutIn(this int4 @this, int4 b, float t) { return Int4.BounceEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #region Back

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out: decelerating from zero velocity.</summary>
        public static int4 backEaseOut(this int4 @this, int4 b, float t) { return Int4.BackEaseOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in: accelerating from zero velocity.</summary>
        public static int4 backEaseIn(this int4 @this, int4 b, float t) { return Int4.BackEaseIn(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out: acceleration until halfway, then deceleration.</summary>
        public static int4 backEaseInOut(this int4 @this, int4 b, float t) { return Int4.BackEaseInOut(@this, b, t, 1.0f); }

        /// <summary>Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in: deceleration until halfway, then acceleration.</summary>
        public static int4 backEaseOutIn(this int4 @this, int4 b, float t) { return Int4.BackEaseOutIn(@this, b, t, 1.0f); }

        #endregion

        #endregion


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
