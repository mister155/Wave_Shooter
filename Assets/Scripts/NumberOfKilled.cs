using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfKilled : MonoBehaviour
{
    public Text text;
    public Player_Death player_Death;

    void Start()
    {
        player_Death = GetComponent<Player_Death>();
        text.text = player_Death.kills.ToString();
    }


}
