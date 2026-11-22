/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class EmailAlertObserver : IAlertObserver
{
    private readonly string recipientEmail;

    public EmailAlertObserver(string recipientEmail = "admin@campus.edu.vn")
    {
        this.recipientEmail = recipientEmail;
    }

    public void Update(AlertEvent alertEvent)
    {
        Console.WriteLine(
            $"[EMAIL -> {recipientEmail}] Cảnh báo {alertEvent.Severity}: Phát hiện khói tại {alertEvent.SensorName} ({alertEvent.Value:F1}{alertEvent.Unit}) lúc {alertEvent.OccurredAt:HH:mm:ss}.");
    }
}