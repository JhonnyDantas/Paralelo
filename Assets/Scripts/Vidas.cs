using UnityEngine;

public class Vidas : MonoBehaviour
{
    public Player player;
    public SpriteRenderer sp;
    public Sprite[] vidaSprites;

    void Start()
    {
        player = GetComponent<Player>();
        sp = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        PerderVida();
    }

    // Chamado quando o jogador perde uma vida
    public void PerderVida()
    {
        player.Vidas--; 

        
        if (player.Vidas >= 0 && player.Vidas < vidaSprites.Length)
        {
            sp.sprite = vidaSprites[player.Vidas]; 
        }
    }
}
