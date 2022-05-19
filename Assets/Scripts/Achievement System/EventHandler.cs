using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GlobalServices;

public class EventHandler : MonoSingletonGeneric<EventHandler>
{
    public event Action OnBulletFired;

    public static new EventHandler Instance { get; set; }

    public void InvokeOnBulletFired()
    {
        OnBulletFired?.Invoke();
    }


}
