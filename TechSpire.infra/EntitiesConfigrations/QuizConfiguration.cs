using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechSpire.Domain.Entities;

namespace TechSpire.infra.EntitiesConfigrations;
public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        // Add the Topic relationship
        builder.HasOne(q => q.Topic)
               .WithMany(t => t.Quizzes)
               .HasForeignKey(q => q.TopicId)
               .OnDelete(DeleteBehavior.SetNull);

        // Example seed data (if needed)
        builder.HasData(
            new Quiz
            {
                Id = 1,
                StangeId = 1,
                Title = "Python Basics Quiz",
                Description = "Test your knowledge of Python basics.",
                TopicId = 1
            },
            new Quiz
            {
                Id = 2,
                StangeId = 2,
                Title = "Python Intermediate Quiz",
                Description = "Test your knowledge of intermediate Python concepts.",
                TopicId = 2
            },
            new Quiz
            {
                Id = 3,
                StangeId = 3,
                Title = "Python Advanced Quiz",
                Description = "Test your knowledge of advanced Python concepts.",
                TopicId = 3
            }

        );
    }
}
