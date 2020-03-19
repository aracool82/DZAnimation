using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinValue = 5;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
    public int GetCoinValue()
    {
        return _coinValue;
    }
}
