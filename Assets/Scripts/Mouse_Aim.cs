using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Aim : MonoBehaviour {

    public Texture2D crosshairTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot;
    
    void OnMouseEnter()
    {
        hotSpot = new Vector2(crosshairTexture.width / 2, crosshairTexture.height / 2);
        Cursor.SetCursor(crosshairTexture, hotSpot, cursorMode);
    }


}
