using System.Collections;
using UnityEngine;
using DG.Tweening;

public class DamageTextController : MonoBehaviour
{
    //�e�L�X�g�̓���
    void OnEnable()
    {
        this.transform.DOMove(new Vector2(transform.position.x, transform.position.y+1f), 0.6f)
                            .OnComplete(() => { gameObject.SetActive(false); });
    }
}
