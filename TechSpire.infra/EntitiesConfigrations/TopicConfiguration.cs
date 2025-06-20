//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TechSpire.infra.EntitiesConfigrations;
//public class TopicConfiguration : IEntityTypeConfiguration<Topic>
//{
//    public void Configure(EntityTypeBuilder<Topic> builder)
//    {
//        builder.HasData
//        (
//            new Topic
//            {
//                Id = 1,
//                Name = "Python Basics",
//                StageId = 1,
//                QuestionId = null,
//                BookId = 1,
//                PostId = null,
//                ArticleId = null,
//                QuizId = null
//            },
//            new Topic
//            {
//                Id = 2,
//                Name = "Advanced Python",
//                StageId = 1,
//                QuestionId = null,
//                BookId = 2,
//                PostId = null,
//                ArticleId = null,
//                QuizId = null
//            }
//        );
//    }
//}
