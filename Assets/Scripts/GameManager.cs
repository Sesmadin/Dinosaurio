//using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] public float tiempo;
    [SerializeField] GameObject gameOver, resetea, jugador, enemigo, enemigo2;
    [SerializeField] bool contar = true;
    [SerializeField] MoverEnemigo moverenemigo;
    public static GameManager Instancia;
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        resetea.SetActive(false);
        puntuacionMaxima = PlayerPrefs.GetInt("MejorPuntuacion");
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
        puntuacionActual = 0;
        jugador.SetActive(true);
        enemigo.SetActive(true);
        gameOver.SetActive(false);
        resetea.SetActive(false);
        tiempo = 0;
        contar = true;
        moverenemigo.IniciarEnemigo();
    }

    //Cada vez que se llama a este método suma la puntuación en +1

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

    public void SumarPunto()
    {

        puntuacionActual += 1;
        if (puntuacionActual >= puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", puntuacionMaxima);
        }
    }

    public void actualizarPuntos()
    {
        puntuacionMaxima = PlayerPrefs.GetInt("MejorPuntuacion");
    }
}
