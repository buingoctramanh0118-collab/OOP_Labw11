/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class EmergencyBridgeObserver : IAlertObserver
{
    private readonly IEmergencyMediator mediator;

    public EmergencyBridgeObserver(IEmergencyMediator mediator)
    {
        this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    public void Update(AlertEvent alertEvent)
    {
        if (alertEvent.Severity == "CRITICAL")
        {
            mediator.Notify(this, "FIRE_DETECTED");
        }
    }
}