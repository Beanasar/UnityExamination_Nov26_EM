using UnityEngine;
using UnityEngine.InputSystem;

public class Speed_animation : MonoBehaviour
{
    [SerializeField] Animator SpeedAimation;

    [SerializeField] InputActionAsset _actionAsset; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        if (_actionAsset.FindAction("Move").IsPressed())
            
            SpeedAimation.SetBool("walking",true);
        else
        {
            SpeedAimation.SetBool("walking",false);
        }
            
            
    }
}
