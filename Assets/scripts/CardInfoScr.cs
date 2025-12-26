using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardInfoScr : MonoBehaviour
{
    public Card SelfCard;
    public Image Logo;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI health;

    public void HideCardInfo(Card card)
    { 
        SelfCard = card;

        Logo.sprite = null;
        Name.text = "";
    }




    public void ShowCardInfo(Card card)
    {
        SelfCard = card;

        Logo.sprite = card.Logo;
        Logo.preserveAspect = true;
        Name.text = card.Name;
        attack.text = card.attack;
        health.text = card.Helth;
    }

   

    private void Start()
    {
        //ShowCardInfo(CardManager.AllCards[transform.GetSiblingIndex()]);
    }


}
