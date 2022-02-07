using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public Image EnemyImage;
    public GameObject toastPanel;
    public IEnumerable EMarkerGrid()
    {
        int count = 0;
        this.gameObject.SetActive(true);

        while (count < 3)
        {
            this.EnemyImage.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            this.EnemyImage.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            count++;
        }

    }
    //public Image Panel;
    ////float F_time = 1f;
    //float time = 0f;

    //public void Fade()
    //{
    //    StartCoroutine(FadeFlow());
    //}
    //IEnumerator FadeFlow()
    //{
    //    Panel.gameObject.SetActive(false);
    //    Color alpha = Panel.color;

    //    if (Time.deltaTime == 5f)
    //    {
    //        Panel.color = alpha;
    //        alpha.a = Mathf.Lerp(0, 1, time);
    //        yield return null;
    //    }

    //    yield return null;

    //    //while (alpha.a < 1f)
    //    //{
    //    //    time += Time.deltaTime;
    //    //    alpha.a = Mathf.Lerp(0, 1, time);
    //    //    Panel.color = alpha;
    //    //    yield return null;
    //    //}
    //    //yield return null;
    //}

    //public Image EnemyImageUI;

    //public void Fade()
    //{
    //    if (Time.deltaTime == 1f)
    //    {
    //        EnemyImageUI.gameObject.SetActive(true);
    //    }

    //}
}
