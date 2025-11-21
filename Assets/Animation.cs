using UnityEngine;
using UnityEngine.InputSystem;
public class Animation : MonoBehaviour
{

    public InputActionAsset eliasPlayerAction;
    public Animator eliasanimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eliasPlayerAction.FindAction("Move").IsPressed())
        {
            eliasanimator.SetBool("Running", true);
        }
        else
        {
            eliasanimator.SetBool("Running", false);
        }
    }
}
