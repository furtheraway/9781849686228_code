using System.Collections.Generic;

namespace CH06.SortingAndFiltering {
	class SortField {
		public string DisplayName { get; set; }
		public string PropertyName { get; set; }
	}

	class SortFieldList : List<SortField> {
	}

}
