using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFPScount : MonoBehaviour
{
    public int FpsCount { get; private set; }

    [SerializeField] private int _boxLabelWidth = 100;
    [SerializeField] private int _boxLabelHeight = 100;

    private string _fps;
    private bool isPaused;

    private void Update()
    {
        FpsCount = (int)(1 / Time.deltaTime);

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("isPaused");
        }
    }

    private void OnGUI()
    {
        _fps = FpsCount.ToString();

        GUI.BeginGroup(new Rect(Screen.width * 0.4f, Screen.width * 0.01f, _boxLabelWidth, _boxLabelHeight));
        GUI.Label(new Rect(80, 10, _boxLabelWidth, _boxLabelHeight), "FPS");
        GUI.Label(new Rect(180, 10, _boxLabelWidth, _boxLabelHeight), "counter");
        GUI.Label(new Rect(180, 60, _boxLabelWidth, _boxLabelHeight), _fps);
        GUI.EndGroup();
    }
}
