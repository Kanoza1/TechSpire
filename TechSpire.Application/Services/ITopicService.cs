using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Abstraction;
using TechSpire.Application.Contracts;

namespace TechSpire.Application.Services;
public interface ITopicService
{
    Task<Result<DbT>> GetTopic( int Id );
    Task<Result<DbT>> GetTopicByName(string Name);

}
