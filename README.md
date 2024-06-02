1. Kết nối ghép đôi máy tính với Bluetooth:
- Vào Settings -> Bluetooth & devices -> Devices.
- Tới mục Bluetooth devices discovery, chuyển chế độ từ Default sang Advanced.
- Cũng trong trang Devices chọn Add device, sẽ thấy tên module HC-05 trong danh sách các thiết bị có thể ghép đôi.
2. Tìm cổng để kết nối:
- Vào Settings -> Bluetooth & devices -> Devices.
- Chọn More Bluetooth settings -> sang mục COM Ports, tìm cổng có direction là Ongoing
3. Chạy chương App Winform:
- Mở file BluetoothApp.slm
- Bấm Start
4. Điều khiển hệ thống:
  
- Chọn cổng ra để kết nối với HC-05 đã xác định trong mục 2.
- Chọn Baud rate (38400)
- Nhấn kết nối để bắt đầu điều khiển
- Chương trình mặc định ở chế độ tự động (không thể điều khiển quạt và cửa sổ qua app) nên cần phải nhấn nút chế độ để chuyển qua chế độ điều khiển thủ công
- Khi trong chế độ Manual, nhán các nút Đóng/Mở cửa, Bật/Tắt quạt để điều khiển cửa sổ và quạt
- Nhấn escape để thoát chương trình
