/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class Alarm
{
    public bool IsRinging { get; private set; }

    public void Activate()
    {
        if (!IsRinging)
        {
            IsRinging = true;
            Console.WriteLine("  [ALARM] Còi báo cháy hú inh ỏi!");
        }
    }

    public void Reset()
    {
        IsRinging = false;
        Console.WriteLine("  [ALARM] Đã tắt còi báo cháy.");
    }
}