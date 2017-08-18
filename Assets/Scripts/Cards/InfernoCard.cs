﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards {
    public class InfernoCard : Card {

        GameObject F;
        GameObject CardLeft1;
        GameObject CardLeft2;
        GameObject CardLeft3;
        GameObject CardRight1;
        GameObject CardRight2;
        GameObject CardRight3;
        GameObject CardDown1;
        GameObject CardDown2;
        GameObject CardDown3;
        GameObject CardUp1;
        GameObject CardUp2;
        GameObject CardUp3;
        GameObject CardIndicatorLeft1;
        GameObject CardIndicatorLeft2;
        GameObject CardIndicatorLeft3;
        GameObject CardIndicatorRight1;
        GameObject CardIndicatorRight2;
        GameObject CardIndicatorRight3;
        GameObject CardIndicatorDown1;
        GameObject CardIndicatorDown2;
        GameObject CardIndicatorDown3;
        GameObject CardIndicatorUp1;
        GameObject CardIndicatorUp2;
        GameObject CardIndicatorUp3;
        private bool cardprocessdone;

        // Use this for initialization
        void Start() {
            F = GameObject.Find("Field");
            F.GetComponent<GameManager>().cardlocked = true;
            CardLeft1 = GameObject.Find(Slave.GetCardName(CardID.Card, x - 1, y));
            CardLeft2 = GameObject.Find(Slave.GetCardName(CardID.Card, x - 2, y));
            CardLeft3 = GameObject.Find(Slave.GetCardName(CardID.Card, x - 3, y));
            CardRight1 = GameObject.Find(Slave.GetCardName(CardID.Card, x + 1, y));
            CardRight2 = GameObject.Find(Slave.GetCardName(CardID.Card, x + 2, y));
            CardRight3 = GameObject.Find(Slave.GetCardName(CardID.Card, x + 3, y));
            CardDown1 = GameObject.Find(Slave.GetCardName(CardID.Card, x, y - 1));
            CardDown2 = GameObject.Find(Slave.GetCardName(CardID.Card, x, y - 2));
            CardDown3 = GameObject.Find(Slave.GetCardName(CardID.Card, x, y - 3));
            CardUp1 = GameObject.Find(Slave.GetCardName(CardID.Card, x, y + 1));
            CardUp2 = GameObject.Find(Slave.GetCardName(CardID.Card, x, y + 2));
            CardUp3 = GameObject.Find(Slave.GetCardName(CardID.Card, x, y + 3));
            CardIndicatorLeft1 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x - 1, y));
            CardIndicatorLeft2 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x - 2, y));
            CardIndicatorLeft3 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x - 3, y));
            CardIndicatorRight1 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x + 1, y));
            CardIndicatorRight2 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x + 2, y));
            CardIndicatorRight3 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x + 3, y));
            CardIndicatorDown1 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x, y - 1));
            CardIndicatorDown2 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x, y - 2));
            CardIndicatorDown3 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x, y - 3));
            CardIndicatorUp1 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x, y + 1));
            CardIndicatorUp2 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x, y + 2));
            CardIndicatorUp3 = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, x, y + 3));

            if (CardLeft1 != null || CardLeft2 != null || CardLeft3 != null) {
                CardIndicatorLeft1.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorLeft2.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorLeft3.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
            }
            if (CardRight1 != null || CardRight2 != null || CardRight3 != null) {
                CardIndicatorRight1.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorRight2.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorRight3.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
            }
            if (CardUp1 != null || CardUp2 != null || CardUp3 != null) {
                CardIndicatorUp1.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorUp2.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorUp3.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
            }
            if (CardDown1 != null || CardDown2 != null || CardDown3 != null) {
                CardIndicatorDown1.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorDown2.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
                CardIndicatorDown3.GetComponent<Indicator>().indicatorColor = IndicatorColor.yellowcovered;
            }
        }

        // Update is called once per frame
        void Update() {
            if (cardprocessdone) return;
            if (Input.GetKeyDown(KeyCode.Mouse0)) {
                if (F.GetComponent<GameManager>().cardlocked == true) {
                    Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    int indexX = F.GetComponent<Field>().RoundIt(mouseWorldPos.x);
                    int indexY = F.GetComponent<Field>().RoundIt(mouseWorldPos.y);
                    GameObject CardIndicator = GameObject.Find(Slave.GetCardName(CardID.CardIndicator, indexX, indexY));
                    GameObject Card = GameObject.Find(Slave.GetCardName(CardID.Card, indexX, indexY));


                    if (CardIndicator.name == CardIndicatorLeft1.name
                        || CardIndicator.name == CardIndicatorLeft2.name
                        || CardIndicator.name == CardIndicatorLeft3.name) {
                        RemoveCard(CardLeft1);
                        RemoveCard(CardLeft2);
                        RemoveCard(CardLeft3);
                        cardprocessdone = true;
                        F.GetComponent<GameManager>().animationDone = true;
                        DestroyImmediate(GameObject.Find(Slave.GetCardName(CardID.Infernocard, x, y)));
                        HideCardIndicator();
                    } else if (CardIndicator.name == CardIndicatorRight1.name
                          || CardIndicator.name == CardIndicatorRight2.name
                          || CardIndicator.name == CardIndicatorRight3.name) {
                        RemoveCard(CardRight1);
                        RemoveCard(CardRight2);
                        RemoveCard(CardRight2);
                        cardprocessdone = true;
                        F.GetComponent<GameManager>().animationDone = true;
                        DestroyImmediate(GameObject.Find(Slave.GetCardName(CardID.Infernocard, x, y)));
                        HideCardIndicator();
                    } else if (CardIndicator.name == CardIndicatorUp1.name
                          || CardIndicator.name == CardIndicatorUp2.name
                          || CardIndicator.name == CardIndicatorUp3.name) {
                        RemoveCard(CardUp1);
                        RemoveCard(CardUp2);
                        RemoveCard(CardUp3);
                        cardprocessdone = true;
                        F.GetComponent<GameManager>().animationDone = true;
                        DestroyImmediate(GameObject.Find(Slave.GetCardName(CardID.Infernocard, x, y)));
                        HideCardIndicator();
                    } else if (CardIndicator.name == CardIndicatorDown1.name
                          || CardIndicator.name == CardIndicatorDown2.name
                          || CardIndicator.name == CardIndicatorDown3.name) {
                        RemoveCard(CardDown1);
                        RemoveCard(CardDown2);
                        RemoveCard(CardDown3);
                        cardprocessdone = true;
                        F.GetComponent<GameManager>().animationDone = true;
                        DestroyImmediate(GameObject.Find(Slave.GetCardName(CardID.Infernocard, x, y)));
                        HideCardIndicator();
                    }
                }
            }
        }

        private void RemoveCard(GameObject DeletedCard) {
            if (DeletedCard == null || DeletedCard.GetComponent<Card>().cardid == CardID.Startpoint) return;
            for (int i = 0; i < F.GetComponent<Field>().cardsOnField.Count; i++) {
                if (F.GetComponent<Field>().cardsOnField[i].GetComponent<Card>().x == DeletedCard.GetComponent<Card>().x
                    && F.GetComponent<Field>().cardsOnField[i].GetComponent<Card>().y == DeletedCard.GetComponent<Card>().y) {
                    F.GetComponent<Field>().cardsOnField.RemoveAt(i);
                    break;
                }
            }
            if (DeletedCard.GetComponent<Card>().cardid == CardID.Blockcard) {
                Block blockdirection = GameObject.Find(Slave.GetCardName(CardID.Card, DeletedCard.GetComponent<Card>().x, DeletedCard.GetComponent<Card>().y)).GetComponent<BlockCard>().blockDirection;
                switch (blockdirection) {
                    case Block.right:
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x + 1, DeletedCard.GetComponent<Card>().y)).GetComponent<Indicator>().indicatorState = IndicatorState.unreachable;
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x + 1, DeletedCard.GetComponent<Card>().y)).GetComponent<Indicator>().team = Team.system;
                        break;
                    case Block.left:
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x - 1, DeletedCard.GetComponent<Card>().y)).GetComponent<Indicator>().indicatorState = IndicatorState.unreachable;
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x - 1, DeletedCard.GetComponent<Card>().y)).GetComponent<Indicator>().team = Team.system;
                        break;
                    case Block.up:
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x, DeletedCard.GetComponent<Card>().y + 1)).GetComponent<Indicator>().indicatorState = IndicatorState.unreachable;
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x, DeletedCard.GetComponent<Card>().y + 1)).GetComponent<Indicator>().team = Team.system;
                        break;
                    case Block.down:
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x, DeletedCard.GetComponent<Card>().y - 1)).GetComponent<Indicator>().indicatorState = IndicatorState.unreachable;
                        GameObject.Find(Slave.GetCardName(CardID.FieldIndicator, DeletedCard.GetComponent<Card>().x, DeletedCard.GetComponent<Card>().y - 1)).GetComponent<Indicator>().team = Team.system;
                        break;
                }
            }
            Destroy(DeletedCard);
        }

        void HideCardIndicator() {
                CardIndicatorLeft1.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorLeft2.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorLeft3.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorRight1.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorRight2.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorRight3.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorUp1.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorUp2.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorUp3.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorDown1.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorDown2.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
                CardIndicatorDown3.GetComponent<Indicator>().indicatorColor = IndicatorColor.transparent;
            
        }
    }
}


