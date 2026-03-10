using UnityEngine;

public class PlataformaVertical : MonoBehaviour
{
    public float velocidad = 2f;
    public float limiteInferior = -2f;
    public float limiteSuperior = 2f;

    private int direccion = 1;

    void Update()
    {
        transform.Translate(Vector2.up * velocidad * direccion * Time.deltaTime);

        if (transform.position.y > limiteSuperior)
            direccion = -1;
        else if (transform.position.y < limiteInferior)
            direccion = 1;
    }
}
