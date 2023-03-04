using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    // ����� ������ ��� ���� �������� ���������� �����
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            ScoreManager.Instance.SetScore(1);
        }// ���� ���� ���� ������ � ����� ������� ��� , �� ������ �������� ��������� (����)
    }
}