# TLU.BusinessFee
## Phần mềm thanh toán công tác phí tại đại học Thăng Long
- Hướng dẫn cài đặt:  
-1- Clone project  
-2- Restore nuget packet cho solution  
-3- Set startup project cho TLU.BusinessFee.Data  
-4- vào công cụ tool>>Nuget packet Manager>>Package Manager Console  
-5- Set default project là TLU.BusinessFee.Data   
-6- Chạy câu lệnh update-database  
-7- Sau khi thành công sẽ có được database trong sqlserver   
-8- Set startup project cho TLU.BusinessFee.BackendApi và chạy chương trình  
* nếu không thành công  
-1- vào file appsettings.json tại TLU.BusinessFee.Data  và sửa như sau  
``"ConnectionStrings": {
    "TLU_BusinessFeeDb": "Data Source=Tên máy;Database=TLU_BusinessFeeDb;Integrated Security=False;User Id=sa;Password=mật khẩu;MultipleActiveResultSets=True;"
    }``     
-2- Tiếp theo vào file appsettings.json>>appsettings.Development.json tại TLU.BusinessFee.BackendApi  và sửa như sau  
``"ConnectionStrings": {
    "TLU_BusinessFeeDb": "Data Source=Tên máy;Database=TLU_BusinessFeeDb;Integrated Security=False;User Id=sa;Password=mật khẩu;MultipleActiveResultSets=True;"
    }``  
-3- Thực hiện lại từ bước 4
