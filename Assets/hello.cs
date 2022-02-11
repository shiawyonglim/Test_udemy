using System.Collections;
using System.Collections.Generic;
//must have this thing so i can use monobehavior
using UnityEngine;
using System.Windows;
//hello world

public class hello : MonoBehaviour
{
    Rigidbody2D _rb;

    float _walkspeed;
    float _inputhorizontol;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();

        _walkspeed = 5.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        //! Horizontal and Vertical must be the same as the input name in unity
        //! Input.GetAxisRaw is for 
        _inputhorizontol = Input.GetAxisRaw("Horizontal");
        if (_inputhorizontol != 0)
        {
            _rb.AddForce(new Vector2(_inputhorizontol * _walkspeed, 0f));
        }
    }
}

