using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MPGeneratedText : MonoBehaviour
{
    public GameObject stringPrefab;
    private Text generatedText;

    void Start()
    {
        generatedText = Instantiate(stringPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Text>();
        generatedText.text = this.generateString();


    }

    void Update()
    {
        generatedText.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(1f, 1f, 0));
    }

    protected string generateString()
    {
        string characterSet = "xm(2)";
        System.Random ran = new System.Random();
        int length = ran.Next(9, 15);

        StringBuilder builder = new StringBuilder(length);
        int index;

        for(int i = 0; i < length; i++)
        {
            index = ran.Next(0, 3);
            builder.Append(characterSet[index]);
        }
        return builder.ToString();
    }

}
