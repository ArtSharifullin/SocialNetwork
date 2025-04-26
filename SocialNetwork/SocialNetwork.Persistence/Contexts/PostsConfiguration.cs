using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SocialNetwork.Persistence.Contexts;

public class PostsConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasData(
        new Post()
        {
            UserPageId = 1,
            Content = "Контент1",
            LikeCount = 1,
            DislikeCount = 1
        },
        new Post()
        {
            UserPageId = 2,
            Content = "Контент2",
            LikeCount = 2,
            DislikeCount = 2
        },
        new Post()
        {
            UserPageId = 3,
            Content = "Контент3",
            LikeCount = 3,
            DislikeCount = 3
        }
        );
    }
}
