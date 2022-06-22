using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    SpriteRenderer Campbell;
    public KeyCode BOB;

    public float timePassed = 0.0f;
    public float interval = 0.0f;
    bool bob2notcalled = true;
    // Start is called before the first frame update
    void Start()
    {
        Campbell = GetComponent<SpriteRenderer>();
        Campbell.enabled = false;
        interval = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(BOB) && Campbell.enabled)
        {
            Campbell.enabled = false;

            timePassed = 0;
            interval = Random.Range(1, 5);
        }
        if (timePassed >= interval)
        {
            if (bob2notcalled)
            {
                Campbell.enabled = true;
                StartCoroutine(bob2());
            }
        }
        else
        {
            timePassed += Time.deltaTime;
        }
    }

    IEnumerator bob2()
    {
        bob2notcalled = false;

        yield return new WaitForSeconds(2.0f);

        Campbell.enabled = false;

        timePassed = 0;
        interval = Random.Range(1, 5);

        bob2notcalled = true;
    }
}
