﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPointBlood : MonoBehaviour
{
    public Sprite[] Sprites;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Stairs")
        {
            Vector2 pos = transform.position;

            if (other.gameObject.tag == "Stairs")
            {
                pos.y = pos.y - 0.55f;
            }
            else
            {
                pos.y = pos.y - Random.Range(0.45f, 0.55f);
            }

            var blood = new GameObject("blood");
            blood.AddComponent<BloodDecay>();
            var sr = blood.AddComponent<SpriteRenderer>();
            sr.sprite = Sprites[Random.Range(0, Sprites.Length - 1)];
            sr.sortingOrder = -1;
            blood.transform.position = pos;
        }
    }
}
