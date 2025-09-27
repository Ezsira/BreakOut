using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
<<<<<<< HEAD:BreakOut/Assets/_Scripts/Puntaje.cs
    public Transform transformHighScore;
    public Transform transformScore;
    public TMP_Text textoHighScore;
    public TMP_Text textoScore;
    public HighScore highScoreSO;
=======

    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;
>>>>>>> b675701 (Avance):BreakOut/Assets/Scripts/Puntaje.cs
   
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD:BreakOut/Assets/_Scripts/Puntaje.cs
        transformScore = GameObject.Find("Score").transform;
        transformHighScore = GameObject.Find("HighScore").transform;
        textoScore = transformScore.GetComponent<TMP_Text>();
        textoHighScore = transformHighScore.GetComponent<TMP_Text>();
        // if (PlayerPrefs.HasKey("HighScore"))
        // {
        //highScore = PlayerPrefs.GetInt("HighScore");

        // }
        highScoreSO.Cargar();
        textoHighScore.text = $"HighScore: {highScoreSO.highScore}";
        highScoreSO.score = 0;


=======
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("PuntajeAlto")) 
        //{
        //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
        //}
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntaje = 0;
>>>>>>> b675701 (Avance):BreakOut/Assets/Scripts/Puntaje.cs
    }

    private void FixedUpdate()
    {
<<<<<<< HEAD:BreakOut/Assets/_Scripts/Puntaje.cs
        highScoreSO.score += 50;
=======
        puntajeAltoSO.puntaje += 50;
>>>>>>> b675701 (Avance):BreakOut/Assets/Scripts/Puntaje.cs
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:BreakOut/Assets/_Scripts/Puntaje.cs
        textoScore.text = $"Score: {highScoreSO.score}";
        if(highScoreSO.score > highScoreSO.highScore)
        {
            highScoreSO.highScore = highScoreSO.score;
            textoHighScore.text = $"HighScore:{highScoreSO.highScore}";
            highScoreSO.Guardar(); 
            //PlayerPrefs.SetInt("HighScore",score);
            
=======
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", puntos);
>>>>>>> b675701 (Avance):BreakOut/Assets/Scripts/Puntaje.cs
        }
    }
}
