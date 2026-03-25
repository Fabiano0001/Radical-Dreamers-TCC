using UnityEngine;
using UnityEngine.UIElements;

public class MusicStater : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    Collider2D Collider;
    private void Start()
    {
        Collider = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //AudioSource.Play();
        GetComponent<FMODUnity.StudioEventEmitter>().Play();
        Destroy(Collider);
    } 
}
