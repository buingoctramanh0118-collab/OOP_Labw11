/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class SensorMonitor
{
    private readonly List<IAlertObserver> observers = new();

    public void Attach(IAlertObserver observer)
    {
        ArgumentNullException.ThrowIfNull(observer);
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    public void Detach(IAlertObserver observer)
    {
        observers.Remove(observer);
    }

    public void CheckSensor(string sensorName, ISensor sensor)
    {
        double value = sensor.ReadValue();
        string? severity = value switch
        {
            >= 70 => "CRITICAL",
            >= 50 => "WARNING",
            _ => null
        };

        if (severity is null)
        {
            Console.WriteLine($"[MONITOR] {sensorName}: {value:F1}{sensor.GetUnit()} -> Bình thường.");
            return;
        }

        var alertEvent = new AlertEvent(
            sensorName,
            value,
            sensor.GetUnit(),
            severity,
            DateTime.Now);

        Notify(alertEvent);
    }

    private void Notify(AlertEvent alertEvent)
    {
        foreach (IAlertObserver observer in observers.ToArray())
        {
            try
            {
                observer.Update(alertEvent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Lỗi tại {observer.GetType().Name}: {ex.Message}");
            }
        }
    }
}