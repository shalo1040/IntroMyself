using UnityEngine;

public class MusicPopUp : MonoBehaviour
{
    public bool isActivated = false;
    public bool isClicked = false;
    
    GameObject player;
    public GameObject popup;

    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("LP_player").GetComponent<GameObject>();
        music = GetComponent<AudioSource>();
        popup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked)
            isActivated = true;
        else
            isActivated = false;
    }

    private void OnGUI()            //화면에 보여지는 부분 코드
    {
        if(isActivated)
        {
            popup.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        isClicked = true;
    }

    public void CloseBtnPressed()      //닫기 버튼 눌렀을 때 실행
    {
        popup.SetActive(false);
        isClicked = false;
        isActivated = false;
    }

    public void PlayBtnPressed()       //재생 버튼 눌렀을 때 실행
    {
        music.Play();
    }

    public void PauseBtnPressed()      //일시정지 버튼 눌렀을 때 실행
    {
        music.Pause();
    }
}
