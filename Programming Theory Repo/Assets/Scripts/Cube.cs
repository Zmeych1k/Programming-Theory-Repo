using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Figure
{
    // ENCAPSULATION
    private string directionDecription = "left";

    // ABSTRACTION
    public override string Name
    {
        get
        {
            return this.name.ToString() + " " + "left";
        }
    }

    // POLYMORPHISM
    public override void DisplayDetailsText(GameObject gameObject)
    {
        if (gameObject.tag == transform.gameObject.tag)
        {
            Debug.Log("Cube clicked");
            UIScreen.Instance.ChangeTextDetails(Name);
        }
    }
}
