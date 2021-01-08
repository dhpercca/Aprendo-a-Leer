using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    public GameObject generateLine;
    Line line;
    [SerializeField] private GameObject CanvasLevel4      = null;    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos.x >= -3 && mousePos.x <= 3 && mousePos.y >= -3.5 && mousePos.y <= 3.5 && CanvasLevel4.activeInHierarchy){
                Vector3 whereGenerate = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y,0);
                GameObject currentLine = Instantiate(generateLine,whereGenerate,transform.rotation);
                line = currentLine.GetComponent<Line>();
            }
        }

        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            line = null;
        }
        if(line != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            line.DrawLine(mousePos);
        }
    }
}
