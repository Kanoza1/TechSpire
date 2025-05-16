using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Domain.Entities;

namespace TechSpire.Application.Contracts.Quiz;
public record QuestionResponse
(
    int Id,
    string Text,
    List<AnswerResponse> Answers
    );
