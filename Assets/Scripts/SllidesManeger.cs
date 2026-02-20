using UnityEngine;

public class SlidesManeger : MonoBehaviour
{
    public static SlidesManeger instance;

    [SerializeField] int SlideToShow;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void UpdateSlidesToShow(int newSlideListNumber)
    {
        SlideToShow = newSlideListNumber;
    }

    public int GiveSlideNumber()
    {
        return SlideToShow;
    }
}
