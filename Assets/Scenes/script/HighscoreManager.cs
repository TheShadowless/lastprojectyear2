using UnityEngine;

public class HighscoreManager : MonoBehaviour
{
    public static HighscoreManager Instance;
    public int highscore = 0;

    void Awake()
    {
        Instance = this;
    }

    public void CheckHighscore(int score)
    {
        if (score > highscore)
        {
            highscore = score;
            Debug.Log("New Highscore: " + highscore);
        }
    }
}
