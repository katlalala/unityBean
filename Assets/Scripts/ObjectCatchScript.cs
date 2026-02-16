using UnityEngine;

public class ObjectCatchScript : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;
    private Rigidbody2D rb;
    SFX_Script sfx;

    void Start()
    {
        sfx = GetComponent<SFX_Script>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.IsChildOf(transform))
            return;

        if (collision.CompareTag("Shout")) {
            
                sfx.PlaySFX(4);
                Destroy(collision.gameObject);
                transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
                rb.mass += massIncrease;

            }
            else

            Debug.Log("Collided with non-donut object: " + collision.gameObject.name);
    }
        }

