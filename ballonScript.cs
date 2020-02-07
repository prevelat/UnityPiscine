using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ballonScript : MonoBehaviour
{
    private Vector3 scaleChange;
    private bool blow;
    public GameObject breath;

    // Start is called before the first frame update
    void Start()
    {
        blow = true;
        scaleChange = new Vector3(1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        blow = breath.GetComponent<breathScript>().blow;
        if (Input.GetKey(KeyCode.Space) && blow)
        {
            //inflate
            transform.localScale += scaleChange * Time.deltaTime;
        }
        else if (transform.localScale.x > 0.25)
        {
            //Deflate
            transform.localScale -= scaleChange * Time.deltaTime;
        }
        if (transform.localScale.x >= 5 || transform.localScale.x <= 1)
        {
            gameObject.SetActive(false);
            Debug.Log("Baloon life time: " + Mathf.RoundToInt(Time.timeSinceLevelLoad) + 's');
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
