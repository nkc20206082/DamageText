using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //�_�[���[�W�e�L�X�g���i�[
    Transform pool;
    //Enemy���_���[�W���󂯂�Ƃ���ł�т���

    private void Start()
    {
        pool = GameObject.Find("DamageText").transform;        //�_���[�W�e�L�X�g(3DText)������
    }
    public void Attack()
    {
        foreach(Transform t in pool)
        {
            Debug.Log(t.gameObject);
            //�I�u�W�F����A�N�e�B�u�Ȃ�g����
            if (!t.gameObject.activeSelf)
            {
                t.SetPositionAndRotation(transform.position,Quaternion.identity);
                t.gameObject.SetActive(true);//�ʒu�Ɖ�]��ݒ��A�A�N�e�B�u�ɂ���
            }
        }
        Instantiate(_damageTextObj, transform.position, transform.rotation, pool);
    }
}
