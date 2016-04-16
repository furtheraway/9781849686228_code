using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH07.CookbookMVVM {
	public enum MessageBoxResult {
		OK,
		Cancel,
		Yes,
		No
	}

	public enum MessageBoxIcon {
		Informatiom, Exclamation, Question
	}

	public interface IMessageBoxService {
		MessageBoxResult Show(string text, string title = null, MessageBoxIcon icon = MessageBoxIcon.Informatiom);
	}
}
