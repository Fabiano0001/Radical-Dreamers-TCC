using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

/*public class StoryScript : MonoBehaviour
{
    [SerializeField] GameObject[] slides;
    int i = 0, j = 0;
    [SerializeField] bool before = true;

    int SlideToShow;
    void Start()
    {
        //singleton q n é destruido entre scenas atuliza o valor para saber o conjunto de sliodes para mostrar na scena
        foreach (GameObject slide in slides)
        {
            slide.SetActive(false);
            i++;
        }
        slides[0].SetActive(true);


        SlideToShow = SlidesManeger.instance.GiveSlideNumber();
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
                GetComponent<AudioSource>().Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && before)
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}*/


public class StoryScript : MonoBehaviour
{
    [SerializeField] SlideData[] slideData;
    [SerializeField] GameObject test;
    SlideData thisSlide;
    int i = 0, j = 0;
    int SlideToShow;
    UnityEngine.UI.Image imagem;

    private void Start()
    {
        SlideToShow = SlidesManeger.instance.GiveSlideNumber();
        imagem = test.GetComponent<UnityEngine.UI.Image>();
        thisSlide = slideData[SlideToShow];
        foreach (Sprite slide in thisSlide.sprites)
        {
            i++;
        }
        imagem.sprite = thisSlide.sprites[j];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSlide();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeScene();
        }
    }

    public void NextSlide()
    {
        j++;
        if (j < i)
        {
            imagem.sprite = thisSlide.sprites[j];
        }
        if (j == i)
        {
            ChangeScene();
        }
    }
    public void ChangeScene()
    {
        if (SlideToShow % 2 != 0)
        {
            SceneManager.LoadScene("Menu");
        }
        switch (SlideToShow)
        {
            case 0:
                SlidesManeger.instance.UpdateSlidesToShow(SlideToShow + 1);
                SceneManager.LoadScene("Gameplay");
                break;
        }
    }
}