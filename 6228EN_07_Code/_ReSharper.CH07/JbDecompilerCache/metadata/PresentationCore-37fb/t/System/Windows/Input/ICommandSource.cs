// Type: System.Windows.Input.ICommandSource
// Assembly: PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\PresentationCore.dll

using System.Windows;

namespace System.Windows.Input {
	/// <summary>
	/// Defines an object that knows how to invoke a command.
	/// </summary>
	public interface ICommandSource {
		/// <summary>
		/// Gets the command that will be executed when the command source is invoked.
		/// </summary>
		/// 
		/// <returns>
		/// The command that will be executed when the command source is invoked.
		/// </returns>
		ICommand Command { get; }

		/// <summary>
		/// Represents a user defined data value that can be passed to the command when it is executed.
		/// </summary>
		/// 
		/// <returns>
		/// The command specific data.
		/// </returns>
		object CommandParameter { get; }

		/// <summary>
		/// The object that the command is being executed on.
		/// </summary>
		/// 
		/// <returns>
		/// The object that the command is being executed on.
		/// </returns>
		IInputElement CommandTarget { get; }
	}
}
