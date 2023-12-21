using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPersonaje : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] float Movimiento;
    [SerializeField] float velocidad;

    // Update is called once per frame
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        ProcesarMovimiento();
    }
    void ProcesarMovimiento()
    //Logica de movimento
    {
        if (Input.GetButton("Fire1"))
        {
            rigidbody.AddForce(Vector2.up * velocidad);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemigo")
        {
            gameManager.Perder();
        }
    }
}

