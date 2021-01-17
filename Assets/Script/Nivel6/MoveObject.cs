using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour 
{        
    //private Vector2 endPosition;
    //[SerializeField] private GameObject letraA = null;       
    public static MoveObject inst;     
    //public static void move(bool locked, float deltaX, float deltaY, Transform letraAPlace, Vector2 initialPosition, Touch touch, Vector2 touchPos, Collider2D collider_2D, Vector2 position1)
    public static void move()
    {            
        //Debug.Log("hola");
        /*switch(touch.phase)
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
                    return endPosition.transform.position = new Vector2(touchPos.x - deltaX, touchPos.y -deltaY);
                break;

            case TouchPhase.Ended:
                if(Mathf.Abs(position1.x - letraAPlace.position.x) <= 0.5f && 
                    Mathf.Abs(position1.y - letraAPlace.position.y) <= 0.5f)
                {
                    locked =true;
                    return endPosition.transform.position = new Vector2(letraAPlace.position.x, letraAPlace.position.y);
                    
                } 
                else
                    {
                        return endPosition.transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                //break;
        }*/
    } 
}
