using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nebukam.Easing;
using Unity.Mathematics;

public class EasingAndTweens : MonoBehaviour
{

    protected Tween<float3> m_float3Tween;
    protected CurveEase m_curveEase;
    
    public AnimationCurve m_curve;


    void Start()
    {
        m_curveEase = new CurveEase(m_curve);
        m_float3Tween = new Tween<float3>(m_curveEase, float3.zero, new float3(10f, 0f, 0f), 5f);
        m_float3Tween = new Tween<float3>(Float3.BackSlerp.InOut, float3.zero, new float3(10f,10f,10f), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        m_float3Tween.Advance(Time.deltaTime);
        Debug.DrawLine(m_float3Tween.from, m_float3Tween.val, Color.red);
    }
}
