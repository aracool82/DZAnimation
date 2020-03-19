using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _money = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _money += collision.GetComponent<Coin>().GetCoinValue();
    }
}
