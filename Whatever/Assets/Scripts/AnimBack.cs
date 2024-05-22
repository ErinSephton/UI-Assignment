using UnityEngine;

public class AnimBack : MonoBehaviour
{
    public GameObject Cam;

    public Animator Animator;

    public void BackButton()
    {
        Debug.Log("Click");
        
        Animator.SetInteger("CameraInt", 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
