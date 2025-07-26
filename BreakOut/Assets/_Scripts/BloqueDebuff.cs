using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueDebuff : Bloque
{
    public float reduccion = 0.3f;
    public float duracion = 5f;

    protected override void ActivarEfecto()
    {
        GameObject paleta = GameObject.FindWithTag("Paleta");
        if (paleta != null)
        {
            StartCoroutine(ReducirPaletaTemporal(paleta));
        }
    }

    private IEnumerator ReducirPaletaTemporal(GameObject paleta)
    {
        Vector3 original = paleta.transform.localScale;
        paleta.transform.localScale -= new Vector3(reduccion, 0, 0);
        yield return new WaitForSeconds(duracion);
        paleta.transform.localScale = original;
    }
}
