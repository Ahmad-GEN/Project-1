using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBtnImage : MonoBehaviour
{
    public Sprite newImage;
    public Button btn;
    public void changeBtnImage()
    {
        btn.image.sprite = newImage;
    }
}
