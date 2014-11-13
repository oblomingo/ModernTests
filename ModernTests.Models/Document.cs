using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ModernTests.Models
{
    [DataContract]
    public class Document : BaseDocument
    {
        public Document() {}

		public Document (string title, bool withSections) {
			Title = title;
			WithSections = withSections;
			Sections = new HashSet<Section>();
			Paragraphs = new HashSet<Paragraph>();
		}

        public Document(string title, bool withSections, HashSet<Paragraph> paragraphs)
        {
			Title = title;
			WithSections = withSections;
			Paragraphs = paragraphs;
			Sections = new HashSet<Section>();
		}

		// Navigation properties
        [DataMember]
		public ICollection<Section> Sections { get; set; }
        [DataMember]
		public ICollection<Paragraph> Paragraphs { get; set; }
    }
}
