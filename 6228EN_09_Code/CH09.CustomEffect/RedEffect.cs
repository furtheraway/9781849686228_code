using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows;

namespace CH09.CustomEffect {
	class RedEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = RegisterPixelShaderSamplerProperty("Input", typeof(RedEffect), 0);

		public Brush Input {
			get { return (Brush)GetValue(InputProperty); }
			set { SetValue(InputProperty, value); }
		}

		public RedEffect() {
			PixelShader = new PixelShader();
			PixelShader.UriSource = new Uri("/Effects/red.ps", UriKind.Relative);
			UpdateShaderValue(InputProperty);
		}
	}
}
