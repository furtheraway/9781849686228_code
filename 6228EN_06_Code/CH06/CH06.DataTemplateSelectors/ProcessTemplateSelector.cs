using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Diagnostics;

namespace CH06.DataTemplateSelectors {
class ProcessTemplateSelector : DataTemplateSelector {
	public string SystemProcessTemplate { get; set; }
	public string UserProcessTemplate { get; set; }

	public override DataTemplate SelectTemplate(object item, DependencyObject container) {
		Process process = (Process)item;
		return ((FrameworkElement)container).FindResource(process.SessionId == 0 ? SystemProcessTemplate : UserProcessTemplate) as DataTemplate;
	}
}
}
