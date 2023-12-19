//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] float tiempo;
    [SerializeField] GameObject gameOver, resetea, jugador, enemigo;
    [SerializeField] bool contar = true;
    [SerializeField] int puntuacion;
    [SerializeField] MoverEnemigo moverenemigo;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        resetea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (contar == true)
        {
            tiempo += Time.deltaTime;
        }
    }

    public void Perder()
    {
        jugador.SetActive(false);
        enemigo.SetActive(false);
        gameOver.SetActive(true);
        resetea.SetActive(true);
        contar = false;
    }

    public void ReiniciarJuego()
    {
        puntuacion = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        gameOver.SetActive(false);
        resetea.SetActive(false);
        tiempo = 0;
        contar = true;
        moverenemigo.IniciarEnemigo();
    }

    //Cada vez que se llama a este m�todo suma la puntuaci�n en +1
    public void ActualizarPuntuaci�n()
    {
        puntuacionActual = +1;

        if (puntuacionActual == puntuacionMaxima)
        {
            puntuacionActual = puntuacionMaxima;
        }
    }


}
