namespace DynamicForms.Models
{
    public class FormDefinition
    {
        public required string Title { get; set; }
        public required List<FormField> Fields { get; set; }
    }
}