using System;


namespace R5T.Z0060
{
    public class MemberDocumentations : IMemberDocumentations
    {
        #region Infrastructure

        public static IMemberDocumentations Instance { get; } = new MemberDocumentations();


        private MemberDocumentations()
        {
        }

        #endregion
    }
}
