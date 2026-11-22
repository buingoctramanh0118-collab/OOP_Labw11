/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed class DoorController
{
    public bool AreDoorsUnlocked { get; private set; }

    public void UnlockAllExitDoors()
    {
        if (!AreDoorsUnlocked)
        {
            AreDoorsUnlocked = true;
            Console.WriteLine("  [DOOR] Đã mở khóa tự động toàn bộ cửa thoát hiểm phòng máy!");
        }
    }

    public void LockDoors()
    {
        AreDoorsUnlocked = false;
        Console.WriteLine("  [DOOR] Đã khóa lại cửa kiểm soát ra vào.");
    }
}