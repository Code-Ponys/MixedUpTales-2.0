﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;


namespace Cards {
    public class AnchorCard : Card {
        GameObject OwnGO;
        GameObject An_Anchor;

        AudioSource Sound;
        SkeletonAnimation skeletonAnimation;
        MeshRenderer MR;
        Spine.AnimationState AS;

        // Use this for initialization
        void Start() {
            GameObject F = GameObject.Find("Field");
            OwnGO = GameObject.Find(Slave.GetCardName(cardid, x, y));

            An_Anchor = (GameObject)Instantiate(Resources.Load("Animations/AN_Anchor"));

            Sound = GameObject.Find("ErrorSound (1)").GetComponent<AudioSource>();
            skeletonAnimation = An_Anchor.GetComponent<SkeletonAnimation>();
            MR = skeletonAnimation.GetComponent<MeshRenderer>();
            AS = skeletonAnimation.state;


            An_Anchor.transform.position = new Vector3(x, (y - 0.5f), -3);
            MR.enabled = true;
            skeletonAnimation.AnimationState.SetAnimation(0, "animation", false);
            Sound.Play();

            AS.Complete += delegate {
                print("animation end");
                MR.enabled = false;
                F.GetComponent<GameManager>().animationDone = true;
                Destroy(An_Anchor);
            };

        }

        // Update is called once per frame
        void Update() {

        }
        
    }
}
