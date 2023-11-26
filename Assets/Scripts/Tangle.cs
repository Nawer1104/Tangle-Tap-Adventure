using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangle : MonoBehaviour
{
    public string type;

    bool isClicked;

    public GameObject vfxClicked;

    private void Awake()
    {
        isClicked = false;
    }

    private void OnMouseDown()
    {
        if (isClicked) return;

        isClicked = true;
        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].TriggerBoxAnimator(type);
        GameObject vfx = Instantiate(vfxClicked, transform.position, Quaternion.identity) as GameObject;
        Destroy(vfx, 1f);
        Destroy(gameObject);
    }
}
