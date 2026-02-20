using UnityEngine;

public class RiboTubo : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform tr;
    [SerializeField] float duracao = 3;
    [SerializeField] public KeyCode tecla;
    bool hit;

    public void Ritmo(float velocidadeDoMovimento)
    {
        //force mode 2D 
        //rb.AddForce(tr.up * velocidadeDoMovimento, ForceMode2D.Force);
        rb.linearVelocity = tr.up * velocidadeDoMovimento;
        Destroy(gameObject, duracao);
    }

    public bool VerificarImput(KeyCode input)
    {
        if (input == tecla)
        {
            hit = true;
            //Destroy(gameObject);
            this.GetComponentInChildren<SpriteRenderer>().enabled = false;
            this.GetComponentInChildren<BoxCollider2D>().enabled = false;
        }

        else 
        {
            //Debug.Log("tecla xxx");
            hit = false;
        }
        return hit;
    }
}
