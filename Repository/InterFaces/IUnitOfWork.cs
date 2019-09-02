using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.InterFaces
{
   public interface IUnitOfWork
    {
       GenericRepositori<Users> UserRepository { get; }
       GenericRepositori<Camera> CameraRepository { get; }
        GenericRepositori<CameraInfo> CameraInfoRepository { get; }
    }
}
