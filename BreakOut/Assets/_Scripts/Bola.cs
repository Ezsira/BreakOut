using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

     bool isGameStarted = false;
    [SerializeField] public float velocidadBola = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 poscionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        poscionInicial.y += 3;
        this.transform.position = poscionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }
    }
}
