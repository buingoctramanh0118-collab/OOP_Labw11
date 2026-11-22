/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class VentilationController
{
    public bool IsHvacRunning { get; private set; } = true;

    public void ShutdownVentilation()
    {
        if (IsHvacRunning)
        {
            IsHvacRunning = false;
            Console.WriteLine("  [VENTILATION] Đã ngắt hệ thống điều hòa/thông gió để chống cháy lan!");
        }
    }

    public void StartVentilation()
    {
        IsHvacRunning = true;
        Console.WriteLine("  [VENTILATION] Đã bật lại hệ thống thông gió.");
    }
}