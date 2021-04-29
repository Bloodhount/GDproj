using System;
using UnityEngine;

public class myAdvancedGUI : MonoBehaviour
{
    [SerializeField] [Header("tune var")] [Range(0, 100)] [Tooltip("some info")] private float mySlider = 1.0f;
    [SerializeField] [TextArea(5, 10)] private string my2Slider;
    [SerializeField] private int my3Slider = 1;

    public Color myColor;
    public MeshRenderer GO;

    void OnGUI()
    {
        mySlider = LebelSlider(new Rect(10, 10, 200, 30), mySlider, 100.0f, "My Slider");
        myColor = RGBSlider(new Rect(10, 60, 200, 30), myColor);
        GO.material.color = myColor;
    }

    float LebelSlider(Rect screenRect, float sliderValue, float sliderValueMax, string lebelText)
    {
        Rect lebelRect = new Rect(screenRect.x, screenRect.y, screenRect.width, screenRect.height);

        GUI.Label(lebelRect, lebelText);

        Rect sliderRect = new Rect(screenRect.x + screenRect.width/2, screenRect.y, screenRect.width/2, screenRect.height);
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderValueMax);

        return sliderValue;
    }

    private Color RGBSlider(Rect screenRect, Color myRGBColor)
    {
        myRGBColor.r = LebelSlider(screenRect, myRGBColor.r, 1f, "Red");

        screenRect.y += 40;
        myRGBColor.g = LebelSlider(screenRect, myRGBColor.g, 1f, "Green");

        screenRect.y += 40;
        myRGBColor.b = LebelSlider(screenRect, myRGBColor.b, 1f, "Blue");

        screenRect.y += 40;
        myRGBColor.a = LebelSlider(screenRect, myRGBColor.a, 1f, "Alpha");

        return myRGBColor;
    }
}
