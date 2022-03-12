using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納

    //Enemyがダメージを受けるところでよびだす
    public void Attack()
    {
        //ダメージテキスト(3DText)を召喚
        Instantiate(_damageTextObj, transform.position, transform.rotation) ;
    }
}
