//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModernTests.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Section
    {
        public Section()
        {
            this.Paragraphs = new HashSet<Paragraph>();
        }
    
        public int Id { get; set; }
        public int Document_Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> DocumentId { get; set; }
    
        public virtual ICollection<Paragraph> Paragraphs { get; set; }
    }
}
