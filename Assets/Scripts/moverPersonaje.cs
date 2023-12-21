using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPersonaje : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] float Movimiento;
    [SerializeField] float velocidad;
    [SerializeField] Animator animator;


    // Update is called once per frame
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        ProcesarMovimiento();
    }
    void ProcesarMovimiento()
    //Logica de movimento
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector2.up * velocidad);
            animator.SetBool("TocarSuelo", false);
        }

        if (Input.GetButtonDown("Down"))
        {
            animator.SetBool("Agachaaa", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("TocarSuelo", true);

        if (collision.transform.tag == "Enemigo")
        {
            gameManager.Perder();
        }
    }
}

