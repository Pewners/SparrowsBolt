using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSpriteSwap : MonoBehaviour
{
    Image myImage;

    public Sprite notHighlighted;
    public Sprite highlighted;

    private void Start()
    {
        myImage = GetComponent<Image>();
    }

    private void OnMouseEnter()
    {
        Debug.Log("Mouse Over");
        myImage.sprite = highlighted;
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
        myImage.sprite = notHighlighted;
    }
}
