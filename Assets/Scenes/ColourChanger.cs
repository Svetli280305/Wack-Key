using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{

    BoxCollider2D Taj;
    SpriteRenderer Campbell;
    public KeyCode BOB;

    public float timePassed = 0.0f;
    public float interval = 0.0f;
    bool bob2notcalled = true;
    // Start is called before the first frame update
    void Start()
    {
        Taj = GetComponent<BoxCollider2D>();
        Campbell = GetComponent<SpriteRenderer>();
        Campbell.enabled = false;
        Taj.enabled = false;
        interval = Random.Range(3.0f, 8.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timePassed >= interval)
        {
            if (bob2notcalled)
            {
                Campbell.sprite = GetRandomSprite();
                Campbell.enabled = true;
                Taj.enabled = true;
                StartCoroutine(bob2());
            }
        }
        else
        {
            timePassed += Time.deltaTime;
        }
    }

    public void Healing()
    {
        if (Input.GetKeyDown(BOB) && Campbell.enabled)
        {
            Campbell.enabled = false;
            Taj.enabled = false;

            timePassed = 0;
            interval = Random.Range(1.0f, 5.0f);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        
    }

    IEnumerator bob2()
    {
        bob2notcalled = false;

        yield return new WaitForSeconds(2.0f);

        Campbell.enabled = false;
        Taj.enabled = false;

        timePassed = 0;
        interval = Random.Range(1.0f, 5.0f);

        bob2notcalled = true;
    }

    Sprite GetRandomSprite()
    {
        Sprite[] sprites = transform.parent.gameObject.GetComponent<Pictures>().pictures;
        return sprites[Random.Range(0, sprites.Length)];
    }
}
