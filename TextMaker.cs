using UnityEngine;

public class TextMaker : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //�_�[���[�W�e�L�X�g���i�[
    private GameObject _getTextObj;

    public void Attack(Vector3 TargetPos,Quaternion TargetRot,int Num)
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
            _getTextObj = Instantiate(_damageTextObj, TargetPos, TargetRot, this.transform);
            _getTextObj.GetComponent<TextMesh>().text = Num.ToString();
        }
        else
        {
            nonActiveTextObj.transform.SetPositionAndRotation(TargetPos, Quaternion.identity);
            nonActiveTextObj.gameObject.SetActive(true);//�ʒu�Ɖ�]��ݒ��A�A�N�e�B�u�ɂ���
            nonActiveTextObj.GetComponent<TextMesh>().text = Num.ToString();
        }
    }
}
