// Type: System.Collections.ObjectModel.ObservableCollection`1
// Assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel {
	[TypeForwardedFrom("WindowsBase, Version=3.0.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
	[Serializable]
	public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged {
		public ObservableCollection();
		public ObservableCollection(List<T> list);
		public ObservableCollection(IEnumerable<T> collection);

		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public void Move(int oldIndex, int newIndex);

		protected override void ClearItems();
		protected override void RemoveItem(int index);
		protected override void InsertItem(int index, T item);
		protected override void SetItem(int index, T item);
		protected virtual void MoveItem(int oldIndex, int newIndex);
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e);
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e);
		protected IDisposable BlockReentrancy();
		protected void CheckReentrancy();
		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged;
		public virtual event NotifyCollectionChangedEventHandler CollectionChanged;
		protected virtual event PropertyChangedEventHandler PropertyChanged;
	}
}
