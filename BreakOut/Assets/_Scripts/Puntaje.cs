using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformHighScore;
    public Transform transformScore;
    public TMP_Text textoHighScore;
    public TMP_Text textoScore;
    public HighScore highScoreSO;
   
    // Start is called before the first frame update
    void Start()
    {
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


    }

    private void FixedUpdate()
    {
        highScoreSO.score += 50;
    }

    // Update is called once per frame
    void Update()
    {
        textoScore.text = $"Score: {highScoreSO.score}";
        if(highScoreSO.score > highScoreSO.highScore)
        {
            highScoreSO.highScore = highScoreSO.score;
            textoHighScore.text = $"HighScore:{highScoreSO.highScore}";
            highScoreSO.Guardar(); 
            //PlayerPrefs.SetInt("HighScore",score);
            
        }
    }
}
