using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;//Rigidbody 2d eriştik    
    [SerializeField] private float speed; //Float tipinde speed adında bir değişken oluşturduk


    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");//Unity içerisindeki Inp.GtAx(Horzntl) moveX'e atadık.
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        //Vector2 değerini velocity içine atadık. Hareketimizi böyle sağlayacağız.
    }
}
