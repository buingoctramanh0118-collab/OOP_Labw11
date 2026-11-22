/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

using System.Text;

namespace Labw11;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var legacySmoke = new LegacySmokeDetector(300); 
        ISensor smokeSensor = new SmokeSensorAdapter(legacySmoke);

        var alarm = new Alarm();
        var door = new DoorController();
        var ventilation = new VentilationController();
        IEmergencyMediator mediator = new EmergencyMediator(alarm, door, ventilation);

        var monitor = new SensorMonitor();
        var dashboard = new DashboardObserver();
        var emailAlert = new EmailAlertObserver("it-security@campus.edu.vn");
        var auditLog = new AuditLogObserver();
        var emergencyBridge = new EmergencyBridgeObserver(mediator);

        monitor.Attach(dashboard);
        monitor.Attach(dashboard); 
        monitor.Attach(emailAlert);
        monitor.Attach(auditLog);
        monitor.Attach(emergencyBridge);

        Console.WriteLine("Kịch bản 1: Mức khói 30% (Bình thường)");
        monitor.CheckSensor("ServerRoom-RackA", smokeSensor);
        Console.WriteLine();

        Console.WriteLine("Kich bản 2: Mức khói tăng lên 58.5%");
        legacySmoke.SetSmokeLevel(585);
        monitor.CheckSensor("ServerRoom-RackA", smokeSensor);
        Console.WriteLine();

        Console.WriteLine("Kịch bản 3: Gỡ EmailObserver & Mức khói đạt 73.5% (CRITICAL)");
        monitor.Detach(emailAlert);
        legacySmoke.SetSmokeLevel(735);
        monitor.CheckSensor("ServerRoom-RackA", smokeSensor);
    }
}