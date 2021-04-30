using UnityEditor;
//using UnityEditor.PackageManager.UI;
using UnityEngine;

public class UnityWindow : EditorWindow
{
    public Color myColor;
    public MeshRenderer GO;

    public Material newMterial;

    private Rect AreaRect = new Rect (10, 60, 200, 30);

    private Transform MainCam;

    [MenuItem(" one / two /  generator prefabs ")]

    public static void ShowWindow()
    {      
        //GetWindow (typeof(UnityEditor.PackageManager.UI.Window), true, "Test window");

        GetWindow (typeof ( UnityWindow ) , false, "Test window");
    }

    void OnGUI()
    {
        GO = EditorGUILayout.ObjectField("Mesh object", GO, typeof(MeshRenderer),true) as MeshRenderer;
        newMterial = EditorGUILayout.ObjectField("newMterial object", newMterial, typeof(Material),true) as Material;

        if (GO)
        {
            myColor = RGBSlider(new Rect(10, 60, 200, 30), myColor);
            GO.sharedMaterial.color = myColor;
        }
        else
        {
            if (GUI.Button(new Rect(10, 100, 200, 30), "create window"))
            {
                MainCam = Camera.main.transform;
                GameObject tmp = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                MeshRenderer GORenderer = tmp.GetComponent<MeshRenderer>();
                GORenderer.sharedMaterial = newMterial;
                tmp.transform.position = new Vector3(MainCam.position.x - 15.0f, MainCam.position.y - 40.0f, MainCam.position.z);
                GO = GORenderer;
            }
        }
       // mySlider = LebelSlider(new Rect(10, 10, 200, 30), mySlider, 100.0f, "My Slider");

    }

    float LebelSlider(Rect screenRect, float sliderValue, float sliderValueMax, string lebelText)
    {
        Rect lebelRect = new Rect(screenRect.x, screenRect.y, screenRect.width, screenRect.height);

        GUI.Label(lebelRect, lebelText);

        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height);
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
