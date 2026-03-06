namespace DynamicForms.Models
{
    public class FormField
    {
        public required string Name { get; set; }
        public required string Label { get; set; }
        public required string Type { get; set; }// text, number, date, etc.
        
    }
}