using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoney : MonoBehaviour
{
    [SerializeField] private GameObject _prefabMonet;
    
    private void Start()
    {
        foreach (Transform transforms in transform)
            Instantiate(_prefabMonet, transforms.position, Quaternion.identity);
    }

}
