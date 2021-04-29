using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGUIslider : MonoBehaviour
{
    private float _sliderValue;
    //private float _plHPValue;
    //PlayerControll Player;

    //private void Awake()
    //{
    //    Player = FindObjectOfType<PlayerControll>();  
    //}

    //private void Update()
    //{
    //  _plHPValue  = Player._hpPl;
    //    Debug.Log(_plHPValue);
    //}

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width / 2 - Screen.width * 0.125f, Screen.height / 2 - Screen.height * 0.375f, Screen.width * 0.25f, Screen.height * 0.25f));
        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();

        if (GUILayout.RepeatButton("Min slider value"))
        {
            _sliderValue = 0.01f;
        }
        if (GUILayout.RepeatButton("Max slider value"))
        {
            _sliderValue = 10.0f;
        }

        GUILayout.Label("Slider value : ");
        _sliderValue = GUILayout.HorizontalSlider(_sliderValue, 0.01f, 10.0f);
        //_sliderValue = GUILayout.HorizontalSlider(_plHPValue, 0.01f, 10.0f);

        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }

}
