//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using TechSpire.Domain.Entities;

//namespace TechSpire.infra.EntitiesConfigrations;
//public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
//{
//    public void Configure(EntityTypeBuilder<Quiz> builder)
//    {
//        // Add the Topic relationship
//        builder.HasOne(q => q.Topic)
//               .WithMany(t => t.Quizzes)
//               .HasForeignKey(q => q.TopicId)
//               .OnDelete(DeleteBehavior.SetNull);

//        // Seed both beginner and intermediate quizzes
//        builder.HasData(
//            new Quiz
//            {
//                Id = 4,
//                StangeId = 1, // Beginner Stage
//                Title = "Beginner Python Quiz",
//                Description = "A comprehensive quiz for Python beginners covering variables, data types, conditionals, and loops.",
//                TopicId = 1 // Syntax
//            },
//            new Quiz
//            {
//                Id = 5,
//                StangeId = 2, // Intermediate Stage
//                Title = "Intermediate Python Quiz",
//                Description = "A comprehensive quiz for Python intermediate learners covering OOP, data structures, algorithms, and functions.",
//                TopicId = 2 // OOP/Data Structure/Algorithms
//            },
//            new Quiz
//            {
//                Id = 6,
//                StangeId = 3, // Advanced Stage
//                Title = "Advanced Python Quiz",
//                Description = "A comprehensive quiz for advanced Python learners covering machine learning, deep learning, and big data.",
//                TopicId = 3 // ML/Data Science/Big Data
//            }
//        );
//    }
//}
