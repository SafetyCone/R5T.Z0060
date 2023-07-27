using System;


namespace R5T.Z0060
{
    public static class Instances
    {
        public static Raw.IMemberDocumentations MemberDocumentations_Raw => Raw.MemberDocumentations.Instance;
        public static Raw.IMemberDocumentationSets MemberDocumentationSets_Raw => Raw.MemberDocumentationSets.Instance;
        public static T0212.F000.IMemberElementOperator MemberElementOperator => T0212.F000.MemberElementOperator.Instance;
        public static Z0056.IMemberElements MemberElements => Z0056.MemberElements.Instance;
        public static Z0056.Raw.IMemberElements MemberElements_Raw => Z0056.Raw.MemberElements.Instance;
    }
}