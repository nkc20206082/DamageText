using System.Collections;
using UnityEngine;
using DG.Tweening;

public class DamageTextController : MonoBehaviour
{
    //テキストの動き
    void Start()
    {
        //GetComponent<TextMesh>().text = "10";
        this.transform.DOMove(new Vector2(transform.position.x, transform.position.y+1f), 0.6f)
                            .OnComplete(() => { Destroy(this.gameObject); });
    }
}
