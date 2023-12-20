//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;
    [SerializeField] GameObject gameOver, resetea, jugador, enemigo, enemigo2;
    [SerializeField] bool contar = true;
    [SerializeField] int puntuacion;
    [SerializeField] MoverEnemigo moverenemigo;
    public static GameManager Instancia;
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

    //Cada vez que se llama a este método suma la puntuación en +1
    public void ActualizarPuntuación()
    {
        puntuacionActual = +1;

        if (puntuacionActual == puntuacionMaxima)
        {
            puntuacionActual = puntuacionMaxima;
        }
    }
    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
