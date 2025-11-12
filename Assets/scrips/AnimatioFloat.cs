using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class AnimationFloat : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;
    public float speed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical") ;

        if(vertical > 0 || vertical< 0)
        {
         anim.SetFloat("velocidad", vertical);
        }

        
    }
}
