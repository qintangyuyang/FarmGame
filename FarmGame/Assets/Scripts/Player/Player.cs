using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed;
    private float inputX;
    private float inputY;
    //移动方向的整合
    private Vector2 movementInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerInput();
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void PlayerInput()
    {
        //将键盘输入的上下左右值赋值给inputX,inputY
        //移动限制,只能上下左右横向移动,限制斜方向移动
        if (inputY == 0)
        {
            inputX = Input.GetAxisRaw("Horizontal");
        }
        if (inputX == 0)
        {
            inputY = Input.GetAxisRaw("Vertical");
        }

        //如果走的是斜方向要限制速度,不然表现的效果就是斜方向走比横向快
        // if (inputX != 0 && inputY != 0)
        // {
        //     inputX = inputX * 0.6f;
        //     inputY = inputY * 0.6f;
        // }
        movementInput = new Vector2(inputX, inputY);
    }

    private void Movement()
    {
        //刚体移动
        rb.MovePosition(rb.position + movementInput * speed * Time.deltaTime);
    }
}
