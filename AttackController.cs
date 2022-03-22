using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納
    private Transform _textObjPool;
    private GameObject _getTextObj;

    //Enemyがダメージを受けるところでよびだす

    private void Awake()
    {
        _textObjPool = GameObject.Find("DamageText").transform;        //ダメージテキスト(3DText)を召喚
    }
    public void Attack()
    {
        GameObject nonActiveTextObj = null;

        for (int i = 0; i < _textObjPool.childCount; i++)
        {
            if (!_textObjPool.GetChild(i).gameObject.activeSelf)
            {
                Debug.Log(_textObjPool.GetChild(i).gameObject);
                nonActiveTextObj = _textObjPool.GetChild(i).gameObject;
                break;
            }
        }
        if (nonActiveTextObj == null)
        {
            _getTextObj = Instantiate(_damageTextObj, transform.position, transform.rotation, _textObjPool);
        }
        else
        {
            nonActiveTextObj.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
            nonActiveTextObj.gameObject.SetActive(true);//位置と回転を設定後、アクティブにする
        }
    }
}
