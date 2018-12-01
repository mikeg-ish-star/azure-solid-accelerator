﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NxtLvl.Azure.Data
{
    public interface IEntityQuery<TItem>
    {
        Task<IList<TItem>> FindAsync(Expression<Func<TItem, bool>> predicate);
    }
}
