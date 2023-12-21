using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEnemigo : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionInicial, posicionMinima;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
            velocidad++;
        }

    }
    public void IniciarEnemigo()
    {
        transform.position = posicionInicial;
        velocidad = 4;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Sumador")
        {
            gameManager.SumarPunto();
        }
    }

}

