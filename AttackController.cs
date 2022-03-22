using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //�_�[���[�W�e�L�X�g���i�[
    private Transform _textObjPool;
    private GameObject _getTextObj;

    //Enemy���_���[�W���󂯂�Ƃ���ł�т���

    private void Awake()
    {
        _textObjPool = GameObject.Find("DamageText").transform;        //�_���[�W�e�L�X�g(3DText)������
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
            nonActiveTextObj.gameObject.SetActive(true);//�ʒu�Ɖ�]��ݒ��A�A�N�e�B�u�ɂ���
        }
    }
}
