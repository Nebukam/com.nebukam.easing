![stable](https://img.shields.io/badge/-stable-darkgreen.svg)
![version](https://img.shields.io/badge/dynamic/json?color=blue&label=version&query=version&url=https%3A%2F%2Fraw.githubusercontent.com%2FNebukam%2Fcom.nebukam.easing%2Fmaster%2Fpackage.json)
![in development](https://img.shields.io/badge/license-MIT-black.svg)
[![doc](https://img.shields.io/badge/documentation-darkgreen.svg)](https://nebukam.github.io/docs/unity/com.nebukam.easing/)

# N:Easing
#### Compact easing library for Unity

N:Easing is a small easing library offering a lot of different and efficient ways to ease & tween in Unity.
The library itself is rather barebone : think of it as a whole lot of alternatives to ```lerp```.
It supports Mathematics's ```float```, ```float2```, ```float3```, ```float4```, ```double```, ```double2```, ```double3```, ```double4```, ```int```, ```int2```, ```int3```, ```int4``` & ```quaternion```. 

It is straighforward to use and extend.
Note : float3 include support for Slerp equations on top of Penner's ones. (i.e backEaseOutSlerp)

### Features
N:Easing provides multiples ways to interact with the most common easing equations, as well as using ```AnimationCurve``` for even more custom easing.

### 1 - **Inline easing using partial class**
As easy as Lerp.

> [equation( T from, T to, float time )](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/ease.cs)
```CSharp

    using static Nebukam.Easing.ease;

    float f = linear(0f, 10f, 0.5f);
    // output : 5.0

```

### 2 - **Typed & cached static equation delegates**
Static classes exist for each types; Using Unity.mathematics naming conventions with the first letter capitalized : ```Float``` for ```float``` etc.

>[Type.Equation( T from, T to, float time, float duration)](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/Easing.cs)

```CSharp

    using Nebukam.Easing;

    Float.Back.In(0f, 10f, 0.5f, 1f);
    // output : 5.0

```

Pre-cached delegate are accessed as group variants, making it easy to choose a specific easing equation :
```CSharp

    Float.Back.Out
    Float.Back.In
    Float.Back.InOut
    Float.Back.OutIn

```

### 3 - **Extensions**

Extensions work in similar ways to the partial class, and add easing methods as extensions to value types, using normalized values (like lerp does)

```CSharp

    using Nebukam.Easing.Extensions;

    float foo = 0f;
    float bar = foo.linear(10f, 0.5f);
    //bar == 5.0f

    bar = (0f).linear(10f, 0.5f);
    //bar == 5.0f

```

### 4 - **Tween object**

The [```Tween```](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/Tweens/Tween.cs) class is a lightweight-ish Tween object. It keeps track of the start, end, value, duration & current time, as well as holding a reference to an ```Easing.Ease<T>``` delegate. It can be implicitly casted to its original type, and as such is easy to work with. **Since one of its property is managed (delegate), it is unfit to work with Unity's Job system**.

```CSharp

    Tween<float> myTween = new Tween(Float.Linear, 0f, 10f, 1f);

    myTween.Advance(0.1f);
    //(float)myTween output : 1.0f;
    myTween.Advance(0.4f);
    //(float)myTween output : 5.0f;
    myTween.Advance(0.5f);
    //(float)myTween output : 10.0f;

    myTween.At(0.5f);
    //output : 5.0f;

```

### 5 - **Custom curve**

The [```CurveEase```](https://github.com/Nebukam/com.nebukam.easing/blob/master/Runtime/CurveEase.cs) allows you to easily access & use easing delegates bound to a given ```AnimationCurve```, and use them with ```Tweens``` (or standalone).

```CSharp

    CurveEase c = new CurveEase(someAnimationCurve);
    c.sampling = Float.Linear; //Default value

    Tween<float> t = new Tween<float>(c, 0f, 10f, 1f);
    t.At(0.5f);
    //output with linear curve : 5.0f

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
> To be used with [Unity's Package Manager](https://docs.unity3d.com/Manual/upm-ui-giturl.html).  
> ⚠ [Git Dependency Resolver For Unity](https://github.com/mob-sakai/GitDependencyResolverForUnity) must be installed *before* in order to fetch nested git dependencies. (See the [Installation troubleshooting](#installation-troubleshooting) if you encounter issues).  

See [Unity's Package Manager : Getting Started](https://docs.unity3d.com/Manual/upm-parts.html)

---
## Dependencies
- **Unity.Mathematics 1.1.0** -- [com.unity.mathematics](https://github.com/Unity-Technologies/Unity.Mathematics)


---
## Credits

Original easing equations are based on [Robert Penner's easing functions](http://robertpenner.com/easing/).

---
## Installation Troubleshooting

After installing this package, Unity may complain about missing namespace references error (effectively located in dependencies). What [Git Dependency Resolver For Unity](https://github.com/mob-sakai/GitDependencyResolverForUnity) does, instead of editing your project's package.json, is create local copies of the git repo *effectively acting as custom local packages*.
Hence, if you encounter issues, try the following:
- In the project explorer, do a ```Reimport All``` on the **Packages** folder (located at the same level as **Assets** & **Favorites**). This should do the trick.
- Delete Library/ScriptAssemblies from you project, then ```Reimport All```.
- Check the [Resolver usage for users](https://github.com/mob-sakai/GitDependencyResolverForUnity#usage)
