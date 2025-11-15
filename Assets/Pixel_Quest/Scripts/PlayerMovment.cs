using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
              
        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);

        if (transform.GetChild(0).GetComponent<SpriteRenderer>())
        {
            _spriteRenderer = transform .GetChild(0).GetComponent<SpriteRenderer>();
        }

        if (_spriteRenderer)
        {
            if (horizontal >= 0) { _spriteRenderer.flipX = true;}
            else { _spriteRenderer.flipX=false;}
        }
    }
}
