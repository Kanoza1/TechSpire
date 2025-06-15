using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Application.Contracts.Quiz;
public record QuizAttemptSummary
(
    int QuizId,
    string QuizTitle,
    double CorrectPercentage,
    DateTime SubmittedAt,
    Dictionary<int, double> QuestionTimes
    );

public record UserQuizSummaryResponse
(
     List<QuizAttemptSummary> Attempts ,
     double AverageScore ,
     int TotalAttempts ,
     int PassedCount ,
     int FailedCount 
);
