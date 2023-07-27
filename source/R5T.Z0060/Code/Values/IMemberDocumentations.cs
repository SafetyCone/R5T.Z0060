using System;

using R5T.T0131;
using R5T.T0212.F000;


namespace R5T.Z0060
{
    [ValuesMarker]
    public partial interface IMemberDocumentations : IValuesMarker
    {
        /// <inheritdoc cref="Z0056.IMemberElements.Self_Referential"/>
        public MemberDocumentation Self_Referential => Instances.MemberElementOperator.Get_MemberDocumentation(
            Instances.MemberElements.Self_Referential);
    }
}
