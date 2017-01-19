using UnityEngine;
using System.Collections;

public class UIAnimation : MonoBehaviour
{
    private Animator _anim;
    private bool _uiUP = false;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.enabled = false;
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        yield return new WaitForSeconds(7);
        _anim.enabled = true;
        _uiUP = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.U) && _uiUP)
        {
            _anim.SetTrigger("MoveDown");
            _uiUP = false;
        }
        if (Input.GetKey(KeyCode.I) && _uiUP == false)
        {
            _anim.SetTrigger("MoveUP");
            _uiUP = true;
        }
    }

}
