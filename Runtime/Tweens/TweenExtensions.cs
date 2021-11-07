using Unity.Mathematics;

namespace Nebukam.Easing
{
    public static class TweenExtensions
    {
        /// <summary>
        /// Return a Tween starting from the current value, using the provided parameters.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ease"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static Tween Ease(this float @this, Float.Ease ease, float to, float duration)
        {
            return new Tween(ease, @this, to, duration);
        }

        /// <summary>
        /// Return a Tween starting from the current value, using the provided parameters.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ease"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static Tween2 Ease(this float2 @this, Float2.Ease ease, float2 to, float duration)
        {
            return new Tween2(ease, @this, to, duration);
        }

        /// <summary>
        /// Return a Tween starting from the current value, using the provided parameters.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ease"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static Tween3 Ease(this float3 @this, Float3.Ease ease, float3 to, float duration)
        {
            return new Tween3(ease, @this, to, duration);
        }

        /// <summary>
        /// Return a Tween starting from the current value, using the provided parameters.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ease"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static Tween4 Ease(this float4 @this, Float4.Ease ease, float4 to, float duration)
        {
            return new Tween4(ease, @this, to, duration);
        }

    }
}
