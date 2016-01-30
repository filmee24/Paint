using System.Collections.Generic;
using Creek.Database.Api;
using Creek.Database.Api.Query;
using Creek.Database.Core.Query.Execution;

namespace Creek.Database.Core
{
    public interface IInternalValuesQuery : IValuesQuery
    {
        IEnumerable<IQueryFieldAction> GetObjectActions();
        string[] GetGroupByFieldList();

        bool HasGroupBy();

        /// <summary>
        ///   To indicate if a query will return one row (for example, sum, average, max and min, or will return more than one row
        /// </summary>
        bool IsMultiRow();

        int ObjectActionsCount { get; }

        bool ReturnInstance();

        /// <summary>
        ///   Returns true if the query has an order by clause
        /// </summary>
        /// <returns> true if has an order by flag </returns>
        bool HasOrderBy();

        /// <summary>
        /// Gets the type of the order by.
        /// </summary>
        /// <returns>The type of the order by - NONE, DESC or ASC</returns>
        OrderByConstants GetOrderByType();
    }
}