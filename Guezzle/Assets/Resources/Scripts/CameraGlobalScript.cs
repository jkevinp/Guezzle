using UnityEngine;
using System.Collections;

public class CameraGlobalScript : MonoBehaviour
{
    public GameObject cameraTarget = null;
    public bool tilt = true;
    public bool rotate = false;
    GameObject _newTarget = null;
    Vector3 basePosition = new Vector3(1.9f, -38.2f, 102.6f);
	void Start () {}
    bool isLerping = false;
    public void LerpLookAt(GameObject target)
    {
        _newTarget = target;
        isLerping = true;
    }
    public void Reset()
    {
        isLerping = true;
        _newTarget = new GameObject();
        _newTarget.transform.position = basePosition;
    }
    float currentTiltValue=0;
    bool isTiltingUp = false;
    float time = 0;
    void FixedUpdate()// Update is called once per frame
    {
        if (isLerping)
        {
            if (Vector3.Distance(cameraTarget.transform.position, _newTarget.transform.position) <= 1)
            {
                isLerping = false;
            }else
            cameraTarget.transform.position =
               Vector3.Lerp(cameraTarget.transform.position, _newTarget.transform.position, 0.1f);   
        }
        if (cameraTarget != null)
        {
            this.transform.LookAt(cameraTarget.transform);
        }
        else
        {
           
        }
        if (tilt) DoTilt();
        if (rotate) DoRotate();
    }
    float angleRotation = 0;
    void DoRotate()
    {
        angleRotation += Time.fixedDeltaTime;
        this.transform.Rotate(Vector3.up * Time.fixedDeltaTime, angleRotation);
    }
    void DoTilt()
    {
           time += Time.fixedDeltaTime;
            if (time < 2)
            {
                isTiltingUp = true;
            }
            else if (time > 2 && time < 4)
            {
                isTiltingUp = false;
            }
            else
            {
                time = 0;
            }
            if (!isTiltingUp)
            {
                currentTiltValue = Mathf.Lerp(currentTiltValue, 1, 0.3f) * Time.fixedDeltaTime;
            }
            else
            {
                currentTiltValue = Mathf.Lerp(currentTiltValue, -1, 0.3f) * Time.fixedDeltaTime;
            }
            cameraTarget.transform.position =
                new Vector3(cameraTarget.transform.position.x,
                    cameraTarget.transform.position.y + currentTiltValue ,
                    cameraTarget.transform.position.z
                    );
        
    }
}