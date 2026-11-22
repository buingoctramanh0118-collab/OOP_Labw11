/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class EmergencyMediator : IEmergencyMediator
{
    private readonly Alarm alarm;
    private readonly DoorController doorController;
    private readonly VentilationController ventilationController;

    public EmergencyMediator(
        Alarm alarm,
        DoorController doorController,
        VentilationController ventilationController)
    {
        this.alarm = alarm ?? throw new ArgumentNullException(nameof(alarm));
        this.doorController = doorController ?? throw new ArgumentNullException(nameof(doorController));
        this.ventilationController = ventilationController ?? throw new ArgumentNullException(nameof(ventilationController));
    }

    public void Notify(object sender, string eventCode)
    {
        Console.WriteLine($"[MEDIATOR] Nhận sự kiện '{eventCode}' từ {sender.GetType().Name}. Bắt đầu điều phối:");
        
        if (eventCode == "FIRE_DETECTED")
        {
            alarm.Activate();
            doorController.UnlockAllExitDoors();
            ventilationController.ShutdownVentilation();
        }
        else if (eventCode == "ALL_CLEAR")
        {
            alarm.Reset();
            doorController.LockDoors();
            ventilationController.StartVentilation();
        }
    }
}