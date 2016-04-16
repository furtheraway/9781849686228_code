﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;

namespace CH11.AsyncCalcWithBackgroundWorker {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		BackgroundWorker _worker;

		public MainWindow() {
			InitializeComponent();
		}

		private void OnCalculate(object sender, RoutedEventArgs e) {
			_worker = new BackgroundWorker();
			_worker.WorkerReportsProgress = true;
			_worker.WorkerSupportsCancellation = true;
			_worker.DoWork += _worker_DoWork_TPL;
			_worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
			_worker.ProgressChanged += _worker_ProgressChanged;

			_calcButton.IsEnabled = false;
			_cancelButton.IsEnabled = true;
			_result.Text = "Calculating...";
			var data = new PrimeInputData {
				First = int.Parse(_from.Text),
				Last = int.Parse(_to.Text)
			};
			_worker.RunWorkerAsync(data);
		}

		void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
			_progress.Value = e.ProgressPercentage;
		}

		void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			_result.Text = e.Cancelled ? "Operation Cancelled" :
				string.Format("Total Primes: {0}", e.Result);
			_calcButton.IsEnabled = true;
			_cancelButton.IsEnabled = false;
		}

		void _worker_DoWork(object sender, DoWorkEventArgs e) {
			var data = (PrimeInputData)e.Argument;
			int count = 0;
			_worker.ReportProgress(0);
			int range = data.Last - data.First + 1, progressCount = 0;
			for(int i = data.First; i <= data.Last; i++) {
				if(_worker.CancellationPending) {
					e.Cancel = true;
					break;
				}
				int limit = (int)Math.Sqrt(i);
				bool isPrime = true;
				for(int j = 2; j <= limit; j++)
					if(i % j == 0) {
						isPrime = false;
						break;
					}
				if(isPrime)
					count++;
				if(++progressCount % 100 == 0)
					_worker.ReportProgress(progressCount * 100 / range);
			}
			if(!e.Cancel) {
				_worker.ReportProgress(100);
				e.Result = count;
			}
		}

		void _worker_DoWork_TPL(object sender, DoWorkEventArgs e) {
			var data = (PrimeInputData)e.Argument;
			int count = 0;
			Parallel.For(data.First, data.Last + 1, (i, state) => {
				if(_worker.CancellationPending) {
					e.Cancel = true;
					state.Stop();
				}
				int limit = (int)Math.Sqrt(i);
				bool isPrime = true;
				for(int j = 2; j <= limit; j++)
					if(i % j == 0) {
						isPrime = false;
						break;
					}
				if(isPrime)
					Interlocked.Increment(ref count);
			});
			e.Result = count;
		}

		private void OnCancel(object sender, RoutedEventArgs e) {
			_worker.CancelAsync();
		}

	}
}
