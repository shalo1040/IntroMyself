using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPopUp : MonoBehaviour
{
    bool isClicked;
    bool isActivated;

    public GameObject popup;

    

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        isActivated = false;
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
            isActivated = true;
        else
            isActivated = false;
    }

    private void OnGUI()
    {
        if (isActivated)
        {
            popup.SetActive(true);
            
        }
    }

    private void OnMouseDown()
    {
        isClicked = true;
    }

    public void CloseBtnPressed()
    {
        popup.SetActive(false);
        isClicked = false;
        isActivated = false;
    }
}
