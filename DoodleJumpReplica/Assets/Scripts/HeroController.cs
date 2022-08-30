using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public Rigidbody2D rb;//Rigidbody 2d eriştik    
    public float speed; //Float türüne bir speed değişkeni oluşturduk


    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");//Unity içerisindeki Inp.GtAx(Horzntl) moveX'e atadık.
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        //Vector2 değerini velocity içine atadık. Hareketimizi böyle sağlayacağız.
    }
}
