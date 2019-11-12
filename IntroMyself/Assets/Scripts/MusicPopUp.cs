/*
 * LP player 터치했을 때 실행
 * 팝업창에서 노래 재생/일시정지
 */ 
using UnityEngine;

public class MusicPopUp : MonoBehaviour
{
    public bool isActivated = false;        //isActivated, isClicked 거짓으로 초기화
    public bool isClicked = false;
    
    GameObject player;                      //LP player
    public GameObject popup;                //팝업창

    public AudioSource music;               //노래 mp3 파일

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("LP_player").GetComponent<GameObject>();   //LP_player와 매치
        music = GetComponent<AudioSource>();        //노래 파일 AUdioSource로 매치
        popup.SetActive(false);                     //팝업창 비활성화
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked)                       //사용자의 터치 감지되면
            isActivated = true;             //활성화 여부 true값으로
        else
            isActivated = false;
    }

    private void OnGUI()            //화면에 보여지는 부분 코드
    {
        if(isActivated)                 //활성화 여부 true값이면
        {
            popup.SetActive(true);      //팝업창 활성화
        }
    }

    private void OnMouseDown()          //사용자가 터치하면
    {
        isClicked = true;               //isClicked 값 true로
    }

    public void CloseBtnPressed()      //닫기 버튼 눌렀을 때 실행
    {
        popup.SetActive(false);         //팝업창 비활성화
        isClicked = false;              //isClicked, isActivated 비활성화
        isActivated = false;
    }

    public void PlayBtnPressed()       //재생 버튼 눌렀을 때 실행
    {
        music.Play();                   //음악 재생
    }

    public void PauseBtnPressed()      //일시정지 버튼 눌렀을 때 실행
    {
        music.Pause();                  //음악 일시정지
    }
}
