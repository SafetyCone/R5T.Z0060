using System;

using R5T.T0131;
using R5T.T0212.F000;


namespace R5T.Z0060.Raw
{
    [ValuesMarker]
    public partial interface IMemberDocumentations : IValuesMarker
    {
        /// <inheritdoc cref="Z0056.Raw.IMemberElements.Pathological_AX"/>
        public MemberDocumentation Pathological_AX => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.Pathological_AX);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.Pathological_A"/>
        public MemberDocumentation Pathological_A => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.Pathological_A);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.R5T_S0082_Program_A"/>
        public MemberDocumentation R5T_S0082_Program_A => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.R5T_S0082_Program_A);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.R5T_S0082_Program_B"/>
        public MemberDocumentation R5T_S0082_Program_B => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.R5T_S0082_Program_B);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.R5T_S0082_Program_C"/>
        public MemberDocumentation R5T_S0082_Program_C => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.R5T_S0082_Program_C);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.R5T_Y0000_Glossary_ForIndex_Exclusive"/>
        public MemberDocumentation R5T_Y0000_Glossary_ForIndex_Exclusive => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.R5T_Y0000_Glossary_ForIndex_Exclusive);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship"/>
        public MemberDocumentation R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.R5T_Y0000_Glossary_ForIndex_ExclusiveInclusiveRelationship);

        /// <inheritdoc cref="Z0056.Raw.IMemberElements.R5T_Y0000_Glossary_ForIndex_Inclusive"/>
        public MemberDocumentation R5T_Y0000_Glossary_ForIndex_Inclusive => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements_Raw.R5T_Y0000_Glossary_ForIndex_Inclusive);
    }
}
