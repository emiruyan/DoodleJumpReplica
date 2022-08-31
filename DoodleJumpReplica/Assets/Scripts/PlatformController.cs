using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D col)
   {
      //Rigidbody içerisinde ki objenin velocity'nin y'si 0'dan küçük eşitse;
      if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
      {
         col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 70f);//Bu objete yukarı doğru 70f güç ekle
      }
   }
}
