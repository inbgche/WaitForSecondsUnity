# WaitForSecondsUnity
Unity WaitForSeconds wrapper Class to avoid GC call.

This kind of code makes food for C# Garbage Collector at every calling time.

```C#
    yield return new WaitForSeconds(1.f); 
```

But, you can avoid that problem if you cache and reuse it.


## Usage ## 
```C#
    // wait 1 second 
    yield return WaitFor.Seconds(1.0f);
    
    // wait 3 second and execute a method
    yield return StartCoroutine(WaitFor.Seconds(3.0f, DoSomething()));
```

## FixedUpdate and EndofFrame ##

```C#
    yield return WaitFor.FixedUpdate;
    yield return WaitFor.EndOfFrame;
```
