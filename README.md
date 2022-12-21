Video game hay còn được gọi tắt là game, là một dạng trò chơi điện tử và tương tác với người dùng thông qua một giao diện để hiển thị hình ảnh (video), nó có thể là: màn hình máy tính, màn hình tivi, kinh thực tế ảo, hay cũng có thể các công cụ máy chơi game thông dụng khác có kích thước từ chiếc máy tính đồ sộ cho đến những thiết bị nhỏ gọn cầm tay. Trong đó các thiết bị đầu vào sử dụng để thao tác trong game được gọi là game controller hay thiết bị tay cầm điều khiển game và sẽ có sự thay đổi tùy theo hệ máy.
Các công cụ : Unity, game maker Studio 2, Buildbox, twine, Cocos2d –x ,..
Các đối tượng cơ bản :
•	Polygons: Là một tập hợp các đối tượng liên kết với nhau.
•	Vertices: là một tập hợp điểm để lưu trữ các đỉnh của một mặt nào đó.
•	Mesh: Mặt lưới bao gồm nhiều tam giác.
Chất lượng :
•	Materials: Là chất liệu tạo nên vật thể cho đối tượng 3D.
•	Texture: Là hình ảnh, dùng để tạo ra chất liệu.
•	Shader: Độ mờ (tối) của đối tượng.
Vật thể
•	Rigid Body là một thành phần giúp vật thể giống với thực tế
Dò tìm va chạm 
•	Collision detection: Khả năng dò tìm va chạm của các đối tượng trong Game
•	Collider: Là một khối vô hình, bao quanh vật thể, nhằm xác định va chạm của vật thể. Có các loại Collider như: Box, Square, Capsule…
Chương 2
•	Assets là một thư mục dùng để chứa tất cả các thành phần của một game.
•	Scenes: Là một giao diện chính của game, dùng để chứa các đối tượng trong game.
•	Game Object : Là một đối tượng trong Game và luôn có một giá trị bắt đầu, đó là Transform
•	3D Game Object gồm những loại :
Cube: Hình lập phương Sphere: Hình khối cầu Capsule: hình dạng thùng chứa. Cylinder: Hình trụ Plane: mặt phẳng Quad: đối tượng 4 điểm
•	Light dùng để chiếu sáng.
  Directional Light: Ánh sáng môi trường Point Light: ánh sáng điểm Spot Light: ánh sáng chiếu (đèn pin) Area Light: Ánh sáng vùng (theo màu)
•	Components
Là các thành phần đi kèm Game Object. Khi gắn vào GO thì maybe gây ảnh hưởng, tạo giao diện or các thuộc tính object.
Muốn tạo thành phần riêng, có thể viết Script. Các đối tượng 3D, 2D sẽ  có các thành phần tương ứng
Cấu tạo của GO tạo ra game scene (3D) gồm audio, collider, mesh Renderer, Material, Script, Particle System, Rigidbody
•	Script
Là kịch bản được viết thêm để điều khiển hoạt động của GO or Component
Script đóng vai trò quan trọng trong việc điều khiển các nhân vật, các thành phần hoạt động khi Game đã được chạy.
Được viết vởi C# or JavaScript, dùng Unity Editor tích hợp vào bộ Visual Studio
-	Commands: Một lệnh được kết thúc bằng dấu chấm phẩy.
-	Variables: Khai báo có tên và gán cho kiểu dữ liệu
     Kiểu biến Vector3 là kiểu biến 1 tập 3 giá trị (X,Y,Z).
     Các kiểu biến dạng public được Unity tự hiểu, tự tách ra và hiễn thị lên Inspector
-	Functions:  Hàm được viết ra hoặc có sẵn
o	Hàm Update(): dùng để cập nhật liên tục các tham số
o	Hàm OnMouseDown(): điều khiển khi nhấn chuột
-	If else statements: lệnh điều khiển.
•	Prefab
Là GO tạo ra nhằm sử dụng lại cho phép lưu trữ đối tượng, hoàn thành các thành phần or thay đổi nhanh chóng
•	The interface : gồm 5 phần
1.	Scene: màn, nơi game được xây dựng
2.	Hierarchy : phân cấp, một danh sách các GO trong 1 màn
3.	Inspector: thiết lập hiện hành cho object đang chọn
4.	Game: cửa sổ trình chiếu khi nhấn play
5.	Project: danh sách các asset của dự án or đối tượng thư viện
Các GO được control by Scene Window bao gồm các chức năng
1.	Hand : định vị toàn cảnh, kéo đối tượng, zoom, quay
2.	Translate: cho phép dịch theo trục tọa độ
3.	Rotate: cho phép xoay theo trục tọa độ
4.	Scale: thay đổi kích thước đối tượng theo trục
•	The Inspector
Inspector: nơi quản lý các thành phần của một Game Object , khi tạo GO, thành phần mặc định thêm vào là Transform.
Có thể thêm mới bằng cách chọn add Component
•	Project window
Cho phép xem Asset 1 cách trực tiếp trong dự án ( có nút Create nhằm tạo ra các thành phần đưa vào Asset)
•	Game Window
Là cửa sổ giao diện khi người chơi nhấn nút play và có thể cho cửa sổ chạy song song với giao diện thiết kế
Chương 3
•	Terrain
Là một dạng địa hình trong game, giúp tạo không gian cho các nhân vật hoạt động, có thể thêm các thành phần như cây, cỏ , địa hình, đá , gió , nước 	(cách tạo vào 3D object chọn terrain)
Sau khi tạo có thể chỉnh sửa thuộc tính = cách vào Inspector chọn Terrain Settings và có thêm nhiều thuộc tính như :
1.	Chất liệu
2.	Liên quan đến Tree và Wind
3.	Liên quan đến chiều dài, rộng cao 
Terrain Editor cung cấp một số chức năng để thiết lập cấu trúc địa hình cho game và phần này nằm trong Terrain Script
1.	Terrain Raise Height Cho phép tạo địa hình đồi nút bằng cách vẽ trong chọn công cụ Brushes và thiết lập trong setting(phím tắt W)
2.	Paint height : Cho phép làm mịn các mép của địa hình
3.	Terrain Smooth Height: Làm mịn bản đồ chiều cao và làm mềm các tính năng địa hình
4.	Paint Texture: Sử dụng để tô các textures cho địa hình, có thể chọn có sẵn or vào edittexture để thêm từ asset
5.	Place Trees: Dùng thực hiện trồng các cây lên Terrain, có thể chọn có sẵn or chọn EditTree để add tree để thêm cây và chọn Brush để tô cây 
Bao gồm 1 số thiết lập như: 
 
Brush Size: thiết lập số lượng cây trên 1 click.
Tree Density: mức độ dày của cây
Color Variation: thiết lập mức độ màu khi trồng nhiều lần.
Tree Width/Height: Kích thước của cây
Tree Width/Height Variation: tạo ngẫu nhiên độ cao của cây khi thực hiện trồng rừng.
 
6.	Paint Details : cho phép thực hiện tree nhưng thêm flower, plants , rocks, tán lá
Chương 4 – Player
•	Inspector : biểu diễn trạng thái của game
Có 3 chức năng : 1. Nút 3 màu : Đánh dấu đối tượng trong game
2. Tên và trạng thái đối tượng game
3. Tag: Quản lý thẻ
4. Layer : Quản lý lớp của game
Tags Là từ khóa đơn giản để gán cho GO và quản lý object
	Có thể thêm bằng cách dùng tag có sẵn trong tag manager or sử dụng Add Tag
Layer dùng để gom nhóm các đối tượng cho dễ quản lý thường áp dụng khi muốn quản lý 1 tập hợp các đối tượng or khi dùng mặt nạ
Prefabs và Inspector gồm : 
1.	Select: Chọn lựa prefab để áp dụng
2.	Revert :Đảo lại các chức năng đã sửa
3.	Apply: Thay đổi thiết lập toàn bộ GO của Prefab
Transform : Là thuộc tính mặc định cho phép thiết lập vị trí, quay và co dãn của đối tượng
Character Controller : Xem như là một Collider ( va chạm) được thiết kế giúp nhân vật di chuyển trong môi trường game hay biểu diễn trạng thái bao gồm các tham số chính :
1.	Height : Chiều cao của character
2.	Radius: Bán kính của character
3.	Slope Limit: Thiết lập điểm dừng khi leo lên dốc
4.	Step Offset: Độ dài bước đi của nhân vật
5.	Skin Width: Độ rộng của lớp bảo vệ nhân vật. Giúp xác định mức độ va chạm
6.	Min Move Distance: Giúp thiết lập bước đi tối thiểu của nhân vật
7.	Center: Vị trí trung tâm của nhân vật.
Các thuộc tính :
1.	Height, Radius: chiều cao và bán kính
2.	Slope Limit: giới hạn về độ dốc khi leo núi
3.	Step Offset: Độ cao của bậc thang khi nhân vật leo cầu thang
4.	Min Move Distance: Độ dài bước chân tối thiểu
5.	Skin width: Độ dày của da, dùng cho va chạm
6.	Center: Tâm của collider
•	Mouse Look
Được biết bằng C# , giúp điều khiển khung nhìn của camera, bao gồm các biến :
1.	Axes : Cho phép lựa chọn chiều quy của Camera gắn vào nhân vật
2.	Sensitivity X/Y : Độ nhạy khi rê chuột
3.	Minimum X/Maximum X: Độ quay theo chiều X
4.	Minimum Y/Maximum Y: Độ quay theo chiều Y
-Cũng là script được gán cho First Person Character nhưng thay đổi giá trị Aexes thành Mouse Y
-Kết quả thay đổi này sẽ ảnh hưởng đến khung nhìn Camera quanh trục X.
•	CharacterMoto (Script)
Giúp điểu khiển bước đi của nhân vật. bao gồm các thuộc tính
1.	Movement: Điều khiển di chuyển nhân vật
2.	Jumping: Điều khiển bước nhảy của nhân vật
3.	Moving Platform: Thiết lập thông số khi di chuyển lên bục
4.	Sliding: Thiết lập chế độ trượt của nhân vật.
•	Graphics
Được tạo nên từ 1 game Object có tên Capsule( giả lập người chơi), trong Inspector có các thành phần :
1.	Transform: quy định vị trí, chiều quay và độ co dãn của đối tượng. Các giá trị này sẽ lấy đối tượng cha làm chuẩn.
2.	Mesh Filter: là thành phần chứa lưới và các thành phần của lưới, dùng để cấu tạo nên vật thể
3.	Mesh Renderer: biểu diễn vật thể. Bao gồm:
a.	Cast Shadows: tạo bóng cho bề mặt.
b.	Receive Shadows: nhận bóng đổ bề mặt
c.	Materials: chất liệu của vật thể.
•	Main Camera
- Là camera gắn trực tiếp vào vật thế dùng quan sát môi trường khi player di chuyển, được gắn phí trên và điều khiển bởi Script. Quan sát trong Inspector sẽ thấy thành phần : Transform, camera, GUILayer, FlareLayer, Mouse Look
- Là thành phần thiết yếu của Camera, dùng để thiết lập khung nhìn cho vật thể
Tham số :	Clear Flags: Cờ xác định thành phần nào bị xóa
		Back Ground Color: Màu của bầu trời xa phía sau vật thể.
		Culling Mask: bao gồm hoặc bỏ qua lớp của các đối tượng đưa ra bởi Camera (áp dụng cho Layer).
		Projection: Có 2 loại là chiếu phối cảnh hoặc chiếu song song
		Field of View: Phạm vi chiếu của Camera
		Cliping Planes: mức độ xa gần của Camera.
		Field of view: Kích thước của Camera và vị trí trên màn hình. Được quy định bởi (X,Y,W,H).
		Dept: Mức độ phía sau của Camera.
		Rendering Path: sử dụng trong việc render ra màn hình của người dùng

•	GUILayer and Flare Layer
GUILayer cho phép hiện ra các thành phần dạng 2D như Menu, text.
Flare Layer cho phép camera hiện các thành phần ánh sáng.
CHƯƠNG 4
•	Rigidbody
cho phép Game Object hoạt động dưới ảnh hưởng của vật lý, gồm các thuộc tính đi kèm
1.	Mass: Khối lượng của vật thể.
2.	Drag: Lực cản không khí, 0 là không có lực cản.
3.	Angular Drag: Lực cản mô men quay.
4.	Use Gravity: Có sử dụng trọng lực hay không.
5.	Is Kinematic: Bỏ qua ảnh hưởng vật lý, dùng để điều khiển trong Code.
6.	Interpolate: Mức độ giảm xóc của đối tượng:
7.	Collision Detection: Cách thức va chạm
8.	Constraints: Ràng buộc khi va chạm.

•	Collider
Là một đối tượng vô hình bao quanh đối tượng game, nhằm xác định mức độ va chạm, gồm các loại :
1.	Box Collider: dành cho khối hộp
2.	Capsule Collider: dành cho capsule
3.	Mesh Collider: Dành cho đối tượng phức tạp
4.	Sphere Collider: Dành cho khối cầu
5.	Wheel Collider: Dành cho bánh xe
6.	Terrain Collider: Dành cho địa hình
Để sử dụng Collider, vào Components chọn Physics, chọn Collider tương ứng. Một số thuộc tính :
-	Is Trigger: xác định là loại va chạm xuyên qua (trigger) hay va chạm không xuyên qua (collision).
-	Material: bề mặt va chạm hiệu ứng vật lý.
-	Center: vị trí tương đối của Collider so với object.
Các phương thức:
-	OnCollisionEnter: Xác định va chạm khi hai đối tượng bắt đầu chạm nhau
-	OnTriggerEnter: Ứng với va chạm loại trigger, là va chạm khi đối tượng này đi vào đối tượng kia
-	OnTriggerExit: Sự kiện khi kết thúc va chạm
	Chỉ hoạt động khi thêm vào RigidBody
Shaders: 
1.	FX: hiệu ứng ánh sáng và kính
2.	GUI and UI: Đối với đồ họa giao diện người dùng
3.	Mobile: Shader for mobile devices
4.	Nature: đối với cây cối và địa hình
5.	Particles: hiệu ứng hệ thống hạt
6.	Skybox: Hiển thị môi trường nền đăng sau tất cả các hình học
7.	Sprites: để sử dụng với hệ thống sprites 2D
8.	Toon: kết xuất theo phong cách hoạt hình
9.	Unlit: Để hiển thị hoàn toàn bỏ qua tất cả ánh sáng và bóng tối
10.	Legacy: Bộ sưu tập lớn các shader cũ được thay thế bởi standard shader


Physic Material 
	Dùng để gán thuộc tính ma sát & độ nẩy lên đối tượng Game, bao gồm các thuộc tính chính: 
1.	Dynamic Friction: ma sát khi chuyển động, có giá trị từ 0 đến 1
2.	Static Friction: ma sát khi đặt lên bề mặt (0->1).
3.	Bounciness: độ nẩy (0->1: không có trọng lực).
4.	Friction Combine: quan hệ giữa ma sát & collider
5.	Bounce Combine: quan hệ giữa ma sát & độ nẩy
Audio
      Âm thanh là một trong những yếu tố không thể thiếu, kích thích giác quan người chơi để trở nên cuốn hút và hấp dẫn 
       Dùng Audio Clip và Audio Source
Audio Source Component
Xây dựng để hỗ trợ phát file âm thanh trong game, bao gồm các thuộc tính cơ bản:
1.	AudioClip: Tập tin âm thanh.
2.	Play On Awake: âm thanh được phát ngay khi Game Object được kích hoạt
3.	Loop: Tuỳ chọn lặp lại liên tục
4.	Mute: ngắt kết nối với các thiết bị output

Animation
	là một công cụ giúp điều khiển sự hoạt động của game bao gồm :
1.	Animator
-	Là component được gắn với hoạt hình
-	Vai trò chuyển thông tin từ GO vào controller
2.	Animator Controller
-	component của Animator, nơi các trạng thái và logic của hoạt hình được tạo ra
-	là một máy trạng thái.
3.	State
-	Là một hình thức chuyển đổi giữa đối tượng này qua đối tượng khác, có 1 số trạng thái chính :
o	Animations: là một hoạt hình đơn, có những thuộc tính như: di chuyển, tốc độ và Mirror
o	Blendspaces: Điều khiển nhiều animation khác nhau trong một nút
o	Default State:  trạng thái ban đầu, mặc định
o	Any State: cho phép di chuyển đến trạng thái này từ bất kỳ trạng thái khác
o	Exit: Sẽ thông báo khi trạng thái này chuyển sang trạng thái khác
4.	Transitions
-	Dùng để chuyển từ trạng thái này sang trạng thái kia
-	Click chuột phải vào Animator, chọn “Create Transition” và kéo sang trạng thái khác
-	những điều kiện của Transition: 
o	Exit Time: xác định thời điểm thoát khỏi hoạt hình khi trạng thái chạy xong
o	Parameters: một số tham số nhằm giúp thõa mãn trạng thái khi thay đổi






5.	Parameters
-	Là các tham số dùng để điều khiển hoạt động của nhân vật,
-	Để tạo mở animation controller nhấn nút  + để tạo, những parameter có thể dùng : 
o	Float: điều khiển tốc độ giữa hai trạng thái
o	Integer: xác định liệu trạng thái có thể được di chuyển tùy vào giá trị
o	Bool: tạo ra điều kiện chuyển đổi trạng thái.
o	Trigger: là trạng thái sự kiện dạng true/false sẽ lặp lại hoạt hình liên tiếp chừng nào nó không chuyển thành giá trị khác
6.	Animator Scripting
-	Sử dụng trong Code, để điều khiển các Animation một các linh hoạt, 1 số phương thức :
o	GetComponent(): lấy ra thành phần Animator của đối tượng
o	Animator.SetInteger(String, Int): áp dụng lên trạng thái( tên string) với giá trị số.
o	Animator.SetTrigger(String): Truyền giá trị mặc định lên trạng thái sự kiện.
Hệ thống hạt
-	Hạt (particle) là đối tượng được phát ra theo hệ thống hạt
-	Các hạt thường là các texture có bề mặt hướng về camera
-	Hiệu ứng hạt (particle system) là một thành phần phát các hạt
-	Hiệu ứng hạt phụ thuộc mức độ đông đúc và thành phần biểu diễn
Khi đó ta có một số hệ thống hạt như sau, người dùng có thể kéo vào Scene, chỉnh các thông số trên Inspector để quan sát.
1.	Dust Storm: Bão bụi.
2.	Fire: hệ thống lửa
3.	Legacy Particles: Các vụ nổ
4.	Misc: hiệu ứng tự nhiên
5.	Smoke: Hiệu ứng khói
6.	Water: Hiệu ứng nước
❖Để sử dụng các hiệu ứng này, sử dụng phương thức: Instantiate() 
Code: 
Raycast : Thường sử dụng xác định đường ngắm của người chơi hoặc AI
