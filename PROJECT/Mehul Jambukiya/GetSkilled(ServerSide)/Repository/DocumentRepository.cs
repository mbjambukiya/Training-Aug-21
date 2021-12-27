using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class DocumentRepository : GenericRepository<Document>, IDocument
    {
        private readonly GetSkilledDbContext context;
        public DocumentRepository(GetSkilledDbContext context) : base(context)
        {
            this.context = context;
        }
        public override bool DeleteData(int documentId)
        {
            var document = context.Documents.Find(documentId);
            if (document != null && document.IsDeleted == false)
            {
                document.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
