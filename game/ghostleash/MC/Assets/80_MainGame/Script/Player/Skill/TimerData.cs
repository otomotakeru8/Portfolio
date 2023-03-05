using System;

[Serializable]
public class TimerData
{
    public int m_lifeFrame;
    public int m_doTick;

    public TimerData(int lifeFrame, int doTick)
    {
        m_lifeFrame = lifeFrame;
        m_doTick = doTick;
    }
}
