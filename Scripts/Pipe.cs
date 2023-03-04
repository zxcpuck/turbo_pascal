using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    // роблю скрипт дл€ зм≥ни швидкост≥ перем≥щенн€ колон
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            ScoreManager.Instance.SetScore(1);
        }// якщо обЇкт €кий зайшов в тр≥гер дор≥внюЇ тру , в≥н спробуЇ получити компонент (очки)
    }
}