using UnityEngine;

public class PlataformaHorizontal : MonoBehaviour
{
    public float velocidad = 2f;
    public float limiteIzquierdo = -3f;
    public float limiteDerecho = 3f;

    private int direccion = 1;

    void Update()
    {
        transform.Translate(Vector2.right * velocidad * direccion * Time.deltaTime);

        if (transform.position.x > limiteDerecho)
            direccion = -1;
        else if (transform.position.x < limiteIzquierdo)
            direccion = 1;
    }
}
