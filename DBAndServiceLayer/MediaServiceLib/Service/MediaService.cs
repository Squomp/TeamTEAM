using MediaDAL;
using MediaServiceLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaServiceLib.Service
{
    public class MediaService
    {
        public MediaListModel GetAllMedia()
        {
            MediaListModel model = new MediaListModel();
            using (var db = new MediaEntities())
            {
                var query = db.Media.Select(x => x);
                var bikeList = query.ToList();

                bikeList.ForEach(x =>
                    model.MediaList.Add(
                            new MediaModel()
                            {
                                Id = x.Id,
                                Author = x.Author,
                                Caption = x.Caption,
                                Description = x.Description,
                                Path = x.Path,
                                Type = (MediaType)Enum.Parse(typeof(MediaType), x.Type),
                                Category = (MediaCategory)Enum.Parse(typeof(MediaCategory), x.Category)
                            }
                        )
                );
            }
            return model;
        }

        public MediaModel GetMediaById(int id)
        {
            return GetAllMedia().MediaList.Where(x => x.Id == id).First();
        }
    }
}
