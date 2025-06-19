using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.Application.Contracts.Stage;
public record WrongAnswerResponse
(
    int QustionId,
    string Text,
    List<string> SelectedAnswerText,
    List<string> CorrectAnswerText,
    double QuestionScore,
    double TimeTakenInSeconds,
    string? MaterialType,
    int? MaterialId,
    string? MaterialTitle,
    int? TopicId,
    string? TopicName,
    string? MaterialUrl
    );