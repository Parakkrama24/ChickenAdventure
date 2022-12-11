using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private float movespeed = 3.5f;
    [SerializeField] private Rigidbody2D Rigidbody;

    [SerializeField]private bool _isGoindLeft;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    private float _firstJumpforce = 5f, _secondJumpForce = 7f;
    private bool _isFirdtJump, _isSecondJump;//false
   
    void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();    //getcompennets
        _spriteRenderer = GetComponent<SpriteRenderer>();//getCompent
        _animator = GetComponent<Animator>();   //getCompnet                                
    }
    private void Start()
    {
       _isFirdtJump = true;
        _isSecondJump = true;
    }
   
    
    private void Update()
    {
        movemet();
        if (Input.GetMouseButtonDown(0))
        {
            jumpchicken();
        }
    }
    private void jumpchicken()
    {
        if (_isFirdtJump == true)
        {
            _isFirdtJump = false;
            Rigidbody.velocity = new Vector2(Rigidbody.velocity.x, _firstJumpforce);
            _animator.SetTrigger("Fly");
        }
        else if (_isSecondJump == true)
        {
            _isSecondJump = false;
            Rigidbody.velocity = new Vector2(Rigidbody.velocity.x, _secondJumpForce);
            _animator.SetTrigger("Fly");
        }
    }

    private void movemet()
    {
        if (_isGoindLeft)//goleft
        {
            Rigidbody.velocity = new Vector3(-movespeed, Rigidbody.velocity.y);
        }
        else//goright
        {
            Rigidbody.velocity = new Vector3(movespeed, Rigidbody.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "boader")
        {
            _isGoindLeft = !_isGoindLeft;
            _spriteRenderer.flipX = _isGoindLeft;//flipx
        }
        if (collision.gameObject.tag == "Graound")
        {
            _isFirdtJump = true;
            _isSecondJump = true;
        }
    }
   
}//class
