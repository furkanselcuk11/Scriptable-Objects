using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Enemy Type",menuName ="EnemyType")]
public class EnemyType : ScriptableObject
{
    // Scriptable Objects Oluşturulur
    // Scriptable Objects default değerleri oluşturulur
    public Color enemyColor = Color.white;
    public float enemySpeed = 5f;
    public Vector3 enemyScale = Vector3.one;
    public string typeName = "type";
}
