using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure
{
    public override string Name
    {
        get
        {
            return this.name.ToString() + " " + "left";
        }
    }

    public override void DisplayDetailsText(GameObject gameObject)
    {
        if (gameObject.tag == transform.gameObject.tag)
        {
            Debug.Log("Cube clicked");
            UIScreen.Instance.ChangeTextDetails(Name);
        }
    }
}
