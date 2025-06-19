using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechSpire.Domain.Entities;

namespace TechSpire.infra.EntitiesConfigrations;
public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasData(
            new Question
            {
                Id = 1,
                QuizId = 1,
                Text = "1-What is the correct way to create a variable in Python?",
                Answers = new List<Answer>
                {
                    new Answer { Id = 1, Text = "variable x = 10", IsCorrect = true },
                    new Answer { Id = 2, Text = "x := 10", IsCorrect = false },
                    new Answer { Id = 3, Text = "int x = 10", IsCorrect = false },
                    new Answer { Id = 4, Text = "x == 10", IsCorrect = false }
                },
                TopicId = 1,
                
            }

        );

        builder.HasOne(q => q.Topic)
               .WithMany(t => t.Questions)
               .HasForeignKey(q => q.TopicId)
               .OnDelete(DeleteBehavior.SetNull);
    }
} 