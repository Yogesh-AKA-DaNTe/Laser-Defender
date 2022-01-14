using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    // Variables for storing Health Text and Player
    Text healthText;
    Player player;

    void Start()
    {
        // Assigning Health Text and Player
        healthText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        // Updating Health Text
        healthText.text = player.GetHealth().ToString();
    }
}
