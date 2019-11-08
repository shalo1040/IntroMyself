using UnityEngine;
using UnityEngine.UI;   //Slider

public class TransformView : MonoBehaviour
{
    //private Transform room;               //현재 객체의 Transform 정보
    Slider RotateSlider;
    Slider ScaleSlider;

    // Start is called before the first frame update
    void Start()
    {
        //room = GetComponent<Transform>(); //Transform 정보 가져옴
        RotateSlider = GameObject.Find("RotateSlider").GetComponent<Slider>();
        ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0.0f, RotateSlider.value, 0.0f);
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }
    
    public void AdjustRotation(float newValue){ }
    public void AdjustScale(float newValue) { }
}
