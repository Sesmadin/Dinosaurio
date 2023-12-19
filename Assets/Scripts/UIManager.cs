using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual, mejorPuntuacion;
    [SerializeField] private TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        //mejorPuntuacion.text = GameManager.Instancia.mejorPuntuacion.ToString();

        //int minutos = (int)GameManager.Instancia.tiempo / 60;
        //int segundos = (int)GameManager.Instancia.tiempo % 60;
        //string textotiempo = $"{minutos:D2}:{segundos:D2}";
        //texto.text = textotiempo;
    }
}