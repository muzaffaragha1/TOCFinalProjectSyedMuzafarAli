using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MPPlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        Vector3 pos = transform.position;
        float x = transform.localScale.y / 4;
        transform.position = new Vector3(pos.x, Terrain.activeTerrain.SampleHeight(pos) + (x), pos.z);

        rb.AddForce(movement * speed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("MP Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count :" + count.ToString();
        if(count >= 17)
        {
            winText.text = "You Have Collected 33% of Collectibles";
        }
    }
}
