using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納
    Transform pool;
    //Enemyがダメージを受けるところでよびだす

    private void Start()
    {
        pool = GameObject.Find("DamageText").transform;        //ダメージテキスト(3DText)を召喚
    }
    public void Attack()
    {
        foreach(Transform t in pool)
        {
            Debug.Log(t.gameObject);
            //オブジェが非アクティブなら使い回し
            if (!t.gameObject.activeSelf)
            {
                t.SetPositionAndRotation(transform.position,Quaternion.identity);
                t.gameObject.SetActive(true);//位置と回転を設定後、アクティブにする
            }
        }
        Instantiate(_damageTextObj, transform.position, transform.rotation, pool);
    }
}
