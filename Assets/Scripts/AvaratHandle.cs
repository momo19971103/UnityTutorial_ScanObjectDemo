using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class AvaratHandle : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] framers;
    private int currentFramer = 0;
    private Image image;
    float timer = 0.0f;
    int seconds = 0;
   
    void Start()
    {
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        //Debug.Log("timer:" + timer);
        Debug.Log("seconds:" + seconds);

        //image.sprite = framers[seconds%2];

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            currentFramer++;
            currentFramer = currentFramer % 2;
            image.sprite = framers[currentFramer];
            Debug.Log("currentFramer:" + currentFramer);
            StartCoroutine("delay");



        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        currentFramer++;
        currentFramer = currentFramer % 2;
        image.sprite = framers[currentFramer];
        Debug.Log("currentFramer:" + currentFramer);

    }




}
