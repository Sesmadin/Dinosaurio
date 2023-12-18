using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManage : MonoBehaviour
{
    [SerializeField] private TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //int minutos = (int)GameManager.Instancia.tiempo / 60;
        //int segundos = (int)GameManager.Instancia.tiempo % 60;
        //string textotiempo = $"{minutos:D2}:{segundos:D2}";
        //texto.text = textotiempo;
    }
}
