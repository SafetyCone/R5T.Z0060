using System;

using R5T.T0131;
using R5T.T0212.F000;


namespace R5T.Z0060
{
    [ValuesMarker]
    public partial interface IMemberDocumentationSets : IValuesMarker
    {
        /// <summary>
        /// Contains cyclic references, where A references B, and B references A.
        /// </summary>
        public MemberDocumentation[] Cyclic => Instances.MemberDocumentationSets_Raw.N_001;

        /// <summary>
        /// Contains cyclic references, where A references B, and B references C, and C references A.
        /// </summary>
        public MemberDocumentation[] Cyclic_Pathological => Instances.MemberDocumentationSets_Raw.N_002;

        /// <summary>
        /// Contains an element the references a member of a cyclic references ring.
        /// Here X references A, where A references B, and B references C, and C references A.
        /// </summary>
        public MemberDocumentation[] Cyclic_Pathological_FromOutside => Instances.MemberDocumentationSets_Raw.N_003;
    }
}
