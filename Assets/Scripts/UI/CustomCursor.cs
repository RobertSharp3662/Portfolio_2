using UnityEngine;
using System.Collections;

public class CustomCursor : MonoBehaviour{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private void Start(){
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseEnter() {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseExit(){
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
