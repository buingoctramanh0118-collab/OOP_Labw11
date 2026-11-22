/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class SmokeSensorAdapter : ISensor
{
    private readonly LegacySmokeDetector legacy;

    public SmokeSensorAdapter(LegacySmokeDetector legacy)
    {
        this.legacy = legacy ?? throw new ArgumentNullException(nameof(legacy));
    }

    public double ReadValue()
    {
        return legacy.GetSmokeLevel() / 10.0;
    }

    public string GetUnit() => "% smoke";
}