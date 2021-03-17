using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat.DTOS;

namespace TLU.BusinessFee.Application.Catalog.DuyetDeXuat
{
    public interface IDuyetDeXuatService
    {
        Task<int> TruongBoPhanManager(UpdateDeXuatManagerRequest request);

        Task<int> PhongKeToanManager(UpdateDeXuatManagerRequest request);
        Task<int> LanhDaoManager(UpdateDeXuatManagerRequest request);
    }
}
