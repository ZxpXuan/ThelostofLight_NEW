using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

using System.Linq;
using System.Text;
using System.Threading;
[RequireComponent(typeof(Animator))]
public class move : MonoBehaviour
{
    public float height;
    public AudioSource jumpsound;
    private Animator m_animator;
    // Use this for initialization
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var leftwalk = false;
        var rightwalk = false;
        var jump = false;
        var down = false;
        if (Input.GetKey(KeyCode.W))
        {
            jump = true;
            jumpsound.Play();
            gameObject.transform.Translate(Vector3.up* height * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            down = true;

            gameObject.transform.Translate(Vector3.down * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {

            leftwalk = true;
            gameObject.transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {

            rightwalk = true;
            gameObject.transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
        m_animator.SetBool("leftwalk", leftwalk);
        m_animator.SetBool("rightwalk", rightwalk);
        m_animator.SetBool("jump", jump);
        m_animator.SetBool("down", down);
    }
}
