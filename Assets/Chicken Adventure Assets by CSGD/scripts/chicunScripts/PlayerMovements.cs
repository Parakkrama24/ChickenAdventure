using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private float movespeed = 3.5f;
    [SerializeField] private Rigidbody2D Rigidbody;

    [SerializeField]private bool _isGoindLeft;
    private SpriteRenderer _spriteRenderer;
   
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();    //getcompennets
        _spriteRenderer = GetComponent<SpriteRenderer>();//getCompent
    }

    
    private void Update()
    {
        if (_isGoindLeft)//goleft
        {
            Rigidbody.velocity = new Vector3(-movespeed, Rigidbody.velocity.y);
        }
        else//goright
        {
            Rigidbody.velocity = new Vector3(movespeed,Rigidbody.velocity.y);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "boader")
        {
            _isGoindLeft = !_isGoindLeft;
            _spriteRenderer.flipX = _isGoindLeft;//flipx
        }
    }
   
}//class
