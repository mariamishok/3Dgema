using System.Collections;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;
    public float smooth = 0.1f;
    public float animToggle = 0.5f;
    
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void MoveAnim(Vector3 inputAxis)
    {
        animToggle = Input.GetKey(KeyCode.LeftShift) ? 1 : 0.5f;
        if (inputAxis.sqrMagnitude > 0)
        {
            anim.SetFloat("Horizontal", inputAxis.x * animToggle, smooth, Time.deltaTime);
            anim.SetFloat("Vertical", inputAxis.z * animToggle, smooth, Time.deltaTime);
        }
        else
        {
            anim.SetFloat("Horizontal", 0, smooth, Time.deltaTime);
            anim.SetFloat("Vertical", 0, smooth, Time.deltaTime);
        }
    }

    public void JumpAnim(bool IsJump)
    {
        anim.SetBool("IsJumping", IsJump);
    }
}
