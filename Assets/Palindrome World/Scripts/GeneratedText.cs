using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class GeneratedText : MonoBehaviour
{

    public GameObject stringPrefab;
    public Text generatedText; 

    // Start is called before the first frame update
    void Start()
    {
        generatedText = Instantiate(stringPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Text>();
        generatedText.text = this.generateString();


    }

    // Update is called once per frame
    void Update()
    {
        generatedText.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(1f,1f,0));

    }

    protected string generateString()
    {
        string characterSet = "xm2";
        System.Random ran = new System.Random();
        int length = ran.Next(9, 15);
        StringBuilder builder = new StringBuilder(length);
        int index;
        for (int i = 0; i < length; i++)
        {
            index = ran.Next(0, 3);
            builder.Append(characterSet[index]);
        }
        return builder.ToString();
    }
}
