using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyType enemyType = null;    // Scriptable Objects erişir  

    [SerializeField] private TextMeshPro typeText = null;
    private float speed = 0;
      
    void Start()
    {
        // Scriptable Objects'deki değerlere erişip o değerleri scriptin bağlı olduğu nesneye aktar
        // Hangi "enemyType" seçilmişse o "enemyType" değerlerini alır
        GetComponent<Renderer>().material.color = enemyType.enemyColor;
        transform.localScale = enemyType.enemyScale;
        typeText.text = enemyType.typeName;
        speed = enemyType.enemySpeed;
    }
    private void FixedUpdate()
    {
        transform.Translate(0, 0, speed * Time.fixedDeltaTime); // Karakter speed değeri ileri hareket eder
    }
}
