using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    [SerializeField] private GameObject paintBrush;

    public void changeColor(string color) {

        switch (color) {
            case "red":
                paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>().Color = new Color(1, 0, 0, 1);
                Debug.Log("RED");
                break;
            case "yellow":
                paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>().Color = new Color(1, 1, 0, 1);
                Debug.Log("YELLOW");
                break;
            case "green":
                paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>().Color = new Color(0, 1, 0, 1);
                Debug.Log("GREEN");
                break;
            case "cyan":
                paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>().Color = new Color(0, 1, 1, 1);
                Debug.Log("CYAN");
                break;
            case "blue":
                paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>().Color = new Color(0, 0, 1, 1);
                Debug.Log("BLUE");
                break;
            case "purple":
                paintBrush.GetComponent<PaintIn3D.P3dPaintSphere>().Color = new Color(1, 0, 1, 1);
                Debug.Log("PURPLE");
                break;
        }
    }
}
