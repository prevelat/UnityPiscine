using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathScript : MonoBehaviour
{
    private Vector3 scaleChange;
    public GameObject baloon;
    public bool blow;

    // Start is called before the first frame update
    void Start()
    {
        blow = true;
        scaleChange = new Vector3(2f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (baloon)
        {
            if (transform.localScale.x < 0.3)
            {
                blow = false;
            }
            if (Input.GetKey(KeyCode.Space) && transform.localScale.x > 0.2 && blow)
            {
                //lose breath
                transform.localScale -= 2 * scaleChange * Time.deltaTime;
            }
            else if (transform.localScale.x < 15)
            {
                //catch breath
                transform.localScale += scaleChange * Time.deltaTime;
            }
            if (!blow)
            {
                if (transform.localScale.x > 5)
                {
                    blow = true;
                }
            }
        }

    }
}