using System;


namespace R5T.Z0060.Raw
{
    public class MemberDocumentationSets : IMemberDocumentationSets
    {
        #region Infrastructure

        public static IMemberDocumentationSets Instance { get; } = new MemberDocumentationSets();


        private MemberDocumentationSets()
        {
        }

        #endregion
    }
}
