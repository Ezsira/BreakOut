using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueBuff : Bloque
{
    public float aumento = 0.5f;
    public float duracion = 5f;

    protected override void ActivarEfecto()
    {
        GameObject paleta = GameObject.FindWithTag("Paleta");
        if (paleta != null)
        {
            StartCoroutine(AgrandarPaletaTemporal(paleta));
        }
    }

    private IEnumerator AgrandarPaletaTemporal(GameObject paleta)
    {
        Vector3 original = paleta.transform.localScale;
        paleta.transform.localScale += new Vector3(aumento, 0, 0);
        yield return new WaitForSeconds(duracion);
        paleta.transform.localScale = original;
    }

}
