using System.Collections.Generic;
using UnityEngine;

public class SpawnMoney : MonoBehaviour
{
    [SerializeField] private GameObject _prefabMonet;
    private List<Transform> _pointsSpawn =new List<Transform>();
    
    private void Start()
    {
        foreach (Transform transforms in transform)
            _pointsSpawn.Add(transforms);
        InitSpawn(_pointsSpawn,_prefabMonet);
    }

    private void InitSpawn(List<Transform> points,GameObject prefab)
    {
        for (int i = 0; i < points.Count; i++)
        {
            Instantiate(prefab, points[i].position, Quaternion.identity);
        }
    }
}
