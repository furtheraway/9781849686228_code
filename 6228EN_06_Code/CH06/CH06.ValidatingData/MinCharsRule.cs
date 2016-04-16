using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace CH06.ValidatingData {
	class MinCharsRule : ValidationRule{
		public int MinimumChars { get; set; }

		public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo) {
			if(((string)value).Length < MinimumChars)
				return new ValidationResult(false, "Use at least " + MinimumChars.ToString() + " characters");
			return new ValidationResult(true, null);
		}
	}
}
