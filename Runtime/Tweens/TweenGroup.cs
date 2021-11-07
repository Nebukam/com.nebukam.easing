using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nebukam.Easing
{
    public class TweenGroup
    {

        protected float m_timescale = 1.0f;
        public float timescale
        {
            get { return m_timescale; }
            set { m_timescale = value; }
        }

        protected List<ITween> m_tweens = new List<ITween>();

        public ITween<T> Create<T>(Easing.Ease<T> e, T a, T b, float d, float dlay = 0f, float ts = 1f)
        {
            Tween<T> newTween = new Tween<T>(e, a, b, d, dlay, ts);
            m_tweens.Add(newTween);
            return newTween;
        }

        public ITweenCurve Create(AnimationCurve c, Easing.Ease<float> e, float d, float dlay = 0f, float ts = 1f)
        {
            TweenCurve newTween = new TweenCurve(c, e, d, dlay, ts);
            m_tweens.Add(newTween);
            return newTween;
        }

        public void Add(ITween tween)
        {
            if(m_tweens.IndexOf(tween) != -1) { return; }
            m_tweens.Add(tween);
        }


        public void Remove(ITween tween)
        {
            m_tweens.Remove(tween);
        }

        public void Set(float t)
        {
            for (int i = 0, n = m_tweens.Count; i < n; i++)
            {
                m_tweens[i].Set(t);
            }
        }

        public void Advance(float t)
        {
            float delta = t * m_timescale;
            for (int i = 0, n = m_tweens.Count; i < n; i++)
            {
                m_tweens[i].Advance(delta);
            }
        }

        public void ResetTime()
        {
            for (int i = 0, n = m_tweens.Count; i < n; i++)
            {
                m_tweens[i].ResetTime();
            }
        }

        public bool IsGroupDone()
        {
            for (int i = 0, n = m_tweens.Count; i < n; i++)
            {
                if (!m_tweens[i].done) { return false; }
            }

            return true;
        }

    }



}
