<h1>Câu 1</h1><br>
Sự khác nhau về cơ chế lưu trữ vùng nhớ giữa Value Types và References Type trong C#:<br>
<table>
<tr>
    <td></td>
    <td>Value Types (Kiểu giá trị)</td>
    <td>Reference Types (Kiểu tham chiếu)</td>
</tr>
<tr>
    <td>Vùng nhớ chính</td>
    <td>Stack</td>
    <td>Managed heap kết hợp stack</td>
</tr>
<tr>
    <td>Bản chất lưu trữ</td>
    <td>Chứa trực tiếp giá trị của dữ liệu</td>
    <td>Chia làm hai phần: biến cục bộ trên Stack giữ địa chỉ bộ nhớ; đối tượng thực tế nằm trên Managed Heap.</td>
</tr>
<tr>
    <td>Kiểu dữ liệu</td>
    <td>int, float, double,...</td>
    <td>class, intèace,...</td>
</tr>
<tr>
    <td>Thao tác gán / sao chép</td>
    <td>Sao chép toàn bộ giá trị sang một ô nhớ mới độc lập. Thay đổi bản sao không ảnh hưởng bản gốc.</td>
    <td>Chỉ sao chép địa chỉ tham chiếu. Cả hai biến cùng trỏ vào một đối tượng trên heap. Sửa biến này sẽ thay đổi biến kia.</td>
</tr>
<tr>
    <td>Hiệu năng truy xuất</td>
    <td>Rất nhanh do làm trên stạc</td>
    <td>Chậm hơn do phải làm thêm phép tham chiếu</td>
</tr>
</table><br>
Cơ chế lưu trữ:<br>
1. Value Types<br>
- Khi khai báo một biến cục bộ kiểu giá trị trong hàm, cả tên biến và giá trị đều nằm trên stack.<br>
- Nếu một Value Type được khai báo làm trường bên trong một Reference Type, giá trị của nó sẽ nằm nội tuyến trên managed heap cùng toàn bộ đối tượng đó.<br>
- Khi chuyển một value type sang kiểu object hoặc interface, runtime sẽ cấp phát một vùng nhớ trên heap để bọc giá trị đó lại (Boxing), tốn hiệu năng.<br>
2. Reference Types<br>
Khi khai báo một đối tượng, stack lưu một biến con trỏ chứa địa chỉ trỏ tới heap. Heap lưu dữ liệu thực của đối tượng.<br>
<h1>Câu 2</h1><br>
Sự khác nhau giữa init và set:<br>
<table>
    <tr>
        <td></td>
        <td>set</td>
        <td>init</td>
    </tr>
    <tr>
        <td>Tính khả biến</td>
        <td>Cho phép ghi đè giá trị bất kì lúc nào trong vòng đời đối tượng.</td>
        <td>Chỉ cho phép gán giá trị khi khởi tạo, sau đó trở thành Read-only.</td>
    </tr>
    <tr>
        <td>Thời điểm gán giá trị</td>
        <td>Trong constructor qua object initializer hoặc qua các code bên ngoài sau khi đã khởi tạo xong.</td>
        <td>Chỉ trong Constructor hoặc thông qua cú pháp Object Initializer.</td>
    </tr>
    <tr>
        <td>Cơ chế</td>
        <td>Trình biên dịch tạo ra phương thức set_PropertyName thông thường.</td>
        <td>Tạo ra phương thức setter với modreq ép compilẻ chặn mọi lệnh gán ngoài giai đoạn khởi tạo.</td>
    </tr>
    <tr>
        <td>Mục đích</td>
        <td>Dành cho các đối tượng cần cập nhật trạng thái liên tục.</td>
        <td>Hỗ trợ thiết kế đối tượng bất biến mà không cần viết constructor quá dài.</td>
    </tr>
</table><br>
Sử dụng thực tế:<br>
- Data Transfer Objects và API: Các đối tượng nhận dữ liệu từ database thường chỉ cần gán một lần khi khởi tạo và không được phép bị sửa đổi ngẫu nhiên trong luồng xử lý tiếp theo.<br>
- Thay thế constructor quá nhiều tham số: Khi class có 10–15 thuộc tính bất biến, dùng thuộc tính chỉ có get bắt buộc phải tạo constructor nhận toàn bộ 15 tham số. Dùng init cho phép giữ tính bất biến nhưng khởi tạo linh hoạt qua cú pháp new Order.<br>
- Kết hợp với record và biểu thức with khi cần tạo một bản sao đối tượng với một vài trường thay đổi giá trị mà không làm hỏng đối tượng gốc.<br>
- Domain-Driven Design Value Objects: Đảm bảo các đối tượng đại diện cho giá trị giữ nguyên tính toàn vẹn và không bị tác động ngoài ý muốn bởi các side-effect trong ứng dụng.<br>

<h1>Câu 3:</h1><br>
Phân biệt virtual và overide:<br>
<table>
    <tr>
        <td></td>
        <td>virtual</td>
        <td>override</td>
    </tr>
    <tr>
        <td>Vị trí khai báo</td>
        <td>Định nghĩa ở lớp cha.</td>
        <td>Định nghĩa ở lớp con.</td>
    </tr>
    <tr>
        <td>Vai trò</td>
        <td>Khai báo một phương thức kèm phần mặc định, mở quyền cho các lớp con được định nghĩa lại hành vi.</td>
        <td>Ghi đè, cung cấp hành vi mới chuyên biệt để thay thế hành vi của lớp cha.</td>
    </tr>
    <tr>
        <td>Tính bắt buộc</td>
        <td>Lớp con không bắt buộc phải ghi đè. Nếu không ghi đè sẽ tự động dùng lại logic mặc định của lớp cha.</td>
        <td>Bắt buộc phương thức ở lớp cha phải là virtual hoặc abstract mới có thể dùng override.</td>
    </tr>
    <tr>
        <td>Cơ chế gọi</td>
        <td>Xác lập một mục trong vtable của kiểu dữ liệu.</td>
        <td>Ghi đè địa chỉ hàm tương ứng trong vtable, trỏ trực tiếp đến mã của lớp con.</td>
    </tr>
</table><br>
<h1>Câu 4</h1><br>
Một thành phần static không thể truy xuất thông qua một thể hiện (object instance) vì:<br>
1. Bản chất phân định phạm vi sở hữu<br>
- Instance Member: Thuộc về từng đối tượng riêng biệt. Mỗi khi dùng new, một vùng nhớ mới được cấp phát trên Heap để chứa các biến instance của riêng đối tượng đó.<br>
- Static Member: Thuộc về bản thân kiểu dữ liệu, không thuộc về bất kì đối tượng cụ thể nào. Dữ liệu static được cấp phát một lần duy nhất và dùng chung cho toàn bộ ứng dụng.<br>
- Vì đối tượng trên Heap hoàn toàn không chứa dữ liệu của static, không thể truy xuất qua con trỏ đối tượng.<br>
2. Con trỏ this<br>
- Khi một phương thức instance được gọi, compiler ngầm truyền tham chiếu của đối tượng hiện tại vào hàm thông qua con trỏ this.<br>
- Static không có con trỏ this. Khi gọi static, CPU thực thi mã trực tiếp với metadata của kiểu mà không cần biết đối tượng gọi là gì. Gọi instance.StaticMethod() không đúng vì con trỏ đối tượng bị thừa và không được dùng trong hàm.<br>