using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeroController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;//Rigidbody 2d eriştik    
    [SerializeField] private float speed; //Float tipinde speed adında bir değişken oluşturduk
    [SerializeField] private Text scoreText;
    [SerializeField] private Transform cam; 
    public GameObject panel;
    private float score;


    private void Start()
    {
        Time.timeScale = 1;//Öldüğümüzde timeScale 0 olduğu için tekrardan Start'ta 1'e çekiyoruz.
    }

    private void Update()
    {
        if (rb.velocity.y > 0 && transform.position.y > score)//Hero'nun velocty y'si 0'dan byük ve transformu scoredan > ise;
        {
            score = transform.position.y;//Hero'nun y'sini score'a atadık.(Hero yükseldikçe skor artacak.)
        }
        scoreText.text = Mathf.Round(score).ToString();//scoreTextin textini ToString olarak yazdır. (Küsüratlı çıkacağı için Mathf.Round kullandık.)

        if (cam.position.y > transform.position.y + 7f)//Camera position y'si büyük ise Hero'nun y'snin +7f'ine;
        //Hero cameranın dışının +7f aşağısına çıkınca
        {
            Time.timeScale = 0;//Oyunu durdur.
            panel.SetActive(true);//Panel halihazırda false'da kapalı true'ya çekerek açıyoruz.
        }
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");//Unity içerisindeki Inp.GtAx(Horzntl) moveX'e atadık.
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        //Vector2 değerini velocity içine atadık. Hareketimizi böyle sağlayacağız.
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
