using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public int originHelth;
    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        originHelth = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log($"Increase helth, the new helth of player name: {playerName} is: {health}");
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = originHelth;
            Debug.Log($"Restore the helth, the new helth player name: {playerName} is: {health}");
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log($"number of players is: {playerCount}");
    }
}
