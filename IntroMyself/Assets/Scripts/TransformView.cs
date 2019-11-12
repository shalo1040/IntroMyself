/*
 * Rotation, Scale 슬라이더 기능 코드
 */ 
using UnityEngine;
using UnityEngine.UI;   //Slider

public class TransformView : MonoBehaviour
{
    Slider RotateSlider;
    Slider ScaleSlider;

    // Start is called before the first frame update
    void Start()
    {
        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();      //RotateSlider와 매치
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();        //ScaleSlider와 매치
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(17.587f, RotateSlider.value, 0.0f);        //RotateSlider.value 값에 변동이 있을 때마다 회전
        transform.localPosition = new Vector3(0.0f, ScaleSlider.value * (-0.9f) + 1.97f, ScaleSlider.value -0.83f);     //ScaleSlider.value 값에 변동이 있을 때마다 확대/축소
    }
    
    //public void AdjustRotation(float newValue){ }
    //public void AdjustScale(float newValue) { }
}
