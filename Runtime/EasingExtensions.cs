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
    public static class EasingExtensions
    {

        /// <summary>
        /// Return Job-friendly EaseFloat object.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static EaseFloat Ease(this float @this, float to, float duration = 1.0f)
        {
            return new EaseFloat()
            {
                time = 0f,
                duration = duration,
                from = @this,
                diff = to - @this,
                value = @this
            };
        }

        /// <summary>
        /// Return Job-friendly EaseFloat object.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static EaseFloat2 Ease(this float2 @this, float2 to, float duration = 1.0f)
        {
            return new EaseFloat2()
            {
                time = 0f,
                duration = duration,
                from = @this,
                diff = to - @this,
                value = @this
            };
        }

        /// <summary>
        /// Return Job-friendly EaseFloat object.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static EaseFloat3 Ease(this float3 @this, float3 to, float duration = 1.0f)
        {
            return new EaseFloat3()
            {
                time = 0f,
                duration = duration,
                from = @this,
                diff = to - @this,
                value = @this
            };
        }

        /// <summary>
        /// Return Job-friendly EaseFloat object.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="to"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static EaseFloat4 Ease(this float4 @this, float4 to, float duration = 1.0f)
        {
            return new EaseFloat4()
            {
                time = 0f,
                duration = duration,
                from = @this,
                diff = to - @this,
                value = @this
            };
        }

    }
}
