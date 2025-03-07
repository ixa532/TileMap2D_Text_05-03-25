using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Animacao : MonoBehaviour
{
    private Animator animator;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Andar");
            rigidbody.velocity = new Vector2(5, -1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Andar");
            rigidbody.velocity = new Vector2();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //mudar
            animator.SetTrigger("Pular");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //Agachar
            animator.SetTrigger("Agachar");
        }
    }
}
