using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.Database.Entity;

namespace ZforeFromwork.Database.Service.Interface
{
    public interface IVideoService
    {
        void InsertVideo(Video video);

        void UpdateVideo(Video video);

        Video GetVideoByID(int id);

        Video GetVideoByName(string name);

        List<Video> GetAllVideo();
    }
}
