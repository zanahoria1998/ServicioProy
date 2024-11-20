using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CronometroClass : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textoCrono;
    [SerializeField] private float tiempo;
    public GameObject BotonTT;
    public GameObject ImagenTT;

    bool tiempoDetenido;

    private int tiempoMinutos, tiempoSegundos;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Cronometro();
    }

        void Cronometro(){

        if (!tiempoDetenido){
            tiempo -= Time.deltaTime;
        }


        tiempoMinutos = Mathf.FloorToInt(tiempo / 60);
        tiempoSegundos = Mathf.FloorToInt(tiempo % 60);

        textoCrono.text = string.Format("{0:00}:{1:00}", tiempoMinutos, tiempoSegundos);

        if (tiempo <= 0){
            tiempoDetenido=true;
            tiempo=0;
            Debug.Log("Tu tiempo se acabo");
            ImagenTT.SetActive(true);
            BotonTT.SetActive(true);
        }
    }
}
