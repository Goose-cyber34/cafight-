using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public struct Card
{
    public string Name;
    public Sprite Logo;
    public int Attack, Helth;

    public Card(string name, string logoPath, int attack, int helth )
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Attack = attack;
        Helth = helth;
        
    }
}

public static class CardManager
{
    public static List<Card> AllCards = new List<Card> ();
}


public class CardManagerScr : MonoBehaviour
{
   
    public void Awake()
    {
        CardManager.AllCards.Add(new Card("GOOSE", "sprite/cards/GOOSE", 3, 3) );
        CardManager.AllCards.Add(new Card("Skeleton", "sprite/cards/Skeleton", 1, 1));
        CardManager.AllCards.Add(new Card("Krok", "sprite/cards/Krok", 1, 2));
        CardManager.AllCards.Add(new Card("Siluet", "sprite/cards/Siluet", 1, 2));
        CardManager.AllCards.Add(new Card("Shadow", "sprite/cards/Shadow", 2, 1));
        CardManager.AllCards.Add(new Card("K_Skeleton", "sprite/cards/K_Skeleton", 4, 1));

    }


 

}
