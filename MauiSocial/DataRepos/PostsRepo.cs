using MauiSocial.Models;
using System.Collections.ObjectModel;

namespace MauiSocial.DataRepos
{
    public static class PostsRepo
    {
    public static ObservableCollection<Post> ImgPosts { get; } = new()
    {
        new Post
        {
            Id = 1,
            Type = Post.PostType.Image,
            ContentUri = "https://picsum.photos/300/300.jpg",
            Likes = 10,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("Alice", "Nice post!"),
                new Comment("Bob", "Awesome!"),
                new Comment("Charlie", "Great shot!")
            }
        },
        new Post
        {
            Id = 2,
            Type = Post.PostType.Image,
            ContentUri = "https://picsum.photos/250/250.jpg",
            Likes = 25,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("David", "Love this!"),
                new Comment("Eve", "Amazing content!"),
                new Comment("Frank", "Keep it up!")
            }
        },
        new Post
        {
            Id = 3,
            Type = Post.PostType.Image,
            ContentUri = "https://picsum.photos/255/255.jpg",
            Likes = 15,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("Grace", "So cool!"),
                new Comment("Hannah", "Really inspiring."),
                new Comment("Ian", "I love this perspective!")
            }
        },
        new Post
        {
            Id = 4,
            Type = Post.PostType.Image,
            ContentUri = "https://picsum.photos/256/256.jpg",
            Likes = 30,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("Jack", "Mind-blowing!"),
                new Comment("Karen", "Best thing I've seen today."),
                new Comment("Leo", "This deserves more likes!")
            }
        }
    };
    public static ObservableCollection<Post> VideoPosts { get; set; } = new()
        {
            new Post
            {
                Id = 1,
                Type = Post.PostType.Video,
                ContentUri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerBlazes.mp4",
                Likes = 10,
                Comments = new ObservableCollection<Comment>
                {
                    new Comment("Alice", "Nice post!"),
                    new Comment("Bob", "Awesome!"),
                    new Comment("Charlie", "Great shot!")
                }
            },
        new Post
        {
            Id = 2,
            Type = Post.PostType.Video,
            ContentUri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4",
            Likes = 25,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("David", "Love this!"),
                new Comment("Eve", "Amazing content!"),
                new Comment("Frank", "Keep it up!")
            }
        },
        new Post
        {
            Id = 3,
            Type = Post.PostType.Video,
            ContentUri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4",
            Likes = 15,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("Grace", "So cool!"),
                new Comment("Hannah", "Really inspiring."),
                new Comment("Ian", "I love this perspective!")
            }
        },
        new Post
        {
            Id = 4,
            Type = Post.PostType.Video,
            ContentUri = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4",
            Likes = 30,
            Comments = new ObservableCollection<Comment>
            {
                new Comment("Jack", "Mind-blowing!"),
                new Comment("Karen", "Best thing I've seen today."),
                new Comment("Leo", "This deserves more likes!")
            }
        }
        };
    }
}
