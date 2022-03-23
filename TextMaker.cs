using UnityEngine;

public class TextMaker : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納
    private GameObject _getTextObj;

    public void Attack(Transform TargetObj)
    {
        GameObject nonActiveTextObj = null;

        for (int i = 0; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeSelf)
            {
                Debug.Log(transform.GetChild(i).gameObject);
                nonActiveTextObj = transform.GetChild(i).gameObject;
                break;
            }
        }
        if (nonActiveTextObj == null)
        {
            _getTextObj = Instantiate(_damageTextObj, TargetObj.position, TargetObj.rotation, this.transform);
        }
        else
        {
            nonActiveTextObj.transform.SetPositionAndRotation(TargetObj.position, Quaternion.identity);
            nonActiveTextObj.gameObject.SetActive(true);//位置と回転を設定後、アクティブにする
        }
    }
}
