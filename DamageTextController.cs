using System.Collections;
using UnityEngine;
using DG.Tweening;

public class DamageTextController : MonoBehaviour
{
    //テキストの動き
    void Start()
    {
        //GetComponent<TextMesh>().text = "10";
        this.transform.DOMove(new Vector2(transform.position.x, transform.position.y+1f), 0.6f);
        StartCoroutine(DestroyObject());
    }

    //消えるまで
    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }
}
