using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler OnSpacePressed; 
    // Start is called before the first frame update
    void Start()
    {
        OnSpacePressed += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this,EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }

    public void EventoEscuchado(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("El evento Unity se disparo correctamente");
    }
}
