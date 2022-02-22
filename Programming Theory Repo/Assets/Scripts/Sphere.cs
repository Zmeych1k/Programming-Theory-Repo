using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Figure
{
    // ENCAPSULATION
    private string directionDecription = "right";

    public override string Name
    {
        get
        {
            return this.name.ToString() + " " + directionDecription;
        }
    }

    // POLYMORPHISM
    public override void DisplayDetailsText(GameObject gameObject)
    {
        if (gameObject.tag == transform.gameObject.tag)
        {
            Debug.Log("Sphere clicked");
            UIScreen.Instance.ChangeTextDetails(Name);
        }
    }
}
