using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScreen : MonoBehaviour
{
    public static UIScreen Instance { get; private set; }

    public Text TextDetails;

    private void Awake()
    {
        Instance = this;
        TextDetails.gameObject.SetActive(false);
    }

    public void ChangeTextDetails(string updatedText)
    {
        TextDetails.gameObject.SetActive(true);

        TextDetails.text = updatedText;
    }
}