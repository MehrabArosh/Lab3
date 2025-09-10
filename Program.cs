﻿using System;
using Cards2;
Deck deck = new();
void flipper(List<Card> p)
{
    foreach (Card c in p)
    {
        c.FlipOver();
    }
}
void printCards(List<Card> cards)
{
    foreach (Card c in cards)
    {
        Console.WriteLine(c.Rank+" "+c.Suit);
     }
    
}
List<Card> p1 = [];
List<Card> p2 = [];
List<Card> p3 = [];
List<Card> p4 = [];
for (int i = 0; i < 2; i++)
{
    p1.Add(deck.TakeTopCard());
    p2.Add(deck.TakeTopCard());
    p3.Add(deck.TakeTopCard());
    p4.Add(deck.TakeTopCard());
}
p2.Add(deck.TakeTopCard());
p3.Add(deck.TakeTopCard());
flipper(p1);
flipper(p2);
flipper(p3);
flipper(p4);
Console.WriteLine("Player 1:");
printCards(p1);
Console.WriteLine("Player 2:");
printCards(p2);
Console.WriteLine("Player 3:");
printCards(p3);
Console.WriteLine("Player 4:");
printCards(p4);