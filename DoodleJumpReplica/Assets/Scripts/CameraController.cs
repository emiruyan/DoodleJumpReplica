using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour //Camera player'ı takip edecek
{

    public Transform hero;
    public Transform bgCenter;

    private void FixedUpdate()
    {
        if (hero.position.y >= transform.position.y)//Hero'nun transformu cameraya büyük eşit ise;
        {
            transform.position = new Vector3(transform.position.x, hero.position.y, transform.position.z);
        }

        if (transform.position.y >= bgCenter.position.y + 10.56f)//Camera y'si büyük eşit ise bgCenterın  y'sinin +10.56f'ine;
        {
            bgCenter.position = new Vector2(bgCenter.position.x, transform.position.y + 10.56f );
        }
    } 
}
