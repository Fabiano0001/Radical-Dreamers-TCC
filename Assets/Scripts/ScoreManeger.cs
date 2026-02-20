using JetBrains.Annotations;
using UnityEngine;

public class ScoreManeger : MonoBehaviour
{
    public static ScoreManeger instance;

    float[] allScores;
    [SerializeField] int howManyLevelsDoWeHave;

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
    
    public void UpdateScore(float score, int level)
    {
        //if (score > allScores[level])
        {
        //    allScores[level] = score;
        }
    }
}
