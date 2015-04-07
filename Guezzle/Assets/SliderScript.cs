using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderScript : MonoBehaviour {
    public Slider slider = null;
    void OnEnable()
    {
        slider.onValueChanged.AddListener(ChangeValue);
        ChangeValue(slider.value);
    }

    void OnDisable()
    {
        slider.onValueChanged.RemoveAllListeners();
    }

    void ChangeValue(float value)
    {
        Debug.Log(value.ToString());
    
    }
}
