/*
 * TV를 눌렀을 때 실행
 * 팝업창에서 영상 재생
 */ 
using UnityEngine;
using UnityEngine.UI;               //RawImage 사용하기 위해 추가
using UnityEngine.Video;            //VideoPlayer 사용하기 위해 추가

public class VideoPopUp : MonoBehaviour
{
    bool isClicked;                 //사용자가 사물을 눌렀는지 여부 판단
    bool isActivated;               //사물이 활성화 되었는지 여부 판단

    public GameObject popup;        //사물이 활성화 되었을 때 보이는 창

    public RawImage video;          //영상을 담을 매개체
    public VideoPlayer player;      //영상

    

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;          //초기화: isClicked, isActivated, pop.SetActive(false)
        isActivated = false;
        popup.SetActive(false);
        player.Prepare();           //영상 준비
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)              //사물이 눌렸다면
            isActivated = true;     //TV 활성화
        else
            isActivated = false;
    }

    private void OnGUI()            //화면에 보여지는 것에 대한 함수
    {
        if (isActivated)            //TV 활성화 되었다면
        {
            popup.SetActive(true);  //팝업창 보이도록 한다
            video.texture = player.texture;     //영상의 텍스쳐를 RawImage 텍스쳐에 입힌다.
            player.Play();          //RawImage에서 영상 재생
        }
    }

    private void OnMouseDown()      //사용자가 TV 누르면
    {
        isClicked = true;           //해당 변수 true값으로
    }

    public void CloseBtnPressed()   //닫기 버튼 누르면
    {
        popup.SetActive(false);     //팝업창 비활성화
        isClicked = false;          //isClicked와 isActivated도 false값으로
        isActivated = false;
    }
}
