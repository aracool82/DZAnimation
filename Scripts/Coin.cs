using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinValue = 5;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyCoin();
    }

    private void DestroyCoin()
    {
        Destroy(gameObject);
    }

    public int GetCoinValue()
    {
        return _coinValue;
    }
}
