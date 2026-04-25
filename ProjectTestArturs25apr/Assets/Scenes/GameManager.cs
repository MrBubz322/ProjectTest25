using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text playerName, PlayerHealth, EnemyName, EnemyHealth;

    public Player player;
    public Enemy currentenEnemy;

    public void Fight()
    {
        player.Attack(currentenEnemy);
        currentenEnemy.Attack(player);
    }
    public void RefreshUI()
    {
        playerName.text = player.name;
        PlayerHealth.text = "HP: " + player.health.ToString("F1");

        EnemyName.text = currentenEnemy.charname;
        EnemyHealth.text = "HP: " + currentenEnemy.health.ToString("F1");
    }
}    
    
