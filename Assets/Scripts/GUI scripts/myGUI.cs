using System;
using UnityEngine;

public class myGUI : MonoBehaviour
{

    public int FpsCount {  get; private set; }

    [SerializeField] private int _buttonRectWidth = 200;
    [SerializeField] private int _buttonRectHeight = 180;
    [SerializeField] private int _boxCornerWidth = 100;
    [SerializeField] private int _boxCornerHeight = 50;
    [SerializeField] private int _boxWidth = 100;
    [SerializeField] private int _boxHeight = 100;
    [SerializeField] private int _boxLabelWidth = 100;
    [SerializeField] private int _boxLabelHeight = 100;

    public GUISkin skinTest;
    public Texture2D _icon2D;

    private string _message;
    private string _fps;
    private Rect buttonRect;
    private bool isPaused;

    private void Update()
    {
        FpsCount = (int)(1 / Time.deltaTime);

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("isPaused");
        }
    }

#if UNITY_EDITOR
    private void OnGUI()
    {
        buttonRect = new Rect(Screen.width / 2 - _buttonRectWidth/2 , Screen.height / 2 - _buttonRectHeight/2, _buttonRectWidth, _buttonRectHeight);

        GUI.skin = skinTest;
        GUI.Box(buttonRect, "MAIN MENU");

        if (GUI.Button(new Rect(Screen.width / 2 - _buttonRectWidth * 0.45f, Screen.height / 2 - _buttonRectHeight * 0.1f - _buttonRectHeight * 0.22f, _buttonRectWidth * 0.9f, _buttonRectHeight * 0.2f), "Open"))
        {
            _message = "Open";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - _buttonRectWidth * 0.45f, Screen.height / 2 - _buttonRectHeight * 0.1f + _buttonRectHeight * 0.04f, _buttonRectWidth * 0.9f, _buttonRectHeight * 0.2f), "Save"))
        {
            _message = "Save";
        }

        if (GUI.Button(new Rect(Screen.width / 2 - _buttonRectWidth * 0.45f, Screen.height / 2 - _buttonRectHeight * 0.1f + _buttonRectHeight * 0.3f, _buttonRectWidth * 0.9f, _buttonRectHeight * 0.2f), "Load"))
        {
            _message = "Load";
        }

        GUI.Label(new Rect(Screen.width * 0.3f, Screen.height * 0.01f, Screen.width * 0.2f, Screen.height * 0.1f), _message);

        GUI.Box(new Rect(Screen.width * 0.01f, Screen.height * 0.01f, _boxCornerWidth, _boxCornerHeight), "Top - left");
        GUI.Box(new Rect(Screen.width * 0.99f - _boxCornerWidth, Screen.height * 0.01f, _boxCornerWidth, _boxCornerHeight), "Top - right");
        GUI.Box(new Rect(Screen.width * 0.01f, Screen.height * 0.99f - _boxCornerHeight, _boxCornerWidth, _boxCornerHeight), "Bottom - left");
        GUI.Box(new Rect(Screen.width * 0.99f - _boxCornerWidth, Screen.height * 0.99f - _boxCornerHeight, _boxCornerWidth, _boxCornerHeight), "Bottom - right");

        GUI.Box(new Rect(Screen.width * 0.01f, Screen.height / 2, _boxWidth, _boxHeight), _icon2D);
        GUI.Box(new Rect(Screen.width * 0.01f, Screen.height / 2 - _boxHeight, _boxWidth, _boxHeight), new GUIContent("Text", _icon2D));

        _fps = FpsCount.ToString();
         
        GUI.BeginGroup(new Rect(Screen.width / 2, Screen.width * 0.01f, _boxLabelWidth, _boxLabelHeight));
        GUI.Label (new Rect(0, 0, _boxLabelWidth, _boxLabelHeight), "Hello");
        GUI.Label (new Rect(0, 25, _boxLabelWidth, _boxLabelHeight), "World");
        GUI.Label (new Rect(0, 50, _boxLabelWidth, _boxLabelHeight), _fps);
        GUI.EndGroup();
    }
#endif
}
