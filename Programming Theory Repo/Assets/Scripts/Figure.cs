using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figure : MonoBehaviour
{
    public abstract string Name
    {
        get;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    DisplayDetailsText(raycastHit.transform.gameObject);
                }
            }
        }
    }

    // POLYMORPHISM
    public abstract void DisplayDetailsText(GameObject gameObject);
}
