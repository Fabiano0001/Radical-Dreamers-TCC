using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour
{
    [SerializeField] GameObject[] slides;
    int i = 0, j = 0;
    [SerializeField] bool before = true;
    void Start()
    {
        //singleton q n é destruido entre scenas atuliza o valor para saber o conjunto de sliodes para mostrar na scena
        foreach (GameObject slide in slides)
        {
            slide.SetActive(false);
            i++;
        }
        slides[0].SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //tocar som passar slide
            if (j == i -1 && before)
            {
                SceneManager.LoadScene("Gameplay");
            }
            else if (j == i -1 && !before)
            {
                SceneManager.LoadScene("Menu");
            }
            if (j < i -1)
            {
                slides[j].SetActive(false);
                slides[j + 1].SetActive(true);
                j++;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && before)
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}
