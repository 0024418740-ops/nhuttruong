# EduHub – User Stories Ch01

## Vai trò người dùng

- **Student (Sinh viên):** đăng ký khóa học và theo dõi trạng thái đăng ký.
- **Instructor (Giảng viên):** quản lý thông tin giảng viên và sự kiện giảng dạy.
- **Administrator (Quản trị viên):** quản lý khóa học, kiểm tra thông tin và theo dõi hoạt động.

## US01 – Tạo khóa học

**Là** quản trị viên, **tôi muốn** tạo khóa học mới, **để** sinh viên có thể đăng ký tham gia.

**Tiêu chí nghiệm thu:**
1. Khi mã khóa học, tên khóa học hợp lệ và sức chứa lớn hơn 0, hệ thống tạo khóa học thành công.
2. Nếu mã hoặc tên khóa học để trống, hoặc sức chứa nhỏ hơn hoặc bằng 0, hệ thống từ chối tạo khóa học và thông báo lỗi.

## US02 – Tạo hồ sơ sinh viên

**Là** quản trị viên, **tôi muốn** tạo hồ sơ sinh viên, **để** lưu thông tin người học trong EduHub.

**Tiêu chí nghiệm thu:**
1. Hệ thống tạo sinh viên khi mã, họ tên và email hợp lệ.
2. Hệ thống từ chối thông tin thiếu mã, họ tên hoặc email; email sai định dạng cũng bị từ chối.

## US03 – Đăng ký khóa học

**Là** sinh viên, **tôi muốn** đăng ký một khóa học, **để** tham gia học tập.

**Tiêu chí nghiệm thu:**
1. Khi mã đăng ký, mã sinh viên và mã khóa học hợp lệ, hệ thống tạo đăng ký ở trạng thái Pending.
2. Nếu một trong các mã bắt buộc để trống, hệ thống từ chối tạo đăng ký và thông báo lỗi.

## US04 – Kích hoạt và hoàn thành đăng ký

**Là** quản trị viên, **tôi muốn** cập nhật trạng thái đăng ký, **để** theo dõi tiến trình học tập của sinh viên.

**Tiêu chí nghiệm thu:**
1. Đăng ký ở trạng thái Pending có thể chuyển sang Active; đăng ký Active có thể chuyển sang Completed.
2. Nếu đăng ký không ở trạng thái Pending khi kích hoạt hoặc không ở trạng thái Active khi hoàn thành, hệ thống từ chối thao tác và thông báo lỗi.

## US05 – Hủy đăng ký

**Là** sinh viên, **tôi muốn** hủy đăng ký chưa hoàn thành, **để** không tiếp tục tham gia khóa học đó.

**Tiêu chí nghiệm thu:**
1. Đăng ký ở trạng thái Pending hoặc Active có thể chuyển sang Cancelled.
2. Hệ thống từ chối hủy đăng ký đã Completed hoặc đã Cancelled.

## US06 – Tạo sự kiện giảng dạy

**Là** giảng viên, **tôi muốn** tạo sự kiện gắn với khóa học và giảng viên, **để** xác định nội dung và thời gian giảng dạy.

**Tiêu chí nghiệm thu:**
1. Hệ thống tạo sự kiện khi mã, tiêu đề, mã khóa học, mã giảng viên và thời gian bắt đầu hợp lệ.
2. Hệ thống từ chối tạo sự kiện nếu thiếu trường bắt buộc hoặc thời gian bắt đầu không hợp lệ.

## US07 – Xem báo cáo đăng ký

**Là** quản trị viên, **tôi muốn** xem thông tin sinh viên, khóa học và trạng thái đăng ký, **để** theo dõi kết quả hoạt động.

**Tiêu chí nghiệm thu:**
1. Báo cáo hiển thị họ tên sinh viên, tên khóa học và trạng thái đăng ký.
2. Trạng thái hiển thị phải phản ánh đúng trạng thái hiện tại của đối tượng Enrollment.

## Ghi chú

Các User Stories mô tả yêu cầu nghiệp vụ dự kiến. Việc xác minh khóa ngoại có tồn tại, kiểm tra sức chứa và phân quyền người dùng cần được triển khai thêm nếu phạm vi bài tập yêu cầu.
