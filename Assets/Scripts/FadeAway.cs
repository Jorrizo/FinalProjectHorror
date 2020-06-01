using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAway : MonoBehaviour
{
    public bool isFaded = false;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
            StartCoroutine(FadeTo(0.0f, 1.0f));
        }

        if(isFaded == true)
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = gameObject.GetComponent<Image>().color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(0, 0, 0, Mathf.Lerp(alpha, aValue, t));
            GetComponent<Image>().color = newColor;
            yield return null;
        }
        yield return null;
        isFaded = true;
    }
}
