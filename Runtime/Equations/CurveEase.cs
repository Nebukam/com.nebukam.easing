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

            m_intEase = IntEase;
            m_int2Ease = Int2Ease;
            m_int3Ease = Int3Ease;
            m_int4Ease = Int4Ease;

            m_doubleEase = DoubleEase;
            m_double2Ease = Double2Ease;
            m_double3Ease = Double3Ease;
            m_double4Ease = Double4Ease;

            m_floatEase = FloatEase;
            m_float2Ease = Float2Ease;
            m_float3Ease = Float3Ease;
            m_float3EaseSlerp = Float3EaseSlerp;
            m_float4Ease = Float4Ease;

            m_quaternionEase = QuaternionEase;

        }

        #region double

        protected Easing.Ease<double> m_doubleEase;
        public Easing.Ease<double> doubleEase { get { return m_doubleEase; } }
        protected double DoubleEase(double a, double b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<double>(CurveEase e) { return e.doubleEase; }

        #endregion

        #region double2

        protected Easing.Ease<double2> m_double2Ease;
        public Easing.Ease<double2> double2Ease { get { return m_double2Ease; } }
        protected double2 Double2Ease(double2 a, double2 b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<double2>(CurveEase e) { return e.double2Ease; }

        #endregion

        #region double3

        protected Easing.Ease<double3> m_double3Ease;
        public Easing.Ease<double3> double3Ease { get { return m_double3Ease; } }
        protected double3 Double3Ease(double3 a, double3 b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<double3>(CurveEase e) { return e.double3Ease; }

        #endregion

        #region double4

        protected Easing.Ease<double4> m_double4Ease;
        public Easing.Ease<double4> double4Ease { get { return m_double4Ease; } }
        protected double4 Double4Ease(double4 a, double4 b, float t, float d)
        {
            return lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<double4>(CurveEase e) { return e.double4Ease; }

        #endregion


        #region int

        protected Easing.Ease<int> m_intEase;
        public Easing.Ease<int> intEase { get { return m_intEase; } }
        protected int IntEase(int a, int b, float t, float d)
        {
            return (int)lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<int>(CurveEase e) { return e.intEase; }

        #endregion

        #region int2

        protected Easing.Ease<int2> m_int2Ease;
        public Easing.Ease<int2> int2Ease { get { return m_int2Ease; } }
        protected int2 Int2Ease(int2 a, int2 b, float t, float d)
        {
            return (int2)lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<int2>(CurveEase e) { return e.int2Ease; }

        #endregion

        #region int3

        protected Easing.Ease<int3> m_int3Ease;
        public Easing.Ease<int3> int3Ease { get { return m_int3Ease; } }
        protected int3 Int3Ease(int3 a, int3 b, float t, float d)
        {
            return (int3)lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<int3>(CurveEase e) { return e.int3Ease; }

        #endregion

        #region int4

        protected Easing.Ease<int4> m_int4Ease;
        public Easing.Ease<int4> int4Ease { get { return m_int4Ease; } }
        protected int4 Int4Ease(int4 a, int4 b, float t, float d)
        {
            return (int4)lerp(a, b, m_curve.Evaluate(m_sampling(0f, 1f, t, d)));
        }

        public static implicit operator Easing.Ease<int4>(CurveEase e) { return e.int4Ease; }

        #endregion


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
