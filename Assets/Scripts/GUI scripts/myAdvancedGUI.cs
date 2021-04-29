using System;
using UnityEngine;

public class myAdvancedGUI : MonoBehaviour
{
    [SerializeField] [Header("tune var")] [Range(0, 100)] [Tooltip("some info")] private float mySlider = 1.0f;
    [SerializeField] [TextArea(5, 10)] private string my2Slider;
    [SerializeField]private int my3Slider = 1;

    public Color myColor;
    public MeshRenderer GO;

    void OnGUI()
    {
        mySlider = LebelSlider(new Rect(10, 10, 200, 20), mySlider, 5.0f, "My Slider");

    }

    float LebelSlider(Rect rect, float mySlider, float v1, string v2)
    {
        throw new NotImplementedException();
    }
}
