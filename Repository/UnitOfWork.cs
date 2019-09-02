using DAL.Models;
using Repository.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        WisthamApiContext db = new WisthamApiContext();

        private GenericRepositori<Users> _UserRepository;
        public GenericRepositori<Users> UserRepository
        {
            get
            {
                if (_UserRepository == null)
                {
                    _UserRepository = new GenericRepositori<Users>(db);
                }
                return _UserRepository;
            }
        }

        private GenericRepositori<Camera> _CameraRepository;

        public GenericRepositori<Camera> CameraRepository
        {
            get
            {
                if (_CameraRepository == null)
                {
                    _CameraRepository = new GenericRepositori<Camera>(db);
                }

                return _CameraRepository;
            }
        }
        private GenericRepositori<CameraInfo> _CameraInfoRepository;

        public GenericRepositori<CameraInfo> CameraInfoRepository
        {
            get
            {
                if (_CameraInfoRepository == null)
                {
                    _CameraInfoRepository = new GenericRepositori<CameraInfo>(db);
                }

                return _CameraInfoRepository;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
