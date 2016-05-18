using CrystalDecisions.Shared;

namespace CrystalProfiler
{
    public class CrystalProfileParameter
    {
        public CrystalProfileParameter(ParameterField field)
        {
            Name = field.Name;
            FieldName = field.ParameterFieldName;
            TypeName = field.ParameterType.ToString();
        }

        public string Name { get; protected set; }

        public string FieldName { get; protected set; }

        public string TypeName { get; protected set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, FieldName: {1}, TypeName: {2}", Name, FieldName, TypeName);
        }
    }
}