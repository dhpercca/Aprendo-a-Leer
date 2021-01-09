using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableLetter : MonoBehaviour, IPointerClickHandler
{
    char _randomLetter;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"Clicked on letter {_randomLetter}");
    }
   private void OnEnable()
   {
        int a = Random.Range(0, 26);
        _randomLetter = (char)('a' + a);

        if(Random.Range(0, 100) > 50)
            GetComponent<TMP_Text>().text = _randomLetter.ToString();
        else
            GetComponent<TMP_Text>().text = _randomLetter.ToString().ToUpper();
   }
}
