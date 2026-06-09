using UnityEngine;

public class Box : MonoBehaviour
{
    public Animator animator; 
    private bool opened = false; 
    public void OpenChest() 
    { 
        if (opened) return; 
        opened = true; 
        animator.SetTrigger("Open"); 
    }
}
