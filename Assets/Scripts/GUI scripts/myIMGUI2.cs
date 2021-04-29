using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myIMGUI2 : MonoBehaviour
{
    //[SerializeField] private int _RectWidth = 300;
    //[SerializeField] private int _RectHeight = 300;

    private Rect windowRect = new Rect(Screen.width / 2 -250, Screen.height / 2 - 350, 500, 500);

    //private void Awake()
    //{
    //    windowRect(Screen.width / 2, Screen.height / 2, 300, 300);
    //}

    void OnGUI()
    {
        windowRect = GUI.Window(0, windowRect, WindowFunc,"Pause");
    }

    void WindowFunc(int windowID)
    {
        if (GUI.Button(new Rect(windowRect.width / 2 - windowRect.width * 0.45f,  windowRect.height * 0.17f, windowRect.width * 0.9f, windowRect.height * 0.2f), "Continue"))
        {
            print("Continue");
        }

        if (GUI.Button(new Rect(windowRect.width / 2 - windowRect.width * 0.45f, windowRect.height * 0.37f , windowRect.width * 0.9f, windowRect.height * 0.2f), "Restart"))
        {
            print("Restart");
        }

        if (GUI.Button(new Rect(windowRect.width / 2 - windowRect.width * 0.45f, windowRect.height * 0.57f, windowRect.width * 0.9f, windowRect.height * 0.2f), "Setting"))
        {
            print("Setting");
        }

        if (GUI.Button(new Rect(windowRect.width / 2 - windowRect.width * 0.45f, windowRect.height * 0.77f, windowRect.width * 0.9f, windowRect.height * 0.2f), "Exit"))
        {
            print("Exit");
        }
    }
}
