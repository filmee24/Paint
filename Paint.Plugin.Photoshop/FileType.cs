using Creek.IO.FilterBuilder;
using System;

namespace Paint.Contracts
{
    public class FileType : IFileType
    {
        public string Filter
        {
            get
            {
                var fb = new FilterBuilder();
                fb.Add(FilterBuilder.Filters.PhotoshopDocuments);

                return fb.ToString();
            }
        }
    }
}