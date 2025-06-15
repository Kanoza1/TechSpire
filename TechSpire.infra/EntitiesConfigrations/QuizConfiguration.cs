//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechSpire.Domain.Entities;

//namespace TechSpire.infra.EntitiesConfigrations;
//public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
//{
//    public void Configure(EntityTypeBuilder<Question> builder)
//    {
//        builder.HasData(
//{
//    new Question
//    {
//        Id = 1,
//        QuizId = 1,
//        Text = "What is the default value of a boolean variable in C#?",
//        Answers = new List<Answer>
//        {
//            new Answer { Id = 1, Text = "True", IsCorrect = false },
//            new Answer { Id = 2, Text = "False", IsCorrect = true },
//            new Answer { Id = 3, Text = "Null", IsCorrect = false },
//            new Answer { Id = 4, Text = "0", IsCorrect = false }
//        }
//    },
//    new Question
//    {
//        Id = 2,
//        QuizId = 2,
//        Text = "Which of the following is a value type in C#?",
//        Answers = new List<Answer>
//        {
//            new Answer { Id = 5, Text = "String", IsCorrect = false },
//            new Answer { Id = 6, Text = "Int32", IsCorrect = true },
//            new Answer { Id = 7, Text = "Object", IsCorrect = false },
//            new Answer { Id = 8, Text = "Dynamic", IsCorrect = false }
//        }
//    }
//})
//    }
//    public void Configure(EntityTypeBuilder<Quiz> builder)
//    {
//        // write your quizzes infor
//        builder.HasData
//            (
//            new Quiz
//            {
//                Id = 1,
//                Title = "C# Basics",
//                Description = "Test your knowledge of C# basics.",
//                StangeId = 1,
                
//            }, new Quiz
//            {
//                Id = 1,
//                Title = "C# Basics",
//                Description = "Test your knowledge of C# basics.",
//                StangeId = 1,
//                Questions = new List<Question>
//                {
//                    new Question
//                    {
//                        Id = 1,
//                        QuizId = 1,
//                        Text = "What is the default value of a boolean variable in C#?",
//                        Answers = new List<Answer>
//                        {
//                            new Answer { Id = 1, Text = "True", IsCorrect = false },
//                            new Answer { Id = 2, Text = "False", IsCorrect = true },
//                            new Answer { Id = 3, Text = "Null", IsCorrect = false },
//                            new Answer { Id = 4, Text = "0", IsCorrect = false }
//                        }
//                    },
//                    new Question
//                    {
//                        Id = 2,
//                        QuizId = 1,
//                        Text = "Which of the following is a value type in C#?",
//                        Answers = new List<Answer>
//                        {
//                            new Answer { Id = 5, Text = "String", IsCorrect = false },
//                            new Answer { Id = 6, Text = "Int32", IsCorrect = true },
//                            new Answer { Id = 7, Text = "Object", IsCorrect = false },
//                            new Answer { Id = 8, Text = "Dynamic", IsCorrect = false }
//                        }
//                    },
//                }
//            },
//                new Quiz
//                {
//                    Id = 1,
//                    Title = "C# Basics",
//                    Description = "Test your knowledge of C# basics.",
//                    StangeId = 1,
//                    Questions = new List<Question>
//                {
//                    new Question
//                    {
//                        Id = 1,
//                        Text = "What is the default value of a boolean variable in C#?",
//                        Answers = new List<Answer>
//                        {
//                            new Answer { Id = 1, Text = "True", IsCorrect = false },
//                            new Answer { Id = 2, Text = "False", IsCorrect = true },
//                            new Answer { Id = 3, Text = "Null", IsCorrect = false },
//                            new Answer { Id = 4, Text = "0", IsCorrect = false }
//                        }
//                           },
//                    new Question
//                    {
//                        Id = 2,
//                        Text = "Which of the following is a value type in C#?",
//                        Answers = new List<Answer>
//                        {
//                            new Answer { Id = 5, Text = "String", IsCorrect = false },
//                            new Answer { Id = 6, Text = "Int32", IsCorrect = true },
//                            new Answer { Id = 7, Text = "Object", IsCorrect = false },
//                            new Answer { Id = 8, Text = "Dynamic", IsCorrect = false }
//                        }
//                    } }
//                },
//                  new Quiz
//                  {
//                      Id = 1,
//                      Title = "C# Basics",
//                      Description = "Test your knowledge of C# basics.",
//                      StangeId = 1,
//                      Questions = new List<Question>
//                {
//                    new Question
//                    {
//                        Id = 1,
//                        QuizId
//                        = 1,
//                        Text = "What is the default value of a boolean variable in C#?",
//                        Answers = new List<Answer>
//                        {
//                            new Answer { Id = 1, Text = "True", IsCorrect = false },
//                            new Answer { Id = 2, Text = "False", IsCorrect = true },
//                            new Answer { Id = 3, Text = "Null", IsCorrect = false },
//                            new Answer { Id = 4, Text = "0", IsCorrect = false }
//                        }
//                    },
//                    new Question
//                    {
//                        Id = 2,
//                        Text = "Which of the following is a value type in C#?",
//                        QuizId = 1,
//                        Answers = new List<Answer>
//                        {
//                            new Answer { Id = 5, Text = "String", IsCorrect = false },
//                            new Answer { Id = 6, Text = "Int32", IsCorrect = true },
//                            new Answer { Id = 7, Text = "Object", IsCorrect = false },
//                            new Answer { Id = 8, Text = "Dynamic", IsCorrect = false }
//                        }
//                    }
//                }
//                  }


//            );
//    }
//}
