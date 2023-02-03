using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QImageSwapper : MonoBehaviour
{

    public GameObject mainImage;
    public GameObject otherImage;
    public KeyCode firstKey;
    public KeyCode secondKey;
    //public bool isClockwise = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(firstKey) || Input.GetKeyDown(secondKey)) && mainImage.activeSelf)
        {
            mainImage.SetActive(false);
            otherImage.SetActive(true);
        }
    }
}
