using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private float _speed = 4f;
    [SerializeField] private float _endPointLeft = -8.5f;
    [SerializeField] private float _endPointRight = 8.5f;
    [SerializeField] private int _money = 0;
    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _sprite.flipX = false;
            Move(_speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _sprite.flipX = true;
            Move( -_speed);
        }
        else 
        {
            _animator.SetBool("isWolk", false);
        }
    }

    private void Move(float speed)
    {
        if (transform.position.x <= _endPointLeft)
            transform.position =new Vector3(_endPointLeft + 0.1f,transform.position.y, transform.position.z);
         else if(transform.position.x >= _endPointRight)
             transform.position = new Vector3(_endPointRight - 0.1f, transform.position.y, transform.position.z);
        _animator.SetBool("isWolk", true);
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        _money += collision.GetComponent<Coin>().GetCoinValue();
    }
}
