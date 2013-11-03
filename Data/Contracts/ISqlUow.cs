﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Contracts
{
    /// <summary>
    /// Sql "Unit of work" interface
    /// </summary>
    public interface ISqlUow
    {
        // Save pending changes to the data store.
        void Commit();

        //Repositories
        IQuestionRepository Questions { get; }
        IAnswerRepository Answers { get; }
        ITagRepository Tags { get; }
        IRepository<UserProfile> UserProfiles { get;}
    }
}
