using UnityEngine;

public class MusicPopUp : MonoBehaviour
{
    public bool isActivated = false;
    public bool isClicked = false;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("LP_player").GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked)
        {
            isActivated = true;
        }
        else
        {
            isActivated = false;
        }
    }

    private void OnGUI()            //화면에 보여지는 부분 코드
    {
        if(isActivated)
        {
            GUI.Window(0, new Rect((Screen.width / 2) - 150, (Screen.height / 2) - 75, 300, 250), ShowGUI, "Invalid word");
        }
    }

    void ShowGUI(int WindowID)
    {

    }

    private void OnMouseDown()
    {
        isClicked = true;
    }
}
