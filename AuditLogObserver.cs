/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class AuditLogObserver : IAlertObserver
{
    public void Update(AlertEvent alertEvent)
    {
        Console.WriteLine(
            $"[AUDIT LOG] {alertEvent.OccurredAt:yyyy-MM-dd HH:mm:ss} | SENSOR={alertEvent.SensorName} | VAL={alertEvent.Value:F1} | LEVEL={alertEvent.Severity}");
    }
}