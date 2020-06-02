using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public bool isFaded;

    private void Start()
    {
        StartCoroutine(FadeTo(0.0f, 1.5f));
    }

    private void Update()
    {
        if (isFaded == true)
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator FadeTo(float aValue, float aTime)
    {
        yield return new WaitForSeconds(1f);
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
