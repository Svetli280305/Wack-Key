using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorConfig : MonoBehaviour
{
    public Texture2D cursorTexture;
    
    void Start()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider && hit.collider.gameObject.tag == "mole" && Input.GetMouseButtonDown(0))
        {
            ScoreBoard s = FindObjectOfType<ScoreBoard>();
            s.AddPoints();
            hit.collider.gameObject.GetComponent<ColourChanger>().Healing();
        }
    }
}
