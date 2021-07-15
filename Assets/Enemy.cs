using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private TextMeshPro typeText = null;
    [SerializeField] private EnemyType enemyType = null;    // Scriptable Objects erişir    
    void Start()
    {
        // Scriptable Objects'deki değerlere erişip o değerleri scriptin bağlı olduğu nesneye aktar
        // Hangi "enemyType" seçilmişse o "enemyType" değerlerini alır
        GetComponent<Renderer>().material.color = enemyType.enemyColor;
        transform.localScale = enemyType.enemyScale;
        typeText.text = enemyType.typeName;
    }
}
