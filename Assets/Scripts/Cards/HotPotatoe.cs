﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotPotatoe : Card {

    GameObject HandCard1;
    GameObject HandCard2;
    GameObject HandCard3;

    // Use this for initialization
    void Start () {
        GameObject F = GameObject.Find("Field");

        Team team = F.GetComponent<GameManager>().currentPlayer;
        if (team == Team.blue) {
            GameObject.Find("HandCard1red").GetComponent<Handcards>().cardid = CardID.none;
            GameObject.Find("HandCard2red").GetComponent<Handcards>().cardid = CardID.none;
            GameObject.Find("HandCard3red").GetComponent<Handcards>().cardid = CardID.none;
        }else {
            GameObject.Find("HandCard1blue").GetComponent<Handcards>().cardid = CardID.none;
            GameObject.Find("HandCard2blue").GetComponent<Handcards>().cardid = CardID.none;
            GameObject.Find("HandCard3blue").GetComponent<Handcards>().cardid = CardID.none;
        }

        Destroy(GameObject.Find(Slave.GetCardName(CardID.HotPotatoe, x, y)));
        F.GetComponent<GameManager>().animationDone = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
