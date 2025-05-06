using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text coinText;
    public Slider hpSlider;
    public Text speedText;

    void Awake()
    {
        Instance = this;
    }

    public void UpdateCoins(int amount)
    {
        coinText.text = "Coins: " + amount;
    }

    public void UpdateHP(int hp)
    {
        hpSlider.value = hp;
    }

    public void UpdateSpeed(float speed)
    {
        speedText.text = "Speed: " + Mathf.Round(speed);
    }
}
