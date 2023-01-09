using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderSuter : MonoBehaviour
{
    public XRSlider myXrSlider;
    public TextMeshProUGUI powerText;
    private float roundedPower;

    public void SliderChange()
    {
        Debug.Log("Slider Value: " + myXrSlider.Value);
        roundedPower = Mathf.Round(myXrSlider.Value * 100)/100f;
        powerText.SetText(roundedPower.ToString());
    }
}
