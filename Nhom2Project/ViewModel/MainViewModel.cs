using System;
using System.Collections.ObjectModel;
using System.Linq;
using Nhom2Project.Model;

namespace Nhom2Project.ViewModel
{
        public class MainViewModel : BaseViewModel
        {

            public MainViewModel()
            {
                Orders = new ObservableCollection<Food>();
                Foods = GetFoods();
            }

            public int OrderCount => Orders.Count;
            public float TotalPrice => Orders.Sum(x => x.Price);

            private ObservableCollection<Food> foods;
            public ObservableCollection<Food> Foods
            {
                get { return foods; }
                set
                {
                    foods = value;
                    OnPropertyChanged();
                }
            }

            private ObservableCollection<Food> orders;
            public ObservableCollection<Food> Orders
            {
                get { return orders; }
                set
                {
                    orders = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(OrderCount));
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }


            private ObservableCollection<Food> GetFoods()
            {
                return new ObservableCollection<Food>
            {
 
                new Food{ Name = "Cà ri massaman (Thái Lan)", Image = "1.jpg", Price = 259000f, Description = "Cà ri Massaman là một món ăn Hồi Giáo ở miền Nam Thái Lan. Nguyên liệu chính là thịt bò, ngoài ra còn có thịt vịt, đậu hũ, gà, lợn "},
                new Food{ Name = "Pizza ở Napoli (Italia)", Image = "2.jpg", Price = 109000f, Description = "Pizza là loại bánh dẹt, tròn được chế biến từ nước, bột mỳ và nấm men, sau khi đã được ủ ít nhất 24 tiếng đồng hồ và nhào nặn thành loại bánh có hình dạng tròn và dẹt, và được cho vào lò nướng chín."},
                new Food{ Name = "Socola (Mexico)", Image = "3.jpg", Price = 76000f, Description = "Sô-cô-la là một từ được dùng để diễn tả một loại thức ăn (còn nguyên hay đã chế biến) được làm từ quả của cây ca cao. Sô-cô-la là nguyên liệu cơ bản trong rất nhiều những loại kẹo, kẹo sô-cô-la, kem, bánh quy, bánh ngọt,... Hương vị sô-cô-la là một trong số những hương vị được yêu thích nhất trên thế giới."},
                new Food{ Name = "Sushi (Nhật Bản)", Image = "4.jpg", Price = 210000f, Description = "Sushi là một món ăn Nhật Bản gồm cơm trộn giấm (shari) kết hợp với các nguyên liệu khác (neta). Neta và hình thức trình bày sushi rất đa dạng, nhưng nguyên liệu chính mà tất cả các loại sushi đều có là shari."},
                new Food{ Name = "Vịt quay Bắc Kinh (Trung Quốc)", Image = "5.jpg", Price = 427000f, Description = "Vịt quay Bắc Kinh là một món ăn từ Bắc Kinh[1] được chế biến từ thời phong kiến. Đặc điểm của loại thịt này là lớp da mỏng và giòn, còn các phiên bản chính thống của món ăn thì phục vụ chủ yếu là da với ít thịt, được người nấu thái lát trước mặt thực khách."},
                new Food{ Name = "Hamburger (Đức)", Image = "6.jpg", Price = 97000f, Description = "Hamburger là một loại thức ăn bao gồm bánh mì kẹp có thịt xay (thường là thịt bò) ở giữa. Miếng thịt có thể được nướng, chiên, hun khói hay nướng trên lửa."},
                new Food{ Name = "Penang assam laksa (Malaysia)", Image = "7.jpg", Price = 215000f, Description = "Laksa là một loại mì cay phổ biến trong ẩm thực Peranakan của Đông Nam Á. Laksa bao gồm mì sợi dày hoặc bún gạo với gà, tôm hoặc cá, được phục vụ trong nước súp cay dựa trên nước cốt dừa cà ri đậm đà và cay hoặc với asam chua ( me hoặc gelugur )."},
                new Food{ Name = "Tom yum goong (Thái Lan)", Image = "8.jpg", Price = 179000f, Description = "Tom yam là tên của loại canh chua cay ăn nóng đặc trưng trong ẩm thực Thái Lan, Lào. "},
                new Food{ Name = "Kem (Mỹ)", Image = "9.jpg", Price = 47000f, Description = "Kem là một loại thực phẩm đông lạnh, món ngọt thường dùng làm món ăn nhẹ hoặc món tráng miệng."},
                new Food{ Name = "Gà Muamba (Gabon Châu Phi)", Image = "10.jpg", Price = 479000f, Description = "Gà Muamba là món hầm cay thường ăn cùng cơm trộn lá sắn, một trong những món ăn du khách không thể không thử khi đến châu Phi"}
            };
            }


            public void AddOrder(Food item)
            {
                if (item != null)
                {
                    Orders.Add(item);
                    OnPropertyChanged(nameof(OrderCount));
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }
        }
    }



