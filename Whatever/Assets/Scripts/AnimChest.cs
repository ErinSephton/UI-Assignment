using UnityEngine;

public class AnimChest : MonoBehaviour
{
    public GameObject Cam;

    public Animator Animator;

    public void ChestButton()
    {
        Debug.Log("Click");
        
        Animator.SetInteger("CameraInt", 1);
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
