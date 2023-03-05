using UnityEngine;
using static Constant;

public class MainGameCharacterDamageModel : MonoBehaviour
{
    public bool alive;
    public int hp;
    public int maxHp;
    public int physicsDamageResistance;
    public int zyuGekiResistance;
    public int zyuRyokuResistance;
    public float addDamageRatio;
    protected bool takeDamage = false;

    public MainGameCharacterDamageModel()
    {
        alive = true;
    }

    public void TakeDamage(Damage damage)
    {
        damage.value = (int)(damage.value * addDamageRatio);
        if (alive == true)
        {
            takeDamage = true;
        }
        Invoke(nameof(ExitTakeDamage), 0.5f);
        if (damage.type == DamageType.physicsDamage)
        {
            double RPD = 1.0 - physicsDamageResistance / 100.0;
            hp -= (int)(damage.value * RPD);
        }
        if (damage.type == DamageType.zyuGeki)
        {
            double RPD = 1.0 - zyuGekiResistance / 100.0;
            hp -= (int)(damage.value * RPD);
        }
        if (damage.type == DamageType.zyuGeki)
        {
            double RPD = 1.0 - zyuRyokuResistance / 100.0;
            hp -= (int)(damage.value * RPD);
        }
        if (hp <= 0)
        {
            alive = false;
        }
    }

    public void Healing(int value)
    {
        hp += value;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }

    void ExitTakeDamage()
    {
        takeDamage = false;
    }
}
