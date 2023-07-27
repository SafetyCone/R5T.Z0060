using System;

using R5T.T0131;
using R5T.T0212.F000;


namespace R5T.Z0060.Raw
{
    [ValuesMarker]
    public partial interface IMemberDocumentationSets : IValuesMarker
    {
        /// <summary>
        /// For <see cref="IMemberDocumentations.R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship"/>
        /// </summary>
        public MemberDocumentation[] N_001 => new[]
        {
            Instances.MemberDocumentations_Raw.R5T_Y0000_Glossary_ForIndex_Exclusive,
            Instances.MemberDocumentations_Raw.R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship,
            Instances.MemberDocumentations_Raw.R5T_Y0000_Glossary_ForIndex_Inclusive,
        };

        /// <summary>
        /// For pathological cycle testing.
        /// </summary>
        public MemberDocumentation[] N_002 => new[]
        {
            Instances.MemberDocumentations_Raw.R5T_S0082_Program_A,
            Instances.MemberDocumentations_Raw.R5T_S0082_Program_B,
            Instances.MemberDocumentations_Raw.R5T_S0082_Program_C,
        };

        /// <summary>
        /// For pathological cycle testing, where an elemnent references an element in the cycle.
        /// </summary>
        public MemberDocumentation[] N_003 => new[]
        {
            Instances.MemberDocumentations_Raw.Pathological_AX,
            Instances.MemberDocumentations_Raw.R5T_S0082_Program_A,
            Instances.MemberDocumentations_Raw.R5T_S0082_Program_B,
            Instances.MemberDocumentations_Raw.R5T_S0082_Program_C,
        };
    }
}
