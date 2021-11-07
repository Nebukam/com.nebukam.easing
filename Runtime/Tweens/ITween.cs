using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nebukam.Easing
{
    public interface ITween
    {

        float progress { get; set; }
        float delay { get; set; }
        float time { get; set; }
        float duration { get; set; }
        bool done { get; }
        float timescale { get; set; }

        void ResetTime();

        ITween Set(float t);
        ITween Advance(float delta);

    }

    public interface ITween<T> : ITween
    {

        Easing.Ease<T> ease { get; set; }
        void Init(T a, T b);
        void Init(Easing.Ease<T> e, T a, T b, float d, float dlay = 0f, float ts = 1f);

        T val { get; }
        T At(float t);

        //ITweenData<T> data { get; set; }

    }

}
