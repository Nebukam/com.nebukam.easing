![stable](https://img.shields.io/badge/-stable-darkgreen.svg)
![version](https://img.shields.io/badge/dynamic/json?color=blue&label=version&query=version&url=https%3A%2F%2Fraw.githubusercontent.com%2FNebukam%2Fcom.nebukam.easing%2Fmaster%2Fpackage.json)
![in development](https://img.shields.io/badge/license-MIT-black.svg)

# N:Easing
#### Compact easing library for Unity

N:Easing is a small easing library offering a lot of different and efficient ways to ease & tween Unity.Mathematics's ```float```, ```float2```, ```float3``` & ```float4```. It is straighforward to use and extend.

### Features
N:Easing provides multiples ways to interact with the most common easing equations, as well as using ```AnimationCurve``` for even more custom easing.

### 1 - **Inline easing using partial class**
As easy as Lerp.

> [easing(from, to, time)](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/ease.cs)
```CSharp

    using static Nebukam.Easing.ease;

    float f = linear(0f, 10f, 0.5f);
    // output : 5.0

```

### 2 - **Static methods**
While straighfoward to use, the static methods signature is the same as the original Penner's functions, making it slightly less easy to grasp and use. **The static methods are flagged to be aggressively inlined, for increased performance.**

>[Ease(float t, float b, float c, float d)](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/Easing.cs)

```CSharp

    Easing.Linear(0.5f, 0f, 10f, 1f);
    // output : 5.0

```


### 3 - **Pre-cached delegate to static methods**
Makes it easy to customize easing methods, and build flexible code. Delegate use the same name as their corresponding method, **however since they are properties, starts with a lowercase instead**. _Make sure to use cached delegates to avoid garbage generation_

>[ease(float from, float to, float t)](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/Easing.cs)
```CSharp

    Easing.Ease easeFunc = Easing.linear;
    easingFunc(0.5f, 0f, 10f, 1f);
    // output : 5.0

```

Pre-cached delegate can be accessed as groups, making it easy to choose a specific easing equation :
```CSharp

    Easing.backEaseIn
    //Can also be accessed through :
    Easing.Back.In
    
    //As well as :
    Easing.Back.Out
    Easing.Back.InOut
    Easing.Back.OutIn

```

### 4 - **Ease object & extensions**

The [```EaseFloat```](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/Jobs/EaseFloat.cs) struct is similar to a Tween object, only much lighter. It keeps track of the start, end, and diff value, as well as duration & current time. It can be implicitly cast to its original type, and as such is easy to work with. **It makes it easy to use easing in Jobs without any boilerplate code**.

```CSharp

    EaseFloat e = (0f).Ease(10f, 1f);
    e.Linear(0.1f);
    // (float)e output : 1.0
    e.Linear(0.5f);
    // (float)e output : 6.0
    e.Linear(0.4f);
    // (float)e output : 10.0

```

### 5 - **Tween object**

The [```Tween```](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/Tweens/Tween.cs) struct is a lightweight Tween object. Similar to the ```EaseFlot``` struct, it keeps track of the start, end, and diff value, as well as duration & current time, as well as holding a reference to an ```Easing.Ease``` delegate. It can be implicitly casted to its original type, and as such is easy to work with. **Since one of its property is managed (delegate), it is unfit to work with Unity's Job system**.

```CSharp

    Tween t = (0f).Ease(Easing.linear, 10f, 1f);
    //or
    Tween t = new Tween(Easing.linear, 0f, 10f, 1f);

    t.Advance(0.1f);
    //(float)t output : 1f;
    t.Advance(0.4f);
    //(float)t output : 5f;
    t.Advance(0.6f);
    //(float)t output : 10f;

    t.At(0.5f);
    //output : 5f;

```

### 6 - **Custom curve**

The [```CurveEase```](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/CurveEase.cs) allows you to easily access & use easing delegates bound to a given ```AnimationCurve```, and use them with ```Tweens```.

```CSharp

    CurveEase c = new CurveEase();
    c.curve = someAnimationCurve;

    Tween t = new Tween(c.ease, 0f, 10f, 1f);
    t.At(0.5f);
    //output with linear curve : 5.0

```
---
## Out-of-the-box easings :

| Easing        |  Out           | In  | InOut | OutIn |
| ------------- |:---| :---|:---|:---|
| **Linear**      | linear | - | - | - |
| **Expo**      | expoEaseOut | expoEaseIn | expoEaseInOut | expoEaseOutIn |
| **Circular**      | circEaseOut | circEaseIn | circEaseInOut | circEaseOutIn |
| **Quad**      | quadEaseOut | quadEaseIn | quadEaseInOut | quadEaseOutIn |
| **Sine**      | sineEaseOut | sineEaseIn | sineEaseInOut | sineEaseOutIn |
| **Cubic**      | cubicEaseOut | cubicEaseIn | cubicEaseInOut | cubicEaseOutIn |
| **Quartic**      | quartEaseOut | quartEaseIn | quartEaseInOut | quartEaseOutIn |
| **Quintic**      | quintEaseOut | quintEaseIn | quintEaseInOut | quintEaseOutIn |
| **Elastic**      | elasticEaseOut | elasticEaseIn | elasticEaseInOut | elasticEaseOutIn |
| **Bounce**      | bounceEaseOut | bounceEaseIn | bounceEaseInOut | bounceEaseOutIn |
| **Back**      | backEaseOut | backEaseIn | backEaseInOut | backEaseOutIn |

---
## Hows

### Installation
To be used with [Unity's Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html) + [Git Dependency Resolver For Unity](https://github.com/mob-sakai/GitDependencyResolverForUnity) (or any git dependencies resolving package, really).

⚠ [Git Dependency Resolver For Unity](https://github.com/mob-sakai/GitDependencyResolverForUnity) must be installed *before* in order to fetch nested git dependencies.
{: .alert .alert-danger}

See [Unity's Package Manager : Getting Started](https://docs.unity3d.com/Manual/upm-parts.html)

---
## Dependencies
- **Unity.Mathematics 1.1.0** -- [com.unity.mathematics](https://github.com/Unity-Technologies/Unity.Mathematics)


---
## Credits

Original easing equations are based on [Robert Penner's easing functions](http://robertpenner.com/easing/).
