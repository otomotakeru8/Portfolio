using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EffectConstant;

public class TalentActions
{
    GameObject targetObject;
    Talent talent;
    public void SetObject(GameObject tObject)
    {
        targetObject = tObject;
        talent = targetObject.GetComponent<Talent>();
    }
    public void ArrowAction()
    {
        talent.m_criticalChance += 5;
    }
    public void BombAction()
    {

    }
    public void StoneAction()
    {

    }
    public void BulletAction()
    {

    }
    public void PierceingBulletAction()
    {

    }
    public void MagicArrowAction()
    {

    }
    public void MagicBulletAction()
    {

    }
    public void IceBulletAction()
    {
        
    }
    public void FireBulletAction()
    {

    }
    public void ElectricBoltAction()
    {

    }
    public void MissileAction()
    {

    }
    public void LaserAction()
    {

    }
    public void TwoRoundBurstAction()
    {

    }
    public void ThreeRoundBurstAction()
    {

    }
    public void FireAction()
    {
        talent.AddEvent(StatusEffect.fire);
    }
    public void ElectricChargeAction()
    {
        talent.AddEvent(StatusEffect.electric);
    }
    public void PoisonAction()
    {
        talent.AddEvent(StatusEffect.toxic);
    }
    public void AddTriggerAction()
    {

    }
    public void AddTimerAction()
    {

    }
    public void GunpowderAction()
    {
        talent.Speed = talent.Speed + 2;
    }
    public void OilAction()
    {

    }
    public void ProjectileSpeedUpFieldAction()
    {

    }
    public void ScopeAction()
    {

    }
    public void WaterBalloonAction()
    {

    }
    public void ProjectileDirectionFixAction()
    {

    }
}
