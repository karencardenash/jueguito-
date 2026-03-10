using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SlowBounce : MonoBehaviour
{
    public float initialForce = 2f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Dirección aleatoria
        Vector2 randomDir = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(0.5f, 1f)
        ).normalized;

        rb.AddForce(randomDir * initialForce, ForceMode2D.Impulse);
    }
}