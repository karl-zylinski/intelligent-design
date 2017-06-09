﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantCollider : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Bodypart")
            return;

        var bps = Resources.Load("BodyPartSelector") as GameObject;
        var go = Instantiate(bps);
        go.GetComponent<BodyPartSelector>().InititateSelection(other.gameObject);
        Destroy(this);
    }
}
