using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// An enum defines a variable type with a few prenamed values // a
public enum CardState
{
    drawpile,
    tableau,
    target,
    discard,
    clock,
    center

}
public class ProspectorClock : Card
{

    [Header("Set Dynamically: ProspectorClock")]
    public CardState state = CardState.drawpile;

    public List<ProspectorClock> hiddenBy = new List<ProspectorClock>();

    public int layoutID;


    public SlotDef slotDef;

    override public void OnMouseUpAsButton()
    {
        // Call the CardClicked method on the Prospector singleton
        CardClock.S.CardClicked(this);

        // Also call the base class (Card.cs) version of this method
        base.OnMouseUpAsButton(); // a
    }
}

