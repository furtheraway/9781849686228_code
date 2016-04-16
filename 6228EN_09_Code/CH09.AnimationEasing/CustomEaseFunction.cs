using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Animation;

namespace CH09.AnimationEasing {
class CustomEaseFunction : EasingFunctionBase {
	protected override double EaseInCore(double t) {
		return 1 - t * t;
	}

	protected override System.Windows.Freezable CreateInstanceCore() {
		return new CustomEaseFunction();
	}
}
}
