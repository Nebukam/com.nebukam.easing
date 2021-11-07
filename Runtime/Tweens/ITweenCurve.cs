using UnityEngine;

namespace Nebukam.Easing
{
    public interface ITweenCurve : ITween<float>
    {
        AnimationCurve curve { get; set; }
    }

}
