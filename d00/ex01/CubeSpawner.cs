using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    private float countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = Random.Range(1f, 2f);
    }
    GameObject Create(GameObject spawn)
    {
        return Instantiate(spawn);
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0 && !cube.activeSelf)
        {
            countdown = 3f;
            Create(cube);
            cube.SetActive(true);
        }
    }
}
