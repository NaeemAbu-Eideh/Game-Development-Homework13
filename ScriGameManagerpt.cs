using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ScriGameManagerpt : MonoBehaviour
{
    
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Naeem Abueideh", 100);
        player2.InitializePlayer("Ameen Abueideh", 100);

        player1.Heal(20);
        player1.Heal(true);

        player2.Heal(15);
        player2.Heal(true);

        Player.ShowPlayerCount();
    }

    
}
