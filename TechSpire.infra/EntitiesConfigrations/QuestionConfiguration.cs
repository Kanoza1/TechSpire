//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using TechSpire.Domain.Entities;

//namespace TechSpire.infra.EntitiesConfigrations;
//public class QuestionConfiguration : IEntityTypeConfiguration<Question>
//{
//    public void Configure(EntityTypeBuilder<Question> builder)
//    {
//        builder.HasData(
//            new Question
//            {
//                Id = 1,
//                QuizId = 1,
//                Text = "1- What is the What is the correct way to create a variable in Python? ",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 1, QuestionId = 1, Text = "x = 5", IsCorrect = true },
//                //    new Answer { Id = 2, QuestionId = 1, Text = "x := 5", IsCorrect = false },
//                //    new Answer { Id = 3, QuestionId = 1, Text = "int x = 5", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 2,
//                QuizId = 1,
//                Text = "2-Which of the following is a valid variable name in Python?",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 4, QuestionId = 2, Text = "first_name", IsCorrect = true },
//                //    new Answer { Id = 5, QuestionId = 2, Text = "2name", IsCorrect = false },
//                //    new Answer { Id = 6, QuestionId = 2, Text = "first-name", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 3,
//                QuizId = 1,
//                Text = "3-What will be the output of the following code? x = \"5\" y = 2 print(x + str(y))",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 7, QuestionId = 3, Text = "52", IsCorrect = true },
//                //    new Answer { Id = 8, QuestionId = 3, Text = "7", IsCorrect = false },
//                //    new Answer { Id = 9, QuestionId = 3, Text = "TypeError", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 4,
//                QuizId = 1,
//                Text = "4-Which of these is not allowed when assigning variables in Python?",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 10, QuestionId = 4, Text = "5 = x", IsCorrect = true },
//                //    new Answer { Id = 11, QuestionId = 4, Text = "x = 5", IsCorrect = false },
//                //    new Answer { Id = 12, QuestionId = 4, Text = "name = \"Alice\"", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 5,
//                QuizId = 1,
//                Text = "5-What is the data type of the variable x in this code? x = 3.14",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 13, QuestionId = 5, Text = "float", IsCorrect = true },
//                //    new Answer { Id = 14, QuestionId = 5, Text = "int", IsCorrect = false },
//                //    new Answer { Id = 15, QuestionId = 5, Text = "str", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 6,
//                QuizId = 1,
//                Text = "6-Which of the following is a valid way to assign a value to a variable?",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 16, QuestionId = 6, Text = "age = 25", IsCorrect = true },
//                //    new Answer { Id = 17, QuestionId = 6, Text = "age := 25", IsCorrect = false },
//                //    new Answer { Id = 18, QuestionId = 6, Text = "int age = 25", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 7,
//                QuizId = 1,
//                Text = "7-What will be the value of x after this code runs? x = 10 x = x + 5",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 19, QuestionId = 7, Text = "15", IsCorrect = true },
//                //    new Answer { Id = 20, QuestionId = 7, Text = "10", IsCorrect = false },
//                //    new Answer { Id = 21, QuestionId = 7, Text = "5", IsCorrect = false },
//                //}

//            },
//            new Question
//            {
//                Id = 8,
//                QuizId = 1,
//                Text = "8-Which of the following variable names is written in snake_case?",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 22, QuestionId = 8, Text = "user_name", IsCorrect = true },
//                //    new Answer { Id = 23, QuestionId = 8, Text = "UserName", IsCorrect = false },
//                //    new Answer { Id = 24, QuestionId = 8, Text = "user-name", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 9,
//                QuizId = 1,
//                Text = "9-What is the value of result after running this code? a = 4 b = 3 result = a * b",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 25, QuestionId = 9, Text = "12", IsCorrect = true },
//                //    new Answer { Id = 26, QuestionId = 9, Text = "7", IsCorrect = false },
//                //    new Answer { Id = 27, QuestionId = 9, Text = "1", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 10,
//                QuizId = 1,
//                Text = "10-Which statement is true about variables in Python?",
//                StageId = 1,
//                TopicId = 1,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 28, QuestionId = 10, Text = "You don\u2019t need to declare the data type before assigning a value", IsCorrect = true },
//                //    new Answer { Id = 29, QuestionId = 10, Text = "Variable names must start with a number", IsCorrect = false },
//                //    new Answer { Id = 30, QuestionId = 10, Text = "Variable names must start with a number", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 11,
//                QuizId = 2,
//                Text = "What keyword is used to define a class in Python?",
//                StageId = 2,
//                TopicId = 2,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 31, QuestionId = 11, Text = "class", IsCorrect = true },
//                //    new Answer { Id = 32, QuestionId = 11, Text = "def", IsCorrect = false },
//                //    new Answer { Id = 33, QuestionId = 11, Text = "object", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 12,
//                QuizId = 2,
//                Text = "What is the first parameter of a method inside a class?",
//                StageId = 2,
//                TopicId = 2,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 34, QuestionId = 12, Text = "self", IsCorrect = true },
//                //    new Answer { Id = 35, QuestionId = 12, Text = "this", IsCorrect = false },
//                //    new Answer { Id = 36, QuestionId = 12, Text = "init", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 13,
//                QuizId = 2,
//                Text = "Which method is automatically called when an object is created?",
//                StageId = 2,
//                TopicId = 2,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 37, QuestionId = 13, Text = "__init__()", IsCorrect = true },
//                //    new Answer { Id = 38, QuestionId = 13, Text = "__str__()", IsCorrect = false },
//                //    new Answer { Id = 39, QuestionId = 13, Text = "__call__()", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 14,
//                QuizId = 2,
//                Text = "What is it called when a class inherits from another class?",
//                StageId = 2,
//                TopicId = 2,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 40, QuestionId = 14, Text = "Inheritance", IsCorrect = true },
//                //    new Answer { Id = 41, QuestionId = 14, Text = "Encapsulation", IsCorrect = false },
//                //    new Answer { Id = 42, QuestionId = 14, Text = "Polymorphism", IsCorrect = false },
//                //},
//            },
//            new Question
//            {
//                Id = 15,
//                QuizId = 2,
//                Text = "What is the purpose of the __str__() method in a class?",
//                StageId = 2,
//                TopicId = 2,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 43, QuestionId = 15, Text = "To return a string representation of the object", IsCorrect = true },
//                //    new Answer { Id = 44, QuestionId = 15, Text = "To initialize the object", IsCorrect = false },
//                //    new Answer { Id = 45, QuestionId = 15, Text = "To delete the object", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 21,
//                QuizId = 3,
//                Text = "What is the main purpose of machine learning?",
//                StageId = 3,
//                TopicId = 3,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 46, QuestionId = 21, Text = "To enable computers to learn from data", IsCorrect = true },
//                //    new Answer { Id = 47, QuestionId = 21, Text = "To create static programs", IsCorrect = false },
//                //    new Answer { Id = 48, QuestionId = 21, Text = "To write code manually for every task", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 22,
//                QuizId = 3,
//                Text = "Which of the following is a common type of machine learning?",
//                StageId = 3,
//                TopicId = 3,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 49, QuestionId = 22, Text = "Supervised learning", IsCorrect = true },
//                //    new Answer { Id = 50, QuestionId = 22, Text = "Unsupervised learning", IsCorrect = true },
//                //    new Answer { Id = 51, QuestionId = 22, Text = "Reinforcement learning", IsCorrect = true },
//                //}
//            },
//            new Question
//            {
//                Id = 23,
//                QuizId = 3,
//                Text = "What is the purpose of a training dataset in machine learning?",
//                StageId = 3,
//                TopicId = 3,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 52, QuestionId = 23, Text = "To train the model to make predictions", IsCorrect = true },
//                //    new Answer { Id = 53, QuestionId = 23, Text = "To evaluate the model's performance", IsCorrect = false },
//                //    new Answer { Id = 54, QuestionId = 23, Text = "To visualize the data", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 24,
//                QuizId = 3,
//                Text = "What is overfitting in machine learning?",
//                StageId = 3,
//                TopicId = 3,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 55, QuestionId = 24, Text = "When a model learns noise in the training data", IsCorrect = true },
//                //    new Answer { Id = 56, QuestionId = 24, Text = "When a model performs well on unseen data", IsCorrect = false },
//                //    new Answer { Id = 57, QuestionId = 24, Text = "When a model is too simple", IsCorrect = false },
//                //}
//            },
//            new Question
//            {
//                Id = 25,
//                QuizId = 3,
//                Text = "What is the purpose of a validation dataset in machine learning?",
//                StageId = 3,
//                TopicId = 3,
//                //Answers = new List<Answer>
//                //{
//                //    new Answer { Id = 58, QuestionId = 25, Text = "To tune hyperparameters and prevent overfitting", IsCorrect = true },
//                //    new Answer { Id = 59, QuestionId = 25, Text = "To train the model", IsCorrect = false },
//                //    new Answer { Id = 60, QuestionId = 25, Text = "To visualize the model's performance", IsCorrect = false },
//                //}
//            }
//        );

//        builder.HasOne(q => q.Topic)
//               .WithMany(t => t.Questions)
//               .HasForeignKey(q => q.TopicId)
//               .OnDelete(DeleteBehavior.SetNull);
//    }
//}