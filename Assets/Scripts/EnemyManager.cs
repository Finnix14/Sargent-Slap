using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] m_SpawnPoints;
    public Transform[] m_BombSpawn;
    public GameObject m_BombPrefab;
    public GameObject m_EnemyPrefabs;
    void Start()
    {

    }
    void OnEnable()
    {
        
    }

    public void SpawnNewEnemy()
    {
        int randonNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length - 1));

        Instantiate(m_EnemyPrefabs, m_SpawnPoints[0].transform.position, Quaternion.identity);
    }

    public void SpawnNewBomb()
    {
        int randonNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length - 1));

        Instantiate(m_BombPrefab, m_BombSpawn[0].transform.position, Quaternion.identity);
    }
}
