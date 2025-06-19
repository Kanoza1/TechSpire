//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using TechSpire.Domain.Entities;

//namespace TechSpire.infra.EntitiesConfigrations;

//public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
//{
//    public void Configure(EntityTypeBuilder<Answer> builder)
//    {
//        builder.HasData(
//            new Answer { Id = 1, QuestionId = 1, Text = "Python is a programming language.", IsCorrect = true },
//            new Answer { Id = 2, QuestionId = 1, Text = "Python is a snake species.", IsCorrect = false },

//            new Answer { Id = 3, QuestionId = 2, Text = "Python supports multiple programming paradigms.", IsCorrect = true },
//            new Answer { Id = 4, QuestionId = 2, Text = "Python only supports procedural programming.", IsCorrect = false },

//            new Answer { Id = 5, QuestionId = 3, Text = "Python is dynamically typed.", IsCorrect = true },
//            new Answer { Id = 6, QuestionId = 3, Text = "Python is statically typed.", IsCorrect = false },

//            new Answer { Id = 7, QuestionId = 4, Text = "Python has a large standard library.", IsCorrect = true },
//            new Answer { Id = 8, QuestionId = 4, Text = "Python has a small standard library.", IsCorrect = false },

//            new Answer { Id = 9, QuestionId = 5, Text = "Python supports object-oriented programming.", IsCorrect = true },
//            new Answer { Id = 10, QuestionId = 5, Text = "Python does not support object-oriented programming.", IsCorrect = false },

//            new Answer { Id = 11, QuestionId = 6, Text = "Python supports functional programming.", IsCorrect = true },
//            new Answer { Id = 12, QuestionId = 6, Text = "Python does not support functional programming.", IsCorrect = false },

//            new Answer { Id = 13, QuestionId = 7, Text = "Python supports concurrent programming.", IsCorrect = true },
//            new Answer { Id = 14, QuestionId = 7, Text = "Python does not support concurrent programming.", IsCorrect = false },

//            new Answer { Id = 15, QuestionId = 8, Text = "Python supports metaprogramming.", IsCorrect = true },
//            new Answer { Id = 16, QuestionId = 8, Text = "Python does not support metaprogramming.", IsCorrect = false },

//            new Answer { Id = 17, QuestionId = 9, Text = "Python supports introspection.", IsCorrect = true },
//            new Answer { Id = 18, QuestionId = 9, Text = "Python does not support introspection.", IsCorrect = false },

//            new Answer { Id = 19, QuestionId = 10, Text = "Python supports reflection.", IsCorrect = true },
//            new Answer { Id = 20, QuestionId = 10, Text = "Python does not support reflection.", IsCorrect = false },

//            new Answer { Id = 21, QuestionId = 11, Text = "Python supports duck typing.", IsCorrect = true },
//            new Answer { Id = 22, QuestionId = 11, Text = "Python does not support duck typing.", IsCorrect = false },

//            new Answer { Id = 23, QuestionId = 12, Text = "Python supports multiple inheritance.", IsCorrect = true },
//            new Answer { Id = 24, QuestionId = 12, Text = "Python does not support multiple inheritance.", IsCorrect = false },

//            new Answer { Id = 25, QuestionId = 13, Text = "Python supports operator overloading.", IsCorrect = true },
//            new Answer { Id = 26, QuestionId = 13, Text = "Python does not support operator overloading.", IsCorrect = false },

//            new Answer { Id = 27, QuestionId = 14, Text = "Python supports method overloading.", IsCorrect = true },
//            new Answer { Id = 28, QuestionId = 14, Text = "Python does not support method overloading.", IsCorrect = false },

//            new Answer { Id = 29, QuestionId = 15, Text = "Python supports method overriding.", IsCorrect = true },
//            new Answer { Id = 30, QuestionId = 15, Text = "Python does not support method overriding.", IsCorrect = false },

//            new Answer { Id = 31, QuestionId = 16, Text = "Python supports class variables.", IsCorrect = true },
//            new Answer { Id = 32, QuestionId = 16, Text = "Python does not support class variables.", IsCorrect = false },

//            new Answer { Id = 33, QuestionId = 17, Text = "Python supports instance variables.", IsCorrect = true },
//            new Answer { Id = 34, QuestionId = 17, Text = "Python does not support instance variables.", IsCorrect = false },

//            new Answer { Id = 35, QuestionId = 18, Text = "Python supports static variables.", IsCorrect = true },
//            new Answer { Id = 36, QuestionId = 18, Text = "Python does not support static variables.", IsCorrect = false },

//            new Answer { Id = 37, QuestionId = 19, Text = "Python supports class methods.", IsCorrect = true },
//            new Answer { Id = 38, QuestionId = 19, Text = "Python does not support class methods.", IsCorrect = false },

//            new Answer { Id = 39, QuestionId = 20, Text = "Python supports instance methods.", IsCorrect = true },
//            new Answer { Id = 40, QuestionId = 20, Text = "Python does not support instance methods.", IsCorrect = false },

//            new Answer { Id = 41, QuestionId = 21, Text = "Python supports static methods.", IsCorrect = true },
//            new Answer { Id = 42, QuestionId = 21, Text = "Python does not support static methods.", IsCorrect = false },

//            new Answer { Id = 43, QuestionId = 22, Text = "Python supports abstract classes.", IsCorrect = true },
//            new Answer { Id = 44, QuestionId = 22, Text = "Python does not support abstract classes.", IsCorrect = false },

//            new Answer { Id = 45, QuestionId = 23, Text = "Python supports interfaces.", IsCorrect = true },
//            new Answer { Id = 46, QuestionId = 23, Text = "Python does not support interfaces.", IsCorrect = false },

//            new Answer { Id = 47, QuestionId = 24, Text = "Python supports mixins.", IsCorrect = true },
//            new Answer { Id = 48, QuestionId = 24, Text = "Python does not support mixins.", IsCorrect = false },

//            new Answer { Id = 49, QuestionId = 25, Text = "Python supports decorators.", IsCorrect = true },
//            new Answer { Id = 50, QuestionId = 25, Text = "Python does not support decorators.", IsCorrect = false }
//        );
//    }
//}
