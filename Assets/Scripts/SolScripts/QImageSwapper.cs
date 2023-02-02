using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QImageSwapper : MonoBehaviour
{

    public Image sourceImage;
    public Sprite clockwiseImage;
    public Sprite counterClockwiseImage;
    public KeyCode firstKey;
    public KeyCode secondKey;
    public bool isClockwise = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(firstKey) || Input.GetKeyDown(secondKey)))
        {
            if (isClockwise == true)
            {
                sourceImage.sprite = counterClockwiseImage;
                //sourceImage.GetComponent<Image>().sprite = counterClockwiseImage;
                isClockwise = false;
            }
            //if (isClockwise == false)
            //{
            sourceImage.sprite = clockwiseImage;  
            //sourceImage.GetComponent<Image>().sprite = clockwiseImage;
                isClockwise = true;
            //}
        }
    }
}
