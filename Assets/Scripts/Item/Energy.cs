﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : Collectable
{
 
    public void OnTriggerEnter(Collider col)
    {
        Pickup(col.attachedRigidbody.gameObject);
    }

    override public void Interact(GameObject caller)
    {
        Pickup(caller);
    }

    override public void PickupMessage(GameObject collector)
    {
        collector.SendMessage("OnEnergyCollected", data, SendMessageOptions.DontRequireReceiver);
    }
}
