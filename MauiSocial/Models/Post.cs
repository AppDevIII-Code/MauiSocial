using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiSocial.Models
{
    public class Post :INotifyPropertyChanged
    {
        public enum PostType
        {
            Image,
            Video
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public PostType Type { get; set; } = PostType.Image; // Image by default
        public int Id { get; set; }

        private string _contentUri;
        public string ContentUri
        {
            get => _contentUri;
            set
            {
                Uri uri;
                if (Uri.TryCreate(value, UriKind.Absolute, out uri))
                {
                    _contentUri = value;
                }
            }
        }
        private int _likes = 0; 
        public int Likes { get => _likes; set { if (value > 1) _likes = value; } }
        public ObservableCollection<Comment> Comments { get; set; } = new();
    }
}
