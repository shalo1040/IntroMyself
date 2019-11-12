/*
 * SceneManager가 scene 이동시켜주는 코드
 */
using UnityEngine;
using UnityEngine.SceneManagement;      //SceneManager 사용하기 위해 추가

public class ChangeScene : MonoBehaviour
{
    public void BasicBtnPressed()       //Scene00에서 Basic 버튼이 눌리면
    {
        SceneManager.LoadScene("Scene02_Basic_20191110");       //해당 씬으로 이동한다.
    }
    public void LikeBtnPressed()        //Scene00에서 Like 버튼이 눌리면
    {
        SceneManager.LoadScene("Scene01_Like_20191107");        //해당 씬으로 이동한다.
    }

    public void BackBtnPressed()        //뒤로가기 버튼이 눌리면
    {
        SceneManager.LoadScene("Scene00_Main_20191107");        //이전 씬으로 돌아간다.
    }
}
