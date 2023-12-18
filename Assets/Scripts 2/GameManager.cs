using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOver, resetea, jugador, enemigo;
    [SerializeField] bool contar = true;
    [SerializeField] public float tiempo = 0;
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
    void Perder()
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
}
