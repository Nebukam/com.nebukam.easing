using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Unity.Mathematics;
using static Unity.Mathematics.math;

namespace Nebukam.Easing
{
    public class CurveEase
    {

        protected AnimationCurve m_curve;
        public AnimationCurve curve
        {
            get { return m_curve; }
            set { m_curve = value; }
        }

        protected Easing.Ease<float> m_sampling = Float.linear;
        public Easing.Ease<float> sampling
        {
            get { return m_sampling; }
            set { m_sampling = value; }
        }

        public CurveEase( AnimationCurve c = null)
        {

            m_curve = c;

            m_floatEase = FloatEase;
            m_float2Ease = Float2Ease;
            m_float3Ease = Float3Ease;
            m_float3EaseSlerp = Float3EaseSlerp;
            m_float4Ease = Float4Ease;
            m_quaternionEase = QuaternionEase;

        }

        #region float

        protected Easing.Ease<float> m_floatEase;
        public Easing.Ease<float> floatEase { get { return m_floatEase; } }
        protected float FloatEase( float a, float b, float t, float d )
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<float> (CurveEase e) { return e.floatEase; }

        #endregion

        #region float2

        protected Easing.Ease<float2> m_float2Ease;
        public Easing.Ease<float2> float2Ease { get { return m_float2Ease; } }
        protected float2 Float2Ease(float2 a, float2 b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<float2>(CurveEase e) { return e.float2Ease; }

        #endregion

        #region float3

        protected Easing.Ease<float3> m_float3Ease;
        public Easing.Ease<float3> float3Ease { get { return m_float3Ease; } }
        protected float3 Float3Ease(float3 a, float3 b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<float3>(CurveEase e) { return e.float3Ease; }


        protected Easing.Ease<float3> m_float3EaseSlerp;
        public Easing.Ease<float3> float3EaseSlerp { get { return m_float3EaseSlerp; } }
        protected float3 Float3EaseSlerp(float3 a, float3 b, float t, float d)
        {
            return Vector3.Slerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        #endregion

        #region float4

        protected Easing.Ease<float4> m_float4Ease;
        public Easing.Ease<float4> float4Ease { get { return m_float4Ease; } }
        protected float4 Float4Ease(float4 a, float4 b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<float4>(CurveEase e) { return e.float4Ease; }

        #endregion

        #region quaternion

        protected Easing.Ease<quaternion> m_quaternionEase;
        public Easing.Ease<quaternion> quaternionEase { get { return m_quaternionEase; } }
        protected quaternion QuaternionEase(quaternion a, quaternion b, float t, float d)
        {
            return slerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<quaternion>(CurveEase e) { return e.quaternionEase; }


        #endregion

    }
}
