using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat.DTOS;

namespace TLU.BusinessFee.Application.Catalog.DuyetDeXuat
{
    public interface IDuyetDeXuatService
    {
        Task<int> TruongBoPhanManagerXetDuyet(string MaDeXuat);

        Task<int> PhongKeToanManager(TuChoiDeXuatManagerRequest request);
        Task<int> LanhDaoManager(TuChoiDeXuatManagerRequest request);
        Task<int> TruongBoPhanManagerTuChoi(TuChoiDeXuatManagerRequest request);
    }
}
