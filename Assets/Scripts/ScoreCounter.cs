using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] int amountTimesTwo = 3;
    [SerializeField] int amountTimesFour = 6;
    [SerializeField] int amountTimesEigth = 12;
    [SerializeField] int level;
    Text scoreText;
    float score = 0;
    int hitsInARow = 0;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "Pontuação : " + score;
    }
    public void AddScore(int amountToAddOnHit)
    {
        if (hitsInARow >= amountTimesEigth)
        {
            score += (amountToAddOnHit * 8);
        }
        else if (hitsInARow >= amountTimesFour)
        {
            score += (amountToAddOnHit * 4);
        }
        else if (hitsInARow >= amountTimesTwo)
        {
            score += (amountToAddOnHit * 2);
        }
        else
        {
            score += amountToAddOnHit;
        }
        hitsInARow++;
        scoreText.text = "Pontuação : " + score;
        ScoreManeger.instance.UpdateScore(score, level);
    }

    public void MissedTheBonus()
    {
        hitsInARow = 0;
    }
}
