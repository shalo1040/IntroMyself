using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BasicBtnPressed()
    {
        SceneManager.LoadScene("Scene02_Basic_20191110");
    }
    public void LikeBtnPressed()
    {
        SceneManager.LoadScene("Scene01_Like_20191107");
    }

    public void BackBtnPressed()
    {
        SceneManager.LoadScene("Scene00_Main_20191107");
    }
}
