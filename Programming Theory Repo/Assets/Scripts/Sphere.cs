using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Figure
{
    public override string Name
    {
        get
        {
            return this.name.ToString() + " " + "right";
        }
    }

    public override void DisplayDetailsText(GameObject gameObject)
    {
        if (gameObject.tag == transform.gameObject.tag)
        {
            Debug.Log("Sphere clicked");
            UIScreen.Instance.ChangeTextDetails(Name);
        }
    }
}
