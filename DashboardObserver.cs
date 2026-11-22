/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class DashboardObserver : IAlertObserver
{
    public void Update(AlertEvent alertEvent)
    {
        Console.WriteLine(
            $"[DASHBOARD] {alertEvent.SensorName}: {alertEvent.Value:F1}{alertEvent.Unit} [{alertEvent.Severity}]");
    }
}