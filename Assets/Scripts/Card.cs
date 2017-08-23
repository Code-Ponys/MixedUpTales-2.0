﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cards;

public class Card : MonoBehaviour {

    public CardID cardid;
    public Team team;
    public int x;
    public int y;
    public bool visited;
    public int PointCardCounter;
    public CardAction cardAction;
    public GameObject Shine;
    public Animator An;
    public GameObject F;
    public bool cardprocessdone;

    protected void SetAnimationStart() {
        Shine = (GameObject)Instantiate(Resources.Load("Animations/AN_Shine"));
        An = Shine.GetComponent<Animator>();
        Shine.transform.position = new Vector3(x, y, -3);
        Shine.GetComponent<SpriteRenderer>().enabled = true;
    }


    protected void AnimationDone() {
        F.GetComponent<GameManager>().animationDone = true;
    }
    protected bool IsSetAnimationEnd() {
        if (An.GetCurrentAnimatorStateInfo(0).IsName("end")) {
            Destroy(Shine);
            return true;
        }
        return false;
    }
}