using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;

namespace ZforeFromwork.Database.Service.Realization
{
    /// <summary>
    /// 摄像头管理服务
    /// </summary>
    public partial class VideoService:BaseService, IVideoService
    {
        public void InsertVideo(Video video)
        {
            base.InsertEntity(video);
        }

        public void UpdateVideo(Video video)
        {
            base.UpdateEntity(video);
        }

        public Video GetVideoByID(int id)
        {
            return base.GetEntityById<Video>(id);
        }

        public Video GetVideoByName(string name)
        {
            return db.TVideo.Where(v => v.VideoName == name).FirstOrDefault();
        }

        public  List<Video> GetAllVideo()
        {
            return base.GetAllEntitys<Video>();
        }
    }
}
