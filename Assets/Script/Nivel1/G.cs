using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G : MonoBehaviour
{
    [SerializeField] private Transform gPlace;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    public static bool locked; 
    public Collider2D collider_2D; 
    public GameObject dropSound;                
    void Start()
    {
        initialPosition = transform.position;               
    }    
    void Update()
    {                                
        //character.locateCharacter(locked, deltaX, deltaY, letraAPlace, initialPosition); 
        if(Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);            
            Vector2 position1 = transform.position;
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    if(collider_2D==Physics2D.OverlapPoint(touchPos))
                    {
                       deltaX = touchPos.x - position1.x;
                       deltaY = touchPos.y - position1.y; 
                    }
                    break;

                case TouchPhase.Moved:
                    if(collider_2D == Physics2D.OverlapPoint(touchPos))
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y -deltaY);
                    break;

                case TouchPhase.Ended:
                    if(Mathf.Abs(position1.x - gPlace.position.x) <= 0.5f && 
                       Mathf.Abs(position1.y - gPlace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(gPlace.position.x, gPlace.position.y);
                        Instantiate(dropSound);
                        locked =true;
                    } 
                    else
                        {
                            transform.position = new Vector2(initialPosition.x, initialPosition.y);
                        }
                    break;
            }
        }    
    }
}
