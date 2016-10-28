using UnityEngine;
using System.Collections;

public class ParseText : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<TextMesh>().text = "INTRODUCTION TO SPEED READING In the context of a hackathon, the word 'hack' is used to describe how multiple technologies can be used together" 
            + " in a new and innovative way. Teams spend the weekend working on innovative software and hardware solutions to real-world problems. These projects range in platform and application,"
            + " including elements of web development, mobile applications, drones, and more. However, many times the most important aspect of a hackathon is the community it generates and skills that"
            + " inexperienced hackers walk away with. Dragon Hacks 2016 is the best 24 hour hardware-focused hackathon event hosted by Drexel. Dragon Hacks 2016 is bringing in the brightest minds of" 
            + " the world's best schools to spend 24 hours to create ground breaking new products from scratch! With over $10,000 in prizes this year, sleepless efforts will be rewarded!";
        string text = GetComponent<TextMesh>().text;
        GetComponent<TextMesh>().text = " ";

        char[] delimiterChars = { ' ', ':' };

        string[] words = text.Split(delimiterChars);

        StartCoroutine(printWords(words));
    }

    // Update is called once per frame
    void Update()
    {



    }

    public IEnumerator printWords(string[] words)
    {
        foreach (string s in words)
        {
            GetComponent<TextMesh>().text = s;
            yield return new WaitForSeconds(.195f);
        }

    }
}
