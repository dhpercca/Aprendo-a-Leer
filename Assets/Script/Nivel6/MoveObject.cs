using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour 
{        
    [SerializeField] private Transform letraPlace;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    //public static bool locked;
    public static bool[] locked = new bool[35];
    int l = 0; 
    public Collider2D collider_2D; 
    public GameObject dropSound;
    
    void Start()
    {            
        initialPosition = transform.position;        
    } 
    void Update()
    {                                        
        if(Input.touchCount > 0 && !locked[l])
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
                    if(Mathf.Abs(position1.x - letraPlace.position.x) <= 0.5f && 
                       Mathf.Abs(position1.y - letraPlace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(letraPlace.position.x, letraPlace.position.y);
                        Instantiate(dropSound);
                        locked[l] = false;
                        l++;                        
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
