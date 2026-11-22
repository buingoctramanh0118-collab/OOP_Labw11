/*
Họ tên: Bùi Ngọc Trâm Anh
MSSV: 202418832
*/

namespace Labw11;

public sealed record AlertEvent(
    string SensorName,
    double Value,
    string Unit,
    string Severity,
    DateTime OccurredAt);