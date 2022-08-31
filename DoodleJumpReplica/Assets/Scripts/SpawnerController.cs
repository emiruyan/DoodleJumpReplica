using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    [SerializeField] GameObject prefab; //Platform prefab
    [SerializeField] private float speed;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float interval;
   
    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }

   
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime; //arttırarak hangi hızda ekleyeceği
    }

    private void Spawn() //Prefabları spawnlayacağımız fonksiyon
    {
        GameObject newPlatform = Instantiate(prefab);//prefabi çoğaltıyoruz
        newPlatform.transform.position =
            new Vector2(Random.Range(minX, maxX), transform.position.y + (Random.Range(0.5f, 1f)));
    }
}
