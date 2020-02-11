using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] char c;
    public GameObject End;
    private float speed;
    public Vector3 InitialPosition;
    private bool newspeed;

    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
        newspeed = true;
    }

    public void Reset()
    {
        transform.position = InitialPosition;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (newspeed)
        {
            speed = Random.Range(5f, 10f);
            newspeed = false;
        }
        if (gameObject.activeSelf)
        {
            if (transform.position.y < 2)
            {
                if (c == 'A' && Input.GetKeyDown(KeyCode.A))
                {
                    newspeed = true;
                    print("Precision : " + (gameObject.transform.position.y - End.transform.position.y));
                    Reset();
                }
                if (c == 'S' && Input.GetKeyDown(KeyCode.S))
                {
                    newspeed = true;
                    print("Precision : " + (gameObject.transform.position.y - End.transform.position.y));
                    Reset();
                }
                if (c == 'D' && Input.GetKeyDown(KeyCode.D))
                {
                    newspeed = true;
                    print("Precision : " + (gameObject.transform.position.y - End.transform.position.y));
                    Reset();
                }
            }
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
    }
}
