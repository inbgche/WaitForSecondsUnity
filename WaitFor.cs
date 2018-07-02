using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
 
public static class WaitFor {
 
    static Dictionary<float, WaitForSeconds> _timeInterval = new Dictionary<float, WaitForSeconds>(100);
 
    static WaitForEndOfFrame _endOfFrame = new WaitForEndOfFrame();
    public static WaitForEndOfFrame EndOfFrame {
        get{ return _endOfFrame;}
    }
 
    static WaitForFixedUpdate _fixedUpdate = new WaitForFixedUpdate();
    public static WaitForFixedUpdate FixedUpdate {
        get{ return _fixedUpdate; }
    }
 
    // usage
    // yield return WaitFor.Seconds(1.0f);
    public static WaitForSeconds Seconds(float seconds){
        if(!_timeInterval.ContainsKey(seconds))
            _timeInterval.Add(seconds, new WaitForSeconds(seconds));
        return _timeInterval[seconds];
    }
   
    // usage
    // yield return StartCoroutine(WaitFor.Seconds(3.0f, DoSomething()));
    public static IEnumerator Seconds(float seconds, UnityAction callback)
    {
        yield return WaitFor.Seconds(seconds);
        callback();
    }
}
