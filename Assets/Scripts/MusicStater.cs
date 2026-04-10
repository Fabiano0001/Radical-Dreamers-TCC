using UnityEngine;
using UnityEngine.UIElements;

public class MusicStater : MonoBehaviour
{
    Collider2D Collider;
    private void Start()
    {
        Collider = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<FMODUnity.StudioEventEmitter>().Play();
        Destroy(Collider);
    } 
}
