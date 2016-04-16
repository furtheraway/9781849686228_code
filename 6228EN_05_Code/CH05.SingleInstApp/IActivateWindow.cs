using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace CH05.SingleInstApp {
	[ServiceContract]
	interface IActivateWindow {
		[OperationContract]
		void Activate(string[] args);
	}
}
