using KoreanTyper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicTyper : MonoBehaviour
{
    [SerializeField]
    float delay = 0.05f;
    string originText;
    Text myText;

    private void Awake()
    {
        myText = GetComponent<Text>();
    }

    private void Start()
    {
        originText = myText.text;
        myText.text = "";

        StartCoroutine(TypingRoutine());
    }

    IEnumerator TypingRoutine()
    {
        int typingLength = originText.GetTypingLength();

        for (int index = 0; index <= typingLength; index++)
        {
            myText.text = originText.Typing(index);
            yield return new WaitForSeconds(delay);
        }
    }
}
