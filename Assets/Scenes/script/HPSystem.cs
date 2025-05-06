using UnityEngine;

public class HPSystem : MonoBehaviour
{
    public int maxHP = 3;
    private int currentHP;

    void Start()
    {
        currentHP = maxHP;
        UIManager.Instance.UpdateHP(currentHP);
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;
        UIManager.Instance.UpdateHP(currentHP);
        if (currentHP <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }

    public void Heal(int amount)
    {
        currentHP = Mathf.Min(currentHP + amount, maxHP);
        UIManager.Instance.UpdateHP(currentHP);
    }
}
